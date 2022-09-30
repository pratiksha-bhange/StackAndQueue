using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues Programs");
            
            StackUsingLinkList stackUsingLinkList = new StackUsingLinkList();
            stackUsingLinkList.push(70);
            stackUsingLinkList.push(30);
            stackUsingLinkList.push(56);
            stackUsingLinkList.Display();
        }
    }
}
