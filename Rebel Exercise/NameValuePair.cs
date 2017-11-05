using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rebel_Exercise
{
    [Serializable]
    public class NameValuePair
    {
        public string Key { get; set; } = "";
        public string Value { get; set; } = "";
        public string DisplayValue
        {
            get { return String.Format("{0}={1}", Key.Trim(), Value.Trim()); }
        }
        
        public NameValuePair (string newKey, string newValue)
        {
            Key = newKey;
            Value = newValue;
        }
    }
}