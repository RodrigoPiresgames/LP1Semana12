using System;

public static class Class1
{
    public static int HowManyOfThisType<T>(IEnumerable<object> items)
    {

        private int count;

        foreach (object o in items)
        {
            if ( o is T)
                count++;
        }

        return count++;
    }

}
