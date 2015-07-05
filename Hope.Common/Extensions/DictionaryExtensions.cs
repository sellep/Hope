using System;
using System.Collections.Generic;

namespace Hope.Common.Extensions
{

    public static class DictionaryExtensions
    {

        public static T SafeGet<I, T>(this Dictionary<I, T> target, I i)
        {
            if (!target.ContainsKey(i))
            {
                T t = Activator.CreateInstance<T>();
                target.Add(i, t);
                return t;
            }

            return target[i];
        }
    }
}
