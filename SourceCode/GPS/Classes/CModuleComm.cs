using System.Collections.Generic;

namespace AgOpenGPS
{
    public class CModuleComm
    {
        //copy of the mainform address
        private readonly FormGPS mf = null;

        //Critical Safety Properties
        public bool isOutOfBounds = true;

        //receive strings
        public string serialRecvAutoSteerStr;
        public string serialRecvMachineStr;

        public static int pgnSentenceLength = 10;

        public bool isMachineDataSentToAutoSteer;

        ////AutoSteer --------------------------------------------------------------------------------------------
        //// PGN - 32766 - 127.254 0x7FFE
        //public byte[] autoSteerData = new byte[pgnSentenceLength];
        //public int sdHeaderHi, sdHeaderLo = 1, sd2 = 2, sdSpeed = 3, sdDistanceHi = 4, sdDistanceLo = 5,
        //            sdSteerAngleHi = 6, sdSteerAngleLo = 7, sd8 = 8, sd9 = 9;

        ////Auto Steer Basic setting -------------------------------------------------------------------------------
        //// PGN - 32764 - 127.252 0x7FFC
        //public byte[] autoSteerSettings = new byte[pgnSentenceLength];
        //public int ssHeaderHi, ssHeaderLo = 1, ssKp = 2, ssHighPWM = 3, ssLowPWM = 4, ssMinPWM = 5,
        //             ssCountsPerDegree = 6, ssWASOffsetHi = 7, ssWASOffsetLo = 8, ss9 = 9;

        //// ----  Arduino Steer Config ----------------------------------------------------------------------------
        ////PGN 32763 - 127.251 0x7FFB
        //public byte[] ardSteerConfig = new byte[pgnSentenceLength];
        //public int arHeaderHi, arHeaderLo = 1, arSet0 = 2, arSet1 = 3, arMaxSpd = 4, arMinSpd = 5, arIncMaxPulse = 6,
        //    arAckermanFix = 7, arSet2 = 8, ar9 = 9;

        ////Machine Module Data ------------------------------------------------------------------------------------
        //// PGN - 32762 - 127.250 0x7FFA
        //public byte[] machineData = new byte[pgnSentenceLength];
        //public int mdHeaderHi, mdHeaderLo = 1, mdSectionControlByteHi = 2, mdSectionControlByteLo = 3,
        //    mdSpeedXFour = 4, mdUTurn = 5, mdTree = 6, mdHydLift = 7, md8 = 8, md9 = 9;

        //// ---- Arduino configuration on machine module  ---------------------------------------------------------
        ////PGN - 32760 - 127.248 0x7FF9
        //public byte[] ardMachineConfig = new byte[pgnSentenceLength];
        //public int amHeaderHi, amHeaderLo = 1, amRaiseTime = 2, amLowerTime = 3, amEnableHyd = 4,
        //     amSet0 = 5, am6 = 6, am7 = 7, am8 = 8, am9 = 9;

        //// ---- Section control switches to AOG  ---------------------------------------------------------
        ////PGN - 32736 - 127.249 0x7FE9
        //public byte[] ss = new byte[pgnSentenceLength];
        //public byte[] ssP = new byte[pgnSentenceLength];
        //public int swHeaderHi, swHeaderLo = 1, sw2 = 2, sw3 = 3, sw4 = 4,
        //     swONHi = 5, swONLo = 6, swOFFHi = 7, swOFFLo = 8, swMain = 9;

        //LIDAR
        //UDP sentence just rec'd
        public string recvUDPSentence = "Inital UDP";

        public int lidarDistance;

        public int pwmDisplay = 0;
        public double actualSteerAngleDisp = 0;
        public int actualSteerAngleChart = 0;


        //for the workswitch
        public bool isWorkSwitchActiveLow, isWorkSwitchEnabled, isWorkSwitchManual;

        public int workSwitchValue, steerSwitchValue = 1;

        //constructor
        public CModuleComm()
        {
            //WorkSwitch logic
            isWorkSwitchEnabled = false;

            //does a low, grounded out, mean on
            isWorkSwitchActiveLow = true;

        }

        //Reset all the byte arrays from modules
        public void ResetAllModuleCommValues()
        {
        }
    }

}