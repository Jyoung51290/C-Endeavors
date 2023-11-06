using Microsoft.VisualBasic;

namespace TaxCalculator
{
    internal class program
    {
        int NumberofW2;
        double totalTaxableIncome;
        int filingStatusChoice;
        public program(int NumberofW2, int filingStatusChoice)
        {
            this.NumberofW2 = NumberofW2;
            this.filingStatusChoice = filingStatusChoice;
            totalTaxableIncome = 0;
        }
        public void Askprogram()
        {
            for (int i = 1; i <= NumberofW2; i++)
            {
                Console.Write($"Enter taxable income for W-2 form #{i}: $");
                double taxableIncome = Convert.ToDouble(Console.ReadLine());
                totalTaxableIncome += taxableIncome;
            }
            double taxAmount = CalculateTax(totalTaxableIncome, filingStatusChoice);

            Console.WriteLine($"Your estimated tax amount is: ${taxAmount}");

            Console.ReadLine();

            static double CalculateTax(double taxableIncome, int filingStatusChoice)
            {
                double taxAmount = 0;


                double[] singleIncomeBrackets = { 0, 910, 1900, 3760, 5700, 9000, 99999999 };
                double[] singleTaxRates = { 0.04, 0.0325, 0.0345, 0.0360, 0.0375, 0.0390, 0.0425 };

                double[] marriedIncomeBrackets = { 0, 1820, 3800, 7520, 11400, 18000, 99999999 };
                double[] marriedTaxRates = { 0.04, 0.0325, 0.0345, 0.0360, 0.0375, 0.0390, 0.0425 };


                double[] incomeBrackets = (filingStatusChoice == 1) ? singleIncomeBrackets : marriedIncomeBrackets;
                double[] taxRates = (filingStatusChoice == 1) ? singleTaxRates : marriedTaxRates;


                int bracketIndex = 0;
                while (taxableIncome > incomeBrackets[bracketIndex])
                {
                    bracketIndex++;
                }


                double lowerBound = incomeBrackets[bracketIndex - 1];
                double upperBound = incomeBrackets[bracketIndex];
                double rate = taxRates[bracketIndex - 1];
                taxAmount = (taxableIncome - lowerBound) * rate;

                return taxAmount;
            }
        }
    }
}