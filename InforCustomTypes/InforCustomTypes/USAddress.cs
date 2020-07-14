using Infor.CustomTypes.Abstracts;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Infor.CustomTypes
{
    public class USAddress : CustomTypeValidations
    {
       
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string USCity { get; set; }
        public string USState { get; set; }
        public string USZipCode { get; set; }

        

        public USAddress(){}

        public USAddress(string _addressLine1, string _addressLine2, string _usCity, string _usState, string _usZipCode)
        {
            this.AddressLine1 = _addressLine1;
            this.AddressLine2 = _addressLine2;
            this.USCity = _usCity;
            this.USState = _usState;
            this.USZipCode = _usZipCode;

        }

        
    }
}
