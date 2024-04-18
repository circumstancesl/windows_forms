namespace WindowsFormsLab
{
    partial class View
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
            this.path1 = new System.Windows.Forms.Label();
            this.path2 = new System.Windows.Forms.Label();
            this.pathDirectory1 = new System.Windows.Forms.TextBox();
            this.pathDirectory2 = new System.Windows.Forms.TextBox();
            this.cynchronizeButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // path1
            // 
            this.path1.AutoSize = true;
            this.path1.Location = new System.Drawing.Point(12, 24);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(147, 13);
            this.path1.TabIndex = 0;
            this.path1.Text = "Путь до первой директории";
            // 
            // path2
            // 
            this.path2.AutoSize = true;
            this.path2.Location = new System.Drawing.Point(13, 62);
            this.path2.Name = "path2";
            this.path2.Size = new System.Drawing.Size(146, 13);
            this.path2.TabIndex = 1;
            this.path2.Text = "Путь до второй директории";
            // 
            // pathDirectory1
            // 
            this.pathDirectory1.Location = new System.Drawing.Point(197, 21);
            this.pathDirectory1.Name = "pathDirectory1";
            this.pathDirectory1.Size = new System.Drawing.Size(464, 20);
            this.pathDirectory1.TabIndex = 2;
            // 
            // pathDirectory2
            // 
            this.pathDirectory2.Location = new System.Drawing.Point(197, 59);
            this.pathDirectory2.Name = "pathDirectory2";
            this.pathDirectory2.Size = new System.Drawing.Size(464, 20);
            this.pathDirectory2.TabIndex = 3;
            // 
            // cynchronizeButton
            // 
            this.cynchronizeButton.Location = new System.Drawing.Point(16, 105);
            this.cynchronizeButton.Name = "cynchronizeButton";
            this.cynchronizeButton.Size = new System.Drawing.Size(151, 23);
            this.cynchronizeButton.TabIndex = 4;
            this.cynchronizeButton.Text = "Синхронизировать";
            this.cynchronizeButton.UseVisualStyleBackColor = true;
            this.cynchronizeButton.Click += new System.EventHandler(this.cynchronizeButton_Click);
            // 
            // result
            // 
            this.result.FormattingEnabled = true;
            this.result.Location = new System.Drawing.Point(16, 163);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(645, 160);
            this.result.TabIndex = 5;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 361);
            this.Controls.Add(this.result);
            this.Controls.Add(this.cynchronizeButton);
            this.Controls.Add(this.pathDirectory2);
            this.Controls.Add(this.pathDirectory1);
            this.Controls.Add(this.path2);
            this.Controls.Add(this.path1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "View";
            this.Text = "WindowsFormsLab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label path1;
        private System.Windows.Forms.Label path2;
        private System.Windows.Forms.TextBox pathDirectory1;
        private System.Windows.Forms.TextBox pathDirectory2;
        private System.Windows.Forms.Button cynchronizeButton;
        private System.Windows.Forms.ListBox result;
    }
}

