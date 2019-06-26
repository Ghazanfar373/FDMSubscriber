using DDS;
using DDS.OpenSplice.CustomMarshalers;
using System;
using System.Runtime.InteropServices;

namespace FDMData
{
    #region __FDMDATA
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __FDMDATA
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
        public char EngineStartSwitch;
        public double ThrottleCommand;
        public double WindSpeedCommand;
        public double WindDirectionCommand;
        public char GeneratorSwitch;
        public char InverterSwitch;
        public char BatteryStatus;
    }
    #endregion

    #region FDMDATAMarshaler
    public sealed class FDMDATAMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__FDMDATA);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_ID = (int)Marshal.OffsetOf(type, "ID");
        private static readonly int offset_Throttle = (int)Marshal.OffsetOf(type, "Throttle");
        private static readonly int offset_ElevatorCommand = (int)Marshal.OffsetOf(type, "ElevatorCommand");
        private static readonly int offset_AileronCommand = (int)Marshal.OffsetOf(type, "AileronCommand");
        private static readonly int offset_RudderCommand = (int)Marshal.OffsetOf(type, "RudderCommand");
        private static readonly int offset_SteerLeft = (int)Marshal.OffsetOf(type, "SteerLeft");
        private static readonly int offset_SteerRight = (int)Marshal.OffsetOf(type, "SteerRight");
        private static readonly int offset_LeftBrakeCommand = (int)Marshal.OffsetOf(type, "LeftBrakeCommand");
        private static readonly int offset_RightBrakeCommand = (int)Marshal.OffsetOf(type, "RightBrakeCommand");
        private static readonly int offset_FlapCommand = (int)Marshal.OffsetOf(type, "FlapCommand");
        private static readonly int offset_EngineStartSwitch = (int)Marshal.OffsetOf(type, "EngineStartSwitch");
        private static readonly int offset_ThrottleCommand = (int)Marshal.OffsetOf(type, "ThrottleCommand");
        private static readonly int offset_WindSpeedCommand = (int)Marshal.OffsetOf(type, "WindSpeedCommand");
        private static readonly int offset_WindDirectionCommand = (int)Marshal.OffsetOf(type, "WindDirectionCommand");
        private static readonly int offset_GeneratorSwitch = (int)Marshal.OffsetOf(type, "GeneratorSwitch");
        private static readonly int offset_InverterSwitch = (int)Marshal.OffsetOf(type, "InverterSwitch");
        private static readonly int offset_BatteryStatus = (int)Marshal.OffsetOf(type, "BatteryStatus");


        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new FDMDATA[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            FDMDATA from = untypedFrom as FDMDATA;
            if (from == null) return false;
            Write(to, offset + offset_ID, from.ID);
            Write(to, offset + offset_Throttle, from.Throttle);
            Write(to, offset + offset_ElevatorCommand, from.ElevatorCommand);
            Write(to, offset + offset_AileronCommand, from.AileronCommand);
            Write(to, offset + offset_RudderCommand, from.RudderCommand);
            Write(to, offset + offset_SteerLeft, from.SteerLeft);
            Write(to, offset + offset_SteerRight, from.SteerRight);
            Write(to, offset + offset_LeftBrakeCommand, from.LeftBrakeCommand);
            Write(to, offset + offset_RightBrakeCommand, from.RightBrakeCommand);
            Write(to, offset + offset_FlapCommand, from.FlapCommand);
            Write(to, offset + offset_EngineStartSwitch, from.EngineStartSwitch);
            Write(to, offset + offset_ThrottleCommand, from.ThrottleCommand);
            Write(to, offset + offset_WindSpeedCommand, from.WindSpeedCommand);
            Write(to, offset + offset_WindDirectionCommand, from.WindDirectionCommand);
            Write(to, offset + offset_GeneratorSwitch, from.GeneratorSwitch);
            Write(to, offset + offset_InverterSwitch, from.InverterSwitch);
            Write(to, offset + offset_BatteryStatus, from.BatteryStatus);
            return true;
        }

        public override void CopyOut(System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
            object toObj = tmpGCHandleTo.Target;
            CopyOut(from, ref toObj, 0);
            if (toObj != tmpGCHandleTo.Target) tmpGCHandleTo.Target = toObj;
        }

        public override void CopyOut(System.IntPtr from, ref object to, int offset)
        {
            FDMDATA dataTo = to as FDMDATA;
            if (dataTo == null) {
                dataTo = new FDMDATA();
                to = dataTo;
            }
            dataTo.ID = ReadInt32(from, offset + offset_ID);
            dataTo.Throttle = ReadDouble(from, offset + offset_Throttle);
            dataTo.ElevatorCommand = ReadDouble(from, offset + offset_ElevatorCommand);
            dataTo.AileronCommand = ReadDouble(from, offset + offset_AileronCommand);
            dataTo.RudderCommand = ReadDouble(from, offset + offset_RudderCommand);
            dataTo.SteerLeft = ReadDouble(from, offset + offset_SteerLeft);
            dataTo.SteerRight = ReadDouble(from, offset + offset_SteerRight);
            dataTo.LeftBrakeCommand = ReadDouble(from, offset + offset_LeftBrakeCommand);
            dataTo.RightBrakeCommand = ReadDouble(from, offset + offset_RightBrakeCommand);
            dataTo.FlapCommand = ReadDouble(from, offset + offset_FlapCommand);
            dataTo.EngineStartSwitch = ReadBoolean(from, offset + offset_EngineStartSwitch);
            dataTo.ThrottleCommand = ReadDouble(from, offset + offset_ThrottleCommand);
            dataTo.WindSpeedCommand = ReadDouble(from, offset + offset_WindSpeedCommand);
            dataTo.WindDirectionCommand = ReadDouble(from, offset + offset_WindDirectionCommand);
            dataTo.GeneratorSwitch = ReadBoolean(from, offset + offset_GeneratorSwitch);
            dataTo.InverterSwitch = ReadBoolean(from, offset + offset_InverterSwitch);
            dataTo.BatteryStatus = ReadBoolean(from, offset + offset_BatteryStatus);
        }

    }
    #endregion

}

