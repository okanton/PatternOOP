using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern1
{
    class Os
    {
        private static Os instance;
        public string Name { get; set; }

        protected Os(string name)
        {
            this.Name = name;
        }

        public static Os GetInstance(string name)
        {
            if (instance == null)
                instance = new Os(name);
            return instance;
        }
    }
}
