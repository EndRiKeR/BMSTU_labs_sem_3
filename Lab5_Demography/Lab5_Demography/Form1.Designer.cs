namespace Lab5_Demography
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadAges_btn = new System.Windows.Forms.Button();
            this.LoadDeath_btn = new System.Windows.Forms.Button();
            this.start_age_txt = new System.Windows.Forms.TextBox();
            this.end_age_txt = new System.Windows.Forms.TextBox();
            this.start_age_lbl = new System.Windows.Forms.Label();
            this.end_age_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadAges_btn
            // 
            this.LoadAges_btn.Location = new System.Drawing.Point(42, 146);
            this.LoadAges_btn.Name = "LoadAges_btn";
            this.LoadAges_btn.Size = new System.Drawing.Size(122, 96);
            this.LoadAges_btn.TabIndex = 0;
            this.LoadAges_btn.Text = "LoadInitialAges";
            this.LoadAges_btn.UseVisualStyleBackColor = true;
            this.LoadAges_btn.Click += new System.EventHandler(this.LoadAges_btn_Click);
            // 
            // LoadDeath_btn
            // 
            this.LoadDeath_btn.Location = new System.Drawing.Point(42, 262);
            this.LoadDeath_btn.Name = "LoadDeath_btn";
            this.LoadDeath_btn.Size = new System.Drawing.Size(122, 96);
            this.LoadDeath_btn.TabIndex = 1;
            this.LoadDeath_btn.Text = "LoadDeathRule";
            this.LoadDeath_btn.UseVisualStyleBackColor = true;
            this.LoadDeath_btn.Click += new System.EventHandler(this.LoadDeath_btn_Click);
            // 
            // start_age_txt
            // 
            this.start_age_txt.Location = new System.Drawing.Point(100, 34);
            this.start_age_txt.Name = "start_age_txt";
            this.start_age_txt.Size = new System.Drawing.Size(100, 20);
            this.start_age_txt.TabIndex = 2;
            // 
            // end_age_txt
            // 
            this.end_age_txt.Location = new System.Drawing.Point(100, 93);
            this.end_age_txt.Name = "end_age_txt";
            this.end_age_txt.Size = new System.Drawing.Size(100, 20);
            this.end_age_txt.TabIndex = 3;
            // 
            // start_age_lbl
            // 
            this.start_age_lbl.AutoSize = true;
            this.start_age_lbl.Location = new System.Drawing.Point(39, 37);
            this.start_age_lbl.Name = "start_age_lbl";
            this.start_age_lbl.Size = new System.Drawing.Size(48, 13);
            this.start_age_lbl.TabIndex = 4;
            this.start_age_lbl.Text = "StartAge";
            // 
            // end_age_lbl
            // 
            this.end_age_lbl.AutoSize = true;
            this.end_age_lbl.Location = new System.Drawing.Point(39, 96);
            this.end_age_lbl.Name = "end_age_lbl";
            this.end_age_lbl.Size = new System.Drawing.Size(45, 13);
            this.end_age_lbl.TabIndex = 5;
            this.end_age_lbl.Text = "EndAge";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(42, 381);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(122, 39);
            this.start_btn.TabIndex = 6;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.end_age_lbl);
            this.Controls.Add(this.start_age_lbl);
            this.Controls.Add(this.end_age_txt);
            this.Controls.Add(this.start_age_txt);
            this.Controls.Add(this.LoadDeath_btn);
            this.Controls.Add(this.LoadAges_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadAges_btn;
        private System.Windows.Forms.Button LoadDeath_btn;
        private System.Windows.Forms.TextBox start_age_txt;
        private System.Windows.Forms.TextBox end_age_txt;
        private System.Windows.Forms.Label start_age_lbl;
        private System.Windows.Forms.Label end_age_lbl;
        private System.Windows.Forms.Button start_btn;
    }
}

