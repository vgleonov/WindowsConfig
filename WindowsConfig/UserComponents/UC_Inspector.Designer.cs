
namespace WindowsConfig.UserComponents
{
    partial class UC_Inspector
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inspector));
            this.pHeader = new System.Windows.Forms.Panel();
            this.labCaption = new System.Windows.Forms.Label();
            this.labPropertyType = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labPropertyName = new System.Windows.Forms.Label();
            this.labPropertyDescription = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn01 = new System.Windows.Forms.ToolStripButton();
            this.btn02 = new System.Windows.Forms.ToolStripButton();
            this.btn03 = new System.Windows.Forms.ToolStripButton();
            this.btn04 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pHeader.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.labPropertyType);
            this.pHeader.Controls.Add(this.labCaption);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(312, 30);
            this.pHeader.TabIndex = 0;
            // 
            // labCaption
            // 
            this.labCaption.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.labCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCaption.Location = new System.Drawing.Point(0, 0);
            this.labCaption.Name = "labCaption";
            this.labCaption.Size = new System.Drawing.Size(144, 30);
            this.labCaption.TabIndex = 0;
            this.labCaption.Text = "ComponentName";
            this.labCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labPropertyType
            // 
            this.labPropertyType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labPropertyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labPropertyType.Location = new System.Drawing.Point(144, 0);
            this.labPropertyType.Name = "labPropertyType";
            this.labPropertyType.Size = new System.Drawing.Size(168, 30);
            this.labPropertyType.TabIndex = 1;
            this.labPropertyType.Text = "PropertyType";
            this.labPropertyType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox
            // 
            this.textbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textbox.Location = new System.Drawing.Point(0, 30);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(312, 22);
            this.textbox.TabIndex = 1;
            // 
            // toolbar
            // 
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn01,
            this.btn02,
            this.btn03,
            this.toolStripSeparator1,
            this.btn04});
            this.toolbar.Location = new System.Drawing.Point(0, 52);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(312, 27);
            this.toolbar.TabIndex = 2;
            this.toolbar.Text = "tools";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labPropertyDescription);
            this.panel1.Controls.Add(this.labPropertyName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 100);
            this.panel1.TabIndex = 3;
            // 
            // labPropertyName
            // 
            this.labPropertyName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labPropertyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labPropertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPropertyName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labPropertyName.Location = new System.Drawing.Point(0, 0);
            this.labPropertyName.Name = "labPropertyName";
            this.labPropertyName.Size = new System.Drawing.Size(312, 31);
            this.labPropertyName.TabIndex = 1;
            this.labPropertyName.Text = "PropertyName";
            // 
            // labPropertyDescription
            // 
            this.labPropertyDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labPropertyDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labPropertyDescription.Location = new System.Drawing.Point(0, 31);
            this.labPropertyDescription.Name = "labPropertyDescription";
            this.labPropertyDescription.Size = new System.Drawing.Size(312, 69);
            this.labPropertyDescription.TabIndex = 2;
            this.labPropertyDescription.Text = "PropertyDescription";
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.Controls.Add(this.panel2);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 79);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(312, 447);
            this.panelBody.TabIndex = 4;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn01
            // 
            this.btn01.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn01.Image = ((System.Drawing.Image)(resources.GetObject("btn01.Image")));
            this.btn01.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(29, 24);
            this.btn01.Text = "toolStripButton1";
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn02
            // 
            this.btn02.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn02.Image = ((System.Drawing.Image)(resources.GetObject("btn02.Image")));
            this.btn02.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(29, 24);
            this.btn02.Text = "toolStripButton2";
            // 
            // btn03
            // 
            this.btn03.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn03.Image = ((System.Drawing.Image)(resources.GetObject("btn03.Image")));
            this.btn03.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(29, 24);
            this.btn03.Text = "toolStripButton3";
            // 
            // btn04
            // 
            this.btn04.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn04.Image = ((System.Drawing.Image)(resources.GetObject("btn04.Image")));
            this.btn04.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(29, 24);
            this.btn04.Text = "toolStripButton4";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 1);
            this.panel2.TabIndex = 0;
            // 
            // UC_Inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.pHeader);
            this.Name = "UC_Inspector";
            this.Size = new System.Drawing.Size(312, 626);
            this.pHeader.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label labPropertyType;
        private System.Windows.Forms.Label labCaption;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton btn01;
        private System.Windows.Forms.ToolStripButton btn02;
        private System.Windows.Forms.ToolStripButton btn03;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn04;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labPropertyDescription;
        private System.Windows.Forms.Label labPropertyName;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panel2;
    }
}
