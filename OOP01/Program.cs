namespace OOP01
{
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Season
    {
        Spring, Summer, Autumn, Winter
    }
    
    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //int numberOfDays = Enum.GetValues(typeof(WeekDays)).Length;
            //for (int i = 0; i < numberOfDays; i++) 
            //{
            //    WeekDays day = (WeekDays)i;
            //    Console.WriteLine(day);
            //}
            #endregion

            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] persons = new Person[3];
            //persons[0] = new Person("Alice", 30);
            //persons[1] = new Person("Bob", 25);
            //persons[2] = new Person("Charlie", 35);

            //foreach (var person in persons)
            //{
            //    person.Display();
            //}
            #endregion

           


        }
    }
}
