
namespace WindowsConfig.UserComponents
{
    partial class UC_InspectorRow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textValue = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pCaption = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.pLeftField = new System.Windows.Forms.Panel();
            this.lCaption = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textValue);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.pCaption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 24);
            this.panel1.TabIndex = 5;
            // 
            // textValue
            // 
            this.textValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textValue.Location = new System.Drawing.Point(136, 0);
            this.textValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textValue.MaximumSize = new System.Drawing.Size(0, 29);
            this.textValue.MinimumSize = new System.Drawing.Size(0, 29);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(165, 29);
            this.textValue.TabIndex = 11;
            this.textValue.Text = "value";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitter1.Location = new System.Drawing.Point(134, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 24);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // pCaption
            // 
            this.pCaption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pCaption.Controls.Add(this.lCaption);
            this.pCaption.Controls.Add(this.pLeftField);
            this.pCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCaption.Location = new System.Drawing.Point(0, 0);
            this.pCaption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCaption.Name = "pCaption";
            this.pCaption.Size = new System.Drawing.Size(134, 24);
            this.pCaption.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 1);
            this.panel2.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn.Location = new System.Drawing.Point(279, 1);
            this.btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(22, 23);
            this.btn.TabIndex = 7;
            this.btn.Text = "v";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // pLeftField
            // 
            this.pLeftField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pLeftField.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftField.Location = new System.Drawing.Point(0, 0);
            this.pLeftField.Margin = new System.Windows.Forms.Padding(2);
            this.pLeftField.Name = "pLeftField";
            this.pLeftField.Size = new System.Drawing.Size(18, 24);
            this.pLeftField.TabIndex = 10;
            // 
            // lCaption
            // 
            this.lCaption.AutoEllipsis = true;
            this.lCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lCaption.Location = new System.Drawing.Point(18, 0);
            this.lCaption.Name = "lCaption";
            this.lCaption.Size = new System.Drawing.Size(116, 24);
            this.lCaption.TabIndex = 11;
            this.lCaption.Text = "...";
            this.lCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_InspectorRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_InspectorRow";
            this.Size = new System.Drawing.Size(301, 24);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pCaption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pCaption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lCaption;
        private System.Windows.Forms.Panel pLeftField;
    }
}
