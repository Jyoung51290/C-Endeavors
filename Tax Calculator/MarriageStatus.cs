namespace Tax_Calculator
{
    internal class MarriageStatus
    {
        public MarriageStatus()
        { }
        public void AskMarriageStatus()
        {
            string MarriageStatus;
            Console.Write("Are you 1.Single or 2.Married? Please enter either '1' or '2'.");
            MarriageStatus = Console.ReadLine();

            switch (MarriageStatus)
            {
                case "1":
                    Console.WriteLine("You are single.");
                    break;
                case "2":
                    Console.WriteLine("You are married.");
                    break;
            }
            
        }
    }
}
