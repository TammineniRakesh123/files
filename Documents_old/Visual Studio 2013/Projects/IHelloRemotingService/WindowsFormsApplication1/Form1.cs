using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        IHelloRemotingService.IHelloRemotingService client;
        public Form1()
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (IHelloRemotingService.IHelloRemotingService)Activator.GetObject(
              typeof(IHelloRemotingService.IHelloRemotingService),
              "tcp://localhost:8080/GetMessage1");
        }
        private void button1_Click(object sender, EventArgs e)
        {


            label1.Text = client.GetMessage1(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
