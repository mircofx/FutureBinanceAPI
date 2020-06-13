﻿using System.Reflection;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FutureBinanceAPI.Models.Orders
{
    public class Order
    {
        public IEnumerable<KeyValuePair<string, string>> ToKeyValuePair()
        {
            return this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .ToDictionary(x => ConvertKey(x.Name), 
                              x => ConvertToString(x.GetValue(this)));
        }

        private string ConvertKey(string defaultKey) => char.ToLowerInvariant(defaultKey[0]) + defaultKey.Substring(1);

        private string ConvertToString(object value)
        {
            return value is decimal ? ((decimal) value).ToString(new CultureInfo("en-US")) : value.ToString();
        }
    }
}