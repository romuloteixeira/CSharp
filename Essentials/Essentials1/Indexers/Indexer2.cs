using System;

namespace Essentials1.Indexers
{
    public class Indexer2<Type>
    {
        Type[] array = new Type[100];
        int nextIndex = 0;

        public Type this[int i] => array[i];

        public void Add(Type value)
        {
            // Fail fast implementation
            if (nextIndex >= array.Length)
            {
                throw new IndexOutOfRangeException($"The collection can hold only {array.Length} elements.");
            }

            array[nextIndex++] = value;
        }
    }
}
