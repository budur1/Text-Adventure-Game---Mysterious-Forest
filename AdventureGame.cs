using System;
class TextAdventureGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcom to the Adventure");
        Console.WriteLine("You find yourself in a mysterious forest.");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Go depper into the forest");
        Console.WriteLine("2. Climb a tree");
        Console.Write("> ");
        string userinput = Console.ReadLine();

        if (userinput == "1")
        {
            Console.WriteLine("You encounter a strange creature. What will you do?");
            Console.WriteLine("1. Try to communicate with the creature");
            Console.WriteLine("2. Retreat slowly");
            Console.Write("> ");

            string chioce = Console.ReadLine();

            if (chioce == "1")
            {
                Console.WriteLine("The creature responds in a friendly manner. You've made a new friend!");
                Console.WriteLine("Congratulations! You've completed the adventure.");
            }
            else if (chioce == "2")
            {
                Console.WriteLine("You retreat and find your way back home.");
                Console.WriteLine("Congratulations! You've completed the adventure.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Game Over!");
            }
        }
        else if (userinput == "2")
        {
            Console.WriteLine("You climb the tree and see a hidden path. What will you do?");
            Console.WriteLine("1. Explore the hidden path");
            Console.WriteLine("2. Climb down and go deeper into the forest");
            Console.Write("> ");

            string chioce = Console.ReadLine();

            if (chioce == "1")
            {
                Console.WriteLine("You discover a treasure chest!");
                Console.WriteLine("Congratulations! You've completed the adventure.");
            }
        
            else if (chioce == "2")
            {
                Console.WriteLine("You venture deeper into the forest.");
                Console.WriteLine("Unfortunately, you got lost. Game over!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Game Over!");
            }
        }
        else 
        {
            Console.WriteLine("Invalid choice. Game Over!");

        }
        Console.WriteLine("Bey bay ^_^ ^_^");
    }
}


