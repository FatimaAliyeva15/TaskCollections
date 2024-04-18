
using Collections.Models;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);

            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList[i]);
            }

            Console.WriteLine("");
            Console.WriteLine($"List Count: {customList.Count}");
            Console.WriteLine($"List Capacity: {customList.Capacity}");
            Console.WriteLine("");


            string containsStr = "";
            int contains;

            do
            {
                Console.Write("Contains: ");
                containsStr = Console.ReadLine();
            } while (!int.TryParse(containsStr, out contains));

            Console.WriteLine(customList.Contains(contains));
            Console.WriteLine("");


            string findStr = "";
            int find;

            do
            {
                Console.Write("Find: ");
                findStr = Console.ReadLine();
            } while (!int.TryParse(findStr, out find));

            customList.Find(find);

            Console.WriteLine("");
            Console.WriteLine("FindAll");
            var findall = customList.FindAll(item => item % 2 == 0);
            foreach (var item in findall)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            string removeStr = "";
            int remove;

            do
            {
                Console.Write("Remove: ");
                removeStr = Console.ReadLine();
            } while (!int.TryParse(removeStr, out remove));

            customList.Remove(remove);
            Console.WriteLine($"{remove} silindi");

            //for (int i = 0; i < customList.Count; i++)
            //{
            //    Console.WriteLine(customList[i]);
            //}


            //Console.WriteLine("Clear");
            //customList.Clear();
            //Console.WriteLine($"List Count: {customList.Count}");
            //Console.WriteLine($"List Capacity: {customList.Capacity}");
            //Console.WriteLine("");

            //Console.WriteLine("");
            //Console.WriteLine("RemoveAll");
            //Predicate<int> removeAll = item => item % 4 == 0;
            //customList.RemoveAll(removeAll);


        }
    }
}
