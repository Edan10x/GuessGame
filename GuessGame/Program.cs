internal class Program
{
    private static void Main(string[] args)
    {
        bool isCorrectGuess = false;

        // random class
        Random random = new Random();
        // create a random number
        int randomNumber = random.Next(100) + 1;

        

        // opening statement
        Console.WriteLine("Welcome to the guessing game!!!");
        Console.WriteLine("\nThe computer chose a random number between 0 - 100");


        while (!isCorrectGuess)
        {
            Console.WriteLine("\nMake your guess now: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess > randomNumber)
            {
                Console.WriteLine("To high");
            }

            if (guess < randomNumber)
            {
                Console.WriteLine("To low");
            }

            if (guess == randomNumber)
            {
                Console.WriteLine("You got it");
                break;
            }
        }

        Console.ReadKey();
    }
}