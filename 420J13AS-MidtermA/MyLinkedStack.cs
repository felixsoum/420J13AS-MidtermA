namespace _420J13AS_MidtermA
{
    class MyLinkedStack<T>
    {
        MyLinkedList<T> myLinkedList = new MyLinkedList<T>();

        public void Push(T value)
        {
            myLinkedList.InsertFirst(new MyLinkedListNode<T>(value));
        }

        public T Pop()
        {
            T result = myLinkedList.head.key;
            myLinkedList.DeleteFirst();
            return result;
        }

        public T Peek()
        {
            return myLinkedList.head.key;
        }

        public int Count()
        {
            int count = 0;
            MyLinkedListNode<T> node = myLinkedList.head;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            return count;
        }

        public void Reverse()
        {
            MyLinkedListNode<T> prevNode = null;
            MyLinkedListNode<T> nextNode = null;
            MyLinkedListNode<T> currentNode = myLinkedList.head;
            while (currentNode != null)
            {
                nextNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }
            myLinkedList.head = prevNode;
        }
    }
}
