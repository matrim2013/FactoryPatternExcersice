using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of phone would you like?");
            var userPhone = Console.ReadLine();

            var phone = PhoneFactory.GetPhone(userPhone);
            phone.Build();
            
        }
    }
}
