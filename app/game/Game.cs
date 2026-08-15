using static TheLongNight.Commands.CommandHandler;

namespace TheLongNight;

public class Game
{

    public async Task Start()
    {
       
        
        Console.Title = "The Long Night";

        Console.Clear();


        Console.WriteLine("=================================");
        Console.WriteLine("          THE LONG NIGHT");
        Console.WriteLine("=================================");
        Console.WriteLine();

        Console.WriteLine("Welcome to The Long Night, a text-based adventure game set in the world of Westeros.");
        Console.WriteLine();
        Console.WriteLine("In this game, you will create a character, explore the world, and make choices that will shape your destiny.");
        Console.WriteLine();
        Console.WriteLine("First, you will need to create an account or log in to an existing one.");
        Console.WriteLine();

        Console.WriteLine("Let's get started!");

        CharacterCreation characterCreation = new CharacterCreation();

        Console.WriteLine();

        //PrintCastleBlack();

        // Console.WriteLine();
        // Console.WriteLine("                    THE LONG NIGHT");
        // Console.WriteLine();
        // Console.WriteLine("You stand before Castle Black.");
        // Console.WriteLine("The Wall towers above you, disappearing into the clouds.");
        // Console.WriteLine();
        // Console.WriteLine("A cold wind blows down from the north.");
        // Console.WriteLine();

        CommandHandler commandHandler = new CommandHandler();

        await commandHandler.StartAsync();
    }

    
}