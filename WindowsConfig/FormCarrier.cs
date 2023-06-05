using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace WindowsConfig
{
    public partial class FormCarrier : Form
    {
        private Form ActForm;
        public FormCarrier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            FormDesign f = new FormDesign();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            if (ActForm != null) { ActForm.Close(); }
            ActForm = f;
            panelBody.Controls.Add(ActForm);
            ActForm.BringToFront();
            ActForm.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            FormTestInspector f = new FormTestInspector();
            f.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
        }
    }
}
