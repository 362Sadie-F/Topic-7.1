namespace Topic_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin = 45633;
            int entry;

            Console.WriteLine("WELCOME TO THE BANK");
            Console.Write("ENTER YOUR PIN: ");
            int.TryParse(Console.ReadLine(), out entry);
            Console.WriteLine();
            while (entry != pin)
            {
                Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
                Console.Write("ENTER YOUR PIN: ");
                int.TryParse(Console.ReadLine(), out entry);
                Console.WriteLine();
            }
            Console.WriteLine("PIN ACCEPTED. WELCOME IN.");

        }
    }
}
