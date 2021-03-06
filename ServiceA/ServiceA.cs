﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.Remoting.Channels.Ipc;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using RemoteObject;
using System.Collections;

namespace ServiceA
{
    public partial class ServiceA : ServiceBase
    {
        /// <summary>
        /// Timer Class
        /// </summary>
        private Timer timer;
        BinaryServerFormatterSinkProvider serverProvider;
        IpcServerChannel serverChannel;


        public ServiceA()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Init_IpcServer("RemoteA", "Object");
            Log("ServiceA Start");
            Log(serverChannel.GetChannelUri());
            timer = new Timer(5*1000);  //interval = 5초마다 실행
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Init_IpcServer(string channel, string uri)
        {

            serverProvider = new BinaryServerFormatterSinkProvider();

            IDictionary prop = new Hashtable
            {
                ["portName"] = channel,
                ["authorizedGroup"] = "Everyone"
            };

            serverChannel = new IpcServerChannel(prop,serverProvider);
            ChannelServices.RegisterChannel(serverChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RmtObject), uri, WellKnownObjectMode.SingleCall);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RmtObject rmtObject = new RmtObject();
            ServiceController serviceController = new ServiceController("ServiceB");
            Log("ServiceB : "+serviceController.Status.ToString());
            Log("Count : "+ rmtObject.Count++);

            if (serviceController.Status.Equals(ServiceControllerStatus.Stopped))
                serviceController.Start();
        }

        protected override void OnStop()
        {
            Log("ServiceA Stop");
        }

        public string GetDateTime()

        {

            DateTime NowDate = DateTime.Now;

            return NowDate.ToString("yyyy-MM-dd HH:mm:ss") + ":" + NowDate.Millisecond.ToString("000");

        }

        /// 로그내용
        public void Log(String msg)

        {

            string FilePath = @"D:\0. 개인업무\00. 개발\ObserveService\ServiceA\Logs\" + DateTime.Today.ToString("yyyyMMdd") + ".log";

            string DirPath = @"D:\0. 개인업무\00. 개발\ObserveService\ServiceA\Logs";

            string temp;



            DirectoryInfo di = new DirectoryInfo(DirPath);

            FileInfo fi = new FileInfo(FilePath);



            try

            {

                if (di.Exists != true) Directory.CreateDirectory(DirPath);



                if (fi.Exists != true)

                {

                    using (StreamWriter sw = new StreamWriter(FilePath))

                    {

                        temp = string.Format("[{0}] {1}", GetDateTime(), msg);

                        sw.WriteLine(temp);

                        sw.Close();

                    }

                }

                else

                {

                    using (StreamWriter sw = File.AppendText(FilePath))

                    {

                        temp = string.Format("[{0}] {1}", GetDateTime(), msg);

                        sw.WriteLine(temp);

                        sw.Close();

                    }

                }

            }

            catch (Exception e)

            {
                Debug.WriteLine(e);
                Debug.WriteLine(e.StackTrace);
            }

        }
    }
}
