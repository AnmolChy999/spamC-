namespace spamc
{
    public class StringReverse
    {
        public void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Enter the word you want to reverse");
            string? input = Console.ReadLine();

            while(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Enter a valid word");
                input = Console.ReadLine();
            }
            string wordToReverse = input;

            for(int i = wordToReverse.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Reversed order of the word:");
                Console.Write($"{wordToReverse[i]} ");
            }
            Console.WriteLine();
        }
    }
}
