using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton uniqueInstance;
        private string singletonData = string.Empty;

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Singleton();
            
            return uniqueInstance;
        }
    }
}
