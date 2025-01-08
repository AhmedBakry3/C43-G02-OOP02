namespace Assignment_Session_2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            Person[] persons = new Person[3];

            persons[0] = new Person("Ahmed", 22);
            persons[1] = new Person("Mohamed", 24);
            persons[2] = new Person("Mahmoud", 35);

            Console.WriteLine("Details of all persons:");
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

            #endregion


            #region MyRegion 2.Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            double x1, y1, x2, y2;
            bool isparsed;

            // Get the first point coordinates
            Console.WriteLine("Enter the coordinates of the first point:");
            do
            {
                Console.Write("X1: ");
                isparsed = double.TryParse(Console.ReadLine(), out x1);
                if (!isparsed)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for X1");
                }
            } while (!isparsed);

            do
            {
                Console.Write("Y1: ");
                isparsed = double.TryParse(Console.ReadLine(), out y1);
                if (!isparsed)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for Y1");
                }
            } while (!isparsed);

            // Create the first point
            Point point1 = new Point(x1, y1);

            // Get the second points coordinates
            Console.WriteLine("Enter the coordinates of the second point:");
            do
            {
                Console.Write("X2: ");
                isparsed = double.TryParse(Console.ReadLine(), out x2);
                if (!isparsed)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for X2");
                }
            } while (!isparsed);

            do
            {
                Console.Write("Y2: ");
                isparsed = double.TryParse(Console.ReadLine(), out y2);
                if (!isparsed)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for Y2");
                }
            } while (!isparsed);

            // Create the second point
            Point point2 = new Point(x2, y2);

            Console.Clear();

            double distance = Point.CalculateDistance(point1, point2);

            Console.WriteLine($"First point: {point1}");
            Console.WriteLine($"Second point: {point2}");
            Console.WriteLine($"The distance between the two points is: {distance}");

            #endregion

            #region 3.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            Person[] persons = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for Person {i + 1}:");

                string? name;
                while (true)
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    if (name?.Trim() == "")
                    {
                        Console.WriteLine("Name cannot be empty. Please enter a valid name");
                        continue; // Skip the rest of the loop and enter the name again untill a valid name entered
                    }

                    break; // If Valid name entered, break out of the loop
                }

                int age;
                bool isparsed;
                while (true)
                {
                    Console.Write("Age: ");
                    isparsed = int.TryParse(Console.ReadLine(), out age);
                    if (isparsed && age >= 0)
                    {
                        break; // If Valid age entered , break out of the loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid positive integer for age");
                    }
                }

                persons[i] = new Person(name, age);

                Console.WriteLine();
            }

            Person oldestPerson = Person.FindOldestPerson(persons);

            Console.WriteLine($"The oldest person is {oldestPerson.Name}, who is {oldestPerson.Age} years old.");

            #endregion

            #region 4.4.Create a struct named Rectangle that represents a rectangle with the following fields: width(type: double) height(type: double)
            //Implement encapsulation by making the fields private and provide public properties access and modify these values.Ensure the following conditions are met:
            //The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message.
            //Implement a public read-only property Area that calculates and returns the area of the rectangle(Area = width * height).
            //Implement a method DisplayInfo that prints the rectangle's dimensions and area.
            //Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.


            Rectangle rectangle = new Rectangle(10,5);

            //Set values for width and height

            rectangle.Width = 10;
            rectangle.Height = 5;

            // Display rectangle's information
            rectangle.DisplayInfo(); // Width: 10, Height: 5, Area: 50 , since they are postive Values , it will not be rejected by the setters

            // Try setting negative values
            rectangle.Width = -3;  // Width cannot be negative
            rectangle.Height = -7; // Height cannot be negative

            // Display rectangle's information with setting negtive values 
            rectangle.DisplayInfo(); // Width: 0, Height: 0, Area: 0 , since the negtive values rejected by the setters ,  the default values (0) set by the parameterless constructor will be displayed for width, height, and area.

            #endregion
        }
    }
}
