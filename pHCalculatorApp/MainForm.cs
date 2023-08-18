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
                    resultMessage += " (�ͧ��ҧ)";
                }
                else if (pH < 7)
                {
                    resultMessage += " (�ô)";
                }
                else
                {
                    resultMessage += " (��ҧ)";
                }

                ResultLabel.Text = resultMessage;
            }
            catch (FormatException)
            {
                ResultLabel.Text = "�ô��͹��Ҥ�������鹷��١��ͧ";
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