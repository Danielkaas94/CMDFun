using System;

class ZodiacStoryGenerator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Zodiac Story Generator!");
        
        // Get user input
        Console.Write("Enter your zodiac sign: ");
        string zodiacSign = Console.ReadLine();

        Console.Write("Enter your gender: ");
        string gender = Console.ReadLine();

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Generate and display the story
        Console.WriteLine("\nGenerating your personalized story...\n");

        string story = GenerateStory(zodiacSign, gender, name);
        Console.WriteLine(story);

        Console.WriteLine("\nThanks for using the Zodiac Story Generator!");
    }

    static string GenerateStory(string zodiacSign, string gender, string name)
    {
        // You can customize the story based on different combinations of zodiac signs and genders
        string story = $"Once upon a time, in a land far away, there was a {gender.ToLower()} named {name}. ";
        
        // Adding a simple twist based on the zodiac sign
        if (zodiacSign.ToLower() == "aries")
        {
            story += $"Born under the sign of Aries, {name} was known for their adventurous spirit and determination. ";
        }
        else if (zodiacSign.ToLower() == "taurus")
        {
            story += $"A Taurus like {name} was admired for their practicality and strong sense of loyalty. ";
        }
        // Add more conditions for other zodiac signs...

        // End the story
        story += $"And so, the tale of {name}, the {zodiacSign} {gender.ToLower()}, unfolds.";

        return story;
    }
}
