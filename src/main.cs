using System;
using Windows.UI.Xaml;

namespace myApp
{
    class app
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int result;
            result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + result);
            Console.ReadLine();

            string[] names = { "charles", "sabbath", "destiny", "cassey" };
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            names[4] = "james";

            if (names[4] != "james")
            {
                Console.WriteLine("Name not Found");
            }
            else
            {
                Console.WriteLine("James is found");
            }


            void is_on()
            {
                if (1 > 0)
                {
                    Console.WriteLine("Omor");
                }
            }

        }
    }
}