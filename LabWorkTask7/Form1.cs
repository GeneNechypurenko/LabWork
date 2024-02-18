namespace LabWorkTask7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            ApplicationRun.RunTask(outputMaxTextBox, outputMinTextBox, outputAvgTextBox, fileOutputTextBox);
        }
    }
}
