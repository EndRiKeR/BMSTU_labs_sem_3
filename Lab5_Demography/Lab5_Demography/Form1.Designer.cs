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
            this.SuspendLayout();
            // 
            // LoadAges_btn
            // 
            this.LoadAges_btn.Location = new System.Drawing.Point(300, 242);
            this.LoadAges_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadAges_btn.Name = "LoadAges_btn";
            this.LoadAges_btn.Size = new System.Drawing.Size(163, 118);
            this.LoadAges_btn.TabIndex = 0;
            this.LoadAges_btn.Text = "LoadInitialAges";
            this.LoadAges_btn.UseVisualStyleBackColor = true;
            this.LoadAges_btn.Click += new System.EventHandler(this.LoadAges_btn_Click);
            // 
            // LoadDeath_btn
            // 
            this.LoadDeath_btn.Location = new System.Drawing.Point(544, 242);
            this.LoadDeath_btn.Margin = new System.Windows.Forms.Padding(4);
            this.LoadDeath_btn.Name = "LoadDeath_btn";
            this.LoadDeath_btn.Size = new System.Drawing.Size(163, 118);
            this.LoadDeath_btn.TabIndex = 1;
            this.LoadDeath_btn.Text = "LoadDeathRule";
            this.LoadDeath_btn.UseVisualStyleBackColor = true;
            this.LoadDeath_btn.Click += new System.EventHandler(this.LoadDeath_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LoadDeath_btn);
            this.Controls.Add(this.LoadAges_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadAges_btn;
        private System.Windows.Forms.Button LoadDeath_btn;
    }
}

