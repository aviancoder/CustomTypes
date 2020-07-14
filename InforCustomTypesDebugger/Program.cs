using System;
using System.Reflection.Emit;
using System.Text;
using System.Reflection;
using System.Linq;
using Infor.CustomTypes.Utilities;
using Infor.CustomTypes;
using System.Xml.Linq;
using System.IO;
using System.Xml.Schema;
using System.Collections.Generic;

namespace InforCustomTypesDebugger
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sBuilder = new StringBuilder();

            // getting an existing type with alias "Account"
            var objAccount = Infor.CustomTypes.Utilities.CustomTypesCollection.GetCustomType("account");
            sBuilder.AppendLine("Return for using the \"Account\" alias : " + objAccount.ToString());

            // getting an existing type with alias "Address"
            var objAddress = Infor.CustomTypes.Utilities.CustomTypesCollection.GetCustomType("address");
            sBuilder.AppendLine("Return for using the \"Address\" alias : " + objAddress.ToString());

            // getting an non existing type
            var objNotFound = Infor.CustomTypes.Utilities.CustomTypesCollection.GetCustomType("notfound");
            sBuilder.AppendLine("Return for using the \"NotFound\" alias : " + objNotFound.ToString());

            Console.WriteLine(sBuilder.ToString());

        }


    }



}
