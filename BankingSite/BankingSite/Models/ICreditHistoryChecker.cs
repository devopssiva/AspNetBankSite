namespace BankingSite.Models
{
    public interface ICreditHistoryChecker
    {
        bool CheckCreditHistory(string firstName, string lastName);
    }
}

//ban 28