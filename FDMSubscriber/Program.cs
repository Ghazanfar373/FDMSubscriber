using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using DDS;
using DDS.OpenSplice;
using FDMData;
using DDSErrorHandle;

namespace FDMSubscriber
{
    class Program
    {
        static private FDMTypeSupport fdmDataType;
        static private ITopic fdmDataTopic;
        static private SubscriberQos sQos;
        static private ISubscriber Subscriber;
        static private DataReaderQos drQos;
        static private IDataReader parentReader;
        static private FDMDataReader fdmDataReader;
        static private FDM[] msg;
        static public FDM fdmData;
        private const string Domain = "DDSDomain";
        private const string PartitionName = "DDSDomain";

        static private DomainParticipantFactory _dpf;
        static private IDomainParticipant _dp;

        static public bool IsAlive;

        /// <summary>
        /// If Stop is true then FDMDATA Subscriber will stop running
        /// </summary>
        static private bool _stopReceive;

        static void Main(string[] args)
        {
            _dpf = DomainParticipantFactory.Instance;
            ErrorHandler.checkHandle(_dpf, "Domain Participant Factory");

            _dp = _dpf.CreateParticipant(Domain);

            //Initialize QOS
            sQos = new SubscriberQos();
            drQos = new DataReaderQos();

            fdmDataType = new FDMTypeSupport();
            string FDMDATATypeName = fdmDataType.TypeName;
            ReturnCode status = fdmDataType.RegisterType(_dp, FDMDATATypeName);
            ErrorHandler.checkStatus(status, "FDMDATA: Cannot Register Type");

            //Create FDMDATA Topic
            fdmDataTopic = _dp.FindTopic("FDMDATA", Duration.FromMilliseconds(1000));
            if (fdmDataTopic == null)
                fdmDataTopic = _dp.CreateTopic("FDMDATA", FDMDATATypeName);
            ErrorHandler.checkHandle(fdmDataTopic, "Cannot Create Topic FDMDATA");

            //Get Subscriber QOS and Set Partition Name
            _dp.GetDefaultSubscriberQos(ref sQos);
            sQos.Partition.Name = new String[1];
            sQos.Partition.Name[0] = PartitionName;

            //Create Subscriber for FDMDATA Topic
            Subscriber = _dp.CreateSubscriber(sQos);
            ErrorHandler.checkHandle(Subscriber, "Cannot Create FDMDATA Subscriber");

            //Get Data Reader QOS and Set History Depth
            Subscriber.GetDefaultDataReaderQos(ref drQos);
            ErrorHandler.checkHandle(drQos, "Cannot get Data Reader Qos");
            drQos.History.Depth = 5;
            drQos.Reliability.Kind = ReliabilityQosPolicyKind.BestEffortReliabilityQos;

            //Create DataReader for FDMDATA Topic
            parentReader = Subscriber.CreateDataReader(fdmDataTopic, drQos);
            ErrorHandler.checkHandle(parentReader, "Cannot Create FDMDATA Data Reader");

            //Narrow abstract parentReader into its typed representative
            fdmDataReader = parentReader as FDMDataReader;
            ErrorHandler.checkHandle(fdmDataReader, "Cannot Narrow FDMDATA Data Reader");
            // drQos.Durability.Kind = DurabilityQosPolicyKind.TransientLocalDurabilityQos;

            fdmData = new FDM();
            //Rececieve Loop
            while (true)
            {
                StartReceive();

                Console.WriteLine("abc: " + fdmData.aa.ToString());
                
            }

        }
        /// <summary>
        /// Start Receiving
        /// </summary>
        static void StartReceive()
        {
            _stopReceive = false;


            //while (!_stopReceive)
            //{
            var msg = new FDM[5];
            var sampleInfo = new SampleInfo[5];

            //InstanceHandle[] InstanceHandles = null;
            //FDMDATAReader.GetMatchedSubscriptions(ref InstanceHandles);
            //MessageBox.Show("Matched: " + InstanceHandles.GetLength(0));
            LivelinessChangedStatus aliveStatus = null;
            var returnCode = fdmDataReader.GetLivelinessChangedStatus(ref aliveStatus);
            ErrorHandler.checkStatus(returnCode, "FDM SUB : Get liveliness");
            if (aliveStatus.AliveCount > 0)
            {
                // FDM is on
                IsAlive = true;
            }
            else
            {
                // FDM is off
                IsAlive = false;
            }

            //Register FDMDATA (pre-allocating resources for it)
            //InstanceHandle cmdHandle = FDMDATAReader.RegisterInstance(msg);

            //MessageBox.Show("Data Sent: Start: " + msg.Start);
            // Take Data from FDM and populate into temporary MSG array
            ReturnCode status = fdmDataReader.Take(ref msg, ref sampleInfo);
            ErrorHandler.checkStatus(status, "Unable to Read : FDMDATA");
            //Console.WriteLine(status.ToString());
            // Copy only latest data to FdmData variable if some Data has been read
            if (status == ReturnCode.Ok)
                fdmData = msg[0];
            
            Thread.Sleep(10);
            //}

        }
    }
}

