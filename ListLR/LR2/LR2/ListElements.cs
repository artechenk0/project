    public class Item<T>
    {
    public Item(T node) => Node = node;
    public T Node { get; set; }
        public Item<T> Previous { get; set; }
        public Item<T> Next { get; set; }
    }
