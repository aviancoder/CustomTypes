using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace Infor.CustomTypes.Utilities
{
    public class CustomTypesManager
    {
        private static string ASSEMBLY_NAMESPACE = @"Infor.CustomTypes";

        public List<Type> GetAllTypes()
        {
            List<Type> typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), ASSEMBLY_NAMESPACE);
            return typelist;
        }
        static List<Type> GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToList();
        }
    }
}
