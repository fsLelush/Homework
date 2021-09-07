namespace Homework
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
            this.A_L = new System.Windows.Forms.Label();
            this.A_TB = new System.Windows.Forms.TextBox();
            this.B_L = new System.Windows.Forms.Label();
            this.B_TB = new System.Windows.Forms.TextBox();
            this.Res_L = new System.Windows.Forms.Label();
            this.Res_TB = new System.Windows.Forms.TextBox();
            this.Calc_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A_L
            // 
            this.A_L.Location = new System.Drawing.Point(46, 68);
            this.A_L.Name = "A_L";
            this.A_L.Size = new System.Drawing.Size(57, 17);
            this.A_L.TabIndex = 0;
            this.A_L.Text = "Число &A";
            // 
            // A_TB
            // 
            this.A_TB.Location = new System.Drawing.Point(109, 67);
            this.A_TB.Name = "A_TB";
            this.A_TB.Size = new System.Drawing.Size(100, 20);
            this.A_TB.TabIndex = 1;
            // 
            // B_L
            // 
            this.B_L.AutoSize = true;
            this.B_L.Location = new System.Drawing.Point(46, 105);
            this.B_L.Name = "B_L";
            this.B_L.Size = new System.Drawing.Size(49, 13);
            this.B_L.TabIndex = 2;
            this.B_L.Text = "Число &B";
            // 
            // B_TB
            // 
            this.B_TB.Location = new System.Drawing.Point(109, 102);
            this.B_TB.Name = "B_TB";
            this.B_TB.Size = new System.Drawing.Size(100, 20);
            this.B_TB.TabIndex = 3;
            // 
            // Res_L
            // 
            this.Res_L.AutoSize = true;
            this.Res_L.Location = new System.Drawing.Point(46, 140);
            this.Res_L.Name = "Res_L";
            this.Res_L.Size = new System.Drawing.Size(59, 13);
            this.Res_L.TabIndex = 4;
            this.Res_L.Text = "&Pезультат";
            // 
            // Res_TB
            // 
            this.Res_TB.Location = new System.Drawing.Point(109, 137);
            this.Res_TB.Name = "Res_TB";
            this.Res_TB.ReadOnly = true;
            this.Res_TB.Size = new System.Drawing.Size(100, 20);
            this.Res_TB.TabIndex = 5;
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(303, 65);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(75, 23);
            this.Calc_B.TabIndex = 6;
            this.Calc_B.Text = "Рас&чёт";
            this.Calc_B.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 325);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Res_TB);
            this.Controls.Add(this.Res_L);
            this.Controls.Add(this.B_TB);
            this.Controls.Add(this.B_L);
            this.Controls.Add(this.A_TB);
            this.Controls.Add(this.A_L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label A_L;
        private System.Windows.Forms.TextBox A_TB;
        private System.Windows.Forms.Label B_L;
        private System.Windows.Forms.TextBox B_TB;
        private System.Windows.Forms.Label Res_L;
        private System.Windows.Forms.TextBox Res_TB;
        private System.Windows.Forms.Button Calc_B;
    }
}

