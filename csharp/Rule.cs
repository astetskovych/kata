using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class Rule
    {
        public Rule(int limit, int val)
        {
            Limit = limit;
            Value = val;
        }
        public int Limit { get; set; }
        public int Value { get; set; }
    }
}
