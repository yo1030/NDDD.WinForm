namespace NDDD.Domain.ValueObjects
{
    /// <summary>
    /// エリアID
    /// </summary>
    public sealed class AreaId : ValueObject<AreaId>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value"></param>
        public AreaId(int value)
        {
            Value = value;
        }

        /// <summary>
        /// 値
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// 表示する値
        /// </summary>
        public string DisplaValue => Value.ToString().PadLeft(4, '0');

        /// <summary>
        /// EqualsCore
        /// </summary>
        /// <param name="other">比較する値</param>
        /// <returns>同じ値のときTrue</returns>
        public override bool EqualsCore(AreaId other)
        {
            return this.Value == other.Value;
        }
    }
}
