using System.Collections.Generic;
using System.Globalization;
namespace PropCalc
{
    public partial class Form1 : Form
    {
        public List<TextBox> Creditors = new List<TextBox>();
        public List<Label> Numbers = new List<Label>();
        public List<string> creditorStrings = new List<string>();
        public int numsCount = 2;
        public Form1()
        {
            InitializeComponent();
            Creditors.Add(sizeOfDemand);
            Numbers.Add(Number);
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
            availableSumForRegistryRepaiment.Text = Program.deDotification(availableSumForRegistryRepaiment.Text);
            sumOfDemandsRegistry.Text = Program.deDotification(sumOfDemandsRegistry.Text);
            for (int i = 0; i < Creditors.Count; i++)
            {
                Creditors[i].Text = Program.deDotification(Creditors[i].Text);
            }
            for(int i = 0; i < Creditors.Count; i++)
            {
                string x = null;
                creditorStrings.Add(x);
            }
            try
            {
                for (int i = 0; i < Creditors.Count; i++)
                {
                    creditorStrings[i] = $"Сумма выплат кредитору № {Numbers[i].Text} = " +
                        $"{decimal.Round(Program.Calculate
                        (decimal.Parse(availableSumForRegistryRepaiment.Text), decimal.Parse(Creditors[i].Text),
                        decimal.Parse(sumOfDemandsRegistry.Text))[0], 2)}" +
                        $" - {decimal.Round(Program.Calculate(decimal.Parse(availableSumForRegistryRepaiment.Text), decimal.Parse(Creditors[i].Text),
                        decimal.Parse(sumOfDemandsRegistry.Text))[1], 2)}%";
                    
                }
                for (int i = 0; i < Creditors.Count; i++)
                {
                    repaimentForDemand.Text += $"\n {creditorStrings[i]}";
                }
                
                   
            }
            catch (Exception)
            {
                MessageBox.Show("Перепроверьте заполненные данные! Суммы указываются без пробелов! Все имеющиеся ячейки должны быть заполнены!");
            }
        }

        private void addCreditor_click(object sender, EventArgs e)
        {
            if (Creditors.Count >= 10)
            {
                MessageBox.Show("Достигнуто предельное количество требований кредиторов");
            }
            else
            {
                TextBox newTextBox = new TextBox();
                Label newLabel = new Label();
                Label lastOldLabel = Numbers.LastOrDefault();
                TextBox lastOldTextBox = Creditors.LastOrDefault();
                newTextBox.Location = new Point(lastOldTextBox.Location.X, lastOldTextBox.Location.Y + 30);
                newLabel.Location = new Point(lastOldLabel.Location.X, lastOldLabel.Location.Y + 30);
                if (numsCount == 10)
                {
                    newLabel.Size = new Size(20, 15);
                }
                else
                {
                    newLabel.Size = new Size(13, 15);
                }
                newLabel.Text = numsCount.ToString();
                newTextBox.Size = new Size(154, 23);
                Creditors.Add(newTextBox);
                Numbers.Add(newLabel);
                this.Controls.Add(newLabel);
                ++numsCount;
                this.Controls.Add(newTextBox);
                    
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void repaimentForDemand_Click(object sender, EventArgs e)
        {

        }
    }
}
