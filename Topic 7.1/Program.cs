namespace Topic_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entry = 45633, tries = 0, pin = 0;
            int count = 0;
            bool done = false;

            //Console.WriteLine("WELCOME TO THE BANK");
            //while (!done)
            //{
            //    Console.Write("ENTER YOUR PIN: ");
            //    while (!int.TryParse(Console.ReadLine(), out pin));
            //    Console.WriteLine("Please enter a valid number.");
            //    tries++;
            //    if (pin == entry)
            //    {
            //        Console.WriteLine("PIN ACCEPTED.");
            //        done = true;
            //    }
            //    else if (tries == 5)
            //    {
            //        Console.WriteLine("Too many innocrect tries. Please try again later.");
            //        done = true;
            //    }
            //}
           
            Console.WriteLine("Enter a message and I'll write it 5 times");
            Console.Write("Message: ");
            string message = Console.ReadLine();
            while (count < 5)
            {
                Console.WriteLine((count +1) + ". " + message);
                count++;
            }

        }
    }
}
