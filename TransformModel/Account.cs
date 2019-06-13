using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Transform;

namespace TransformModel
{
    public class Account
    {
        public string accountCode;
        public string name;
        public AccountType type;
        public DateTime openDate;
        public Currency currency;

        //transform account data to formatted string
        public string GetString()
        {
            string accountData = string.Empty;
            //transform account data to formatted string
            return accountData;
        }
    }
}
