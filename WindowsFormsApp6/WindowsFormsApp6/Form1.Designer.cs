
namespace WindowsFormsApp6
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
            this.Form2 = new System.Windows.Forms.Button();
            this.Form3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.Form2.Location = new System.Drawing.Point(138, 136);
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(174, 72);
            this.Form2.TabIndex = 0;
            this.Form2.Text = "Окно1";
            this.Form2.UseVisualStyleBackColor = true;
            this.Form2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.Form3.Location = new System.Drawing.Point(440, 138);
            this.Form3.Name = "Form3";
            this.Form3.Size = new System.Drawing.Size(174, 70);
            this.Form3.TabIndex = 1;
            this.Form3.Text = "Окно2";
            this.Form3.UseVisualStyleBackColor = true;
            this.Form3.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Главное Окно";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Form3);
            this.Controls.Add(this.Form2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Form2;
        private System.Windows.Forms.Button Form3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

