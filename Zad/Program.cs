namespace Zad
{
    internal class Program
    {
        static LinkedList<string> list = new LinkedList<string>() { };
        static void Main(string[] args)
        {
            AddItem();
            PrintList();
            RemoveBought();
            PrintList();
        }
        static void PrintList()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void AddItem()
        {
            string answer = null;
            do
            {

                Console.Write("What to add to the shopping list (or type \"done\" to exit): ");
                string item = Console.ReadLine().ToLower();
                if (item == "done")
                {
                    break;
                }
                Console.Write("Where to put it (start or end): ");
                answer = Console.ReadLine().ToLower();
                if (answer == "start")
                {
                    list.AddFirst(item);
                }
                else
                {
                    list.AddLast(item);
                }
            } while (true);
            Console.WriteLine("========================");
        }
        static void RemoveBought()
        {
            Console.WriteLine("Which items have you bought?");
            string[] bought = Console.ReadLine().ToLower().Split().ToArray();
            for (int i = 0; i < bought.Length; i++)
            {
                    list.Remove(bought[i]);
                    Console.WriteLine($"Removed {bought[i]}");
            }
            Console.WriteLine("=====================");
        }
    }
}
