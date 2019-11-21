using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Library_Classes;
namespace App
{
    public class UserCollection : IEnumerable, IEnumerator
    {
        Trading_Establishment[] studentsArray;
        int position = -1;
        int i = 0;
        public UserCollection(int N)
        {
            studentsArray = new Trading_Establishment[N];
        }
        public void Add(Trading_Establishment obj)
        {
            studentsArray[i] = obj;
            i++;
        }
        public bool MoveNext()
        {
            if (position < studentsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get { return studentsArray[position]; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
        public void Sorts()
        {
            Array.Sort(studentsArray);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = 500000;
            Random rn = new Random();
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            Stopwatch sw3 = new Stopwatch();
            Stopwatch sw4 = new Stopwatch();
            Trading_Establishment[] Arr1 = new Trading_Establishment[N];            // массив
            List<Trading_Establishment> Arr2 = new List<Trading_Establishment>(N);  // типизированная коллекция
            ArrayList Arr3 = new ArrayList(N);                                      // не типизированная колллекция
            UserCollection Arr4 = new UserCollection(N);                            // пользовательская коллекция
            for (int a = 0; a < N; a++)
            {
                int house = rn.Next(1, 3);
                switch (house)
                {
                    case 1:
                        Arr1[a] = new Supermarket();
                        Arr2.Add(new Supermarket());
                        Arr3.Add(new Supermarket());
                        Arr4.Add(new Supermarket());
                        break;
                    case 2:
                        Arr1[a] = new Stall();
                        Arr2.Add(new Stall());
                        Arr3.Add(new Stall());
                        Arr4.Add(new Stall());
                        break;
                }
            }
            sw1.Start();
            Array.Sort(Arr1);
            sw1.Stop();

            sw2.Start();
            Arr2.Sort();
            sw2.Stop();

            sw3.Start();
            Arr3.Sort();
            sw3.Stop();

            sw4.Start();
            Arr4.Sorts();
            sw4.Stop();

            Console.WriteLine($"Время на сортировку обычного массива -> {sw1.Elapsed}");
            Console.WriteLine($"Время на сортировку типизированной коллекции -> {sw2.Elapsed}");
            Console.WriteLine($"Время на сортировку не типизированной коллекции -> {sw3.Elapsed}");
            Console.WriteLine($"Время на сортировку пользовательской коллекции -> {sw4.Elapsed}");
            Console.ReadKey();
        }
    }
}