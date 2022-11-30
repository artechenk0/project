using System.Collections;
using System.Collections.Generic;

namespace LR2
{
    public class DoubleLinkedList<T> : IEnumerable<T>  // кольцевой двусвязный список
    {
        Item<T> head { get; set; }
        int count { get; set; }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        public void Add(T node)
        {
            Item<T> newNode = new Item<T>(node);

            if (head == null)
            {
                head = newNode;
                head.Next = newNode;
                head.Previous = newNode;
            }
            else
            {
                newNode.Previous = head.Previous;
                newNode.Next = head;
                head.Previous.Next = newNode;
                head.Previous = newNode;
            }
            count++;
        }
        // удаление элемента
        public bool Remove(T node)
        {
            Item<T> current = head;
            Item<T> removedItem = null;
            if (count == 0) return false;

            // поиск удаляемого узла
            do
            {
                if (current.Node.Equals(node))
                {
                    removedItem = current;
                    break;
                }
                current = current.Next;
            }
            while (current != head);

            if (removedItem != null)
            {
                // если удаляется единственный элемент списка
                if (count == 1)
                    head = null;
                else
                {
                    // если удаляется первый элемент
                    if (removedItem == head)
                    {
                        head = head.Next;
                    }
                    removedItem.Previous.Next = removedItem.Next;
                    removedItem.Next.Previous = removedItem.Previous;
                }
                count--;
                return true;
            }
            return false;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Item<T> current = head;
            if (current == null) return false;

            do
            {
                if (current.Node.Equals(data))
                    return true;

                current = current.Next;
            }
            while (current != head);

            return false;
        }
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Item<T> current = head;
            do
            {
                if (current != null)
                {
                    yield return current.Node;
                    current = current.Next;
                }
            }
            while (current != head);
        }
    }
}