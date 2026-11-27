using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Net.WebSockets;

namespace Advanced03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> ints = new List<int>();
            #region List
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //ints.Add(4);
            //ints.Add(5);


            //Helper.PrintCollection("Numbers", ints);
            //Console.WriteLine(ints.Count);
            //Console.WriteLine(ints[0]);
            //Console.WriteLine(ints[^1]);
            //ints.Insert(2, 5); //Right Shift
            //Console.WriteLine("After Update");
            //Helper.PrintCollection("Numbers", ints);
            //Console.WriteLine(ints.Remove(5));//left Shift
            //ints.RemoveAt(3);
            //Helper.PrintCollection("Numbers", ints);
            //Console.WriteLine(ints.Contains(1));
            //Console.WriteLine(ints.IndexOf(5));
            //Console.WriteLine(ints.IndexOf(4));
            //ints.Add(3);
            //ints.Add(3);
            //ints.Add(3);
            //Console.WriteLine(ints.LastIndexOf(3));
            //Console.WriteLine(ints.IndexOf(3,3));
            //Console.WriteLine(ints.IndexOf(3,2,3)); 
            #endregion

            #region Count&Capscity
            //List<int> numbers=new List<int>();

            //Console.WriteLine($"Count:{numbers.Count},capacity:{numbers.Capacity}");

            //for (int i = 0; i < 5; i++) { 

            //   numbers.Add(i);
            //   Console.WriteLine($"Count:{numbers.Count},capacity:{numbers.Capacity}");
            //}
            #endregion

            #region Methods
            //List<int> ints = [2, 4, 5, 7, 8, 4, 6, 8, 3];
            //Console.WriteLine($"Count:{ints.Count},capacity:{ints.Capacity}");

            //List<int> ints1 = ints.FindAll(x => x % 2 == 0);
            //Helper.PrintCollection<int>("ints01", ints1);
            //Console.WriteLine(ints.FindIndex(0, x => x % 2 == 1));
            //Console.WriteLine(ints.FindLast(x => x % 2 == 0));
            //Console.WriteLine(ints.FindLastIndex(x => x % 2 == 0));
            //Console.WriteLine(ints.Exists(x => x % 2 == 0));
            //ints.Sort();
            //Helper.PrintCollection<int>("numbers",ints);
            //ints.AddRange([11, 3, 4]);
            //Helper.PrintCollection("numbers", ints);
            //ints.RemoveAll(x=> x % 2 == 0);
            //Helper.PrintCollection<int>("numbers", ints);
            ////ints.RemoveRange(0, 4);
            //Helper.PrintCollection<int>("numbers", ints);
            //List<string> strings = ints.ConvertAll(x => $"{x} string");
            //Helper.PrintCollection<string>("numbers", strings);
            //ints.TrimExcess();
            //ints.EnsureCapacity(15);
            #endregion

            #region Dictionary
            //Dictionary<int, string> students = new Dictionary<int, string>()
            //{
            //    {101,"Mohamed" },
            //    {102,"Yahia" },
            //    {103,"Ahmed" }
            //};
            //students[104] = "Abdullah" ;//Add and Update
            //Console.WriteLine(students.TryAdd(104,"Abdo"));
            //Console.WriteLine(students[104]);
            ////Console.WriteLine(students[105]);
            //Console.WriteLine(students.ContainsKey(105));
            //if (students.ContainsKey(105))
            //{
            //    Console.WriteLine(students[105]);
            //}
            //if (students.TryGetValue(105, out string name))
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine(students.GetValueOrDefault(105,"! Exists"));

            //Dictionary<string, int> marks = new Dictionary<string, int>()
            //{
            //    {"Yahia",90 },
            //    {"Hamza",88 },
            //    {"Ahmed",70 }
            //};

            //foreach(var student in marks)
            //{
            //    Console.WriteLine($"{student.Key},{student.Value}");
            //}
            //foreach(var key in marks.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //foreach(var value in marks.Values)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine(marks.ContainsValue(60));
            //Dictionary<Student, int> students = new Dictionary<Student, int>();
            //students.Add(new Student() { Name = "Yahia", Age = 20 }, 90);
            ////students.Add(new Student() { Name = "Yahia", Age = 20 }, 88);

            //Student student = new Student() { Name = "Yahia", Age = 7 };
            //students[student] = 98;
            //Console.WriteLine($"{student.Name} Is Exists,{students.ContainsKey(student)}");

            //student.Name = "Hamza";
            //Console.WriteLine($"{student.Name} Is Exists,{students.ContainsKey(student)}");

            //Dictionary<StudentRecord, int> students = new Dictionary<StudentRecord, int>();
            //StudentRecord student = new StudentRecord("Yahia",20);

            //students[student] = 98;
            //Console.WriteLine($"{student.Name} Is Exists,{students.ContainsKey(student)}");


            //Console.WriteLine($"{student.Name} Is Exists,{students.ContainsKey(student)}");
            //HashSet<int> set = new HashSet<int>();
            //set.Add(1);
            //set.Add(2);
            //set.Add(3);
            //set.Add(4);
            //Console.WriteLine(set.Add(1));
            //Helper.PrintCollection<int>("Set", set);
            //Console.WriteLine(set.Contains(3));
            //List<int> duplicates = [1, 3, 2, 4, 3, 2, 4, 1, 2];
            //List<int> uniqe= duplicates.ToHashSet().ToList();
            //Helper.PrintCollection<int>("Duplicates", duplicates);
            //Helper.PrintCollection<int>("Unique", uniqe);
            //HashSet<int> A = [1, 2, 3, 4];
            //HashSet<int> B = [3, 4, 5, 6];
            //HashSet<int> union = new HashSet<int>(A);
            //union.UnionWith(B);
            //Helper.PrintCollection<int>("Union", union);

            //HashSet<int> intersect = new HashSet<int>(A);
            //intersect.IntersectWith(B);
            //Helper.PrintCollection<int>("intersect", intersect);

            //HashSet<int> except = new HashSet<int>(A);
            //except.ExceptWith(B);
            //Helper.PrintCollection<int>("except", except);

            //HashSet<int> sym = new HashSet<int>(A);
            //sym.SymmetricExceptWith(B);
            //Helper.PrintCollection("Sym", sym);

            //HashSet<int> c = [3, 4];
            //HashSet<int> D = [3, 4];

            //Console.WriteLine(c.IsSubsetOf(A));
            //Console.WriteLine(c.IsSubsetOf(B));
            //Console.WriteLine(A.IsSupersetOf(c));
            //Console.WriteLine(c.IsSupersetOf(A));
            //Console.WriteLine(B.IsSupersetOf(A));

            //Console.WriteLine(A.SetEquals(B));
            //Console.WriteLine(D.SetEquals(c));

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(10);
            //queue.Enqueue(12);
            //queue.Enqueue(13);

            ////Console.WriteLine(queue.Peek());
            ////Console.WriteLine(queue.Count);
            ////Console.WriteLine(queue.Dequeue());
            ////Console.WriteLine(queue.Count);

            //Console.WriteLine(queue.TryPeek(out int p));
            //Console.WriteLine(p);
            //Console.WriteLine(queue.TryPeek(out int dq));
            //Console.WriteLine(dq);

            Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.TryPeek(out int p));
            Console.WriteLine(p);
            Console.WriteLine(stack.TryPop(out int pop));
            Console.WriteLine(pop);
            Console.WriteLine(stack.Count);
                
            #endregion
        }

    }
}
