using System;
using System.Collections;

namespace deliverable_two
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Hello user, what are you in the mood for?");
                Console.WriteLine("Here are your options");
                Console.WriteLine("1) Action");
                Console.WriteLine("2) Chilling");
                Console.WriteLine("3) Danger");
                Console.WriteLine("4) Skydiving");

                int mood = Convert.ToInt32(Console.ReadLine());
                if (mood == 1)
                {
                Console.WriteLine("action");
                }
                else if (mood == 2)
                {
                Console.WriteLine("chilling");
                }
                 else if (mood == 2)
                {
                Console.WriteLine("danger");
                }
                else if (mood == 3)
                {
                Console.WriteLine("good food");
                }

                string go = "You should go";

                Console.WriteLine("Enter option :");
                   int activity = Convert.ToInt32(Console.ReadLine());
                if (activity == 1)
                    Console.WriteLine(go + " stock car racing");
                else if (activity == 2)
                    Console.WriteLine(go + " hiking");
                else if (activity == 3)
                    Console.WriteLine(go + " skydiving");
                else if (activity == 4)
                    Console.WriteLine(go + " to Taco Bell");


                string travel = "You should travel in ";
                string trl1 = "sneakers";
                string trl2 = "a sedan";
                string trl3 = "a Volkswagen bus";
                string trl4 = "an airplane";
;
                Console.WriteLine("How many people are you bringing with you?");

               int  destination;
                destination = Convert.ToInt32(Console.ReadLine());
                if (destination == 0)
                {
                    Console.WriteLine(travel + trl1);
                }
                else if (destination >= 1)
                {
                    Console.WriteLine(travel + trl2);
                }
                else if (destination >= 5)
                {
                    Console.WriteLine(travel + trl3);
                }
                else if (destination >= 11)
                {
                    Console.WriteLine(travel + trl4);
                }
                else
                {
                    Console.WriteLine("The input was not understood.");
                }

                Console.WriteLine("Okay, if you're in the mood for " + mood + ", then " + activity + " " + destination);
                Console.WriteLine("Good Bye!");
            }
        }
    }
}