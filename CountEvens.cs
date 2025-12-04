namespace spamc
{
    public class CountEvens
    {
       public void EvenNumberCounter()
        {
            Console.WriteLine("Enter how many numbers you want to enter:");

            int limit ;
            var input = Console.ReadLine();

            while(!int.TryParse(input, out limit) || limit < 0 || limit > 50)
            {
                Console.WriteLine("Enter a valid number between 1 and 50:");
                input = Console.ReadLine();
            }

            int[] numbers = new int[limit];

            Console.WriteLine($"Enter {limit} numbers");
            for(int i = 0; i<limit; i++)
            {
                var userNum = Console.ReadLine();
                int userInt;
                while(!int.TryParse(userNum, out userInt))
                    {
                                Console.WriteLine("Enter a valid integer");
                                userNum = Console.ReadLine();
                    }
                numbers[i] = userInt;
            }

            int count = 0;
            List<int> evens = new List<int>();

            foreach(int num in numbers)
            {
                if(num% 2 ==0)
                {
                    evens.Add(num);
                    count++;
                }
            }

            if(count == 0)
            {
                Console.WriteLine("No even numbers were entered");
            }
            else
            {
                Console.WriteLine($"There are {count} even numbers");
                foreach(int eve in evens)
                {
                    Console.WriteLine(eve);
                }
            }
        }
    }
}
