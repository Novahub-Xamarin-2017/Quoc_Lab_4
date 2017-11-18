using System;

namespace ex_7
{
    public class Student : ICompare<Student>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Score { get; set; }

        public Student()
        {
        }

        public Student(string name, DateTime birthDate, int score)
        {
            Name = name;
            BirthDate = birthDate;
            Score = score;
        }

        public bool IsBigger(Student another) => this.Score > another.Score;

        public override string ToString()
            => $"Name : {Name}, BirthDate : {BirthDate}, Score : {Score}";
    }
}