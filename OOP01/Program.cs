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

            #region 3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string seasonName = Console.ReadLine();

            //if (Enum.TryParse(seasonName ,true,out Season season) )
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring months: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer months: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn months: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter months: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season input.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season input.");
            //}
            #endregion

            #region 4.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //⮚	Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //Permissions userPermissions = Permissions.Read | Permissions.Write;
            //Console.WriteLine($"Current permissions: {userPermissions}");

            //// Add a permission
            //userPermissions |= Permissions.Delete;
            //Console.WriteLine($"Permissions after adding Delete: {userPermissions}");

            //// Remove a permission
            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine($"Permissions after removing Write: {userPermissions}");

            //// Check if a specific permission exists
            //bool hasWritePermission = userPermissions.HasFlag(Permissions.Write);
            //Console.WriteLine($"User has Write permission: {hasWritePermission}");

            #endregion

            

        }
    }
}
