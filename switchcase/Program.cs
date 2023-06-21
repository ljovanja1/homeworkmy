using System;

namespace switchcase {
    
    
    class Program {

        static void Main() {

            short user_input = Convert.ToInt16(Console.ReadLine());
            switch(user_input) {
                case 5:
                    Console.WriteLine("Number is 5");
                    break;
                case 15:
                    Console.WriteLine("Number is 15");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 115:
                    Console.WriteLine("Number is 115");
                    break;
                default:
                    Console.WriteLine("Number is not detection");
                    break;
            }
        }
    }
}