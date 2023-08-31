using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistedStorage
{
    public class TextFileStorage : IStorage
    {
        public string Get(string key)
        {
            string filePath = "dict.txt";
            string value;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //Console.WriteLine(line); // Process each line here
                    string[] tokens = line.Split(new char[] { ',' }, 2);
                    if (tokens[0]==key)
                    {
                        return tokens[1];
                    }
                }
            }
            return null;
            //throw new notimplementedexception();
        }

        public void Save(string key, string value)
        {
            File.AppendAllText("dict.txt", key+","+value+Environment.NewLine);  
            //throw new NotImplementedException();
        }
    }
}
