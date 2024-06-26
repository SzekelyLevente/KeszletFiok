using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KeszletFiok
{
    internal class Repository : IRepository
    {
        public Repository()
        {
            
        }

        public bool Contains(string key)
        {
            return Preferences.Default.ContainsKey(key);
        }

        public string Read(string key)
        {
            return Preferences.Default.Get<String>(key,null);
        }

        public void Update(string key, string value)
        {
            Preferences.Default.Set<String>(key,value);
        }
    }
}
