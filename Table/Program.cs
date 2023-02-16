using System;
using System.Linq;
using System.Net;

namespace table
{
    class Program
    {
        static void Main(String[] args)
        {
            Random rnd = new Random();
         //   Console.WriteLine("(Type a number below zero to stop the aplication)\n");

            Console.Write("Type the number: ");
            int num = int.Parse(Console.ReadLine());
            

            while (num > 0  )
            {

                HashSet<int> numbers = new HashSet<int>();

                Console.WriteLine("Until which number? ");
                int until = int.Parse(Console.ReadLine()) +1;


                Console.WriteLine("Type the answer: ");


                for (int i = 0; i < until; i++)
                {

                    int random = rnd.Next(until);

                    while (numbers.Contains(random))
                    {
                        random = rnd.Next(until);
                    }

                    Console.Write($"{num} * {random} =");
                    int numF = int.Parse(Console.ReadLine());



                    while (numF != num * random)
                    {
                        Console.Write($"{num} * {random} =");
                        numF = int.Parse(Console.ReadLine());
                    }


                    numbers.Add(random);

                }


                Console.WriteLine("Finished\n ");
                numbers.Clear();
                Console.Write("Type the choosen number: ");
                num = int.Parse(Console.ReadLine());
            }
        //    Console.WriteLine("The aplication has stopped! ");
        } 





    }



}