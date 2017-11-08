/* Program ID: A2JayJangP2
 * Purpose: Assignment 2 Part 2
 * Revision History:
 * Jay Jang - Feb 12, 2017
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2JayJangP2
{
    class Program
    {

        //Sphere
        public static double calculateVolume(double inputDoubleRadius)
        {
            return 4.0d / 3.0d 
                * 3.14159 
                * Math.Pow(inputDoubleRadius, 3);
        }

        //Cylinder
        public static double calculateVolume(
            double inputDoubleRadius,
            double inputDoubleHeight)
        {
            return 3.14159 
                * Math.Pow(inputDoubleRadius, 2)
                * inputDoubleHeight;
        }

        //Rectangular prism
        public static double calculateVolume(double inputDoubleLength,
                                      double inputDoubleWidth,
                                      double inputDoubleHeight)
        {
            return inputDoubleLength
                * inputDoubleWidth
                * inputDoubleHeight;
        }

        public static string readInputString(string input)
        {
            string stringInput;
            do
            {
                Console.Write(input);
                stringInput = Console.ReadLine();
            } while (stringInput == "");
            return stringInput;
        }
        static void Main(string[] args)
        {
            //declaration variables
            string inputUserType;
            int inputIntUserType;
            string inputRadius;
            string inputHeight;
            string inputLength;
            string inputWidth;
            double result;
            double inputDoubleRadius;
            double inputDoubleHeight;
            double inputDoubleLength;
            double inputDoubleWidth;
            
            //initiolize variables
            inputUserType = "";
            inputIntUserType = 0;
            inputRadius = "";
            inputHeight = "";
            inputLength = "";
            inputWidth = "";
            result = 0;
            inputDoubleRadius = 0;
            inputDoubleHeight = 0;
            inputDoubleLength = 0;
            inputDoubleWidth = 0;

            //Ask choose the shape
            Console.WriteLine(
                "Please choose what type of shape you want to make:");
            Console.WriteLine("1. Sphere");
            Console.WriteLine("2. Cylinder");
            Console.WriteLine("3. Rectangular prism");
            inputUserType = readInputString("Answer is (1 or 2 or 3): ");
            inputIntUserType = int.Parse(inputUserType);

            if(inputIntUserType == 1)
            {
                Console.WriteLine("  You choose the type is Sphere");
            }
            else if(inputIntUserType ==2)
            {
                Console.WriteLine("  You choose the type is Cylinder");
            }
            else if(inputIntUserType ==3)
            {
                Console.WriteLine(
                    "  You choose the type is Rectangular prism");
            }
            else
            {
                Console.WriteLine(
               "An Error has occured"+
               "Please enter your information again.");
                return;
            }
            Console.WriteLine(""); // Line Change

            // Calculate volume of shape
            switch (inputIntUserType)
            {
                case 1:
                    inputRadius = readInputString(
                        "Plesae enter the radius of the sphere: ");
                    inputDoubleRadius = double.Parse(inputRadius);
                    if (inputDoubleRadius <= 0)
                    {
                        Console.WriteLine(
                        "An Error has occured"+
                        "Please enter your information again.");
                        return;
                    }
                    else
                    {                  
                    Console.WriteLine(
                        "  The radius of sphere is: "+ inputDoubleRadius);
                        result = calculateVolume(inputDoubleRadius);
                    }
                    Console.WriteLine(""); // Line Change
                    Console.WriteLine("===Your sphere volume is "
                                       + Math.Round(result, 4));

                    break;

                case 2:
                    inputRadius = readInputString(
                        "Plesae enter the radius of the cylinder: ");
                    inputDoubleRadius = double.Parse(inputRadius);
                    if (inputDoubleRadius <= 0)
                    {
                        Console.WriteLine(
                        "An Error has occured"+
                        "Please enter your information again.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(
                            "  The radius of cylinder is: "
                            + inputDoubleRadius);
                    }

                    inputHeight = readInputString(
                        "Plesae enter the height of the cylinder: ");
                    inputDoubleHeight = double.Parse(inputHeight);
                    if (inputDoubleHeight <= 0)
                    {
                        Console.WriteLine(
                        "An Error has occured"+
                        "Please enter your information again.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(
                            "  The height of cylinder is: "
                            + inputDoubleHeight);
                        result = calculateVolume(inputDoubleRadius,
                                                 inputDoubleHeight);
                    }
                    Console.WriteLine(""); // Line Change
                    Console.WriteLine("===Your cylinder volume is "
                                      + Math.Round(result, 4));

                    break;

                case 3:                 
                    inputLength = readInputString(
                        "Plesae enter the length of "+
                        "the rectangular prism: ");
                    inputDoubleLength = double.Parse(inputLength);
                    if (inputDoubleLength <= 0)
                    {
                        Console.WriteLine(
                        "An Error has occured"+
                        "Please enter your information again.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(
                            "  The length of rectangular prism is: "
                            + inputDoubleLength);
                    }


                    inputWidth = readInputString(
                        "Plesae enter the width of "+
                        "the rectangular prism: ");
                    inputDoubleWidth = double.Parse(inputWidth);
                    if (inputDoubleWidth <= 0)
                    {
                        Console.WriteLine(
                        "An Error has occured"+
                        "Please enter your information again.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(
                            "  The width of rectangular prism is: "
                            + inputDoubleWidth);
                    }

                    inputHeight = readInputString(
                        "Plesae enter the height of "+
                        "the rectangular prism: ");
                    inputDoubleHeight = double.Parse(inputHeight);
                    if (inputDoubleHeight <= 0)
                    {
                        Console.WriteLine(
                        "An Error has occured"+
                        "Please enter your information again.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(
                            "  The height of rectangular prism is: "
                            + inputDoubleHeight);
                    }
                    result = calculateVolume(inputDoubleLength,
                                             inputDoubleWidth,
                                             inputDoubleHeight);

                    Console.WriteLine(""); // Line Change
                    Console.WriteLine("===Your rectangular prism "+
                        "volume is " + Math.Round(result, 4));

                    break;
            }

            Console.WriteLine(""); // Line Change

        }
    }
}
