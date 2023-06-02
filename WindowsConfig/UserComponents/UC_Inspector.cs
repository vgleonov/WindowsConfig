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
    public partial class UC_Inspector : UserControl
    {
        private int _pwidth=0;
        public int CaptionWidth
        {
            set { _pwidth = value; }
            get { return _pwidth;  }
        }
        public List<UC_InspectorRow> Rows = new List<UC_InspectorRow>();
        private void AddRow()
        {
            UC_InspectorRow row = new UC_InspectorRow(CaptionWidth) { Dock = DockStyle.Top, Parent = panelBody, Height = 29 };
            row.OnMoved += new UC_InspectorRow.MethodContainer(this.ResizeRows);
            panelBody.Visible = false;
            Rows.Add(row);
            panelBody.Controls.Add(row);
            ResizeRows();
            panelBody.Visible = true;
        }
        public void ResizeRows()
        {
            foreach (UC_InspectorRow r in Rows)
            {
                r.ResizeCaptionWidth(CaptionWidth);
            }
        }
        public void ResizeRows(int w)
        {
            if (w == CaptionWidth)  return;
            panelBody.Visible = false;
            CaptionWidth = w;
            foreach (UC_InspectorRow r in Rows)
            {
                r.ResizeCaptionWidth(CaptionWidth);
            }
            panelBody.Visible = true;
        }
        public UC_Inspector()
        {
            InitializeComponent();
            CaptionWidth = AppParameters.InspectorSplitPosition;
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            AddRow();
        }
}
}