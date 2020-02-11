using System;

namespace YourName
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // display a literal value
            Console.WriteLine("What is your name?");
            // input a value and assign it to a string variable
            string name = Console.ReadLine();
            // display the string variable
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Hello, {0}", name);


            Phone phone = new Phone();
            phone.Manufacturer = "Apple";
            phone.Number = 5489995;
            phone.Color = "Black";

            Phone anotherPhone = new Phone(123, "Android", "Black");
        }
    }


    public class Phone
    {
        //prop tab twice to get: public int MyProperty { get; set; }
        public int Number { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        //ctor table twice to create a constructor
        //methods need a return type
        //no return types on a constructor
        //can set values in the constructor
        //this is the default constructor
        public Phone()
        {
            Number = 1234;
            Manufacturer = "Apple";
            Color = "Silver";
        }

        //this is passing in property types
        public Phone(int number, string manu, string color)
        {
            Number = number;
            Manufacturer = manu;
            Color = color;
        }

    }

    class Ticket
    {
        //properties
        public int Number { get; set; }
        public string Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Priority { get; set; }

        //methods
        public Boolean isValid()
        {
            //Check ExpirationDate
            return true;
        }
    }

    class Ticket2
    {
        public void ReadFile() { }
        public void WriteFile() { }
        public void CheckInput() { }
        public void DisplayMenu() { }
        public void GetFileIndex(){}
    }

    public class MathHelper
    {
        public int AddNumbers(int x, int y)
        {
            return x + y;
        }
    }
}
