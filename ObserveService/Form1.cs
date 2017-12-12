using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Windows.Forms;
using RemoteObject;

namespace ObserveService
{
    public partial class Form1 : Form
    {
        ServiceController serviceA = new ServiceController("ServiceA");
        ServiceController serviceB = new ServiceController("ServiceB");
        
        private Timer timer= new Timer();
        public Form1()
        {
            InitializeComponent();

            IpcClientChannel clientChannel = new IpcClientChannel();
            ChannelServices.RegisterChannel(clientChannel,false);

            RemotingConfiguration.RegisterWellKnownClientType(typeof(RmtObject), "ipc://remote/counter");

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            serviceA.Refresh();
            serviceB.Refresh();
            ServiceA_Status.Text = serviceA.Status.ToString();
            ServiceB_Status.Text = serviceB.Status.ToString();
        }

        private void ServicaA_On_Click(object sender, EventArgs e)
        {
            serviceA.Start();
        }

        private void ServiceA_Off_Click(object sender, EventArgs e)
        {
            serviceA.Stop();
        }

        private void ServiceB_On_Click(object sender, EventArgs e)
        {
            serviceB.Start();
        }

        private void ServiceB_Off_Click(object sender, EventArgs e)
        {
            serviceB.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serviceA.Stop();
            serviceB.Stop();
        }
    }
}
