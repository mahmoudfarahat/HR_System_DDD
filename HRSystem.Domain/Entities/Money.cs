using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Domain.Entities
{
    public record Money
    {
        public decimal Value { get; private init; }

        private Money(decimal value)
        {
            if (value < 0) throw new ArgumentException("Money cannot be negative.");
            Value = value;
        }

        public static Money FromDecimal(decimal value) => new Money(value);
    }
}
