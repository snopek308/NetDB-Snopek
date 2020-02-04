using System;

namespace YourName
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //// display a literal value
            //Console.WriteLine("What is your name?");
            //// input a value and assign it to a string variable
            //string name = Console.ReadLine();
            //// display the string variable
            //Console.WriteLine("Hello, " + name);
            //Console.WriteLine("Hello, {0}", name);


            //anything that could be a problem, you can put in a try
            try
            {
                Console.WriteLine("Enter one number: ");
                var number1 = Console.ReadLine();
                Console.WriteLine("Enter a second number: ");
                var number2 = Console.ReadLine();

                int result = 0;
                var isValidx = int.TryParse(number1, out int x);
                var isValidy = int.TryParse(number2, out int y);
                
                if(isValidx && isValidy)
                {
                    result = x + y;
                }
                Console.WriteLine($"You answer is: {result}");

                //var x = Convert.ToInt32(number1);
                //int y = int.Parse(number2);
                //var result = x + y;



                //double x = 7.0;
                //double y = 0.0;
                //Console.WriteLine(x / y);

                //int z = 0;
                //int w = 5;
                //Console.WriteLine(w / z);
            }
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("You messed up");
            //    throw;
            //}
            //exception covers all problems, its a catch all
            catch (Exception)
            {
                //You wouldn't write the method in the catch
                //
                //Logger log = new Logger(filename);
                //Log.WriteToConsole(e.Message);

                //throw;
            }
            //this is always executed
            //important bc that's where you want to do clean-up
            finally
            {

            }
            

        }
    }
}
