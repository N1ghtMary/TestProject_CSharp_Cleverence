namespace Test_project_C__250325_Cleverence
{
    partial class Task1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task1));
            labelTask1Text = new Label();
            textBoxInput = new TextBox();
            buttonCompress = new Button();
            buttonDecompress = new Button();
            buttonClear = new Button();
            labelResult = new Label();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // labelTask1Text
            // 
            labelTask1Text.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTask1Text.Location = new Point(12, 9);
            labelTask1Text.Name = "labelTask1Text";
            labelTask1Text.Size = new Size(678, 105);
            labelTask1Text.TabIndex = 0;
            labelTask1Text.Text = resources.GetString("labelTask1Text.Text");
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInput.Location = new Point(12, 117);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "Введите строку для обработки";
            textBoxInput.Size = new Size(678, 33);
            textBoxInput.TabIndex = 1;
            // 
            // buttonCompress
            // 
            buttonCompress.BackColor = Color.LightSteelBlue;
            buttonCompress.FlatStyle = FlatStyle.Flat;
            buttonCompress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCompress.Location = new Point(12, 221);
            buttonCompress.Name = "buttonCompress";
            buttonCompress.Size = new Size(222, 50);
            buttonCompress.TabIndex = 2;
            buttonCompress.Text = "Компрессировать";
            buttonCompress.UseVisualStyleBackColor = false;
            buttonCompress.Click += buttonCompress_Click;
            // 
            // buttonDecompress
            // 
            buttonDecompress.BackColor = Color.LightBlue;
            buttonDecompress.FlatStyle = FlatStyle.Flat;
            buttonDecompress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecompress.Location = new Point(240, 221);
            buttonDecompress.Name = "buttonDecompress";
            buttonDecompress.Size = new Size(222, 50);
            buttonDecompress.TabIndex = 3;
            buttonDecompress.Text = "Декомпрессировать";
            buttonDecompress.UseVisualStyleBackColor = false;
            buttonDecompress.Click += buttonDecompress_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(255, 192, 192);
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(468, 221);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(222, 50);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.Location = new Point(12, 153);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(198, 25);
            labelResult.TabIndex = 5;
            labelResult.Text = "Результат обработки:";
            // 
            // textBoxResult
            // 
            textBoxResult.Enabled = false;
            textBoxResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResult.Location = new Point(12, 181);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.PlaceholderText = "Результат обработки";
            textBoxResult.Size = new Size(678, 33);
            textBoxResult.TabIndex = 6;
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 283);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(buttonClear);
            Controls.Add(buttonDecompress);
            Controls.Add(buttonCompress);
            Controls.Add(textBoxInput);
            Controls.Add(labelTask1Text);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Task1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTask1Text;
        private TextBox textBoxInput;
        private Button buttonCompress;
        private Button buttonDecompress;
        private Button buttonClear;
        private Label labelResult;
        private TextBox textBoxResult;
    }
}