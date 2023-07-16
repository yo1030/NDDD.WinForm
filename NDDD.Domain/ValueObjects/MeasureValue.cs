using NDDD.Domain.Helpers;
using System;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MeasureValue : ValueObject<MeasureValue>
    {
        public MeasureValue(float value)
        {
            Value = value;
        }

        public float Value { get; }

        //public string DisplaValue => Math.Round(Value, 2) + "℃";
        public string DisplaValue => Value.RoundString(2) + "℃";

        public override bool EqualsCore(MeasureValue other)
        {
            return this.Value == other.Value;
        }
    }
}
