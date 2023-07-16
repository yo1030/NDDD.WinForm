using System;

namespace NDDD.Domain.ValueObjects
{
    /// <summary>
    /// 計測日時
    /// </summary>
    public sealed class MeasureDate : ValueObject<MeasureDate>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value">値</param>
        public MeasureDate(DateTime value)
        {
            Value = value;
        }

        /// <summary>
        /// 値
        /// </summary>
        public DateTime Value { get; }

        /// <summary>
        /// 表示する値
        /// </summary>
        public string DisplaValue => Value.ToString("yyyy/MM/dd HH:mm:ss");

        /// <summary>
        /// EqualsCore
        /// </summary>
        /// <param name="other">比較する値</param>
        /// <returns>同じ値のときTrue</returns>
        public override bool EqualsCore(MeasureDate other)
        {
            return this.Value == other.Value;
        }
    }
}
