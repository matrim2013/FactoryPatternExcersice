using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class ApplePhone : IPhone
    {
        public void Build()
        {
            Console.WriteLine("We are building your iphone");
        }
    }
}
