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


    struct Point
    {
        public double X;
        public double Y;
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point p)
        {
            double deltaX = p.X - X;
            double deltaY = p.Y - Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
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

            #region 5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("Enter a color name (Red, Green, Blue): ");
            //string inputColor = Console.ReadLine();

            //if (Enum.TryParse(inputColor, true, out Colors color))
            //{
            //    if (color == Colors.Red || color == Colors.Blue || color == Colors.Green )
            //    {
            //        Console.WriteLine($"'{inputColor}' is a primary color.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"'{inputColor}' is not a primary color.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"'{inputColor}' is not a valid color.");
            //}
            #endregion

            #region 6- Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter the X coordinate for the first point1 (X Y):");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate for the first point1 (X Y):");
            //double y1 = double.Parse(Console.ReadLine());
            //Point point1 = new Point(x1, y1);

            //Console.WriteLine("Enter the X coordinate for the first point2 (X Y):");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate for the first point2 (X Y):");
            //double y2 = double.Parse(Console.ReadLine());
            //Point point2 = new Point(x2, y2);

            //double distance = point1.DistanceTo(point2);
            //Console.WriteLine($"The distance between the two points is: {distance}");
            #endregion

            




        }
    }
}
