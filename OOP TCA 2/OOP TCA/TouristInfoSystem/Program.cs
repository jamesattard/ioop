using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInfoSystem
{
    //  static SightseeingExcursion negomboDayTour = new SightseeingExcursion("Negombo Day Tour", "Negombo", 15);
    //  static SightseeingExcursion dambullaCaveTemples = new SightseeingExcursion("Dambulla Cave Temples", "Dambulla", 20);
    //  static AdventureExcursion sigiriyaBikeTour = new AdventureExcursion("Sigiriya Bike Tour", "Sigiriya", 25);
    //  static SightseeingExcursion kandyCulturalDance = new SightseeingExcursion("Kandy Cultural Dance", "Kandy", 20);
    //  static SightseeingExcursion parrotRock = new SightseeingExcursion("Parrot Rock", 15);
    // static AdventureExcursion mountEtnaHike = new AdventureExcursion("Mount Etna Hike Tour", "Catania", 20);
    // static SightseeingExcursion taorminaTour = new SightseeingExcursion("Taormina City Tour", "Taromina", 15);
    // static SightseeingExcursion isolaBellaTour = new SightseeingExcursion("Isola Bella Tour", "Taromina", 15);
    // static BoatExcursion isolaBellaBoatTour = new BoatExcursion("Isola Bella Boat Tour", "Taromina", 30, 6, "Isola Bella Bay", isolaBellaTour);
    internal class Program
    {     

        static AdventureExcursion lionRock = new AdventureExcursion("Sigiriya Lion Rock",  15, false);
        static BoatExcursion mirissaWhaleWatching = new BoatExcursion("Mirissa Whale Watching", 40, 20, "Mirissa Bay", true);
        
        static SightseeingExcursion cataniaTour = new SightseeingExcursion("Catania City Tour", 15);
        static JeepExcursion nebrodiJeepTour = new JeepExcursion("Nebrodi Jeep Tour", 30, 4, "Cesaro", "Mountain trail");

        static Tour sriLankaTour = new Tour("Sri Lanka Explorer", "Discover the best of Sri Lanka ", new List<Excursion> { lionRock, mirissaWhaleWatching }, 200, 900);
        static Tour sicily = new Tour("Sicily Adventurer", "Discover the best of Sicily ", new List<Excursion> { cataniaTour, nebrodiJeepTour}, 100, 100);
        static List<Tour> allTours = new List<Tour> { sriLankaTour, sicily };

        static void Main(string[] args)
        {
            ShowAvailableTours();
        }

        static void ShowAvailableTours()
        {
            int choice = 0;
            do {
                Console.Clear();
                Console.WriteLine("Available Tours");
                Console.WriteLine("---------------\n");
                if (allTours.Count > 0)
                {
                    for (int i = 0; i < allTours.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {allTours[i].Name}");
                    }
                    Console.WriteLine("If you want to view more details about the tour, input the tour number. Otherwise input -1 to return to main menu.");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice > 0 && choice <= allTours.Count)
                    {
                        choice--;
                        Console.WriteLine($"\nTour name: {allTours[choice].Name}");
                        Console.WriteLine($"Tour description: {allTours[choice].Description}");
                        Console.WriteLine($"Tour Cost: {allTours[choice].Cost}");
                        Console.WriteLine("Details of excursions included in Tour price:");
                        foreach (Excursion excursion in allTours[choice].Excursions)
                        {
                            Console.WriteLine(excursion.ExcursionDetails());
                        }
                    }
                    else if (choice == -1)
                    {
                        Console.WriteLine("Thank you for using our application!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input!");
                    }

            }
                else
                {
                    Console.WriteLine("No tours available.");
                }
                Console.ReadKey();
            } while (choice != -1);
        }

        
    
        
    }
}
