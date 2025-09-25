Dictionary<int, string> vendingPairs = new Dictionary<int, string>();
vendingPairs.Add(78, "tea thats cold");
vendingPairs.Add(67, "nestea");
vendingPairs.Add(6, "fuzetea");
vendingPairs.Add(7, "iced tea");
vendingPairs.Add(76, "cold tea");
int vendingNum = 3;
bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("Choose product");
    string vendingInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(vendingInput))
    {
        if (int.TryParse(vendingInput, out vendingNum))
        {

            if (vendingNum == 0)
            {
                isRunning = false;
            }

            if (vendingPairs.ContainsKey(vendingNum))
            {
                
                Console.WriteLine("You have chosen " + vendingPairs[vendingNum]);
            }
            else
            {
                Console.WriteLine("Invalid product");
                continue;
            }

        }
        else
        {
            Console.WriteLine("invalid prod");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
        continue;
    }

}


