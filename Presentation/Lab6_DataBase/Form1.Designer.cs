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
            this.add_btn = new System.Windows.Forms.Button();
            this.change_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.id_catcher_txt = new System.Windows.Forms.TextBox();
            this.tables_names_cb = new System.Windows.Forms.ComboBox();
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
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(197, 726);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(162, 29);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(197, 761);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(162, 29);
            this.change_btn.TabIndex = 2;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = true;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(197, 796);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(162, 29);
            this.del_btn.TabIndex = 3;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            // 
            // id_catcher_txt
            // 
            this.id_catcher_txt.Location = new System.Drawing.Point(26, 784);
            this.id_catcher_txt.Name = "id_catcher_txt";
            this.id_catcher_txt.Size = new System.Drawing.Size(151, 27);
            this.id_catcher_txt.TabIndex = 10;
            // 
            // tables_names_cb
            // 
            this.tables_names_cb.FormattingEnabled = true;
            this.tables_names_cb.Location = new System.Drawing.Point(26, 736);
            this.tables_names_cb.Name = "tables_names_cb";
            this.tables_names_cb.Size = new System.Drawing.Size(151, 28);
            this.tables_names_cb.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 839);
            this.Controls.Add(this.tables_names_cb);
            this.Controls.Add(this.id_catcher_txt);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.TextBox id_catcher_txt;
        private System.Windows.Forms.ComboBox tables_names_cb;
    }
}
