using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_sep_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(10);

            list.Add(50);

            list.Add("abhay");
            list.Add(90.98);

            list.Insert(1, 45);

            ////Console.WriteLine(" --- ");
            //Console.WriteLine(list.LastIndexOf(10));
            //Console.WriteLine(" --- ");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Clear();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}




            // Stack
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(105);

            stack.Push(160);

            stack.Push(170);

            stack.Push(190);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //stack.Pop();
            //Console.WriteLine("---------");     

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------");

            //Console.WriteLine(stack.Peek());







            //Queue

            Queue queue = new Queue();
            queue.Enqueue(45);
            queue.Enqueue(445);

            queue.Enqueue(453);

            //queue.Enqueue(458);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            //queue.Dequeue();

            //Console.WriteLine("------");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(queue.Peek());



            //Hashtable

            Hashtable ht = new Hashtable();
            ht.Add(1, "IND");
            ht.Add(2, "SRI");
            ht.Add(87, "Ban");
            ht.Add(6, "AUS");
            ht.Add(3, "FR");


            ht.Remove(2);

            //foreach (DictionaryEntry d in ht)
            //{
            //    Console.WriteLine($"{d.Key}    {d.Value}");

            //}


            Team team = new Team();

            //foreach (var p in team)
            //{
            //    Console.WriteLine(p);

            //}


            Player p1 = new Player(10000, "Rohit");
            Player p2 = new Player(12000, "Virat");
            Player p3 = new Player(14000, "Sachin");

            int result = p2.CompareTo(p3);

            if(result == 1)
            {
                Console.WriteLine("Virat runs are more than Sachin");
            }
            else
            {
                Console.WriteLine("Virat runs are less than Sachin");
            }

            
           

           
            







        }
    }
}
