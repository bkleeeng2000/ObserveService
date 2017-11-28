using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels.Ipc;

namespace IpcServiceTest
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();

            //Ipc MSDN: https://goo.gl/zXg5fy

            //서버채널 생성
            IpcChannel ipcChannel = new IpcChannel("localhost:9090");
            
            //서버채널 등록
            System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(ipcChannel,false);

            Debug.WriteLine("The name of the channel is {0}", ipcChannel.ChannelName);
            Debug.WriteLine("The priority of the channel is {0}", ipcChannel.ChannelPriority);

        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }


    }
}
