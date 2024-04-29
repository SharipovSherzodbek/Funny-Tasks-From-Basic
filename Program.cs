namespace Lesson
{
    class Tasks
    {
        public void TimeCalculator()
        {
            Console.WriteLine("Welcome to TASK1 \n\tTime Calculator~!");
            Console.WriteLine("Enter time in minutes to convert hours:minutes...");

            uint timeInMinutes;
            if (!uint.TryParse(Console.ReadLine(), out timeInMinutes))
            {
                Console.WriteLine("ERROR: Invalid format, Please enter an integer!");
                return;
            }

            uint hour = timeInMinutes / 60;
            uint minute = timeInMinutes % 60;

            if (minute < 10)
            {
                Console.WriteLine($"Succesfully converted: \"{hour}:0{minute}\" ");
            }
            else
            {
                Console.WriteLine($"Succesfully converted: \"{hour}:{minute}\" ");
            }
        }

        public void AgeCategory()
        {
            Console.WriteLine("Welcome to TASK2 \n\t Age category");
            Console.WriteLine("Enter your age to know your age category");

            uint age;
            if (!uint.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("ERROR: Invalid format, Please enter an integer!");
            }

            if (age <= 12)
            {
                Console.WriteLine("You are child!");
            }
            else
            {
                if (age <= 19)
                {
                    Console.WriteLine("You are a teenager");
                }
                else if (age <= 59)
                {
                    Console.WriteLine("You are an adult");
                }
                else
                {
                    Console.WriteLine("Your age more than 60 ");
                }
            }
        }

        public void CalculationOfGPA()
        {
            Console.WriteLine("Welcome to TASK3 \n\t Calculation of GPA!");
            Console.WriteLine("Enter your marks in all three subjects to calculate your GPA…");
            Console.WriteLine("Notification: Your score must be from \"0\" to \"100\" and a valid integer!");

            Console.WriteLine("Enter a score from first subject:");
            if (!ushort.TryParse(Console.ReadLine(), out ushort firstScore) || firstScore > 100)
            {
                Console.WriteLine("Invalid input! Please enter a valid score between 0 and 100.");
                return;
            };

            Console.WriteLine("Enter a score from second subject:");
            if (!ushort.TryParse(Console.ReadLine(), out ushort secondScore) || secondScore > 100)
            {
                Console.WriteLine("Invalid input! Please enter a valid score between 0 and 100.");
                return;
            }

            Console.WriteLine("Enter a score from third subject:");
            if (!ushort.TryParse(Console.ReadLine(), out ushort thirdScore) || thirdScore > 100)
            {
                Console.WriteLine("Invalid input! Please enter a valid score between 0 and 100.");
                return;
            }

            ushort result = (ushort)((firstScore + secondScore + thirdScore) / 3);

            string message = result >= 80 ? "Your GPA is - Excelent"
                           : result >= 60 ? "Your GPA is - Good"
                           : result >= 40 ? "Your GPA is - Satisfactory"
                           : "Your GPA is - Unsatisfactory";
            Console.WriteLine(message);
        }

        public void FindANumber()
        {
            Console.WriteLine("Welcome to TASK4 \n\t Find a number from 1 to 100!");
            bool exit = true;
            int guess = 0;
            Random random = new Random();
            int randomNumber = random.Next(100);

            while (exit)
            {
                Console.WriteLine("Guess the number and we say whether the entered number is big or small");
                int enteredNumber;
                if (!int.TryParse(Console.ReadLine(), out enteredNumber) || enteredNumber > 100 || enteredNumber < 0)
                {
                    Console.WriteLine("Error: Please enter a valid integer");
                }

                guess++;
                string resultMessage =
                    enteredNumber > randomNumber ? "Entered number is bigger"
                                                 : enteredNumber == randomNumber
                                                 ? "Wow you find it!"
                                                 : "Entered number is smaller";
                Console.WriteLine($"{resultMessage} \tNumber of tries: {guess}");

                exit = !(enteredNumber == randomNumber);
            }
            Console.WriteLine("Congratulations! You've guessed the number. Game over!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        Tasks tasks = new Tasks();
            tasks.TimeCalculator();
            tasks.AgeCategory();
            tasks.CalculationOfGPA();
            tasks.FindANumber();
        }
    }
}