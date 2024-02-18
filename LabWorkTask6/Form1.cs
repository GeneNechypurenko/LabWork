using LabWork;

namespace LabWorkTask6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            int start = int.Parse(startNumeric.Value.ToString());
            int end = int.Parse(endNumeric.Value.ToString());
            int threadCount = int.Parse(streamsNumeric.Value.ToString());

            ApplicationRun.RunTask(start, end, threadCount, resultListBox);
        }
    }
}
