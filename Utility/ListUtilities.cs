using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class ListUtilities
    {
        public static List<T> Create<T>(List<T> collection, T data)
        {
            collection.Add(data);
            return collection;
        }

        public static List<T> Delete<T>(List<T> collection, int idx)
        {
            collection.Remove(collection[idx]);
            return collection;
        }

        public static List<T> Update<T>(List<T> collection, T data, int index)
        {
            collection[index] = data;
            return collection;
        }

        public static IEnumerable<T> Read<T>(List<T> collection)
        {
            return collection;
        }

        public static T ReadByID<T>(List<T> collection, int id)
        {
            return collection[id];
        }
    }
}
