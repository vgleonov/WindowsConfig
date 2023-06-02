
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pCaption = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.pLeftField = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.pCaption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 29);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(182, 0);
            this.textBox1.MaximumSize = new System.Drawing.Size(0, 29);
            this.textBox1.MinimumSize = new System.Drawing.Size(0, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 29);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "123test";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitter1.Location = new System.Drawing.Point(179, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 29);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // pCaption
            // 
            this.pCaption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCaption.Location = new System.Drawing.Point(0, 0);
            this.pCaption.Name = "pCaption";
            this.pCaption.Size = new System.Drawing.Size(179, 29);
            this.pCaption.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 1);
            this.panel2.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn.Location = new System.Drawing.Point(371, 1);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(30, 28);
            this.btn.TabIndex = 7;
            this.btn.Text = "v";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // pLeftField
            // 
            this.pLeftField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pLeftField.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftField.Location = new System.Drawing.Point(0, 1);
            this.pLeftField.Name = "pLeftField";
            this.pLeftField.Size = new System.Drawing.Size(24, 28);
            this.pLeftField.TabIndex = 9;
            // 
            // UC_InspectorRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pLeftField);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_InspectorRow";
            this.Size = new System.Drawing.Size(401, 29);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pCaption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel pLeftField;
    }
}
