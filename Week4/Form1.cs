namespace Week4
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
           
            // Increase counter by 1
            counter++;
            // Display updated counter value
            lblCounterValue.Text = counter.ToString();
        }
    }
}
