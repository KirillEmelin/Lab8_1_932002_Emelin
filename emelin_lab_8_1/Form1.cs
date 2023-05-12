namespace emelin_lab_8_1
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();
        private const double Threshold = 0.5;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();

            double value = _random.NextDouble();

            string result = value < Threshold ? "Yes!" : (value > Threshold ? "No" : "I do not know");

            textBox2.Text = result;
        }
    }
}
