namespace PropCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sumOfDemandsRegistry = new TextBox();
            label1 = new Label();
            label2 = new Label();
            availableSumForRegistryRepaiment = new TextBox();
            sizeOfDemand = new TextBox();
            label3 = new Label();
            repaimentForDemand = new Label();
            Calculate = new Button();
            richTextBox1 = new RichTextBox();
            addCredittorButton = new Button();
            Number = new Label();
            SuspendLayout();
            // 
            // sumOfDemandsRegistry
            // 
            sumOfDemandsRegistry.HideSelection = false;
            sumOfDemandsRegistry.Location = new Point(292, 26);
            sumOfDemandsRegistry.Name = "sumOfDemandsRegistry";
            sumOfDemandsRegistry.Size = new Size(154, 23);
            sumOfDemandsRegistry.TabIndex = 0;
            sumOfDemandsRegistry.TextChanged += SumOfDemandsRegistryChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(246, 15);
            label1.TabIndex = 1;
            label1.Text = "Общая сумма всех требований кредиторов";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 59);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 2;
            label2.Text = "Требования кредиторов";
            label2.Click += label2_Click;
            // 
            // availableSumForRegistryRepaiment
            // 
            availableSumForRegistryRepaiment.Location = new Point(705, 171);
            availableSumForRegistryRepaiment.Name = "availableSumForRegistryRepaiment";
            availableSumForRegistryRepaiment.Size = new Size(144, 23);
            availableSumForRegistryRepaiment.TabIndex = 5;
            // 
            // sizeOfDemand
            // 
            sizeOfDemand.Location = new Point(66, 76);
            sizeOfDemand.Name = "sizeOfDemand";
            sizeOfDemand.Size = new Size(154, 23);
            sizeOfDemand.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(500, 153);
            label3.Name = "label3";
            label3.Size = new Size(353, 15);
            label3.TabIndex = 4;
            label3.Text = "Доступная сумма для удовлетворения требований кредиторов";
            // 
            // repaimentForDemand
            // 
            repaimentForDemand.AutoSize = true;
            repaimentForDemand.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            repaimentForDemand.Location = new Point(12, 381);
            repaimentForDemand.Name = "repaimentForDemand";
            repaimentForDemand.Size = new Size(237, 21);
            repaimentForDemand.TabIndex = 6;
            repaimentForDemand.Text = "Сумма выплат кредиторам ";
            repaimentForDemand.UseMnemonic = false;
            repaimentForDemand.Click += repaimentForDemand_Click;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(500, 171);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(144, 37);
            Calculate.TabIndex = 7;
            Calculate.Text = "Рассчитать";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(500, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(358, 133);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // addCredittorButton
            // 
            addCredittorButton.Location = new Point(226, 76);
            addCredittorButton.Name = "addCredittorButton";
            addCredittorButton.Size = new Size(27, 23);
            addCredittorButton.TabIndex = 9;
            addCredittorButton.Text = "+";
            addCredittorButton.UseVisualStyleBackColor = true;
            addCredittorButton.Click += addCreditor_click;
            // 
            // Number
            // 
            Number.AutoSize = true;
            Number.Location = new Point(34, 79);
            Number.Name = "Number";
            Number.Size = new Size(13, 15);
            Number.TabIndex = 10;
            Number.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 581);
            Controls.Add(Number);
            Controls.Add(addCredittorButton);
            Controls.Add(richTextBox1);
            Controls.Add(Calculate);
            Controls.Add(repaimentForDemand);
            Controls.Add(availableSumForRegistryRepaiment);
            Controls.Add(label3);
            Controls.Add(sizeOfDemand);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sumOfDemandsRegistry);
            Name = "Form1";
            Text = "Калькулятор пропорций";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox sumOfDemandsRegistry;
        public Label label1;
        public Label label2;
        public TextBox sizeOfDemand;
        public TextBox availableSumForRegistryRepaiment;
        public Label label3;
        public Label repaimentForDemand;
        public Button Calculate;
        public RichTextBox richTextBox1;
        private Button addCredittorButton;
        private Label Number;
    }
}
