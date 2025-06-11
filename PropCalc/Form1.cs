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
                repaimentForDemand.Text = $"Сумма выплат конкретному кредитору ={double.Round(Program.Calculate(double.Parse(availableSumForRegistryRepaiment.Text), double.Parse(sizeOfDemand.Text), double.Parse(sumOfDemandsRegistry.Text))[0], 2)}" +
                    $" - {double.Round(Program.Calculate(double.Parse(availableSumForRegistryRepaiment.Text), double.Parse(sizeOfDemand.Text), double.Parse(sumOfDemandsRegistry.Text))[1], 2)} %";
            }
            catch (Exception)
            {
                MessageBox.Show("Перепроверьте заполненные данные! Дробная часть должна отделяться ЗАПЯТОЙ!!! В противном случае расчёты могут оказаться неверными!!!");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
