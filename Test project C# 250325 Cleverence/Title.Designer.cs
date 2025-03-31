namespace Test_project_C__250325_Cleverence
{
    partial class Title
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
            buttonTask1 = new Button();
            labelTitle = new Label();
            buttonTask2 = new Button();
            labelTask3 = new Label();
            SuspendLayout();
            // 
            // buttonTask1
            // 
            buttonTask1.BackColor = Color.White;
            buttonTask1.FlatStyle = FlatStyle.Flat;
            buttonTask1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTask1.Location = new Point(12, 62);
            buttonTask1.Name = "buttonTask1";
            buttonTask1.Size = new Size(262, 41);
            buttonTask1.TabIndex = 0;
            buttonTask1.Text = "Задание 1";
            buttonTask1.UseVisualStyleBackColor = false;
            buttonTask1.Click += buttonTask1_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(262, 50);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Выполнила: Поздышева М.А.\r\nТестовое задание на C#";
            // 
            // buttonTask2
            // 
            buttonTask2.BackColor = Color.White;
            buttonTask2.FlatStyle = FlatStyle.Flat;
            buttonTask2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTask2.Location = new Point(12, 109);
            buttonTask2.Name = "buttonTask2";
            buttonTask2.Size = new Size(262, 41);
            buttonTask2.TabIndex = 2;
            buttonTask2.Text = "Задание 2";
            buttonTask2.UseVisualStyleBackColor = false;
            buttonTask2.Click += buttonTask2_Click;
            // 
            // labelTask3
            // 
            labelTask3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTask3.Location = new Point(12, 153);
            labelTask3.Name = "labelTask3";
            labelTask3.Size = new Size(262, 55);
            labelTask3.TabIndex = 3;
            labelTask3.Text = "Задание 3 - консольная программа внутри решения";
            // 
            // Title
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 209);
            Controls.Add(labelTask3);
            Controls.Add(buttonTask2);
            Controls.Add(labelTitle);
            Controls.Add(buttonTask1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Title";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Title";
            Load += Title_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTask1;
        private Label labelTitle;
        private Button buttonTask2;
        private Label labelTask3;
    }
}