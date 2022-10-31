namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int fct = 1;

            for (int i = 1; i <= 7 ; i++)

            {
             fct=fct*i;

            }
            Console.WriteLine("Faktorialin Hesablanmasi" +" " + fct);
        }
    }
}