namespace TimeConversionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbUserInput_TextChanged(object sender, EventArgs e)
        {
            int Seconds = int.Parse(tbUserInput.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbOutput.Text = "";
        }

        private void btnConvert_Click_1(object sender, EventArgs e)
        {
            int seconds = int.Parse(tbUserInput.Text);

            if (seconds >= 86400) // Greater than or equal to 24 hours
            {
                int days = seconds / 86400;
                lbOutput.Text = $"{days} day(s)";
            }
            else if (seconds >= 3600) // Greater than or equal to 1 hour
            {
                int hours = seconds / 3600;
                lbOutput.Text = $"{hours} hour(s)";
            }
            else if (seconds >= 60) // Greater than or equal to 1 minute
            {
                int minutes = seconds / 60;
                lbOutput.Text = $"{minutes} minute(s)";
            }
            else
            {
                lbOutput.Text = "Less than 1 minute";
            }

        }

    }
}