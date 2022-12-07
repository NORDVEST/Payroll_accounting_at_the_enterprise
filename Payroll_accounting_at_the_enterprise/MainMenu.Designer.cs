namespace Payroll_accounting_at_the_enterprise
{
    partial class MainMenu
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
            this.buttonTableMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTableMenu
            // 
            this.buttonTableMenu.Location = new System.Drawing.Point(383, 168);
            this.buttonTableMenu.Name = "buttonTableMenu";
            this.buttonTableMenu.Size = new System.Drawing.Size(196, 38);
            this.buttonTableMenu.TabIndex = 0;
            this.buttonTableMenu.Text = "Работа с таблицами";
            this.buttonTableMenu.UseVisualStyleBackColor = true;
            this.buttonTableMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Все отчеты";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonTableMenu);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTableMenu;
        private System.Windows.Forms.Button button2;
    }
}

