using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgOpenGPS
{
    public class CGuidance
    {
        private readonly FormGPS mf;

        //steer, pivot, and ref indexes
        private int sA, sB, C, pA, pB;
        private int rA, rB;

        public double distanceFromCurrentLineSteer, distanceFromCurrentLinePivot;
        public double steerAngleGu, rEastSteer, rNorthSteer, rEastPivot, rNorthPivot;
        public double pivotCurvatureOffset;

        public bool isOnRightSideCurrentLine = true;

        public double inty, xTrackSteerCorrection;
        public double steerHeadingError, steerHeadingErrorDegrees;

        public double steerAngleSmoothed, pivotErrorTotal;
        public double distSteerError, lastDistSteerError, derivativeDistError;

        public double pivotDistanceError, pivotDistanceErrorLast, pivotDerivative, pivotDerivativeSmoothed;

        //derivative counters
        private int counter, counter2;


        public CGuidance(FormGPS _f)
        {
            //constructor
            mf = _f;
        }

        /// <summary>
        /// Function to calculate steer angle for AB Line Segment only
        /// </summary>
        /// <param name="curA"></param>
        /// <param name="curB"></param>
        /// <param name="pivot"></param>
        /// <param name="steer"></param>
        /// <param name="isValid"></param>
        public void StanleyGuidanceABLine(vec3 curA, vec3 curB, vec3 pivot, vec3 steer, bool isValid)
        {            //calculate required steer angle

            if (isValid)
            { 
                bool isFixHeadingSameWayAsRef = Math.PI - Math.Abs(Math.Abs(pivot.heading - curA.heading) - Math.PI) < glm.PIBy2;

                if (!isFixHeadingSameWayAsRef)
                {
                    vec3 swap = new vec3(curA);
                    curA = curB;
                    curB = swap;
                    curA.heading += Math.PI;
                    curB.heading += Math.PI;
                    if (curA.heading > glm.twoPI) curA.heading -= glm.twoPI;
                    if (curB.heading > glm.twoPI) curB.heading -= glm.twoPI;
                }

                //get the pivot distance from currently active AB segment   ///////////  Pivot  ////////////
                double dx = curB.easting - curA.easting;
                double dy = curB.northing - curA.northing;
                if (Math.Abs(dx) < Double.Epsilon && Math.Abs(dy) < Double.Epsilon) return;

                //save a copy of dx,dy in youTurn
                mf.yt.dxAB = dx; mf.yt.dyAB = dy;

                //how far from current AB Line is fix
                distanceFromCurrentLinePivot = ((dy * pivot.easting) - (dx * pivot.northing) + (curB.easting
                            * curA.northing) - (curB.northing * curA.easting))
                                / Math.Sqrt((dy * dy) + (dx * dx));

                double U = (((pivot.easting - curA.easting) * dx)
                                + ((pivot.northing - curA.northing) * dy))
                                / ((dx * dx) + (dy * dy));

                rEastPivot = curA.easting + (U * dx);
                rNorthPivot = curA.northing + (U * dy);

                mf.ABLine.rEastAB =   rEastPivot;
                mf.ABLine.rNorthAB = rNorthPivot;

                mf.ABLine.isABSameAsVehicleHeading = isFixHeadingSameWayAsRef;

                //get the distance from currently active AB segment of steer axle //////// steer /////////////
                vec3 steerA = new vec3(curA);
                vec3 steerB = new vec3(curB);


                //create the AB segment to offset
                steerA.easting += (Math.Sin(steerA.heading + glm.PIBy2) * (inty));
                steerA.northing += (Math.Cos(steerA.heading + glm.PIBy2) * (inty));

                steerB.easting += (Math.Sin(steerB.heading + glm.PIBy2) * (inty));
                steerB.northing += (Math.Cos(steerB.heading + glm.PIBy2) * (inty));

                dx = steerB.easting - steerA.easting;
                dy = steerB.northing - steerA.northing;

                if (Math.Abs(dx) < Double.Epsilon && Math.Abs(dy) < Double.Epsilon) return;

                //how far from current AB Line is fix
                distanceFromCurrentLineSteer = ((dy * steer.easting) - (dx * steer.northing) + (steerB.easting
                            * steerA.northing) - (steerB.northing * steerA.easting))
                                / Math.Sqrt((dy * dy) + (dx * dx));

                //are we on the right side or not
                isOnRightSideCurrentLine = distanceFromCurrentLineSteer > 0;

                // calc point on ABLine closest to current position - for display only
                U = (((steer.easting - steerA.easting) * dx)
                                + ((steer.northing - steerA.northing) * dy))
                                / ((dx * dx) + (dy * dy));

                rEastSteer = steerA.easting + (U * dx);
                rNorthSteer = steerA.northing + (U * dy);

                distanceFromCurrentLinePivot += mf.nudOffset;

                steerHeadingError = (steer.heading - steerB.heading);

                //Fix the circular error
                if (steerHeadingError > Math.PI) steerHeadingError -= Math.PI;
                else if (steerHeadingError < Math.PI) steerHeadingError += Math.PI;

                if (steerHeadingError > glm.PIBy2) steerHeadingError -= Math.PI;
                else if (steerHeadingError < -glm.PIBy2) steerHeadingError += Math.PI;

                //Overshoot setting on Stanley tab
                steerHeadingError *= mf.vehicle.stanleyHeadingErrorGain;

                double sped = Math.Abs(mf.avgSpeed);
                if (sped > 1) sped = 1 + 0.277 * (sped - 1);
                else sped = 1;
                double XTEc = Math.Atan((distanceFromCurrentLineSteer * mf.vehicle.stanleyDistanceErrorGain)
                    / (sped));

                xTrackSteerCorrection = (xTrackSteerCorrection * 0.5) + XTEc * (0.5);

                //derivative of steer distance error
                distSteerError = (distSteerError * 0.95) + ((xTrackSteerCorrection * 60) * 0.05);
                if (counter++ > 5)
                {
                    derivativeDistError = distSteerError - lastDistSteerError;
                    lastDistSteerError = distSteerError;
                    counter = 0;
                }

                if (mf.pn.speed > -0.1)
                    steerAngleGu = glm.toDegrees((xTrackSteerCorrection + steerHeadingError) * -1.0);
                else
                    steerAngleGu = glm.toDegrees((xTrackSteerCorrection - steerHeadingError) * -1.0);

                if (Math.Abs(distanceFromCurrentLineSteer) > 0.5) steerAngleGu *= 0.5;
                else steerAngleGu *= (1 - Math.Abs(distanceFromCurrentLineSteer));

                if (steerAngleGu < -mf.vehicle.maxSteerAngle) steerAngleGu = -mf.vehicle.maxSteerAngle;
                else if (steerAngleGu > mf.vehicle.maxSteerAngle) steerAngleGu = mf.vehicle.maxSteerAngle;

                //pivot PID
                pivotDistanceError = (pivotDistanceError * 0.9) + (distanceFromCurrentLinePivot * 0.1);
                pivotDistanceError = Math.Atan((pivotDistanceError) / (sped));

                if (counter2++ > 10)
                {
                    pivotDerivative = pivotDistanceError - pivotDistanceErrorLast;
                    pivotDistanceErrorLast = pivotDistanceError;
                    counter2 = 0;
                    pivotDerivative *= 2;

                    //limit the derivative
                    if (pivotDerivative > 0.03) pivotDerivative = 0.03;
                    if (pivotDerivative < -0.03) pivotDerivative = -0.03;
                }

                pivotErrorTotal = pivotDistanceError + pivotDerivative;

                if (mf.pn.speed > mf.startSpeed
                    && mf.isAutoSteerBtnOn
                    && Math.Abs(derivativeDistError) < 1
                    && Math.Abs(pivotDistanceError) < mf.vehicle.stanleyIntegralDistanceAwayTriggerAB)

                {
                    //if over the line heading wrong way, rapidly decrease integral
                    if ((inty < 0 && distanceFromCurrentLinePivot < 0) || (inty > 0 && distanceFromCurrentLinePivot > 0))
                    {
                        inty += pivotErrorTotal * mf.vehicle.stanleyIntegralGainAB * -3;
                    }
                    else
                    {
                        inty += pivotErrorTotal * mf.vehicle.stanleyIntegralGainAB * -0.5;
                    }

                    //integral slider is set to 0
                    if (mf.vehicle.stanleyIntegralGainAB == 0) inty = 0;
                }
                else inty *= 0.9;

                //Convert to millimeters from meters
                distanceFromCurrentLineSteer = Math.Round(distanceFromCurrentLineSteer * 1000.0, MidpointRounding.AwayFromZero);
                distanceFromCurrentLinePivot = Math.Round(distanceFromCurrentLinePivot * 1000.0, MidpointRounding.AwayFromZero);

                mf.guidanceLineDistanceOff = mf.distanceDisplayPivot = (short)distanceFromCurrentLinePivot;
                mf.distanceDisplaySteer = (short)distanceFromCurrentLineSteer;
                mf.guidanceLineSteerAngle = (Int16)(steerAngleGu * 100);
            }
            else
            {
                //invalid distance so tell AS module
                mf.distanceDisplayPivot = 32000;
                distanceFromCurrentLineSteer = 32000;
                mf.guidanceLineDistanceOff = 32000;
            }
        }
        public void StanleyGuidanceCurve(vec3 pivot, vec3 steer, ref List<vec3> curList)

        {            //calculate required steer angle


            //find the closest point roughly
            int cc = 0, dd;
            int ptCount = curList.Count;
            if (ptCount > 5)
            {
                double minDistA = 1000000, minDistB;

                for (int j = 0; j < ptCount; j += 10)
                {
                    double dist = ((steer.easting - curList[j].easting) * (steer.easting - curList[j].easting))
                                    + ((steer.northing - curList[j].northing) * (steer.northing - curList[j].northing));
                    if (dist < minDistA)
                    {
                        minDistA = dist;
                        cc = j;
                    }
                }

                minDistA = minDistB = 1000000;
                dd = cc + 7; if (dd > ptCount - 1) dd = ptCount;
                cc -= 7; if (cc < 0) cc = 0;

                //find the closest 2 points to current close call
                for (int j = cc; j < dd; j++)
                {
                    double dist = ((steer.easting - curList[j].easting) * (steer.easting - curList[j].easting))
                                    + ((steer.northing - curList[j].northing) * (steer.northing - curList[j].northing));
                    if (dist < minDistA)
                    {
                        minDistB = minDistA;
                        sB = sA;
                        minDistA = dist;
                        sA = j;
                    }
                    else if (dist < minDistB)
                    {
                        minDistB = dist;
                        sB = j;
                    }
                }

                //too far from guidance line? Lost? Fresh delete of ref?
                if (minDistA < (1.5 * (mf.tool.toolWidth * mf.tool.toolWidth)))
                {
                    if (minDistA == 100000000)
                        return;
                }
                else
                {
                    curList.Clear();
                    return;
                }

                //just need to make sure the points continue ascending or heading switches all over the place
                if (sA > sB) { C = sA; sA = sB; sB = C; }

                //currentLocationIndex = sA;
                if (sA > ptCount - 1 || sB > ptCount - 1) return;

                minDistA = minDistB = 1000000;
                dd = sB; cc = dd - 12; if (cc < 0) cc = 0;

                //find the closest 2 points of pivot back from steer
                for (int j = cc; j < dd; j++)
                {
                    double dist = ((pivot.easting - curList[j].easting) * (pivot.easting - curList[j].easting))
                                    + ((pivot.northing - curList[j].northing) * (pivot.northing - curList[j].northing));
                    if (dist < minDistA)
                    {
                        minDistB = minDistA;
                        pB = pA;
                        minDistA = dist;
                        pA = j;
                    }
                    else if (dist < minDistB)
                    {
                        minDistB = dist;
                        pB = j;
                    }
                }

                //just need to make sure the points continue ascending or heading switches all over the place
                if (pA > pB) { C = pA; pA = pB; pB = C; }

                if (pA > ptCount - 1 || pB > ptCount - 1)
                {
                    pA = ptCount - 2;
                    pB = ptCount - 1;
                }

                //get the pivot distance from currently active AB segment   ///////////  Pivot  ////////////
                double dx = curList[pB].easting - curList[pA].easting;
                double dz = curList[pB].northing - curList[pA].northing;

                if (Math.Abs(dx) < Double.Epsilon && Math.Abs(dz) < Double.Epsilon) return;

                //how far from current AB Line is fix
                distanceFromCurrentLinePivot = ((dz * pivot.easting) - (dx * pivot.northing) + (curList[pB].easting
                            * curList[pA].northing) - (curList[pB].northing * curList[pA].easting))
                                / Math.Sqrt((dz * dz) + (dx * dx));

                double U = (((pivot.easting - curList[pA].easting) * dx)
                                + ((pivot.northing - curList[pA].northing) * dz))
                                / ((dx * dx) + (dz * dz));

                rEastPivot = curList[pA].easting + (U * dx);
                rNorthPivot = curList[pA].northing + (U * dz);

                //get the distance from currently active AB segment of steer axle //////// steer /////////////
                vec3 steerA = new vec3(curList[sA]);
                vec3 steerB = new vec3(curList[sB]);

                double curvature = curList[pA].heading - steerA.heading;
                if (curvature > Math.PI) curvature -= Math.PI; else if (curvature < Math.PI) curvature += Math.PI;
                if (curvature > glm.PIBy2) curvature -= Math.PI; else if (curvature < -glm.PIBy2) curvature += Math.PI;

                //because of draft 
                curvature = Math.Sin(curvature) * mf.vehicle.wheelbase * 0.65;
                pivotCurvatureOffset = (pivotCurvatureOffset * 0.9) + (curvature * 0.1);

                //create the AB segment to offset
                steerA.easting += (Math.Sin(steerA.heading + glm.PIBy2) * (pivotCurvatureOffset + inty));
                steerA.northing += (Math.Cos(steerA.heading + glm.PIBy2) * (pivotCurvatureOffset + inty));

                steerB.easting += (Math.Sin(steerB.heading + glm.PIBy2) * (pivotCurvatureOffset + inty));
                steerB.northing += (Math.Cos(steerB.heading + glm.PIBy2) * (pivotCurvatureOffset + inty));

                dx = steerB.easting - steerA.easting;
                dz = steerB.northing - steerA.northing;

                if (Math.Abs(dx) < Double.Epsilon && Math.Abs(dz) < Double.Epsilon) return;

                //how far from current AB Line is fix
                distanceFromCurrentLineSteer = ((dz * steer.easting) - (dx * steer.northing) + (steerB.easting
                            * steerA.northing) - (steerB.northing * steerA.easting))
                                / Math.Sqrt((dz * dz) + (dx * dx));

                //are we on the right side or not
                isOnRightSideCurrentLine = distanceFromCurrentLineSteer > 0;

                // calc point on ABLine closest to current position - for display only
                U = (((steer.easting - steerA.easting) * dx)
                                + ((steer.northing - steerA.northing) * dz))
                                / ((dx * dx) + (dz * dz));

                rEastSteer = steerA.easting + (U * dx);
                rNorthSteer = steerA.northing + (U * dz);

                // backwards line check
                //if ((Math.PI - Math.Abs(Math.Abs(pivot.heading - curList[sA].heading) - Math.PI)) > glm.PIBy2)
                //{
                //    isCurrentLineValid = false;
                //    return;
                //}

                steerHeadingError = (steer.heading - steerB.heading);

                //Fix the circular error
                if (steerHeadingError > Math.PI) steerHeadingError -= Math.PI;
                else if (steerHeadingError < Math.PI) steerHeadingError += Math.PI;

                if (steerHeadingError > glm.PIBy2) steerHeadingError -= Math.PI;
                else if (steerHeadingError < -glm.PIBy2) steerHeadingError += Math.PI;

                //Overshoot setting on Stanley tab
                steerHeadingError *= mf.vehicle.stanleyHeadingErrorGain;

                double sped = Math.Abs(mf.avgSpeed);
                if (sped > 1) sped = 1 + 0.277 * (sped - 1);
                else sped = 1;
                double XTEc = Math.Atan((distanceFromCurrentLineSteer * mf.vehicle.stanleyDistanceErrorGain)
                    / (sped));

                xTrackSteerCorrection = (xTrackSteerCorrection * 0.5) + XTEc * (0.5);

                //derivative of steer distance error
                distSteerError = (distSteerError * 0.95) + ((xTrackSteerCorrection * 60) * 0.05);
                if (counter++ > 5)
                {
                    derivativeDistError = distSteerError - lastDistSteerError;
                    lastDistSteerError = distSteerError;
                    counter = 0;
                }

                if (mf.pn.speed > -0.1)
                    steerAngleGu = glm.toDegrees((xTrackSteerCorrection + steerHeadingError) * -1.0);
                else
                    steerAngleGu = glm.toDegrees((xTrackSteerCorrection - steerHeadingError) * -1.0);

                if (Math.Abs(distanceFromCurrentLineSteer) > 0.5) steerAngleGu *= 0.5;
                else steerAngleGu *= (1 - Math.Abs(distanceFromCurrentLineSteer));

                if (steerAngleGu < -mf.vehicle.maxSteerAngle) steerAngleGu = -mf.vehicle.maxSteerAngle;
                else if (steerAngleGu > mf.vehicle.maxSteerAngle) steerAngleGu = mf.vehicle.maxSteerAngle;

                //pivot PID
                pivotDistanceError = (pivotDistanceError * 0.9) + (distanceFromCurrentLinePivot * 0.1);
                pivotDistanceError = Math.Atan((pivotDistanceError) / (sped));

                if (counter2++ > 10)
                {
                    pivotDerivative = pivotDistanceError - pivotDistanceErrorLast;
                    pivotDistanceErrorLast = pivotDistanceError;
                    counter2 = 0;
                    pivotDerivative *= 2;

                    //limit the derivative
                    if (pivotDerivative > 0.03) pivotDerivative = 0.03;
                    if (pivotDerivative < -0.03) pivotDerivative = -0.03;
                }

                pivotErrorTotal = pivotDistanceError + pivotDerivative;

                //if (mf.pn.speed > mf.startSpeed
                //    && mf.isAutoSteerBtnOn
                //    && Math.Abs(derivativeDistError) < 1
                //    && Math.Abs(pivotDistanceError) < mf.vehicle.ast.integralDistanceAwayTrigger)

                //{
                //    //if over the line heading wrong way, rapidly decrease integral
                //    if ((inty < 0 && distanceFromCurrentLinePivot < 0) || (inty > 0 && distanceFromCurrentLinePivot > 0))
                //    {
                //        inty += pivotErrorTotal * mf.vehicle.ast.stanleyIntegralGain * -3;
                //    }
                //    else
                //    {
                //        inty += pivotErrorTotal * mf.vehicle.ast.stanleyIntegralGain * -0.5;
                //    }

                //    //integral slider is set to 0
                //    if (mf.vehicle.ast.stanleyIntegralGain == 0) inty = 0;
                //}
                //else inty *= 0.9;

                //Convert to millimeters from meters
                distanceFromCurrentLineSteer = Math.Round(distanceFromCurrentLineSteer * 1000.0, MidpointRounding.AwayFromZero);
                distanceFromCurrentLinePivot = Math.Round(distanceFromCurrentLinePivot * 1000.0, MidpointRounding.AwayFromZero);

                mf.guidanceLineDistanceOff = mf.distanceDisplayPivot = (short)distanceFromCurrentLinePivot;
                mf.distanceDisplaySteer = (short)distanceFromCurrentLineSteer;
                mf.guidanceLineSteerAngle = (Int16)(steerAngleGu * 100);
            }
            else
            {
                //invalid distance so tell AS module
                mf.distanceDisplayPivot = 32000;
                distanceFromCurrentLineSteer = 32000;
                mf.guidanceLineDistanceOff = 32000;
            }
        }



    }
}
