using System;

namespace _420J13AS_MidtermA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q6.a)
            int[] inputA = new int[] { 3, 7, 4, 2, 8, 5, 7, 1, 6, 9, 7, 0 };
            DescendingInsertionSort(inputA);
            Console.WriteLine(string.Join(", ", inputA));

            //Q6.b)
            int[] inputB = new int[] { 3, 7, 4, 2, 8, 5, 7, 1, 6, 9, 7, 0 };
            LuckySort(inputB, 7);
            Console.WriteLine(string.Join(", ", inputB));
            LuckySort(inputB, 8);
            Console.WriteLine(string.Join(", ", inputB));

            //Q7.a)
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            myLinkedList.InsertFirst(new MyLinkedListNode<int>(1));
            myLinkedList.InsertFirst(new MyLinkedListNode<int>(2));
            myLinkedList.InsertFirst(new MyLinkedListNode<int>(3));
            Console.WriteLine(myLinkedList);
            myLinkedList.DeleteFirst();
            Console.WriteLine(myLinkedList);

            //Q7.b)
            MyLinkedStack<string> myLinkedStack = new MyLinkedStack<string>();
            myLinkedStack.Push("Button");
            myLinkedStack.Push("Mutton");
            myLinkedStack.Push("Sutton");
            string output = "";
            output += myLinkedStack.Count() + ", ";
            output += myLinkedStack.Pop() + ", ";
            output += myLinkedStack.Peek() + ", ";
            output += myLinkedStack.Pop() + ", ";
            output += myLinkedStack.Pop() + ", ";
            output += myLinkedStack.Count() + ", ";
            Console.WriteLine(output);
        }

        static void DescendingInsertionSort(int[] array)
        {
            //TODO
        }

        static void LuckySort(int[] array, int luckyNumber)
        {
            //TODO
        }
    }
}
