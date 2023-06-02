using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    public static class Checker
    {
        
        public static int HowManyOfThisType<T>(IEnumerable<object> items)
        {
            private int count = 0;

            foreach (object o in items)
            {
                if (o is T)
                    count++;
            }
            return count++;
        }
    }
}