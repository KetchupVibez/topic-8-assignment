namespace topic_8_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string punctuation = ", ", punctuation2 = ", ";
            int randomColour, numberAmount, min, max, newNumber, numberCount, amount = 0, numberDelete;
            Random generator = new Random();

            //List<string> colours = new List<string> { "Red", "Orange", "Yellow", "Green", "Blue" };

            //for (int i = 0; i <= 4; i = i + 1)
            //{
            //    if (i == 4)
            //    {
            //        punctuation = ". ";
            //    }
            //    Console.Write(colours[i] + punctuation);

            //}
            //randomColour = generator.Next(0, 5);
            //Console.WriteLine(colours[randomColour] + " Was the random colour chose.");

            List<int> numbers = new List<int>(); // Creates an empty List
            Console.WriteLine("Enter the minimum of your number list.");
            Int32.TryParse(Console.ReadLine(), out min);
            Console.WriteLine("Now enter the maximum.");
            Int32.TryParse(Console.ReadLine(), out max);
            Console.WriteLine("Enter how many numbers you would like to add in your list.");
            Int32.TryParse(Console.ReadLine(), out numberAmount);
            Console.WriteLine("Enter a number and I will tell you how many times that number prints.");
            Int32.TryParse(Console.ReadLine(), out numberCount);
            Console.WriteLine("Enter a number that when prints, I will print a zero instead.");
            Int32.TryParse(Console.ReadLine(), out numberDelete);
            for (int i = 1; i < (numberAmount + 1); i++)
            {
                newNumber = generator.Next(min, (max + 1));
                if (newNumber == numberDelete) // if statement to convert chosen number to zero
                    newNumber = 0;
                numbers.Add(newNumber);
                Console.Write(newNumber + punctuation);
                if (newNumber == numberCount) // if statement to figure out how many times chosen number will print
                    amount += 1;

            }
            Console.WriteLine();
            Console.WriteLine("The number " + numberCount + " was printed " + amount + " times.");
            Console.WriteLine("I will now reset your list with zero. Press enter.");
            Console.ReadLine();
            for (int i = 1; i < (numberAmount + 1); i++)
            {
                newNumber = generator.Next(min, (max + 1));
                newNumber = 0;
                numbers.Add(newNumber);
                Console.Write(newNumber + punctuation);
                

            }
            Console.WriteLine();
            Console.WriteLine("Now we will make a new list with your rules. Press enter.");
            Console.ReadLine();
            for (int i = 1; i < (numberAmount + 1); i++)
            {
                newNumber = generator.Next(min, (max + 1));
                numbers.Add(newNumber);
                Console.Write(newNumber + punctuation);


            }

        }
    }
}
