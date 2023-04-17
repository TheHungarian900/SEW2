using System;

namespace _230309_ADT_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<User> users = new ArrayStack<User>(3);
            ArrayStack<string> names = new ArrayStack<string>(10);

            users.Push(new User("Adam", 100000));
            users.Push(new User("Eva", 100000));
            users.Push(new User("WasINed", 10));

            Console.WriteLine(users.Pop().Name);
            Console.WriteLine(users.Peek().Name);
            Console.WriteLine(users.Pop().Name);
            Console.WriteLine(users.Pop().Name);
            Console.WriteLine(users.IsEmpty());
        }
    }
}
