using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class GooglePhone : IPhone
    {
        public void Build()
        {
            Console.WriteLine("We are buidling your new G phone!");
        }
    }
}
