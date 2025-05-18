using System;

namespace if_else_for
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }
            while (true) ;


/*
            while (true) 
            {
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }


            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("Iteration {0}", i);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }



 
            //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

		var color = Console.ReadLine();

		switch(color)
		{
			case "red":
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is red!");
			break;

			case "green":
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
			break;

    	    case "cyan":
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is Cyan!");
			break;


			default:
				Console.BackgroundColor = ConsoleColor.Yellow;
				Console.ForegroundColor = ConsoleColor.Red;

				Console.WriteLine("Your BackgroundColor color is Yellow and ForegroundColor color is Red!");
				break;
		}


            //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }


            //////////////////////////////////////////////////////////////////////////
            var a = 6;
            var b = 7;

            var c = a != b ? a + b : b;

            Console.WriteLine(c);

            //////////////////////////////////////////////////////////////////////////
            var a = 6;
            var b = 7;

            if (a == b && b > 1)
            {
                Console.WriteLine("Условие истинно");
            }
            else if (b > 10 || b == 7)
            {
                Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0}", b);
            }


            //////////////////////////////////////////////////////////////////////////
            var a = 6;
            var b = 11;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");

                if (b < 10)
                    Console.WriteLine("Значение b = {0}", b);
            }



            //////////////////////////////////////////////////////////////////////////
            var a = 6;
            var b = 7;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }


            //////////////////////////////////////////////////////////////////////////
            var inv = true;
            var result = !inv;
            Console.Write(result);


            
            //////////////////////////////////////////////////////////////////////////
            var a = 5 + 6;
            var b = 7 + 8;

            var c = (b != a) & (b > a + 1);
            var d = (b != a) && (b > a + 1);

            Console.WriteLine(c);
            Console.WriteLine(d);



            c = (b == a) & (b > a + 1);
            d = (b == a) && (b > a + 1);

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadKey();
            

            //////////////////////////////////////////////////////////////////////////
            int a, b;
            double x, y;
            bool c;
            c = (a < b) | (x > y);

            //////////////////////////////////////////////////////////////////////////
            string a = "test1";
            string b = "test2";
            bool c;

            c = a != b;
            Console.Write("a != b ? {0}", c);
            Console.ReadKey();

            //////////////////////////////////////////////////////////////////////////
            var myapples = 5;
            var hisapples = 6;
            var hispeares = 5;

            var result = (myapples != hispeares) & (myapples < hisapples);

            Console.WriteLine(result);
            Console.ReadKey();
*/
        }
    }
}
