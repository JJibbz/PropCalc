using System.Globalization;
namespace PropCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SumOfDemandsRegistryChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                repaimentForDemand.Text = $"Сумма выплат конкретному кредитору ={double.Round(Program.Calculate(double.Parse(availableSumForRegistryRepaiment.Text,CultureInfo.InvariantCulture), double.Parse(sizeOfDemand.Text, CultureInfo.InvariantCulture), double.Parse(sumOfDemandsRegistry.Text, CultureInfo.InvariantCulture))[0], 2)}" +
                    $" - {double.Round(Program.Calculate(double.Parse(availableSumForRegistryRepaiment.Text, CultureInfo.InvariantCulture), double.Parse(sizeOfDemand.Text, CultureInfo.InvariantCulture), double.Parse(sumOfDemandsRegistry.Text, CultureInfo.InvariantCulture))[1], 2)} %";
            }
            catch (Exception)
            {
                MessageBox.Show("Перепроверьте заполненные данные! Суммы указываются без пробелов!");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
