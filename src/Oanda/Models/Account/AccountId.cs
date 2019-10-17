using System;

namespace Oanda.Models.Account
{
    public class AccountId
    {
        public int SiteId;

        public int DivisionId;

        public int UserId;

        public int AccountNumber;

        public AccountId(string accountId)
        {
            var accountParameters = accountId.Split("-");

            SiteId = Convert.ToInt32(accountParameters[0]);
            DivisionId = Convert.ToInt32(accountParameters[1]);
            UserId = Convert.ToInt32(accountParameters[2]);
            AccountNumber = Convert.ToInt32(accountParameters[3]);
        }

        public override string ToString() => $"{SiteId}-{DivisionId}-{UserId}-{AccountNumber}";
    }
}
