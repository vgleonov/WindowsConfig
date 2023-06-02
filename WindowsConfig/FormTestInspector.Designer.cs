
namespace WindowsConfig
{
    partial class FormTestInspector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uC_Inspector1 = new WindowsConfig.UserComponents.UC_Inspector();
            this.SuspendLayout();
            // 
            // uC_Inspector1
            // 
            this.uC_Inspector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Inspector1.Location = new System.Drawing.Point(0, 0);
            this.uC_Inspector1.Name = "uC_Inspector1";
            this.uC_Inspector1.Size = new System.Drawing.Size(323, 584);
            this.uC_Inspector1.TabIndex = 0;
            // 
            // FormTestInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 584);
            this.Controls.Add(this.uC_Inspector1);
            this.Name = "FormTestInspector";
            this.Text = "FormTestInspector";
            this.ResumeLayout(false);

        }

        #endregion

        private UserComponents.UC_Inspector uC_Inspector1;
    }
}