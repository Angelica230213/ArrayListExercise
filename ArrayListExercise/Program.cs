using System.Collections;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace ArrayListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList() { "Anna", "Ivan", "Maria", "Georgi", "Peter", "Elena", "Nikolay" };

            arrayList.Add("Yulia");
            arrayList.Add("Arlecchino");
            arrayList.Add("Barbara");

            arrayList.Insert(3, "Valeriy");

            Console.WriteLine(string.Join(" ", arrayList.ToArray()));

            arrayList.Remove("Nikolay");
            arrayList.RemoveAt(2);

            if (arrayList.Contains("Maria"))
            {
                Console.WriteLine("Maria is in the list.");
            }
            else
            {
                Console.WriteLine("Maria is not in the list.");
            }

            Console.WriteLine(arrayList.Count);

            arrayList.InsertRange(0, new[] { "Mitya", "Odette" });

            if (arrayList.Contains("Georgi"))
            {
                int index = arrayList.IndexOf("Georgi");
                arrayList[index] = "VIP_George";
            }

            Console.WriteLine(arrayList.IndexOf("Peter"));

            foreach (object element in arrayList)
            {
                if (element is string text && text.StartsWith("A", StringComparison.Ordinal))
                {
                    arrayList.Remove(element);
                }

                if (element is string && element.ToString().Length < 4)
                {
                    arrayList.Remove(element);
                }
            }

            Console.WriteLine(string.Join(" ", arrayList.ToArray()));

            arrayList.Sort();
            arrayList.Reverse();

            (arrayList[0], arrayList[arrayList.Count - 1]) = (arrayList[arrayList.Count - 1], arrayList[0]);

            Console.WriteLine(string.Join(" ", arrayList.ToArray()));

            if (arrayList.Count > 5)
            {
                Console.WriteLine("The park was full today.");
            }
            else if (arrayList.Count > 1 || arrayList.Count <= 5)
            {
                Console.WriteLine("Today it was a peaceful day.");
            }
            else if (arrayList.Count == 0)
            {
                Console.WriteLine("The park was empty.");
            }
            if (arrayList.Count > 0)
            {
                Console.WriteLine("{}, {}", arrayList[0], arrayList[arrayList.Count - 1]);
            }

            Console.WriteLine("You can add a name if it doesn't exist already.");

            string name = Console.ReadLine();

            if (arrayList.Contains(name))
            {
                Console.WriteLine("This name already exists in the list.");
            }
            else
            {
                arrayList.Add(name);
                Console.WriteLine("Name added successfully.");
            }

            Console.WriteLine("Would you like to remove a name? (yes/no)");

            if (Console.ReadLine().ToLower() == "yes")
            {
                Console.WriteLine("Enter the name to remove:");
                string nameToRemove = Console.ReadLine();
                if (arrayList.Contains(nameToRemove))
                {
                    arrayList.Remove(nameToRemove);
                    Console.WriteLine("Name removed successfully.");
                }
                else
                {
                    Console.WriteLine("This name does not exist in the list.");
                }
            }
        }
    }
}
