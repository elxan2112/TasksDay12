using System;
using System.Collections.Specialized;
using System.Xml.Schema;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input info about first student");//students
            Console.Write("Surname: ");
            string sur = Input.WordInput();
            Console.Write("Course: ");
            int cour = Input.CourseInput();
            Console.Write("Number of record book: ");
            int srb = Input.NumsInput();
            Student stud = new Student(sur, cour, srb);
            stud.Print();
            Console.WriteLine("Нажмите любую клавишу!");
            Console.ReadKey();
            Console.WriteLine("Пробуем метод ToString!!!");
            Console.WriteLine(sur.ToString());
            Console.WriteLine(cour.ToString());
            Console.WriteLine(srb.ToString());
            Console.WriteLine(stud.ToString());
            Console.WriteLine("Нажмите любую клавишу!");
            Console.ReadKey();
            Console.WriteLine("Input info about second student");//students
            Console.WriteLine("Фамилии первого и второго сдудента одинаковы");
            Console.Write("Course: ");
            cour = Input.CourseInput();
            Console.Write("Number of record book: ");
            srb = Input.NumsInput();
            Student stud1 = new Student(sur, cour, srb);
            stud.Surname = stud1.Surname;
            stud1.Print();
            Console.WriteLine("Нажмите любую клавишу!");
            Console.ReadKey();
            Console.WriteLine("Пробуем метод ToString!!!");
            Console.WriteLine(sur.ToString());
            Console.WriteLine(cour.ToString());
            Console.WriteLine(srb.ToString());
            Console.WriteLine(stud.ToString());
            Console.WriteLine("Нажмите любую клавишу!");
            Console.ReadKey();
            Console.WriteLine("далее показаны хаш коды фамилий первого и второго студента соответственно!!!(Переопределенный метод!!!)");
            Console.WriteLine(stud.GetHashCode());
            Console.WriteLine(stud1.GetHashCode());
            Console.WriteLine("Нажмите любую клавишу!");
            Console.ReadKey();
            Console.WriteLine("А это тип даного объекта");
            Console.WriteLine(stud1.GetType());
            Console.WriteLine("Нажмите любую клавишу!");
            Console.ReadKey();
            Console.WriteLine("Input info about first aspirant");//aspirants
            Console.Write("Surname: ");
            sur = Input.WordInput();
            Console.Write("Course: ");
            cour = Input.CourseInput();
            Console.Write("Number of record book: ");
            srb = Input.NumsInput();
            Console.Write("Topic: ");
            string topic = Input.WordInput();
            Aspirant asp = new Aspirant(sur, cour, srb, topic);
            asp.Print();
            Console.WriteLine("Нажмите любую клавишу!");
            Console.ReadKey();
            Console.WriteLine("Input info about second aspirant");//aspirants
            Console.WriteLine("Фамилии первого и второго аспиранта одинаковые");
            Console.Write("Course: ");
            cour = Input.CourseInput();
            Console.Write("Number of record book: ");
            srb = Input.NumsInput();
            Console.Write("Topic: ");
            topic = Input.WordInput();
            Aspirant asp1 = new Aspirant(sur, cour, srb, topic);
            asp.Surname = asp1.Surname;
            asp.Print();
            Console.WriteLine("Далее показаны хаш коды фамилий первого и второго аспиранта соответственно!!!(Метод не переопределён!!!)");
            Console.WriteLine("Нажмите любую клавишу!");
            Console.ReadKey();
            Console.WriteLine(asp.GetHashCode());
            Console.WriteLine(asp1.GetHashCode());
            Console.ReadKey();
        }
    }
    abstract class People
    {
        public string Surname { get; set; }
        public int Course { get; set; }
        public int StudentsRecordBook { get; set; }
        public People()
        {

        }
        public People(string surname, int course, int srb)
        {
            Surname = surname;
            Course = course;
            StudentsRecordBook = srb;
        }
        public abstract void Print();
    }
    class Student : People
    {
        public Student(string surname, int course, int srb): base(surname, course, srb)
        {
            Surname = surname;
            Course = course;
            StudentsRecordBook = srb;
        }
        public override int GetHashCode()
        {
            return Surname.GetHashCode();
        }

        public override void Print()
        {
            Console.WriteLine($"{Surname}, {Course}, {StudentsRecordBook}");
        }
    }
    class Aspirant : People
    {
        public string Topic { get; set; }
        public Aspirant(string surname, int course, int srb, string topic) : base(surname, course, srb)
        {
            Topic = topic;
        }
        public override void Print()
        {
            Console.WriteLine($"{Surname}, {Course}, {StudentsRecordBook}, {Topic}");
        }
    }
    class Input
    {
        public static string WordInput()
        {
            string word = Console.ReadLine();
            return word;
        }
        public static int CourseInput()
        {
            int nums = 0;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if (nums > 0 && nums < 5)
                    return nums;
                else
                {
                    Console.WriteLine("Введите число от 1 до 4");
                    return CourseInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return CourseInput();
            }
        }
        public static int NumsInput()
        {
            int nums = 0;

            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if (nums > 0)
                    return nums;
                else
                {
                    Console.WriteLine("Введите положительное число!");
                    return NumsInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return NumsInput();
            }
        }
    }
}
