namespace Essentials1.Indexers
{
    public class Indexer1<Type>
    {
        private Type[] array = new Type[100];

        public Type this[int i] 
        {
            get => array[i];

            set => array[i] = value;
        }

        public string MyToString(int i)
        {
            return array[i].ToString();
        }
    }
}
