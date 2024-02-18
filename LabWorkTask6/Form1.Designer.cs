namespace LabWorkTask6
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
            label1 = new Label();
            startNumeric = new NumericUpDown();
            endNumeric = new NumericUpDown();
            label2 = new Label();
            startButton = new Button();
            resultListBox = new ListBox();
            streamsNumeric = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)startNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)streamsNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите начало диапазона:";
            // 
            // startNumeric
            // 
            startNumeric.Location = new Point(12, 32);
            startNumeric.Name = "startNumeric";
            startNumeric.Size = new Size(225, 27);
            startNumeric.TabIndex = 1;
            // 
            // endNumeric
            // 
            endNumeric.Location = new Point(12, 97);
            endNumeric.Name = "endNumeric";
            endNumeric.Size = new Size(225, 27);
            endNumeric.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите конец диапазона:";
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 220);
            startButton.Name = "startButton";
            startButton.Size = new Size(225, 56);
            startButton.TabIndex = 4;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // resultListBox
            // 
            resultListBox.FormattingEnabled = true;
            resultListBox.Location = new Point(255, 12);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(231, 264);
            resultListBox.TabIndex = 5;
            // 
            // streamsNumeric
            // 
            streamsNumeric.Location = new Point(12, 169);
            streamsNumeric.Name = "streamsNumeric";
            streamsNumeric.Size = new Size(225, 27);
            streamsNumeric.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(225, 20);
            label3.TabIndex = 6;
            label3.Text = "Введите количество потоков:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 298);
            Controls.Add(streamsNumeric);
            Controls.Add(label3);
            Controls.Add(resultListBox);
            Controls.Add(startButton);
            Controls.Add(endNumeric);
            Controls.Add(label2);
            Controls.Add(startNumeric);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)startNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)endNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)streamsNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown startNumeric;
        private NumericUpDown endNumeric;
        private Label label2;
        private Button startButton;
        private ListBox resultListBox;
        private NumericUpDown streamsNumeric;
        private Label label3;
    }
}
