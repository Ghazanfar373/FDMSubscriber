using DDS;
using System.Runtime.InteropServices;

namespace FDMData
{
    #region FDMDATA
    [StructLayout(LayoutKind.Sequential)]
    public sealed class FDMDATA
    {
        public int ID;
        public double Throttle;
        public double ElevatorCommand;
        public double AileronCommand;
        public double RudderCommand;
        public double SteerLeft;
        public double SteerRight;
        public double LeftBrakeCommand;
        public double RightBrakeCommand;
        public double FlapCommand;
        public bool EngineStartSwitch;
        public double ThrottleCommand;
        public double WindSpeedCommand;
        public double WindDirectionCommand;
        public bool GeneratorSwitch;
        public bool InverterSwitch;
        public bool BatteryStatus;
    };
    #endregion

}

