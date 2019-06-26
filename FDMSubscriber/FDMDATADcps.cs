using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DDS;
using DDS.OpenSplice;
using DDS.OpenSplice.CustomMarshalers;

namespace FDMData
{
    #region FDMDATADataReader
    public class FDMDATADataReader : DDS.OpenSplice.DataReader, IFDMDATADataReader
    {
        private FDMDATATypeSupport typeSupport;

        public FDMDATADataReader(FDMDATATypeSupport ts, IntPtr gapiPtr)
            : base(gapiPtr)
        {
            typeSupport = ts;
        }

        public ReturnCode Read(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos)
        {
            return Read(ref dataValues, ref sampleInfos, Length.Unlimited);
        }

        public ReturnCode Read(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples)
        {
            return Read(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode Read(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates)
        {
            return Read(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                viewStates, instanceStates);
        }

        public ReturnCode Read(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.Read(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (FDMDATA[])objectValues;
            return result;
        }

        public ReturnCode Take(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos)
        {
            return Take(ref dataValues, ref sampleInfos, Length.Unlimited);
        }

        public ReturnCode Take(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples)
        {
            return Take(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode Take(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates)
        {
            return Take(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                viewStates, instanceStates);
        }

        public ReturnCode Take(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.Take(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (FDMDATA[])objectValues;
            return result;
        }

        public ReturnCode ReadWithCondition(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition)
        {
            return ReadWithCondition(ref dataValues, ref sampleInfos,
                Length.Unlimited, readCondition);
        }

        public ReturnCode ReadWithCondition(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        readCondition);
            dataValues = (FDMDATA[])objectValues;
            return result;
        }

        public ReturnCode TakeWithCondition(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition)
        {
            return TakeWithCondition(ref dataValues, ref sampleInfos,
                Length.Unlimited, readCondition);
        }

        public ReturnCode TakeWithCondition(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        readCondition);
            dataValues = (FDMDATA[])objectValues;
            return result;
        }

        public ReturnCode ReadNextSample(
                FDMDATA dataValue,
                SampleInfo sampleInfo)
        {
            object objectValues = dataValue;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextSample(
                        this,
                        ref objectValues,
                        ref sampleInfo);
            dataValue = (FDMDATA)objectValues;
            return result;
        }

        public ReturnCode TakeNextSample(
                FDMDATA dataValue,
                SampleInfo sampleInfo)
        {
            object objectValues = dataValue;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextSample(
                        this,
                        ref objectValues,
                        ref sampleInfo);
            dataValue = (FDMDATA)objectValues;
            return result;
        }

        public ReturnCode ReadInstance(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return ReadInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode ReadInstance(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return ReadInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode ReadInstance(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (FDMDATA[])objectValues;
            return result;
        }

        public ReturnCode TakeInstance(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return TakeInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode TakeInstance(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return TakeInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode TakeInstance(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (FDMDATA[])objectValues;
            return result;
        }

        public ReturnCode ReadNextInstance(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return ReadNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode ReadNextInstance(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return ReadNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode ReadNextInstance(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (FDMDATA[])objectValues;
            return result;
        }

        public ReturnCode TakeNextInstance(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return TakeNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode TakeNextInstance(
            ref FDMDATA[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return TakeNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode TakeNextInstance(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (FDMDATA[])objectValues;
            return result;
        }

        public ReturnCode ReadNextInstanceWithCondition(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            return ReadNextInstanceWithCondition(
                ref dataValues,
                ref sampleInfos,
                Length.Unlimited,
                instanceHandle,
                readCondition);
        }

        public ReturnCode ReadNextInstanceWithCondition(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextInstanceWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        readCondition);
            dataValues = (FDMDATA[])objectValues;
            return result;
        }

        public ReturnCode TakeNextInstanceWithCondition(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            return TakeNextInstanceWithCondition(
                ref dataValues,
                ref sampleInfos,
                Length.Unlimited,
                instanceHandle,
                readCondition);
        }

        public ReturnCode TakeNextInstanceWithCondition(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextInstanceWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        readCondition);

            dataValues = (FDMDATA[])objectValues;
            return result;
        }

        public ReturnCode ReturnLoan(
                ref FDMDATA[] dataValues,
                ref SampleInfo[] sampleInfos)
        {
            ReturnCode result;

            if (dataValues != null && sampleInfos != null)
            {
                if (dataValues != null && sampleInfos != null)
                {
                    if (dataValues.Length == sampleInfos.Length)
                    {
                        dataValues = null;
                        sampleInfos = null;
                        result = ReturnCode.Ok;
                    }
                    else
                    {
                        result = ReturnCode.PreconditionNotMet;
                    }
                }
                else
                {
                    if ((dataValues == null) && (sampleInfos == null))
                    {
                        result = ReturnCode.Ok;
                    }
                    else
                    {
                        result = ReturnCode.PreconditionNotMet;
                    }
                }
            }
            else
            {
                result = ReturnCode.BadParameter;
            }

            return result;
        }

        public ReturnCode GetKeyValue(
                ref FDMDATA key,
                InstanceHandle handle)
        {
            object keyObj = key;
            ReturnCode result = DDS.OpenSplice.FooDataReader.GetKeyValue(
                        this,
                        ref keyObj,
                        handle);
            if (keyObj != key) key = keyObj as FDMDATA;
            return result;
        }

        public InstanceHandle LookupInstance(
                FDMDATA instance)
        {
            return
                DDS.OpenSplice.FooDataReader.LookupInstance(
                        this,
                        instance);
        }

    }
    #endregion
    
    #region FDMDATADataWriter
    public class FDMDATADataWriter : DDS.OpenSplice.DataWriter, IFDMDATADataWriter
    {
        private FDMDATATypeSupport typeSupport;

        public FDMDATADataWriter(FDMDATATypeSupport ts, IntPtr gapiPtr)
            : base(gapiPtr)
        {
            typeSupport = ts;
        }

        public InstanceHandle RegisterInstance(
                FDMDATA instanceData)
        {
            return DDS.OpenSplice.FooDataWriter.RegisterInstance(
                        this,
                        instanceData);
        }

        public InstanceHandle RegisterInstanceWithTimestamp(
                FDMDATA instanceData,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.RegisterInstanceWithTimestamp(
                        this,
                        instanceData,
                        sourceTimestamp);
        }

        public ReturnCode UnregisterInstance(
                FDMDATA instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.UnregisterInstance(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode UnregisterInstanceWithTimestamp(
                FDMDATA instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.UnregisterInstanceWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode Write(FDMDATA instanceData)
        {
            return Write(instanceData, InstanceHandle.Nil);
        }

        public ReturnCode Write(
                FDMDATA instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.Write(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode WriteWithTimestamp(
                FDMDATA instanceData,
                Time sourceTimestamp)
        {
            return WriteWithTimestamp(instanceData, InstanceHandle.Nil, sourceTimestamp);
        }

        public ReturnCode WriteWithTimestamp(
                FDMDATA instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.WriteWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode Dispose(
                FDMDATA instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.Dispose(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode DisposeWithTimestamp(
                FDMDATA instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.DisposeWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode WriteDispose(
                FDMDATA instanceData)
        {
            return WriteDispose(instanceData, InstanceHandle.Nil);
        }

        public ReturnCode WriteDispose(
                FDMDATA instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.WriteDispose(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode WriteDisposeWithTimestamp(
                FDMDATA instanceData,
                Time sourceTimestamp)
        {
            return WriteDisposeWithTimestamp(instanceData, InstanceHandle.Nil, sourceTimestamp);
        }

        public ReturnCode WriteDisposeWithTimestamp(
                FDMDATA instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.WriteDisposeWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode GetKeyValue(
                ref FDMDATA key,
                InstanceHandle instanceHandle)
        {
            object keyObj = key;
            ReturnCode result = DDS.OpenSplice.FooDataWriter.GetKeyValue(
                                    this,
                                    ref keyObj,
                                    instanceHandle);
            if (keyObj != key) key = keyObj as FDMDATA;
            return result;
        }

        public InstanceHandle LookupInstance(
            FDMDATA instanceData)
        {
            InstanceHandle result = DDS.OpenSplice.FooDataWriter.LookupInstance(
                                        this,
                                        instanceData);
            return result;
        }
    }
    #endregion

    #region FDMDATATypeSupport
    public class FDMDATATypeSupport : DDS.OpenSplice.TypeSupport
    {
        private const string typeName = "FDMData::FDMDATA";
        private const string keyList = "ID";
        private const string metaDescriptor = "<MetaData version=\"1.0.0\"><Module name=\"FDMData\"><Struct name=\"FDMDATA\"><Member name=\"ID\"><Long/></Member><Member name=\"Throttle\"><Double/></Member><Member name=\"ElevatorCommand\"><Double/></Member><Member name=\"AileronCommand\"><Double/></Member><Member name=\"RudderCommand\"><Double/></Member><Member name=\"SteerLeft\"><Double/></Member><Member name=\"SteerRight\"><Double/></Member><Member name=\"LeftBrakeCommand\"><Double/></Member><Member name=\"RightBrakeCommand\"><Double/></Member><Member name=\"FlapCommand\"><Double/></Member><Member name=\"EngineStartSwitch\"><Boolean/></Member><Member name=\"ThrottleCommand\"><Double/></Member><Member name=\"WindSpeedCommand\"><Double/></Member><Member name=\"WindDirectionCommand\"><Double/></Member><Member name=\"GeneratorSwitch\"><Boolean/></Member><Member name=\"InverterSwitch\"><Boolean/></Member><Member name=\"BatteryStatus\"><Boolean/></Member></Struct></Module></MetaData>";

        public FDMDATATypeSupport()
            : base(typeof(FDMDATA))
        { }

        public override string TypeName
        {
            get
            {
                return typeName;
            }
        }

        public override string Description
        {
            get
            {
                return metaDescriptor;
            }
        }

        public override string KeyList
        {
            get
            {
                return keyList;
            }
        }

        public override ReturnCode RegisterType(IDomainParticipant participant, string typeName)
        {
            return RegisterType(participant, typeName, new FDMDATAMarshaler());
        }

        public override DDS.OpenSplice.DataWriter CreateDataWriter(IntPtr gapiPtr)
        {
            return new FDMDATADataWriter(this, gapiPtr);
        }

        public override DDS.OpenSplice.DataReader CreateDataReader(IntPtr gapiPtr)
        {
            return new FDMDATADataReader(this, gapiPtr);
        }
    }
    #endregion
}

