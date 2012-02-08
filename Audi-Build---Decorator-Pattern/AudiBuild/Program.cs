using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudiBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Audi myAudi = new AudiA420TFSIManualQuattro();

            Console.WriteLine("Welcome to the Audi A4 builder page!\n");
            while( !exit ){
                bool valid = false;
                while(!valid){
                    Console.WriteLine("Would you like a six-speed manual(0) or an automatic(1)?");
                    String modelInput = Console.ReadLine();
                    if( modelInput == "0" )
                    {
                        myAudi = new AudiA420TFSIManualQuattro();
                        valid = true;
                    } else if( modelInput == "1" )
                    {
                        valid = true;
                        myAudi = new AudiA420TFSIAutoQuattro();
                    } else
                    {
                        Console.WriteLine("INVALID INPUT");
                    }
                }

                Console.WriteLine("Would you like the 19” 5-arm-Rotor-design Titanium-finish alloy wheels - $1250.00? (y/n)");
                String wheelInput = Console.ReadLine();
                if( wheelInput == "y")
                    myAudi = new BigWheels( myAudi );
                else if( wheelInput == "n" )
                    Console.WriteLine();
                else
                    Console.WriteLine("Invalid input: stock wheels being used.");

                Console.WriteLine("Type the color you would like:\nMoonlight Blue Metallic\nMonsoon Gray Metallic\nIce Silver Metallic\nPhantom Balck Pearl Effect\nGlacier White Metallic\nMoonlight Blue Metallic");
                String colorChoice = Console.ReadLine();

                if (colorChoice == "Moonlight Blue Metallic" || colorChoice == "Monsoon Gray Metallic" ||
                    colorChoice == "Ice Silver Metallic" || colorChoice == "Phantom Balck Pearl Effect" ||
                    colorChoice == "Glacier White Metallic" || colorChoice == "Moonlight Blue Metallic")
                {
                    myAudi = new Color( myAudi, colorChoice );
                } else {
                    // deafult color, can be anything other than on of the colors above
                    myAudi = new Color( myAudi, "default");
                }

                Console.WriteLine("Would you like Audi's adaptive cruise control? (y/n)");
                String cruiseInput = Console.ReadLine();

                if (cruiseInput == "y")
                    myAudi = new CruiseControl(myAudi);


                Console.WriteLine("Would you like Audi's selective drive option? (y/n)");
                String driveInput = Console.ReadLine();

                if (driveInput == "y")
                    myAudi = new SelectiveDrive(myAudi);

                Console.WriteLine("Would you like to add Audi's sun shade option? (y/n)");
                String shadeInput = Console.ReadLine();

                if (shadeInput == "y")
                    myAudi = new SunShades(myAudi);

                Console.WriteLine(myAudi.getDescription() + "\nFinal Cost: " + myAudi.cost());     

                           


                Console.ReadLine();
            }
        }
    }
}
