using System;

namespace ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = GetInputStudents();
            students = Sort(students);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }

        private static Student[] GetInputStudents()
        {
            var students = new Student[3];
            students[0] = new Student("Invoker", DateTime.Parse("02/04/1997"), 95);
            students[1] = new Student("Anti Mage", DateTime.Parse("02/05/1997"), 98);
            students[2] = new Student("Tinker", DateTime.Parse("02/06/1997"), 94);
            return students;
        }

        static void Swap<T>(ref T valueA, ref T valueB)
        {
            var tempt = valueA;
            valueA = valueB;
            valueB = tempt;
        }

        static T[] Sort<T>(T[] list) where T:ICompare<T>
        {
            for (var i = 0; i < list.Length -1; i++)
            {
                for (var j = i+1; j < list.Length; j++)
                {
                    if (list[i].IsBigger(list[j]))
                    {
                        Swap(ref list[i], ref list[j]);
                    }
                }
            }
            return list;
        }
    }
}
