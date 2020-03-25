using System;

namespace Nterface
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Queue<int> a = new Queue<int>();
            a.Enqueue(0);
            a.Enqueue(10);
            a.Enqueue(20);

            Console.WriteLine(a.Dequeue());
            Console.WriteLine(a.Dequeue());
            Console.WriteLine(a.Dequeue());

            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(15);
            s.Push(20);


            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Family f = new Family();
            f.mother = new Human() { Name = "Mother", Age = 20 };
            f.father = new Human() { Name = "Father", Age = 20 };
            f.sister = new Human() { Name = "Sister", Age = 20 };
            f.grandmother = new Human() { Name = "grandMother", Age = 20 };
            f.grandfather = new Human() { Name = "grandFather", Age = 20 };
            f.brother = new Human() { Name = "Brother", Age = 20 };
            //f.sister = new Human() { Name = "Sister2", Age = 20 };
            //f.sister = new Human() { Name = "Siste3r", Age = 20 };
            //f.sister = new Human() { Name = "Sister4", Age = 20 };
        
            foreach (Human h in f)
            {
                Console.WriteLine(h.Name);
            }




        }
    }
}
