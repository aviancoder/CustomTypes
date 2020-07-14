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


            var obj = Infor.CustomTypes.Utilities.CustomTypesCollection.GetCustomType("account");
            sBuilder.AppendLine(obj.ToString());

            Console.WriteLine(sBuilder.ToString());


        }


    }



}
