using System.Diagnostics;

namespace FoodShareCore.Utilities
{
    public class ListUtilities
    {
        public static List<T> Create<T>(List<T> collection, T data)
        {
            collection.Add(data);
            return collection;
        }

        public static List<T> Delete<T>(List<T> collection, int id)
        {
            collection.Remove(collection[id]);
            return collection;
        }

        public static List<T> Update<T>(List<T> collection, T data, int id)
        {
            collection[id] = data;
            return collection;
        }

        public static List<T> Read<T>(List<T> collection)
        {
            return collection;
        }

        public static T ReadByID<T>(List<T> collection, int id)
        {
            return collection[id];
        }

        public static bool SearchList<T>(List<T> collection, T target)
        {
            foreach (T item in collection)
            {
                if (ReferenceEquals(item, target)) return true;
            }
            return false;
        }
    }
}
