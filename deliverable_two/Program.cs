using System;
using System.Collections;

namespace deliverable_two
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string action, destination;
            {
                Console.WriteLine("Hello user, what are you in the mood for?");
                ArrayList arrList1 = new ArrayList();
                arrList1.Add("1.) Action");
                arrList1.Add("2.) Chilling");
                arrList1.Add("3.) Danger");
                arrList1.Add("4.) Good Food");
                Console.WriteLine("Here are your options:");
                foreach (object item in arrList1)
                {
                    Console.WriteLine(item);
                }

                action = Console.ReadLine();
                if (action == "Action" || action == "1" || action == "action")
                {
                    Console.WriteLine("You have selected Action, as your choice.", action);
                    Console.WriteLine("You should go...");
                    Console.WriteLine("Stock Car Racing");
                }
                else if (action == "Chilling" || action == "2" || action == "action")
                {
                    Console.WriteLine("You have selected Chilling, as your choice.", action);
                    Console.WriteLine("You should go...");
                    Console.WriteLine("Hiking");
                }
                else if (action == "Danger" || action == "3" || action == "danger")
                {
                    Console.WriteLine("You have selected Danger, as your choice.", action);
                    Console.WriteLine("You should go...");
                    Console.WriteLine("Skydiving");
                }
                else if (action == "Good Food" || action == "4" || action == "Good food" || action == "good food" || action == "good Food")
                {
                    Console.WriteLine("You have selected Good Food, as your choice.", action);
                    Console.WriteLine("You should go...");
                    Console.WriteLine("To Taco Bell");
                }
                else
                {
                    Console.WriteLine("I'm sorry, I am not programmed to go beyond what was typed...");
                }


                Console.WriteLine("How many people are you bringing with you?");
                ArrayList arrList2 = new ArrayList();
                arrList2.Add("a. (0)");
                arrList2.Add("b. (1 - 4)");
                arrList2.Add("c. (5 - 10)");
                arrList2.Add("d (11+)");
                Console.WriteLine("Here are your options:");
                foreach (object item in arrList2)
                {
                    Console.WriteLine(item);
                }
                destination = Console.ReadLine();
                if (destination == "0" || destination == "Zero" || destination == "zero" || destination == "a" || destination == "A")
                {
                    Console.WriteLine("You have selected 0, as your choice.", destination);
                    Console.WriteLine("You should travel in...");
                    Console.WriteLine("Sneakers (^_^)");
                    Console.WriteLine("Good Bye!");
                }
                else if (destination == "1" || destination == "2" || destination == "3" || destination == "4" || destination == "1 - 4" || destination == "b" || destination == "B")
                {
                    Console.WriteLine("You have selected a range between 1 - 4, as your choice.", destination);
                    Console.WriteLine("You should travel in...");
                    Console.WriteLine("a sedan (o_o)");
                    Console.WriteLine("Good Bye!");
                }
                else if (destination == "c" || destination == "C" || destination == "5" || destination == "6" || destination == "7" || destination == "8" || destination == "9" || destination == "10")
                {
                    Console.WriteLine("You have selected a range between 5 - 10, as your choice.", destination);
                    Console.WriteLine("You should travel in...");
                    Console.WriteLine("a Volkswagen bus (0-0)");
                    Console.WriteLine("Good Bye!");
                }
                else if (destination == "11+" || destination =="11" || destination == "d" || destination == "D")
                {
                    Console.WriteLine("You have selected 11+ , as your choice.", destination);
                    Console.WriteLine("You should travel in...");
                    Console.WriteLine("an airplane <(^-^)>");
                    Console.WriteLine("Good Bye!");
                }
                else
                {
                    Console.WriteLine("I'm sorry, I am not programmed to go beyond what was typed...");
                }
            }
        }
    }
}