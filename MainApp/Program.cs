using PersistedStorage;
using System.ComponentModel.DataAnnotations;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStorage storage = Factory.StorageFactory();

            Console.WriteLine("Enter Action: \"i\" for insert, Enter \"g\" for lookup. ");

            String? s = Console.ReadLine();

            while (s != "q")
            {
                if(s=="i" || s== "I")
                {
                    Console.WriteLine("Enter key and value separated by comma.");   
                    s = Console.ReadLine();
                    string[] tokens = s.Split(new char[] { ',' }, 2);

                    storage.Save(tokens[0], tokens[1]);
                }
                else if (s=="g" || s == "G")
                {
                    Console.WriteLine("Enter key: ");
                    s = Console.ReadLine();
                    string value = storage.Get(s);
                    if (value != null)
                        Console.WriteLine(value + Environment.NewLine);
                    else
                        Console.WriteLine("Key " + s + " not found!!" + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("Enter \"i\" for inserting \nEnter \"g\" for lookup.\n");
                }
                Console.WriteLine("Enter Action: ");

               s = Console.ReadLine();
            }
        }
    }
}
