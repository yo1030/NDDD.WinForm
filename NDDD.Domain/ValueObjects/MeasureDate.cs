using System;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MeasureDate : ValueObject<MeasureDate>
    {
        public MeasureDate(DateTime value)
        {
            Value = value;
        }

        public DateTime Value { get; }

        public string DisplaValue => Value.ToString("yyyy/MM/dd HH:mm:ss");

        public override bool EqualsCore(MeasureDate other)
        {
            return this.Value == other.Value;
        }
    }
}
