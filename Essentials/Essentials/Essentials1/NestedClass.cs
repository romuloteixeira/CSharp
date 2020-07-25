using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials1
{
    public class NestedClass
    {
        public class Nested
        {
            public int Value { get; set; }

            public override string ToString() => $"Value: {Value}";
        }
    }
}
