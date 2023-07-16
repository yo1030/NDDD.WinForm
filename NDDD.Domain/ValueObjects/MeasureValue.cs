using NDDD.Domain.Helpers;
using System;

namespace NDDD.Domain.ValueObjects
{
    /// <summary>
    /// 計測値
    /// </summary>
    public sealed class MeasureValue : ValueObject<MeasureValue>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value">値</param>
        public MeasureValue(float value)
        {
            Value = value;
        }

        /// <summary>
        /// 値
        /// </summary>
        public float Value { get; }

        /// <summary>
        /// 表示する値
        /// </summary>
        //public string DisplaValue => Math.Round(Value, 2) + "℃";
        public string DisplaValue => Value.RoundString(2) + "℃";

        /// <summary>
        /// EqualsCore
        /// </summary>
        /// <param name="other">比較する値</param>
        /// <returns>同じ値のときTrue</returns>
        public override bool EqualsCore(MeasureValue other)
        {
            return this.Value == other.Value;
        }
    }
}
