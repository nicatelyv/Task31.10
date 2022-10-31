namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = 4;
            int x = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a%i == 0)
                {
                    x++;
                }

            }
            if (a == 1)
            {
                Console.WriteLine("1 ne murekkebdir ne de sadedir");
            }
            else if (x > 2)
            {
                Console.WriteLine("Eded murekkebdir");
            }
            else
            {
                Console.WriteLine("Eded sadedir");
            }
            
        }
    }
}