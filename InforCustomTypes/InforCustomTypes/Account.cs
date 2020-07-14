using Infor.CustomTypes.Abstracts;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Infor.CustomTypes
{
    public class Account : CustomTypeValidations
    {
       
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        

        public Account(){}

        public Account(int _accountID, string _accountName)
        {
            this.AccountID = _accountID;
            this.AccountName = _accountName;
        }

        
    }
}
