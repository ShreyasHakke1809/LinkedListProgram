﻿namespace DSLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            Console.WriteLine("Please choose an option");
            Console.WriteLine("\n1.Create simple linked list \n2.Add element at first position\n3.Linked list by Appending\n4.Ability to Insert element\n5.Delete first element\n6.Delete last element\n7.Search linked list to find node eith value 30");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    customLinkedList.AddLast(56);
                    customLinkedList.AddLast(30);
                    customLinkedList.AddLast(70);
                    customLinkedList.Display();
                    break;
                case 2:
                    customLinkedList.AddFirst(70);
                    customLinkedList.AddFirst(30);
                    customLinkedList.AddFirst(56);
                    customLinkedList.Display();
                    break;
                case 3:
                    customLinkedList.Append(56);
                    customLinkedList.Append(30);
                    customLinkedList.Append(70);
                    customLinkedList.Display();
                    break;
                case 4:
                    customLinkedList.Append(56);
                    customLinkedList.Append(70);
                    customLinkedList.Insert(1, 30);
                    customLinkedList.Display();
                    break;
                case 5:
                    customLinkedList.Append(56);
                    customLinkedList.Append(70);
                    customLinkedList.Insert(1, 30);
                    customLinkedList.Display();
                    customLinkedList.DeleteFirst();
                    customLinkedList.Display();
                    break;
                case 6:
                    customLinkedList.Append(56);
                    customLinkedList.Append(70);
                    customLinkedList.Insert(1, 30);
                    customLinkedList.Display();
                    customLinkedList.DeleteLast();
                    customLinkedList.Display();
                    break;
                case 7:
                    customLinkedList.Append(56);
                    customLinkedList.Append(70);
                    customLinkedList.Insert(1, 30);
                    customLinkedList.Display();
                    customLinkedList.SearchVaue(30);
                    break;
                case 8:
                    customLinkedList.Append(56);
                    customLinkedList.Append(30);
                    customLinkedList.Append(70);
                    customLinkedList.Display();
                    customLinkedList.InsertAfter(30, 40);
                    customLinkedList.Display();
                    break;
                case 9:

                    customLinkedList.Append(56);
                    customLinkedList.Append(30);
                    customLinkedList.Append(70);
                    customLinkedList.InsertAfter(30, 40);
                    customLinkedList.Display();
                    customLinkedList.DeleteParticularElement(40);
                    customLinkedList.Display();
                    break;
                case 10:
                    customLinkedList.OrderedLinkedlist(56);
                    customLinkedList.OrderedLinkedlist(30);
                    customLinkedList.OrderedLinkedlist(40);
                    customLinkedList.OrderedLinkedlist(70);
                    customLinkedList.Display();
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }
        }
    }
}