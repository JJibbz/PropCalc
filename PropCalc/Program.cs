namespace PropCalc
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static decimal[] Calculate(decimal avSumForRep, decimal sizeOfDem, decimal sumOfDemReg)
        {
                decimal[] values = new decimal[2];
                decimal sum = (avSumForRep * sizeOfDem) / sumOfDemReg;
                decimal percents = 100 / (sizeOfDem / sum);
                values[0] = sum;
                values[1] = percents;
                return values;  
        }

        public static string deDotification(string stringValueWithTheDot)
        {
            string result = stringValueWithTheDot.Replace('.', ',');
            return result;
        }
       
    }
}