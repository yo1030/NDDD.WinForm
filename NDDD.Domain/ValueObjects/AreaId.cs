namespace NDDD.Domain.ValueObjects
{
    public sealed class AreaId : ValueObject<AreaId>
    {
        public AreaId(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public string DisplaValue => Value.ToString().PadLeft(4, '0');

        public override bool EqualsCore(AreaId other)
        {
            return this.Value == other.Value;
        }
    }
}
