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
            this.components = new System.ComponentModel.Container();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_btn = new System.Windows.Forms.Button();
            this.change_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.tables_names_cb = new System.Windows.Forms.ComboBox();
            this.contextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(DataBaseModels.Entity.Doctor);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(244, 286);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(250, 37);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.ButtonPressed);
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(244, 331);
            this.change_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(250, 37);
            this.change_btn.TabIndex = 2;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.ButtonPressed);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(244, 372);
            this.del_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(250, 37);
            this.del_btn.TabIndex = 3;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.ButtonPressed);
            // 
            // tables_names_cb
            // 
            this.tables_names_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "Doctors",
            "Certificates",
            "Specializations"});
            this.tables_names_cb.FormattingEnabled = true;
            this.tables_names_cb.Location = new System.Drawing.Point(49, 331);
            this.tables_names_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tables_names_cb.Name = "tables_names_cb";
            this.tables_names_cb.Size = new System.Drawing.Size(146, 23);
            this.tables_names_cb.TabIndex = 11;
            this.tables_names_cb.Text = "Doctor";
            this.tables_names_cb.SelectedIndexChanged += new System.EventHandler(this.tables_names_cb_SelectedIndexChanged);
            // 
            // contextBindingSource
            // 
            this.contextBindingSource.DataSource = typeof(DataBaseContext.Context);
            // 
            // specializationBindingSource
            // 
            this.specializationBindingSource.DataSource = typeof(DataBaseModels.Entity.Specialization);
            // 
            // certificateBindingSource
            // 
            this.certificateBindingSource.DataSource = typeof(DataBaseModels.Entity.Certificate);
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(12, 12);
            this.dataTable.MultiSelect = false;
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowTemplate.Height = 25;
            this.dataTable.Size = new System.Drawing.Size(482, 258);
            this.dataTable.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 425);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.tables_names_cb);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.add_btn);
            this.Name = "Form1";
            this.Text = "Lab6";
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ComboBox tables_names_cb;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource contextBindingSource;
        private System.Windows.Forms.BindingSource certificateBindingSource;
        private System.Windows.Forms.BindingSource specializationBindingSource;
        private System.Windows.Forms.DataGridView dataTable;
    }
}
