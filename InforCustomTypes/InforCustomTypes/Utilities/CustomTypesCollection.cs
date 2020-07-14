using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Infor.CustomTypes.Utilities
{
    public static class CustomTypesCollection
    {
        private static Dictionary<string, Type> DICTIONARY_CUSTOMTYPES;
        private static string COMPONENTS_FILENAME = @"Components.xml";
        private static string COMPONENTS_NODE_NAME = @"Component";
        private static string COMPONENTS_ATTRIBUTE_ALIAS = @"alias";
        private static string COMPONENTS_ATTRIBUTE_TYPE = @"type";

        public static Type GetCustomType(string _key)
        {
            Type retval = typeof(object);

            // check if Dictionary is loaded with values
            
            if (DICTIONARY_CUSTOMTYPES == null)
                DICTIONARY_CUSTOMTYPES = new Dictionary<string, Type>();
            if (DICTIONARY_CUSTOMTYPES.Count <= 0)
            {
                // add values to list

                // get all available types on the namespace
                CustomTypesManager customTypesManager = new CustomTypesManager();
                List<Type> availableTypes = customTypesManager.GetAllTypes();

                // get the Components XML value
                var xmlString = File.ReadAllText(COMPONENTS_FILENAME);
                var str = XElement.Parse(xmlString);
                var result = str.Elements(COMPONENTS_NODE_NAME);
                foreach (XElement xElement in result)
                {

                    var attAlias = xElement.Attributes().Where(x => x.Name.LocalName.Equals(COMPONENTS_ATTRIBUTE_ALIAS, StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value;
                    var attType = xElement.Attributes().Where(x => x.Name.LocalName.Equals(COMPONENTS_ATTRIBUTE_TYPE, StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Value;


                    // match the type attribule value against full name of available type
                    Type type = availableTypes.Where(x => x.FullName.Equals(attType, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                    // add item to collection if found
                    if (type != null)
                    {
                        DICTIONARY_CUSTOMTYPES.Add(attAlias.ToUpper(), type);
                    }
                }
            }

            // return the value based on the list
            try
            {
                if (DICTIONARY_CUSTOMTYPES[_key.ToUpper()] != null)
                    retval = DICTIONARY_CUSTOMTYPES[_key.ToUpper()];
            }
            catch (KeyNotFoundException)
            {
                // do nothing for now, line of code below is redundant
                retval = typeof(object);
            }


            // as code safety mechanism, the method will return an object if not found
            return retval;
        }

    }
}
