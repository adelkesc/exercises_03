using System;
using System.Collections.Generic;

namespace Exercise_3
{
    public static class ListExtension
    {
        public static Random random = new Random();
       public static string RandomListItem(this String str)
       {
        //    the idea was to use random to pick an index in the list and return the value
           return str[random.Next(List<T>.Count)];
       }

       public static string ShuffleList(this String str)
       {
        //    nothing here for now
           return null;
       }
    }
}
// i'm not sure which types to use for a list extension because a list is generic, but extension methods can't be generic?