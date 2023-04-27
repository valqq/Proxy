using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    abstract class Subject
    {
        
        public abstract void Create(string key, string value);

        public abstract void Read(string key);

        public abstract void Update(string key, string value);
        public abstract void Delete(string key);
    }
}
