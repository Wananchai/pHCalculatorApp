namespace pHCalculatorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double molarity = double.Parse(MolarityTextBox.Text);
                double pH = -Math.Log10(molarity);
                pH = Math.Round(pH, 2);

                string resultMessage = $"pH Value: {pH}";

                if (pH > 7)
                {
                    resultMessage += " (ของด่าง)";
                }
                else if (pH < 7)
                {
                    resultMessage += " (กรด)";
                }
                else
                {
                    resultMessage += " (กลาง)";
                }

                ResultLabel.Text = resultMessage;
            }
            catch (FormatException)
            {
                ResultLabel.Text = "โปรดป้อนค่าความเข้มข้นที่ถูกต้อง";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 25);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}