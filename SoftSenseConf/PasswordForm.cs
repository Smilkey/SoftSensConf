using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace SoftSenseConf
{
    public partial class PasswordForm : Form
    {

        public PasswordForm()
        {
            InitializeComponent();

        }

        public string textPassword { get; set; }

        public void button_ok_Click(object sender, EventArgs e)
        {
            //FormMainSoftSense mainPswrd = new FormMainSoftSense();
            //mainPswrd.Write_accepted(this, e);
            this.textPassword = textBox_password.Text;
            Close();
        }
    }
}
