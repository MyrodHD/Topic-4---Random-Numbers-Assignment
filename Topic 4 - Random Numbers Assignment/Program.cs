namespace Topic_4___Random_Numbers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Generator = new Random();

            //Part 1 
            int max;
            int min;

            Console.WriteLine("Provide me with an maximum value: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Provide me with a minimum value: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(Generator.Next(min, max));
            Console.WriteLine(Generator.Next(min, max));
            Console.WriteLine(Generator.Next(min, max));
            Console.WriteLine(Generator.Next(min, max));
            Console.WriteLine(Generator.Next(min, max));
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();

            //Part 2
            int dice1;
            int dice2;

            dice1 = Generator.Next(0,25);
            dice2 = Generator.Next(0,25);

            Console.WriteLine(dice1);
            Console.WriteLine();
            Console.WriteLine(dice2);
            Console.WriteLine();
            Console.WriteLine($"The total of the numbers is: {dice1 + dice2}");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();

            //Part 3


            int decimalAmount;
            double randmax = (double)max;
            double randmin = (double)min;

            Console.WriteLine("How many decimal places do you want: ");
            decimalAmount = Convert.ToInt32(Console.ReadLine());

            double number = Generator.NextDouble() * (randmin - randmax) + randmin;
            number = Math.Round(number,decimalAmount);

            double number2 = Generator.NextDouble() * (randmin - randmax) + randmin;
            number2 = Math.Round(number2, decimalAmount);

            double number3 = Generator.NextDouble() * (randmin - randmax) + randmin;
            number3 = Math.Round(number3, decimalAmount);

            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
        }
    }
}
