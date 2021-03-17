using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {



            iPlayerManage player;

            if (comboBox1.Text== "Mp3 CD")
            {
                 player = new AudioManage();
                this.Text = player.Play();
            }

            else if (comboBox1.Text == "Video CD")
            {
                 player = new VideoManage();
                this.Text = player.Play();
            }
            else
            {
                MessageBox.Show("Please insert CD");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            iPlayerManage player;

            if (comboBox1.Text == "Mp3 CD")
            {
                player = new AudioManage();
                this.Text = player.Stop();
            }

            else if (comboBox1.Text == "Video CD")
            {
                player = new VideoManage();
                this.Text = player.Stop();
            }
            else
            {
                MessageBox.Show("Please insert CD");
            }
        }
    }
}
