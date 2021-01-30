using Tinkerforge;

namespace AgOpenGPS
{
    public class CAHRS
    {
        private readonly FormGPS mf;

        /// <summary>
        /// The USB TinkerForge comm
        /// </summary>
        public readonly IPConnection ipcon;

        /// <summary>
        /// The Tinker IMU object
        /// </summary>
        public readonly BrickIMUV2 imu;

        public static string HOST = "localhost";
        public static int PORT = 4223;
        public static readonly string UID = Properties.Settings.Default.setIMU_UID; // "68wESU"; // Change XXYYZZ to the UID of your IMU Brick 2.0

        //Roll and heading from the IMU
        public double imuHeading = 99999, prevIMUHeading = 0, imuRoll = 88888;

        //actual value in degrees
        public double rollZero;

        //Roll Filter Value
        public double rollFilter;

        //is the auto steer in auto turn on mode or not
        public bool isAutoSteerAuto;

        //the factor for fusion of GPS and IMU
        public double fusionWeight;

        //constructor
        public CAHRS(FormGPS _f)
        {
            mf = _f;

            //non GPS AHRS sensors
            //isHeadingCorrectionFromAutoSteer = Properties.Settings.Default.setIMU_isHeadingCorrectionFromAutoSteer;
            //isHeadingCorrectionFromBrick = Properties.Settings.Default.setIMU_isHeadingCorrectionFromBrick;
            ////isHeadingCorrectionFromExtUDP = Properties.Settings.Default.setIMU_isHeadingCorrectionFromExtUDP;

            //isRollFromAutoSteer = Properties.Settings.Default.setIMU_isRollFromAutoSteer;
            //isRollFromAVR = Properties.Settings.Default.setIMU_isRollFromAVR;
            //isRollFromOGI = Properties.Settings.Default.setIMU_isRollFromOGI;

            rollZero = Properties.Settings.Default.setIMU_rollZero;
            //pitchZeroX16 = Properties.Settings.Default.setIMU_pitchZeroX16;

            rollFilter = Properties.Settings.Default.setIMU_rollFilter;

            isAutoSteerAuto = Properties.Settings.Default.setAS_isAutoSteerAutoOn;

            fusionWeight = Properties.Settings.Default.setIMU_fusionWeight;

            //usb IMU Tinker
            //if (isHeadingCorrectionFromBrick)
            //{
            //    ipcon = new IPConnection(); // Create IP connection
            //    imu = new BrickIMUV2(CAHRS.UID, ipcon); // Create device object

            //    try
            //    {
            //        ipcon.Connect(HOST, PORT); // Connect to brickd - daemon
            //                                   // Don't use device before ipcon is connected

            //        // Register Orientation callback in AHRS class
            //        imu.OrientationCallback += OrientCB;

            //        // Set period for Orientation callback to 0.1s (100ms)
            //        imu.SetOrientationPeriod(100);

            //        //set the mode with mag
            //        imu.SetSensorFusionMode(1);

            //        imu.LedsOff();
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        //event for TinkerForge IMU
        //public void OrientCB(BrickIMUV2 sender, short heading, short roll, short pitch)
        //{
        //    if (isHeadingCorrectionFromBrick)
        //    {
        //        mf.ahrs.correctionHeadingX16 = heading;
        //    }
        //}
    }
}

////input to the Kalman
//rollK = roll;

////Kalman filter
//Pc = P + varProcess;
//G = Pc / (Pc + varRoll);
//P = (1 - G) * Pc;
//Xp = XeRoll;
//Zp = Xp;
//XeRoll = (G * (rollK - Zp)) + Xp;
////Kalman variables
//private double rollK = 0;
//private double Pc = 0.0;
//private double G = 0.0;
//private double P = 1.0;
//private double Xp = 0.0;
//private double Zp = 0.0;
//private double XeRoll = 0;
//private readonly double varRoll = 0.06; // variance, smaller, more faster filtering
//private readonly double varProcess = 0.02;