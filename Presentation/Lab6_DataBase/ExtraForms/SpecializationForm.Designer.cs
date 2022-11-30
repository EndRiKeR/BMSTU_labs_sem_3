using Npgsql;

namespace Presentation
{
    partial class SpecializationForm
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
            this.mail_lbl = new System.Windows.Forms.Label();
            this.specForm_specId_lbl = new System.Windows.Forms.Label();
            this.specForm_specName_lbl = new System.Windows.Forms.Label();
            this.specForm_specId_txt = new System.Windows.Forms.TextBox();
            this.specForm_specName_txt = new System.Windows.Forms.TextBox();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mail_lbl
            // 
            this.mail_lbl.AutoSize = true;
            this.mail_lbl.Location = new System.Drawing.Point(100, 35);
            this.mail_lbl.Name = "mail_lbl";
            this.mail_lbl.Size = new System.Drawing.Size(114, 15);
            this.mail_lbl.TabIndex = 0;
            this.mail_lbl.Text = "Specialization\'s Data";
            // 
            // specForm_specId_lbl
            // 
            this.specForm_specId_lbl.AutoSize = true;
            this.specForm_specId_lbl.Location = new System.Drawing.Point(49, 98);
            this.specForm_specId_lbl.Name = "specForm_specId_lbl";
            this.specForm_specId_lbl.Size = new System.Drawing.Size(92, 15);
            this.specForm_specId_lbl.TabIndex = 1;
            this.specForm_specId_lbl.Text = "Specialization Id";
            // 
            // specForm_specName_lbl
            // 
            this.specForm_specName_lbl.AutoSize = true;
            this.specForm_specName_lbl.Location = new System.Drawing.Point(41, 149);
            this.specForm_specName_lbl.Name = "specForm_specName_lbl";
            this.specForm_specName_lbl.Size = new System.Drawing.Size(114, 15);
            this.specForm_specName_lbl.TabIndex = 2;
            this.specForm_specName_lbl.Text = "Specialization Name";
            // 
            // specForm_specId_txt
            // 
            this.specForm_specId_txt.Location = new System.Drawing.Point(194, 95);
            this.specForm_specId_txt.Name = "specForm_specId_txt";
            this.specForm_specId_txt.Size = new System.Drawing.Size(100, 23);
            this.specForm_specId_txt.TabIndex = 3;
            // 
            // specForm_specName_txt
            // 
            this.specForm_specName_txt.Location = new System.Drawing.Point(195, 146);
            this.specForm_specName_txt.Name = "specForm_specName_txt";
            this.specForm_specName_txt.Size = new System.Drawing.Size(100, 23);
            this.specForm_specName_txt.TabIndex = 4;
            // 
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(121, 210);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(75, 23);
            this.Ok_btn.TabIndex = 5;
            this.Ok_btn.Text = "Ok";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // SpecializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 265);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.specForm_specName_txt);
            this.Controls.Add(this.specForm_specId_txt);
            this.Controls.Add(this.specForm_specName_lbl);
            this.Controls.Add(this.specForm_specId_lbl);
            this.Controls.Add(this.mail_lbl);
            this.Name = "SpecializationForm";
            this.Text = "Specialization\'s Entity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mail_lbl;
        private System.Windows.Forms.Label specForm_specId_lbl;
        private System.Windows.Forms.Label specForm_specName_lbl;
        private System.Windows.Forms.TextBox specForm_specId_txt;
        private System.Windows.Forms.TextBox specForm_specName_txt;
        private System.Windows.Forms.Button Ok_btn;
    }
}