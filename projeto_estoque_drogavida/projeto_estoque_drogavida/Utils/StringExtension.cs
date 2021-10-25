using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_estoque_drogavida.Utils
{
    public static class StringExtension
    {
        public static string SubStringTo(this string thatString, int limit)
        {

            if (thatString.Length > limit)
            {
                return thatString.Substring(0, limit);
            }
            return thatString;

        }
    }
}