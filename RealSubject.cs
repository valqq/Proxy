using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class RealSubject : Subject
    {
        Dictionary<string, string> dictionary;

        public RealSubject()
        {
            dictionary = new Dictionary<string, string>();
            dictionary.Add("TestKey", "TestValue");
        }

        public override void Create(string key, string value)
        {
            this.dictionary.Add(key, value);
        }

        public override string Read(string key)
        {
            return this.dictionary[key];
        }

        public override bool Update(string key, string value)
        {
            if (this.dictionary.ContainsKey(key) && this.dictionary.ContainsValue(value))
            {
                this.dictionary[key] = value;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Delete(string key)
        {
            return this.dictionary.Remove(key);
        }
    }
}
