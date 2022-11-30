namespace Presentation
{
    partial class DoctorForm
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
            this.docForm_docId_lbl = new System.Windows.Forms.Label();
            this.docForm_specId_lbl = new System.Windows.Forms.Label();
            this.docForm_docName_lbl = new System.Windows.Forms.Label();
            this.docForm_docName_txt = new System.Windows.Forms.TextBox();
            this.docForm_main_lbl = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.docForm_docId_txt = new System.Windows.Forms.TextBox();
            this.docForm_specId_udn = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.docForm_specId_udn)).BeginInit();
            this.SuspendLayout();
            // 
            // docForm_docId_lbl
            // 
            this.docForm_docId_lbl.AutoSize = true;
            this.docForm_docId_lbl.Location = new System.Drawing.Point(59, 67);
            this.docForm_docId_lbl.Name = "docForm_docId_lbl";
            this.docForm_docId_lbl.Size = new System.Drawing.Size(56, 15);
            this.docForm_docId_lbl.TabIndex = 2;
            this.docForm_docId_lbl.Text = "Doctor Id";
            // 
            // docForm_specId_lbl
            // 
            this.docForm_specId_lbl.AutoSize = true;
            this.docForm_specId_lbl.Location = new System.Drawing.Point(59, 114);
            this.docForm_specId_lbl.Name = "docForm_specId_lbl";
            this.docForm_specId_lbl.Size = new System.Drawing.Size(92, 15);
            this.docForm_specId_lbl.TabIndex = 3;
            this.docForm_specId_lbl.Text = "Specialization Id";
            // 
            // docForm_docName_lbl
            // 
            this.docForm_docName_lbl.AutoSize = true;
            this.docForm_docName_lbl.Location = new System.Drawing.Point(59, 166);
            this.docForm_docName_lbl.Name = "docForm_docName_lbl";
            this.docForm_docName_lbl.Size = new System.Drawing.Size(39, 15);
            this.docForm_docName_lbl.TabIndex = 4;
            this.docForm_docName_lbl.Text = "Name";
            // 
            // docForm_docName_txt
            // 
            this.docForm_docName_txt.Location = new System.Drawing.Point(193, 161);
            this.docForm_docName_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docForm_docName_txt.Name = "docForm_docName_txt";
            this.docForm_docName_txt.Size = new System.Drawing.Size(132, 23);
            this.docForm_docName_txt.TabIndex = 5;
            // 
            // docForm_main_lbl
            // 
            this.docForm_main_lbl.AutoSize = true;
            this.docForm_main_lbl.Location = new System.Drawing.Point(123, 24);
            this.docForm_main_lbl.Name = "docForm_main_lbl";
            this.docForm_main_lbl.Size = new System.Drawing.Size(78, 15);
            this.docForm_main_lbl.TabIndex = 6;
            this.docForm_main_lbl.Text = "Doctor\'s Data";
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(137, 214);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(82, 22);
            this.ok_btn.TabIndex = 7;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // docForm_docId_txt
            // 
            this.docForm_docId_txt.Location = new System.Drawing.Point(192, 64);
            this.docForm_docId_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docForm_docId_txt.Name = "docForm_docId_txt";
            this.docForm_docId_txt.Size = new System.Drawing.Size(132, 23);
            this.docForm_docId_txt.TabIndex = 9;
            // 
            // docForm_specId_udn
            // 
            this.docForm_specId_udn.Location = new System.Drawing.Point(202, 112);
            this.docForm_specId_udn.Name = "docForm_specId_udn";
            this.docForm_specId_udn.Size = new System.Drawing.Size(120, 23);
            this.docForm_specId_udn.TabIndex = 10;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 265);
            this.Controls.Add(this.docForm_specId_udn);
            this.Controls.Add(this.docForm_docId_txt);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.docForm_main_lbl);
            this.Controls.Add(this.docForm_docName_txt);
            this.Controls.Add(this.docForm_docName_lbl);
            this.Controls.Add(this.docForm_specId_lbl);
            this.Controls.Add(this.docForm_docId_lbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoctorForm";
            this.Text = "Doctor\'s Entity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.docForm_specId_udn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label docForm_docId_lbl;
        private System.Windows.Forms.Label docForm_specId_lbl;
        private System.Windows.Forms.Label docForm_docName_lbl;
        private System.Windows.Forms.TextBox docForm_docName_txt;
        private System.Windows.Forms.Label docForm_main_lbl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox docForm_docId_txt;
        private System.Windows.Forms.NumericUpDown docForm_specId_udn;
    }
}