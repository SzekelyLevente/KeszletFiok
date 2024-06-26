using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszletFiok
{
    internal class Logic : Ilogic
    {
        private IRepository repository;

        public Logic(IRepository repository)
        {
            this.repository = repository;
        }
        public bool Contains(string key)
        {
            return repository.Contains(key);
        }

        public string Read(string key)
        {
            return repository.Read(key);
        }

        public void Update(string key, string value)
        {
            if(value.Length!=12 && key=="firstStorage" && key=="account")
            {
                throw new Exception("A beolvasott érték nem 12 karakter hosszú!");
            }
            repository.Update(key, value);
        }
    }
}
