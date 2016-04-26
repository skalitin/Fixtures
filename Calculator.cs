using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixtures
{
    public class Calculator
    {
        public int Foo { get; set; }
        public int Bar { get; set; }
        public int Result()
        {
            return Foo * 2 + Bar + 1;
        }
    }

    public class AnotherExample
    {
        public string Something { get; set; }
        public string CompletelyDifferent { get; set; }
        public string Message()
        {
            return string.Format("Hello, {0} and {1}", Something, CompletelyDifferent);
        }
    }
}
