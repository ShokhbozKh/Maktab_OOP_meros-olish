using System.Diagnostics.CodeAnalysis;

namespace oop_Vazifa_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to School!");

            Student student = new Student();
            student.Marks = new int[] { 3, 4, 5, 5, 5, 4, 45 };
            student.DisplayInfo();
            Console.WriteLine();

            Xodim xodim = new Xodim();
            Console.WriteLine(xodim.FullName);
            Console.WriteLine();

            Teacher teacher = new Teacher();
            teacher.DisplayInfo();


        }
    }
    class Student:AllPeople
    { 
        public int AverageGrade { get; set; }
        public int[] Marks { get; set; }

        public Student()
        {
            AverageGrade = 0;
            
        }
        public int UrtachaBaho(int[] Mark)
        {
            int sum = 0;
            foreach (int i in Mark)
            {
                sum += i;
            }
            return  (sum)/Mark.Length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nFullName: {FullName} \nPhoneNumber:{PhoneNumber} \nO'rtacha Baho:{UrtachaBaho}");

        }
    }
    class Xodim:AllPeople
    {
        public long Salary { get; set; }
        public Xodim()
        {
            Salary = 4_500_000;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nFullName: {FullName} \nPhoneNumber:{PhoneNumber} \nO'rtacha Baho:{Salary}");
        }
        public int CalculateTax()
        {
            float result;
            result = (Salary / 100) * 13;
            return (int)result;
        }
    }
    class Teacher:AllPeople
    {
        public long HourlyRate { get; set; }// soatiga qancha olishi
        public Teacher() 
        { 
            HourlyRate = 200_000;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nFullName: {FullName} \nPhoneNumber:{PhoneNumber} \nKunlik:{HourlyRate}");
            Console.WriteLine($"Oylik: {HourlyRate*24}");
        }
    }
    class AllPeople
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public long PhoneNumber { get; set; }
        public AllPeople()
        {
            Id= 0;
            FullName = "Test Test";
            PhoneNumber = 99_718_47_60;
        }

    }
}