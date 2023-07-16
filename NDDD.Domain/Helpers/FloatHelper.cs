using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Helpers
{
    public static class FloatHelper
    {
        public static string RoundString(this float value, int decimalPoint)
        {
            value = Convert.ToSingle(Math.Round(value, decimalPoint));
            return value.ToString(decimalPoint == 0 ? String.Empty
                                                    : "." + string.Concat(Enumerable.Repeat("0",decimalPoint)));
        }
    }
}
