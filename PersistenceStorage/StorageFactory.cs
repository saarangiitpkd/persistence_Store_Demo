using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistedStorage
{
    public class Factory 
    { 
        public static IStorage StorageFactory ()
        {
            if (File.Exists("dict.txt"))
            {
                return new TextFileStorage();
            }
            else
            {
                return new InMemoryStorage();
            }
        }
    }
}
