namespace PractWork6
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
            this.chipherFileButton = new System.Windows.Forms.Button();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chipherFileButton
            // 
            this.chipherFileButton.Location = new System.Drawing.Point(314, 126);
            this.chipherFileButton.Name = "chipherFileButton";
            this.chipherFileButton.Size = new System.Drawing.Size(93, 23);
            this.chipherFileButton.TabIndex = 0;
            this.chipherFileButton.Text = "Зашифровать";
            this.chipherFileButton.UseVisualStyleBackColor = true;
            this.chipherFileButton.Click += new System.EventHandler(this.chipherFileButton_Click);
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(12, 126);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(75, 23);
            this.openFileDialogButton.TabIndex = 1;
            this.openFileDialogButton.Text = "Выбрать";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // openFileDialog1
            // 
            this.folderBrowserDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Переменные";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(153, 126);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 4;
            this.generate.Text = "Генерация";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(444, 161);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFileDialogButton);
            this.Controls.Add(this.chipherFileButton);
            this.MaximumSize = new System.Drawing.Size(460, 200);
            this.MinimumSize = new System.Drawing.Size(460, 200);
            this.Name = "MainForm";
            this.Text = "PractWork6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chipherFileButton;
        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.OpenFileDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generate;
    }
}

