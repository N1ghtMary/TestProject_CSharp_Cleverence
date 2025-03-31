namespace Test_project_C__250325_Cleverence
{
    partial class Task2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task2));
            labelTask2 = new Label();
            labelCurrentText = new Label();
            labelCount = new Label();
            buttonReadCount = new Button();
            buttonWriteCount = new Button();
            numericUpDownWrite = new NumericUpDown();
            labelWriteText = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWrite).BeginInit();
            SuspendLayout();
            // 
            // labelTask2
            // 
            labelTask2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTask2.Location = new Point(12, 9);
            labelTask2.Name = "labelTask2";
            labelTask2.Size = new Size(682, 153);
            labelTask2.TabIndex = 0;
            labelTask2.Text = resources.GetString("labelTask2.Text");
            // 
            // labelCurrentText
            // 
            labelCurrentText.AutoSize = true;
            labelCurrentText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrentText.Location = new Point(359, 176);
            labelCurrentText.Name = "labelCurrentText";
            labelCurrentText.Size = new Size(230, 25);
            labelCurrentText.TabIndex = 1;
            labelCurrentText.Text = "Текущее значение count:";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCount.Location = new Point(595, 176);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(22, 25);
            labelCount.TabIndex = 2;
            labelCount.Text = "0";
            // 
            // buttonReadCount
            // 
            buttonReadCount.BackColor = Color.LightSteelBlue;
            buttonReadCount.FlatStyle = FlatStyle.Flat;
            buttonReadCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReadCount.Location = new Point(12, 165);
            buttonReadCount.Name = "buttonReadCount";
            buttonReadCount.Size = new Size(335, 50);
            buttonReadCount.TabIndex = 3;
            buttonReadCount.Text = "Прочитать";
            buttonReadCount.UseVisualStyleBackColor = false;
            buttonReadCount.Click += buttonReadCount_Click;
            // 
            // buttonWriteCount
            // 
            buttonWriteCount.BackColor = Color.LightBlue;
            buttonWriteCount.FlatStyle = FlatStyle.Flat;
            buttonWriteCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWriteCount.Location = new Point(12, 221);
            buttonWriteCount.Name = "buttonWriteCount";
            buttonWriteCount.Size = new Size(335, 50);
            buttonWriteCount.TabIndex = 4;
            buttonWriteCount.Text = "Записать";
            buttonWriteCount.UseVisualStyleBackColor = false;
            buttonWriteCount.Click += buttonWriteCount_Click;
            // 
            // numericUpDownWrite
            // 
            numericUpDownWrite.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownWrite.Location = new Point(615, 230);
            numericUpDownWrite.Name = "numericUpDownWrite";
            numericUpDownWrite.Size = new Size(79, 33);
            numericUpDownWrite.TabIndex = 5;
            // 
            // labelWriteText
            // 
            labelWriteText.AutoSize = true;
            labelWriteText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWriteText.Location = new Point(359, 232);
            labelWriteText.Name = "labelWriteText";
            labelWriteText.Size = new Size(250, 25);
            labelWriteText.TabIndex = 6;
            labelWriteText.Text = "Записать значение в count:";
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 278);
            Controls.Add(labelWriteText);
            Controls.Add(numericUpDownWrite);
            Controls.Add(buttonWriteCount);
            Controls.Add(buttonReadCount);
            Controls.Add(labelCount);
            Controls.Add(labelCurrentText);
            Controls.Add(labelTask2);
            Name = "Task2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task2";
            Load += Task2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownWrite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTask2;
        private Label labelCurrentText;
        private Label labelCount;
        private Button buttonReadCount;
        private Button buttonWriteCount;
        private NumericUpDown numericUpDownWrite;
        private Label labelWriteText;
    }
}