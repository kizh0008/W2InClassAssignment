using System; 
namespace W2InClassAssignments2

{
    // Exercise 1 & 2
    class Book
    {
        public string Title;
        public string Author;
        public int YearPublished;

        public Book(string title, string author, int yearPublished)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year Published: {YearPublished}");
        }
    }

    // Exercise 3 & 4
    class Student
    {
        private string name;
        private int grade;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
            }
        }

        public bool IsPassing()
        {
            return grade >= 50;
        }
    }

    // Exercise 5
    class Engine
    {
        public int HorsePower { get; set; }

        public Engine(int hp)
        {
            HorsePower = hp;
        }
    }

    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public void Describe()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine Horsepower: {Engine.HorsePower}");
        }
    }

    // Exercise 6
    class StringUtils
    {
        public static int CountVowels(string input)
        {
            int count = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c))
                    count++;
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            var book = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
            book.DisplayInfo();

            Console.WriteLine("\n---");

            
            var student = new Student { Name = "Adhithyan", Grade = 85 };
            Console.WriteLine($"Student: {student.Name}, Grade: {student.Grade}, Passing: {student.IsPassing()}");

            student.Grade = 40;
            Console.WriteLine($"Student: {student.Name}, New Grade: {student.Grade}, Passing: {student.IsPassing()}");

            Console.WriteLine("\n---");

            
            var engine = new Engine(450);
            var car = new Car("Mustang", engine);
            car.Describe();

            Console.WriteLine("\n---");

            
            Console.WriteLine(StringUtils.CountVowels("Hello World"));        
            Console.WriteLine(StringUtils.CountVowels("Apples ARE awesome"));
        }
    }
}
