namespace _420J13AS_MidtermA
{
    class MyLinkedList<T>
    {
        public MyLinkedListNode<T> head;

        public void InsertFirst(MyLinkedListNode<T> x)
        {
            //TODO
        }

        public void DeleteFirst()
        {
            //TODO
        }

        public override string ToString()
        {
            string print = "";
            MyLinkedListNode<T> x = head;
            while (x != null)
            {
                print += x.key + ", ";
                x = x.next;
            }
            return print;
        }
    }
}
