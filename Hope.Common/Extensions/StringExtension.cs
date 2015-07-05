using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hope.Common.Extensions
{
    public static class StringExtension
    {

        public static string Con(this string target, params object[] args)
        {
            return string.Concat(target, args);
        }
    }
}
