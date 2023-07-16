﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Helpers
{
    /// <summary>
    /// Floatヘルパー
    /// </summary>
    public static class FloatHelper
    {
        /// <summary>
        /// 指定した桁数で四捨五入し、ゼロ埋め
        /// </summary>
        /// <param name="value">値</param>
        /// <param name="decimalPoint">小数点以下桁数</param>
        /// <returns></returns>
        public static string RoundString(this float value, int decimalPoint)
        {
            value = Convert.ToSingle(Math.Round(value, decimalPoint));
            return value.ToString(decimalPoint == 0 ? String.Empty
                                                    : "." + string.Concat(Enumerable.Repeat("0",decimalPoint)));
        }
    }
}
