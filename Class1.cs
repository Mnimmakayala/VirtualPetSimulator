/* Developer: Mahesh Nimmakayala
 * Date:31-05-2024
 * Description: Making an entertaining application to play with your pet is the purpose of this challenge. To determine your pet's level of health, contentment, and hunger through play, relaxation, and feeding */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VirtualPetStatusTracker
{
    public class Class1
    {


        public static void Main(string[] args)
        {
            //Declaring all the variables
            String[] types = { "Dog", "Cat", "Rabbit" };
            String setType, ipSetType, petName;
            int getType;
            int errCheck;

            //Input the pet details from the user
            Console.WriteLine("Please choose a type of pet: \n 1. Dog \n 2. Cat \n 3. Rabbit");
            ipSetType = Console.ReadLine();
            Console.WriteLine("User entered : " + ipSetType);
            getType = (Convert.ToInt32(ipSetType)) - 1;
            setType = types[getType];

            Console.WriteLine("What would you like to name your pet");
            petName = Console.ReadLine();
            Console.WriteLine("Entered Value: " + petName);
            Console.WriteLine("Welcome " + petName + "!" + " Let's play with your " + setType.ToLower() + ".");

            //Get the user option and call the respective methods
            CalculateStatus status = new CalculateStatus(petName, setType);

            bool userStatus = true;
            while (userStatus)
            {
                Console.WriteLine("Main Menu: \n 1. Feed " + petName + " \n 2. Play With " + petName + " \n 3. Let " + petName + " Rest \n 4. Check " + petName + "'s Status \n 5. Exit  ");
                String userResponse = Console.ReadLine();
                Console.WriteLine("User Value is " + userResponse);

                switch (Convert.ToInt32(userResponse))
                {
                    case 1:
                        status.Feed();
                        break;

                    case 2:
                        status.Play();
                        break;

                    case 3:
                        status.Rest();
                        break;

                    case 4:
                        status.CheckStatus();
                        break;

                    case 5:
                        Console.WriteLine("Thank you for playing with " + petName + "Goodbye!");
                        userStatus = false;
                        break;

                    default:
                        Console.WriteLine("Please insert a valid input value between 1 to 5.");
                        break;
                }

            }

        }


    }
}
