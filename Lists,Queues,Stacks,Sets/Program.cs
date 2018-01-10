using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Queues_Stacks_Sets
{

    class Program
    {
        static public void TestList()
        {
            Console.WriteLine("**********************************\nTest List\n");
            //add
            List<string> car = new List<string>  {
                "Honda", "Mercedez", "BMW"
            };
            //
            car.Add("Ford");
            car.AddRange(new[] { "Cuore", "Lexus", "Safari" });
            //
            car.Insert(0, "Polonez");
            car.InsertRange(0, new[] { "Fiat", "Seat" });
            //

            IEnumerator enumer = car.GetEnumerator();
            int i = 0;
            while (enumer.MoveNext())
            {
                Console.WriteLine("{0:}- {1:}", i, enumer.Current);
                i++;
            }
            //remove
            car.Remove("Mercedez");
            car.RemoveAt(2);
            car.RemoveRange(0, 2);
            car.RemoveAll(c => c.StartsWith("c"));
            Console.WriteLine("*************************");
            i = 0;
            enumer = car.GetEnumerator();
            while (enumer.MoveNext())
            {
                Console.WriteLine("{0:}- {1:}", i, enumer.Current);
                i++;
            }

        }

        static public void testLinkedList()
        {
            Console.WriteLine("**********************************\nTest LindekList\n");
            //add
            LinkedList<string> car = new LinkedList<string>();
            car.AddFirst("Ford");
            car.AddLast("Seat");
            car.AddAfter(car.First, "Fiat");
            car.AddAfter(car.First.Next, "Polonez");
            car.AddBefore(car.Last.Previous, "Opel");
            IEnumerator enume = car.GetEnumerator();
            while (enume.MoveNext())
                Console.Write(enume.Current+".");

            //remove
            car.Remove("Polonez");
            car.RemoveFirst();
            car.RemoveLast();
            Console.WriteLine("\n\n********************************\n");
            enume = car.GetEnumerator();
            while (enume.MoveNext())
                Console.Write(enume.Current + ".");
            Console.WriteLine("\n\n********************************\n");

            LinkedListNode<string> snode = car.Find("Fiat");
            car.Remove(snode);
            car.AddFirst(snode);
            enume = car.GetEnumerator();
            while (enume.MoveNext())
                Console.Write(enume.Current + ".");


        }
        static public void testQueue()
        {
            Console.WriteLine("**********************************\nTest Queue\n");
            Queue<string> car = new Queue<string>();

            car.Enqueue("Toyota");
            car.Enqueue("BMW");
            car.Enqueue("Seat");

            Console.WriteLine(car.Peek());
            Console.WriteLine(car.ElementAt(1));
            car.Dequeue();
            Console.WriteLine(car.Peek());
        }
        static public void testStack()
        {
            Console.WriteLine("**********************************\nTest Stack\n");
            Stack<string> cars = new Stack<string> { };

            cars.Push("Toyota");
            cars.Push("Honda");
            cars.Push("Suzuki");

            Console.WriteLine(cars.Count);
            Console.WriteLine(cars.Peek());
            cars.Pop();
            Console.WriteLine(cars.Peek());
            cars.Pop();
            Console.WriteLine(cars.Peek());

        }
        static public void testHaskSet()
        {
            HashSet<string> car = new HashSet<string> { "Toyota", "Honda", "Audi" };
            car.Add("Toyota");//no duplicated

            IEnumerator enumer = car.GetEnumerator();
            while (enumer.MoveNext())
            {
                Console.WriteLine(enumer.Current);
            }

            Console.WriteLine("\n*******************\n");
            //Conitain methode is extremely quick   
            Console.WriteLine(car.Contains("Honda"));
            Console.WriteLine(car.Contains("Fiat"));

            string[] arr = { "Toyota", "Honda" ,"Audi"};
            //compares the collection with collection of elements passed
            car.IntersectWith(arr);

            enumer = car.GetEnumerator();
            Console.WriteLine("\n*******************\n");
            while (enumer.MoveNext())
                Console.WriteLine(enumer.Current);
            Console.WriteLine("\n*******************\n");
            arr = new string[] {"Polonez" };
            //return both collection
            car.UnionWith(arr);

            enumer = car.GetEnumerator();
            while (enumer.MoveNext())
                Console.WriteLine(enumer.Current);

            Console.WriteLine("\n*******************\n");
            car.ExceptWith(arr);
            enumer = car.GetEnumerator();
            while (enumer.MoveNext())
                Console.WriteLine(enumer.Current);


            Console.WriteLine("\n*******************\n");
            arr = new string[] { "Audi" };
            car.SymmetricExceptWith(arr);
            enumer = car.GetEnumerator();
            while (enumer.MoveNext())
                Console.WriteLine(enumer.Current);

        }



        static public void testOrderSet()
        {
            SortedSet<string> cars = new SortedSet<string> { "Toyota", "Audi", "Honda", "Camery" };

            foreach (string s in cars)
            {
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            //TestList();
            //testLinkedList();
            //testQueue();
            //testStack();
            testHaskSet();
            Console.Read();
        }
    }
}
