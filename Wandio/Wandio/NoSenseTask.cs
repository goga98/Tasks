using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wandio
{
    public static class NoSenseTask
    {
        public static T ThisDoesntMakeAnySense<T>(this IEnumerable<T> list, Predicate<T> predicate, Func<T> newrecord)
        {            

            if (list == null)
            {
                throw new ArgumentException();
            }
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    return default;
                }
            }
            return newrecord();
        }
    }
}
