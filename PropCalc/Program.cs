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

        public static double[] Calculate(double avSumForRep, double sizeOfDem, double sumOfDemReg)
        {
                double[] values = new double[2];
                double sum = (avSumForRep * sizeOfDem) / sumOfDemReg;
                double percents = 100 / (sizeOfDem / sum);
                values[0] = sum;
                values[1] = percents;
                return values;  
        }       
    }
}