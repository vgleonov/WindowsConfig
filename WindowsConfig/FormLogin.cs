using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsConfig
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //private void labForget_MouseHover(object sender, EventArgs e)
        //{
        //    labForget.ForeColor = Color.SteelBlue;
        //}

        private void labForget_MouseLeave(object sender, EventArgs e)
        {
            labForget.ForeColor = Color.SlateGray;
        }

        //private void labForget_Click(object sender, EventArgs e)
        //{
        //    //labForget.ForeColor = Color.LightSteelBlue;
        //}

        private void labForget_MouseUp(object sender, MouseEventArgs e)
        {
            labForget.ForeColor = Color.SteelBlue;
        }

        private void labForget_MouseDown(object sender, MouseEventArgs e)
        {
            labForget.ForeColor = Color.LightSteelBlue;
        }

        private void labForget_MouseEnter(object sender, EventArgs e)
        {
            labForget.ForeColor = Color.SteelBlue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
