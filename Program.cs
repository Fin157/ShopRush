namespace ShopRush;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    // Accepts a shopping list and shops (the shops are without items we aren't looking for - removed
    // during preprocessing)
    static int GetMinShopCount(HashSet<int> shoppingList, List<HashSet<int>> shops)
    {
        int bestShopIndex = -1;
        int currentMax = -1;

        for (int i = 0; i < shops.Count; i++)
        {
            if (currentMax < shops[i].Count)
            {
                currentMax = shops[i].Count;
                bestShopIndex = i;
            }
        }

        // If 1 shop has everything: we need 1 shop
        // If 1 shop has everything except 1 item: we need 2 shops
        // If all shops have at most 1 item we need: we need as many shops as there are items
        // Otherwise we need to manually count the number of shops that we need (depends on if the shops'
        // sortiments are disjunct - then it's less compared to if not)
    }
}
