namespace EXAM2
{
    class program
    {
        static void Main(string[] args)
        {
            int num_BS = 5;
            int num_WS = 2;
            int num_CF = 3;
            bool order = true;
            Console.Write("Input Day of order(1:Mon, 2:Tue, 3:Wed, 4:Thus, 5:Fri, 6:Sat, 7:Sun)> ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Time of order(8 A.M - 18 P.M)> ");
            int time = Convert.ToInt32(Console.ReadLine());
           
           while (order)
           {
                Console.Write("Input Menu: Breakfast Set, Weekend Set, Coffee, (End) For cancel the order)> ");
                string? menu = Console.ReadLine();
                switch(menu)
                {
                    case "Breakfast Set":
                        if (time > 11)
                        {
                            Console.WriteLine("Sorry your order is not available");
                            //num_BS = 0;
                        }
                        else
                        {
                            if (num_BS > 0)
                            {
                                num_BS--;
                            }
                            else
                            {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        break;
                    case "Weekend Set":
                        if (day < 6)
                        {
                            Console.WriteLine("Sorry your order is not available");
                            //num_WS = 0;
                        }
                        else
                        {
                            if (num_WS > 0)
                            {
                                num_WS--;
                            }
                            else
                            {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        }
                        break;
                    case "Coffee":
                        if (num_CF > 0)
                            {
                                num_CF--;
                            }
                            else
                            {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                        break;
                    case "End":
                        order = false;
                        break;
                    default :
                        Console.WriteLine("Please enter a valid menu");
                        break;
            }
           }
           Console.WriteLine("Thank You For Use Our Service");
            
        }
    }
}

