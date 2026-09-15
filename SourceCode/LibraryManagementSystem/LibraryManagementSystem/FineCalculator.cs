namespace LibraryManagementSystem
{
    public class FineCalculator : IFineCalculator
    {
        public double CalculateFine(int lateDays)
        {
            return lateDays * 10;
        }
    }
}