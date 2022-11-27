namespace Presentation
{
    partial class CertificateForm
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
            this.cerfForm_main_lbl = new System.Windows.Forms.Label();
            this.cerfForm_cerfId_lbl = new System.Windows.Forms.Label();
            this.cerfForm_docId_lbl = new System.Windows.Forms.Label();
            this.cerfForm_description_lbl = new System.Windows.Forms.Label();
            this.cerfForm_dateTime_lbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cerfForm_calendar = new System.Windows.Forms.MonthCalendar();
            this.cerfForm_ok_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // cerfForm_main_lbl
            // 
            this.cerfForm_main_lbl.AutoSize = true;
            this.cerfForm_main_lbl.Location = new System.Drawing.Point(125, 26);
            this.cerfForm_main_lbl.Name = "cerfForm_main_lbl";
            this.cerfForm_main_lbl.Size = new System.Drawing.Size(122, 20);
            this.cerfForm_main_lbl.TabIndex = 0;
            this.cerfForm_main_lbl.Text = "Certificate\'s Data";
            // 
            // cerfForm_cerfId_lbl
            // 
            this.cerfForm_cerfId_lbl.AutoSize = true;
            this.cerfForm_cerfId_lbl.Location = new System.Drawing.Point(39, 85);
            this.cerfForm_cerfId_lbl.Name = "cerfForm_cerfId_lbl";
            this.cerfForm_cerfId_lbl.Size = new System.Drawing.Size(94, 20);
            this.cerfForm_cerfId_lbl.TabIndex = 1;
            this.cerfForm_cerfId_lbl.Text = "Certificate Id";
            // 
            // cerfForm_docId_lbl
            // 
            this.cerfForm_docId_lbl.AutoSize = true;
            this.cerfForm_docId_lbl.Location = new System.Drawing.Point(39, 126);
            this.cerfForm_docId_lbl.Name = "cerfForm_docId_lbl";
            this.cerfForm_docId_lbl.Size = new System.Drawing.Size(72, 20);
            this.cerfForm_docId_lbl.TabIndex = 2;
            this.cerfForm_docId_lbl.Text = "Doctor Id";
            // 
            // cerfForm_description_lbl
            // 
            this.cerfForm_description_lbl.AutoSize = true;
            this.cerfForm_description_lbl.Location = new System.Drawing.Point(39, 169);
            this.cerfForm_description_lbl.Name = "cerfForm_description_lbl";
            this.cerfForm_description_lbl.Size = new System.Drawing.Size(85, 20);
            this.cerfForm_description_lbl.TabIndex = 3;
            this.cerfForm_description_lbl.Text = "Description";
            // 
            // cerfForm_dateTime_lbl
            // 
            this.cerfForm_dateTime_lbl.AutoSize = true;
            this.cerfForm_dateTime_lbl.Location = new System.Drawing.Point(39, 211);
            this.cerfForm_dateTime_lbl.Name = "cerfForm_dateTime_lbl";
            this.cerfForm_dateTime_lbl.Size = new System.Drawing.Size(41, 20);
            this.cerfForm_dateTime_lbl.TabIndex = 4;
            this.cerfForm_dateTime_lbl.Text = "Date";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.InterceptArrowKeys = false;
            this.numericUpDown1.Location = new System.Drawing.Point(197, 78);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(197, 121);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.TabIndex = 7;
            // 
            // cerfForm_calendar
            // 
            this.cerfForm_calendar.Location = new System.Drawing.Point(172, 211);
            this.cerfForm_calendar.Name = "cerfForm_calendar";
            this.cerfForm_calendar.TabIndex = 8;
            // 
            // cerfForm_ok_btn
            // 
            this.cerfForm_ok_btn.Location = new System.Drawing.Point(137, 453);
            this.cerfForm_ok_btn.Name = "cerfForm_ok_btn";
            this.cerfForm_ok_btn.Size = new System.Drawing.Size(94, 29);
            this.cerfForm_ok_btn.TabIndex = 8;
            this.cerfForm_ok_btn.Text = "Ok";
            this.cerfForm_ok_btn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 512);
            this.Controls.Add(this.cerfForm_ok_btn);
            this.Controls.Add(this.cerfForm_calendar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cerfForm_dateTime_lbl);
            this.Controls.Add(this.cerfForm_description_lbl);
            this.Controls.Add(this.cerfForm_docId_lbl);
            this.Controls.Add(this.cerfForm_cerfId_lbl);
            this.Controls.Add(this.cerfForm_main_lbl);
            this.Name = "Form2";
            this.Text = "Certificate\'s Data";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cerfForm_main_lbl;
        private System.Windows.Forms.Label cerfForm_cerfId_lbl;
        private System.Windows.Forms.Label cerfForm_docId_lbl;
        private System.Windows.Forms.Label cerfForm_description_lbl;
        private System.Windows.Forms.Label cerfForm_dateTime_lbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar cerfForm_calendar;
        private System.Windows.Forms.Button cerfForm_ok_btn;
    }
}