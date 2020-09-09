using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class PhoneFactory
    {       
        public static IPhone GetPhone(string phoneType)
        {
            switch (phoneType.ToLower())
            {
                case "android":
                    return new AndroidPhone();
                case "apple":
                case "iphone":
                    return new ApplePhone();
                case "google":
                    return new GooglePhone();
                default:
                    return new AndroidPhone();
            }

        }
            

    }
}
