
namespace BankingSite.Models
{
    public class CreditHistoryChecker : ICreditHistoryChecker
    {
        public bool CheckCreditHistory(string firstName, string lastName)
        {
            // Simulating actual credit check    
            // Somebody please implement actual credit check
            if (firstName.ToUpperInvariant() == "SARAH" 
                && lastName.ToUpperInvariant() == "SMITH")
            {
                return false;
            }

           return true;
        }
    }
}