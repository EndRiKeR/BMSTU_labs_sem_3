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
            this.cerfForm_docId_udn = new System.Windows.Forms.NumericUpDown();
            this.cerfForm_descr_txt = new System.Windows.Forms.TextBox();
            this.cerfForm_ok_btn = new System.Windows.Forms.Button();
            this.cerfForm_cerfId_txt = new System.Windows.Forms.TextBox();
            this.cerfForm_calendar = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.cerfForm_docId_udn)).BeginInit();
            this.SuspendLayout();
            // 
            // cerfForm_main_lbl
            // 
            this.cerfForm_main_lbl.AutoSize = true;
            this.cerfForm_main_lbl.Location = new System.Drawing.Point(125, 27);
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
            this.cerfForm_docId_lbl.Location = new System.Drawing.Point(39, 125);
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
            // cerfForm_docId_udn
            // 
            this.cerfForm_docId_udn.Location = new System.Drawing.Point(197, 121);
            this.cerfForm_docId_udn.Name = "cerfForm_docId_udn";
            this.cerfForm_docId_udn.Size = new System.Drawing.Size(150, 27);
            this.cerfForm_docId_udn.TabIndex = 6;
            // 
            // cerfForm_descr_txt
            // 
            this.cerfForm_descr_txt.Location = new System.Drawing.Point(197, 165);
            this.cerfForm_descr_txt.Name = "cerfForm_descr_txt";
            this.cerfForm_descr_txt.Size = new System.Drawing.Size(150, 27);
            this.cerfForm_descr_txt.TabIndex = 7;
            // 
            // cerfForm_ok_btn
            // 
            this.cerfForm_ok_btn.Location = new System.Drawing.Point(141, 306);
            this.cerfForm_ok_btn.Name = "cerfForm_ok_btn";
            this.cerfForm_ok_btn.Size = new System.Drawing.Size(94, 29);
            this.cerfForm_ok_btn.TabIndex = 8;
            this.cerfForm_ok_btn.Text = "Ok";
            this.cerfForm_ok_btn.UseVisualStyleBackColor = true;
            this.cerfForm_ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cerfForm_cerfId_txt
            // 
            this.cerfForm_cerfId_txt.Location = new System.Drawing.Point(197, 75);
            this.cerfForm_cerfId_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cerfForm_cerfId_txt.Name = "cerfForm_cerfId_txt";
            this.cerfForm_cerfId_txt.Size = new System.Drawing.Size(150, 27);
            this.cerfForm_cerfId_txt.TabIndex = 9;
            // 
            // cerfForm_calendar
            // 
            this.cerfForm_calendar.Location = new System.Drawing.Point(120, 211);
            this.cerfForm_calendar.Name = "cerfForm_calendar";
            this.cerfForm_calendar.Size = new System.Drawing.Size(250, 27);
            this.cerfForm_calendar.TabIndex = 10;
            // 
            // CertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 347);
            this.Controls.Add(this.cerfForm_calendar);
            this.Controls.Add(this.cerfForm_cerfId_txt);
            this.Controls.Add(this.cerfForm_ok_btn);
            this.Controls.Add(this.cerfForm_descr_txt);
            this.Controls.Add(this.cerfForm_docId_udn);
            this.Controls.Add(this.cerfForm_dateTime_lbl);
            this.Controls.Add(this.cerfForm_description_lbl);
            this.Controls.Add(this.cerfForm_docId_lbl);
            this.Controls.Add(this.cerfForm_cerfId_lbl);
            this.Controls.Add(this.cerfForm_main_lbl);
            this.Name = "CertificateForm";
            this.Text = "Certificate\'s Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CerfForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.cerfForm_docId_udn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cerfForm_main_lbl;
        private System.Windows.Forms.Label cerfForm_cerfId_lbl;
        private System.Windows.Forms.Label cerfForm_docId_lbl;
        private System.Windows.Forms.Label cerfForm_description_lbl;
        private System.Windows.Forms.Label cerfForm_dateTime_lbl;
        private System.Windows.Forms.NumericUpDown cerfForm_docId_udn;
        private System.Windows.Forms.TextBox cerfForm_descr_txt;
        private System.Windows.Forms.Button cerfForm_ok_btn;
        private System.Windows.Forms.TextBox cerfForm_cerfId_txt;
        private System.Windows.Forms.DateTimePicker cerfForm_calendar;
    }
}