using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Haunted Mansion Adventure!");

            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("You find yourself standing in front of an old, decrepit mansion on a stormy night.");
                Console.Write("Enter your name: ");
                string playerName = Console.ReadLine();

                Console.WriteLine("Welcome, " + playerName + "! You decide to enter the mansion and explore its dark mysteries.");
                Console.WriteLine("The wind howls, and strange sounds echo through the halls.");

                int roomsExplored = 0;
                int currentRoom = 1; 

                while (roomsExplored < 6)
                {
                    Console.WriteLine("You enter Room " + currentRoom + ":");

                    bool advance = false;
                    Random random = new Random();
                    int deathOption = random.Next(1, 3); 

                    switch (currentRoom)
                    {
                        case 1:
                            Console.WriteLine("You hear ghostly whispers coming from an old mirror in the room.");
                            Console.WriteLine("1. Approach the mirror and try to communicate with the spirits.");
                            Console.WriteLine("2. Inspect the room for clues.");
                            string choice1 = Console.ReadLine();
                            if (choice1 == "1" && deathOption == 1)
                            {
                                Console.WriteLine("As you approach the mirror, an evil spirit possesses you. GAME OVER.");
                                roomsExplored = 6; 
                            }
                            else if (choice1 == "1" && deathOption == 2)
                            {
                                Console.WriteLine("The mirror shatters, and a ghostly apparition emerges, guiding you to the next room. You advance with the ghostly companion.");
                                advance = true;
                            }
                            else
                            {
                                Console.WriteLine("You search the room and discover a hidden passage behind a bookshelf. You enter the passage and move forward.");
                                advance = true;
                            }
                            break;

                        case 2:
                            Console.WriteLine("You enter a dark library with ancient, dusty books. A book on a pedestal glows with an eerie light.");
                            Console.WriteLine("1. Examine the glowing book.");
                            Console.WriteLine("2. Investigate the other books.");
                            string choice2 = Console.ReadLine();
                            if (choice2 == "1" && deathOption == 1)
                            {
                                Console.WriteLine("As you touch the glowing book, you are consumed by dark magic. GAME OVER.");
                                roomsExplored = 6; 
                            }
                            else if (choice2 == "1" && deathOption == 2)
                            {
                                Console.WriteLine("As you touch the glowing book, ancient knowledge fills your mind. You advance, empowered with new insights.");
                                advance = true;
                            }
                            else
                            {
                                Console.WriteLine("You inspect the other books but find nothing of interest. Suddenly, the room transforms, and you are transported to the next room.");
                                advance = true;
                            }
                            break;

                        case 3:
                            Console.WriteLine("You enter a room with an old, creaky piano. It starts playing on its own.");
                            Console.WriteLine("1. Approach the piano and listen to the eerie melody.");
                            Console.WriteLine("2. Flee the room in fear.");
                            string choice3 = Console.ReadLine();
                            if (choice3 == "1" && deathOption == 1)
                            {
                                Console.WriteLine("As you approach the piano, ghostly hands emerge and pull you into the piano. GAME OVER.");
                                roomsExplored = 6; 
                            }
                            else if (choice3 == "1" && deathOption == 2)
                            {
                                Console.WriteLine("As you listen, the piano stops, and you hear faint, haunting laughter. You advance, trying to ignore the chill in the air.");
                                advance = true;
                            }
                            else
                            {
                                Console.WriteLine("You run out of the room, not daring to stay. GAME OVER.");
                                roomsExplored = 6; 
                            }
                            break;


                        case 4:
                            
                            break;

                        case 5:
                            
                            break;
                    }

                    if (advance)
                    {
                        roomsExplored++;
                        currentRoom++;
                    }
                }

                if (roomsExplored == 6)
                {
                    Console.WriteLine("You've explored all the rooms, and each had its unique challenge.");

                    Console.WriteLine("Congratulations, you've completed the Haunted Mansion Adventure!");
                }

                Console.Write("Play again? (yes/no): ");
                string playAgainChoice = Console.ReadLine().ToLower();
                if (playAgainChoice != "yes")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for braving the Haunted Mansion Adventure!");
        }
    }
}
