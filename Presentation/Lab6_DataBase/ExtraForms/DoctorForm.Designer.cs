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
            this.docForm_specId_nud = new System.Windows.Forms.NumericUpDown();
            this.docForm_docId_nud = new System.Windows.Forms.NumericUpDown();
            this.docForm_docId_lbl = new System.Windows.Forms.Label();
            this.docForm_specId_lbl = new System.Windows.Forms.Label();
            this.docForm_docName_lbl = new System.Windows.Forms.Label();
            this.docForm_docName_txt = new System.Windows.Forms.TextBox();
            this.docForm_main_lbl = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.docForm_specId_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docForm_docId_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // docForm_specId_nud
            // 
            this.docForm_specId_nud.Location = new System.Drawing.Point(221, 152);
            this.docForm_specId_nud.Name = "docForm_specId_nud";
            this.docForm_specId_nud.Size = new System.Drawing.Size(150, 27);
            this.docForm_specId_nud.TabIndex = 0;
            // 
            // docForm_docId_nud
            // 
            this.docForm_docId_nud.InterceptArrowKeys = false;
            this.docForm_docId_nud.Location = new System.Drawing.Point(221, 87);
            this.docForm_docId_nud.Name = "docForm_docId_nud";
            this.docForm_docId_nud.ReadOnly = true;
            this.docForm_docId_nud.Size = new System.Drawing.Size(150, 27);
            this.docForm_docId_nud.TabIndex = 1;
            // 
            // docForm_docId_lbl
            // 
            this.docForm_docId_lbl.AutoSize = true;
            this.docForm_docId_lbl.Location = new System.Drawing.Point(67, 89);
            this.docForm_docId_lbl.Name = "docForm_docId_lbl";
            this.docForm_docId_lbl.Size = new System.Drawing.Size(72, 20);
            this.docForm_docId_lbl.TabIndex = 2;
            this.docForm_docId_lbl.Text = "Doctor Id";
            // 
            // docForm_specId_lbl
            // 
            this.docForm_specId_lbl.AutoSize = true;
            this.docForm_specId_lbl.Location = new System.Drawing.Point(67, 152);
            this.docForm_specId_lbl.Name = "docForm_specId_lbl";
            this.docForm_specId_lbl.Size = new System.Drawing.Size(119, 20);
            this.docForm_specId_lbl.TabIndex = 3;
            this.docForm_specId_lbl.Text = "Specialization Id";
            // 
            // docForm_docName_lbl
            // 
            this.docForm_docName_lbl.AutoSize = true;
            this.docForm_docName_lbl.Location = new System.Drawing.Point(67, 222);
            this.docForm_docName_lbl.Name = "docForm_docName_lbl";
            this.docForm_docName_lbl.Size = new System.Drawing.Size(49, 20);
            this.docForm_docName_lbl.TabIndex = 4;
            this.docForm_docName_lbl.Text = "Name";
            // 
            // docForm_docName_txt
            // 
            this.docForm_docName_txt.Location = new System.Drawing.Point(221, 215);
            this.docForm_docName_txt.Name = "docForm_docName_txt";
            this.docForm_docName_txt.Size = new System.Drawing.Size(150, 27);
            this.docForm_docName_txt.TabIndex = 5;
            // 
            // docForm_main_lbl
            // 
            this.docForm_main_lbl.AutoSize = true;
            this.docForm_main_lbl.Location = new System.Drawing.Point(141, 32);
            this.docForm_main_lbl.Name = "docForm_main_lbl";
            this.docForm_main_lbl.Size = new System.Drawing.Size(100, 20);
            this.docForm_main_lbl.TabIndex = 6;
            this.docForm_main_lbl.Text = "Doctor\'s Data";
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(157, 285);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(94, 29);
            this.ok_btn.TabIndex = 7;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.docForm_main_lbl);
            this.Controls.Add(this.docForm_docName_txt);
            this.Controls.Add(this.docForm_docName_lbl);
            this.Controls.Add(this.docForm_specId_lbl);
            this.Controls.Add(this.docForm_docId_lbl);
            this.Controls.Add(this.docForm_docId_nud);
            this.Controls.Add(this.docForm_specId_nud);
            this.Name = "DoctorForm";
            this.Text = "Doctor\'s Entity";
            ((System.ComponentModel.ISupportInitialize)(this.docForm_specId_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docForm_docId_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown docForm_specId_nud;
        private System.Windows.Forms.NumericUpDown docForm_docId_nud;
        private System.Windows.Forms.Label docForm_docId_lbl;
        private System.Windows.Forms.Label docForm_specId_lbl;
        private System.Windows.Forms.Label docForm_docName_lbl;
        private System.Windows.Forms.TextBox docForm_docName_txt;
        private System.Windows.Forms.Label docForm_main_lbl;
        private System.Windows.Forms.Button ok_btn;
    }
}