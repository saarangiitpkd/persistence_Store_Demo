using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersistedStorage
{
    public class InMemoryStorage : IStorage
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public string Get(string key)
        {
            //throw new NotImplementedException();
            if (dict.TryGetValue(key, out string value))
            {
                return value;
            }
            else
            {
                return null;
            }
            return null;
        }

        public void Save(string key, string value)
        {
            //throw new NotImplementedException();
            dict.Add(key, value);
        }
    }
}
