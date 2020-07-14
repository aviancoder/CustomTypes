using Infor.CustomTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Infor.CustomTypes.Abstracts
{
    public abstract class CustomTypeValidations : ICustomTypes
    {
        //public string ValidationMessage { get; set; }
        public virtual bool Validated(object _obj)
        {
            foreach (var prop in _obj.GetType().GetProperties())
            {
                // check for string values
                if (prop.PropertyType == typeof(string))
                {

                    if (String.IsNullOrEmpty(prop.GetValue(_obj, null).ToString()) == true)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
