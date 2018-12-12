namespace Lab07
{
    partial class MainForm
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tby = new System.Windows.Forms.TextBox();
            this.Tbx1 = new System.Windows.Forms.TextBox();
            this.Tbx2 = new System.Windows.Forms.TextBox();
            this.Tbx3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(101, 408);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(124, 45);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Вычислить";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(366, 408);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(124, 45);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Очистить";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(634, 408);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(124, 45);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "Выход";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "х1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "х2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат";
            // 
            // tby
            // 
            this.tby.Location = new System.Drawing.Point(386, 178);
            this.tby.Name = "tby";
            this.tby.ReadOnly = true;
            this.tby.Size = new System.Drawing.Size(150, 22);
            this.tby.TabIndex = 8;
            // 
            // Tbx1
            // 
            this.Tbx1.Location = new System.Drawing.Point(386, 84);
            this.Tbx1.Name = "Tbx1";
            this.Tbx1.Size = new System.Drawing.Size(150, 22);
            this.Tbx1.TabIndex = 9;
            this.Tbx1.TextChanged += new System.EventHandler(this.Tbx1_TextChanged);
            // 
            // Tbx2
            // 
            this.Tbx2.Location = new System.Drawing.Point(386, 129);
            this.Tbx2.Name = "Tbx2";
            this.Tbx2.Size = new System.Drawing.Size(150, 22);
            this.Tbx2.TabIndex = 10;
            this.Tbx2.TextChanged += new System.EventHandler(this.Tbx2_TextChanged);
            // 
            // Tbx3
            // 
            this.Tbx3.Location = new System.Drawing.Point(386, 226);
            this.Tbx3.Name = "Tbx3";
            this.Tbx3.ReadOnly = true;
            this.Tbx3.Size = new System.Drawing.Size(150, 22);
            this.Tbx3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Среднее арифметическое";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tbx3);
            this.Controls.Add(this.Tbx2);
            this.Controls.Add(this.Tbx1);
            this.Controls.Add(this.tby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tby;
        private System.Windows.Forms.TextBox Tbx1;
        private System.Windows.Forms.TextBox Tbx2;
        private System.Windows.Forms.TextBox Tbx3;
        private System.Windows.Forms.Label label4;
    }
}

