Dictionary<int, string> vendingPairs = new Dictionary<int, string>();
vendingPairs.Add(78, "tea thats cold");
vendingPairs.Add(67, "nestea");
vendingPairs.Add(6, "fuzetea");
vendingPairs.Add(7, "iced tea");
vendingPairs.Add(76, "cold tea");
int vendingNum = 3;
while (true)
{
    Console.WriteLine("Choose product");
    string vendingInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(vendingInput))
    {
        if (int.TryParse(vendingInput, out vendingNum))
        {

            if (vendingNum == 0)
            {
                Environment.Exit(0);
            }

            if (vendingPairs.ContainsKey(vendingNum))
            {
                string chosen = vendingPairs[vendingNum];
                Console.WriteLine("You have chosen " + chosen);
            }
            else
            {
                Console.WriteLine("Invalid product");
            }

        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }

}


