/* Developer: Mahesh Nimmakayala
 * Date:31-05-2024
 * Description: Used for analysing the pet's happiness, health, hunger*/


using System;
using System.Threading;
using System.Xml.Linq;
namespace VirtualPetStatusTracker
{

    public class CalculateStatus
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }


        // Passing the pet details and initializing the hunger, happiness and health
        public CalculateStatus(string petName, string petType)
        {
            Name = petName;
            Type = petType;
            Hunger = 5;
            Happiness = 5;
            Health = 5;

        }


        // Feeding the pet which will increase the health and decrease the hunger
        public void Feed()
        {

            // Check the range of health and happiness is within the limit
            Hunger = Math.Max(1, Math.Min(10, Hunger));

            if (Hunger == 1)
            {
                Console.WriteLine($"{Name} is fully fed. Perform other actions.\nHunger decreased to {Hunger} and health increased to {Health}.");
            }
            else
            {
                Hunger -= 2;
                Health += 1;

                Console.WriteLine($"{Name} fed. Hunger decreased to {Hunger} and health increased to {Health}.");
            }
        }


        // Playing with the pet which will increase the happiness and increase the hunger
        public void Play()
        {

            // Check the range of health and happiness is within the limit
            Happiness = Math.Min(10, Happiness);
            Hunger = Math.Min(10, Hunger);

            //Verify the happiness and hunger is within the range
            if (Happiness == 10 || Hunger == 10)
            {
                Console.WriteLine($"{Name} has played completely. Perform other actions.\nHappiness increased to {Happiness} and hunger increased to {Hunger}.");
            }
            else
            {
                Happiness += 2;
                Hunger += 1;

                Console.WriteLine($"{Name} had fun playing. Happiness increased to {Happiness} and hunger increased slightly to {Hunger}.");
            }
        }


        // Resting the pet which will increase the health and decrease the hunger
        public void Rest()
        {

            // Check the range of health and happiness is within the limit
            Health = Math.Min(10, Health);
            Happiness = Math.Max(1, Math.Min(10, Happiness));

            if (Health == 10 || Happiness == 10)
            {
                Console.WriteLine($"{Name} is rested completely. Perform other actions. \nHealth is {Health} and happiness is {Happiness}.");
            }
            else
            {
                Health += 2;
                Happiness -= 1;

                Console.WriteLine($"{Name} rested. Health improved to {Health} but decreased slightly in happiness to {Happiness}.");
            }
        }


  

    // Display the final calculated hunger, happiness and health
    public void CheckStatus()
    {
        Console.WriteLine($"Please find the status of {Name} ({Type}) below: ");
        Console.WriteLine($"Hunger: {Hunger} \nHappiness: {Happiness} \nHealth: {Health}");



    }
    }

}
//}
