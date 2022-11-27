namespace Lab6_DataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_doc_btn = new System.Windows.Forms.Button();
            this.doc_change_btn = new System.Windows.Forms.Button();
            this.doc_del_btn = new System.Windows.Forms.Button();
            this.cerf_del_btn = new System.Windows.Forms.Button();
            this.cerf_change_btn = new System.Windows.Forms.Button();
            this.cerf_add_btn = new System.Windows.Forms.Button();
            this.spec_del_btn = new System.Windows.Forms.Button();
            this.spec_change_btn = new System.Windows.Forms.Button();
            this.spec_add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1354, 703);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_doc_btn
            // 
            this.add_doc_btn.Location = new System.Drawing.Point(90, 726);
            this.add_doc_btn.Name = "add_doc_btn";
            this.add_doc_btn.Size = new System.Drawing.Size(162, 29);
            this.add_doc_btn.TabIndex = 1;
            this.add_doc_btn.Text = "AddDoctor";
            this.add_doc_btn.UseVisualStyleBackColor = true;
            this.add_doc_btn.Click += new System.EventHandler(this.add_doc_btn_Click);
            // 
            // doc_change_btn
            // 
            this.doc_change_btn.Location = new System.Drawing.Point(90, 761);
            this.doc_change_btn.Name = "doc_change_btn";
            this.doc_change_btn.Size = new System.Drawing.Size(162, 29);
            this.doc_change_btn.TabIndex = 2;
            this.doc_change_btn.Text = "ChangeDoctor";
            this.doc_change_btn.UseVisualStyleBackColor = true;
            this.doc_change_btn.Click += new System.EventHandler(this.doc_change_btn_Click);
            // 
            // doc_del_btn
            // 
            this.doc_del_btn.Location = new System.Drawing.Point(90, 796);
            this.doc_del_btn.Name = "doc_del_btn";
            this.doc_del_btn.Size = new System.Drawing.Size(162, 29);
            this.doc_del_btn.TabIndex = 3;
            this.doc_del_btn.Text = "DeleteDoctor";
            this.doc_del_btn.UseVisualStyleBackColor = true;
            // 
            // cerf_del_btn
            // 
            this.cerf_del_btn.Location = new System.Drawing.Point(256, 796);
            this.cerf_del_btn.Name = "cerf_del_btn";
            this.cerf_del_btn.Size = new System.Drawing.Size(162, 29);
            this.cerf_del_btn.TabIndex = 6;
            this.cerf_del_btn.Text = "DeleteCertificate";
            this.cerf_del_btn.UseVisualStyleBackColor = true;
            // 
            // cerf_change_btn
            // 
            this.cerf_change_btn.Location = new System.Drawing.Point(256, 761);
            this.cerf_change_btn.Name = "cerf_change_btn";
            this.cerf_change_btn.Size = new System.Drawing.Size(162, 29);
            this.cerf_change_btn.TabIndex = 5;
            this.cerf_change_btn.Text = "ChangeCertificate";
            this.cerf_change_btn.UseVisualStyleBackColor = true;
            // 
            // cerf_add_btn
            // 
            this.cerf_add_btn.Location = new System.Drawing.Point(256, 726);
            this.cerf_add_btn.Name = "cerf_add_btn";
            this.cerf_add_btn.Size = new System.Drawing.Size(162, 29);
            this.cerf_add_btn.TabIndex = 4;
            this.cerf_add_btn.Text = "AddCertificate";
            this.cerf_add_btn.UseVisualStyleBackColor = true;
            // 
            // spec_del_btn
            // 
            this.spec_del_btn.Location = new System.Drawing.Point(423, 796);
            this.spec_del_btn.Name = "spec_del_btn";
            this.spec_del_btn.Size = new System.Drawing.Size(162, 29);
            this.spec_del_btn.TabIndex = 9;
            this.spec_del_btn.Text = "DeleteSpecialiation";
            this.spec_del_btn.UseVisualStyleBackColor = true;
            // 
            // spec_change_btn
            // 
            this.spec_change_btn.Location = new System.Drawing.Point(423, 761);
            this.spec_change_btn.Name = "spec_change_btn";
            this.spec_change_btn.Size = new System.Drawing.Size(162, 29);
            this.spec_change_btn.TabIndex = 8;
            this.spec_change_btn.Text = "ChangeSpecialization";
            this.spec_change_btn.UseVisualStyleBackColor = true;
            // 
            // spec_add_btn
            // 
            this.spec_add_btn.Location = new System.Drawing.Point(423, 726);
            this.spec_add_btn.Name = "spec_add_btn";
            this.spec_add_btn.Size = new System.Drawing.Size(162, 29);
            this.spec_add_btn.TabIndex = 7;
            this.spec_add_btn.Text = "AddSpecialization";
            this.spec_add_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 839);
            this.Controls.Add(this.spec_del_btn);
            this.Controls.Add(this.spec_change_btn);
            this.Controls.Add(this.spec_add_btn);
            this.Controls.Add(this.cerf_del_btn);
            this.Controls.Add(this.cerf_change_btn);
            this.Controls.Add(this.cerf_add_btn);
            this.Controls.Add(this.doc_del_btn);
            this.Controls.Add(this.doc_change_btn);
            this.Controls.Add(this.add_doc_btn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_doc_btn;
        private System.Windows.Forms.Button doc_change_btn;
        private System.Windows.Forms.Button doc_del_btn;
        private System.Windows.Forms.Button cerf_del_btn;
        private System.Windows.Forms.Button cerf_change_btn;
        private System.Windows.Forms.Button cerf_add_btn;
        private System.Windows.Forms.Button spec_del_btn;
        private System.Windows.Forms.Button spec_change_btn;
        private System.Windows.Forms.Button spec_add_btn;
    }
}
