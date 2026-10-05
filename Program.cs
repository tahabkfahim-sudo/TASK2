namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
List<int> numbers = new List<int>();

            DateTime startTime = DateTime.Now;

            char choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("T - Display program running time");
                Console.WriteLine("Q - Quit");

                Console.Write("Enter your choice: ");
                choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 'P':
                    case 'p':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("[ ");

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i] + " ");
                            }

                            Console.WriteLine("]");
                        }

                        break;


                    case 'A':
                    case 'a':

                        Console.Write("Enter a number to add: ");
                        int number = int.Parse(Console.ReadLine());

                        bool found = false;

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == number)
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found == true)
                        {
                            Console.WriteLine(number + " already exists");
                        }
                        else
                        {
                            numbers.Add(number);
                            Console.WriteLine(number + " added");
                        }

                        break;


                    case 'M':
                    case 'm':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            int sum = 0;

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }

                            double mean = (double)sum / numbers.Count;

                            Console.WriteLine("The mean is " + mean);
                        }

                        break;


                    case 'S':
                    case 's':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int smallest = numbers[0];

                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] < smallest)
                                {
                                    smallest = numbers[i];
                                }
                            }

                            Console.WriteLine("The smallest number is " + smallest);
                        }

                        break;


                    case 'L':
                    case 'l':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = numbers[0];

                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] > largest)
                                {
                                    largest = numbers[i];
                                }
                            }

                            Console.WriteLine("The largest number is " + largest);
                        }

                        break;


                    case 'C':
                    case 'c':

                        numbers.Clear();

                        Console.WriteLine("List cleared");

                        break;


                    case 'T':
                    case 't':

                        TimeSpan elapsedTime = DateTime.Now - startTime;

                        Console.WriteLine("Program has been running for:");
                        Console.WriteLine(
                            elapsedTime.Hours + " hours, " +
                            elapsedTime.Minutes + " minutes, " +
                            elapsedTime.Seconds + " seconds"
                        );

                        break;


                    case 'Q':
                    case 'q':

                        Console.WriteLine("Goodbye");

                        break;


                    default:

                        Console.WriteLine("Unknown selection, please try again");

                        break;
                }

            } while (choice != 'Q' && choice != 'q');


        }
    }
}
