using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsConfig.UserComponents
{
    public partial class UC_InspectorRow : UserControl
    {
        public delegate void MethodContainer(int i);
        public event MethodContainer OnMoved;
        
        public void ResizeCaptionWidth(int w)
        {
                pCaption.Width = w;
        }
        public UC_InspectorRow(int width)
        {
            InitializeComponent();
            pCaption.Width = width;
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

            OnMoved(pCaption.Width);
        }
    }
}
