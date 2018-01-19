/*
 * Jan 18, 2018
 * William H Smith UMSL INFSY-6805 C# and .NET
 * 
 * This assignment was to take in from the user a radius of a circle and output
 * the diameter, area, and circomference of that circle. Must take in an integer
 * use floats for the rest and only use one variable.
 *
 */


using System;

namespace CircleAreaRadiusDiameter
{
    class Program
    {
        static void Main(string[] args)
        {


            //Title and intro
            Console.WriteLine("\n\n*** The Area, Diameter, and Circumference of a Circle *** \n");
            Console.WriteLine("* I also added input validation. * \n\n");
            Console.Write("Enter an integer (whole number, no decimals) for the Radius of a circle:  ");

            //Read in the number and trim just in case
            string Str = Console.ReadLine().Trim();

            Console.WriteLine("");  //Just to add a space

            //Where the magic happens 
            int Num;
            bool isNum = int.TryParse(Str, out Num);
            if (isNum)
            {
                //float rad = (float)Num;
                //float dia = rad * 2f;
                //float cir = dia * 3.14159f;
                //float area = (float)Math.Pow(rad, 2) * (float)Math.PI;
                //Console.WriteLine(dia);

                Console.WriteLine($"You entered a Radius of {Num}.\nResults:");

                // I think this is the cleanest but, it is store values as variables
                //Console.Write($"Diameter = {dia}, Area = {area}, The circumference = {cir}");

                // This one only uses one variable, the original int but it has the equations right there == messy
                //Console.Write($"Diameter = {(float)Num * 2f}, Area = {(float)Math.Pow((float)Num, 2) * (float)Math.PI}, Circumference = {((float)Num * 2f) * 3.14159f}");

                //this one is like the last except the equations are referenced afterwards. (object {0}, object2 {1}, object3 {2} => equations)
                Console.Write("Diameter = {0}, Area = {1}, Circumference = {2}",(float)Num * 2f, (float)Math.Pow((float)Num, 2) * (float)Math.PI, ((float)Num * 2f) * 3.14159f);

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
