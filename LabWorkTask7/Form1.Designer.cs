namespace LabWorkTask7
{
    partial class Form1
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
            label3 = new Label();
            startButton = new Button();
            label2 = new Label();
            label1 = new Label();
            outputMaxTextBox = new TextBox();
            outputMinTextBox = new TextBox();
            outputAvgTextBox = new TextBox();
            fileOutputTextBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 14;
            label3.Text = "Среднее:";
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 211);
            startButton.Name = "startButton";
            startButton.Size = new Size(225, 65);
            startButton.TabIndex = 12;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 10;
            label2.Text = "Минимум:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 8;
            label1.Text = "Максимум:";
            // 
            // outputMaxTextBox
            // 
            outputMaxTextBox.Location = new Point(12, 32);
            outputMaxTextBox.Name = "outputMaxTextBox";
            outputMaxTextBox.ReadOnly = true;
            outputMaxTextBox.Size = new Size(225, 27);
            outputMaxTextBox.TabIndex = 16;
            // 
            // outputMinTextBox
            // 
            outputMinTextBox.Location = new Point(12, 97);
            outputMinTextBox.Name = "outputMinTextBox";
            outputMinTextBox.ReadOnly = true;
            outputMinTextBox.Size = new Size(225, 27);
            outputMinTextBox.TabIndex = 17;
            // 
            // outputAvgTextBox
            // 
            outputAvgTextBox.Location = new Point(12, 161);
            outputAvgTextBox.Name = "outputAvgTextBox";
            outputAvgTextBox.ReadOnly = true;
            outputAvgTextBox.Size = new Size(225, 27);
            outputAvgTextBox.TabIndex = 18;
            // 
            // fileOutputTextBox
            // 
            fileOutputTextBox.Location = new Point(258, 32);
            fileOutputTextBox.Multiline = true;
            fileOutputTextBox.Name = "fileOutputTextBox";
            fileOutputTextBox.ReadOnly = true;
            fileOutputTextBox.ScrollBars = ScrollBars.Vertical;
            fileOutputTextBox.Size = new Size(226, 244);
            fileOutputTextBox.TabIndex = 19;
            fileOutputTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 9);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 20;
            label4.Text = "Содержимое файла:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 287);
            Controls.Add(label4);
            Controls.Add(fileOutputTextBox);
            Controls.Add(outputAvgTextBox);
            Controls.Add(outputMinTextBox);
            Controls.Add(outputMaxTextBox);
            Controls.Add(label3);
            Controls.Add(startButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button startButton;
        private Label label2;
        private Label label1;
        private TextBox outputMaxTextBox;
        private TextBox outputMinTextBox;
        private TextBox outputAvgTextBox;
        private TextBox fileOutputTextBox;
        private Label label4;
    }
}
