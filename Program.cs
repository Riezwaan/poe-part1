using System;
using System.Media;

class CyberSecurityBot
{
    static void Main()
    {
        // play voice greeting
        PlayGreeting();

        // display ascii robot face
        ShowAsciiArt();

        // ask for user's name
        Console.Write("what's your name? ");
        string userName = Console.ReadLine().Trim();

        // if name is empty, it will just proceed without validation
        Console.WriteLine($"\ncybersecurity bot: hello, {userName}! ask me cybersecurity-related questions (type 'exit' to quit).");

        while (true)
        {
            Console.Write("\nYou: ");
            string input = Console.ReadLine().ToLower().Trim();

            // exit condition
            if (input == "exit")
            {
                Console.WriteLine($"cybersecurity bot: stay safe online, {userName}! goodbye.");
                break;
            }

            // process user input
            ProvideCyberSecurityInfo(input);
        }
    }

    static void PlayGreeting()
    {
        try
        {
          //  SoundPlayer player = new SoundPlayer("greeting.wav");
          //  player.Play();
        }
        catch
        {
            Console.WriteLine("cybersecurity bot: (audio error) could not play the greeting.");
        }
    }

    static void ShowAsciiArt()
    {
        Console.WriteLine(@"
        .----------------.
        |  CYBER  BOT   |
        '----------------'
          .--------.
         |  [o]  [o]  |  
         |   ------   |  
         |  \______/  |
          '--------'
    ");
    }

    static void ProvideCyberSecurityInfo(string question)
    {
        switch (question)
        {
            case "password safety":
                Console.WriteLine("cybersecurity bot: use strong, unique passwords and enable two-factor authentication.");
                break;
            case "phishing":
                Console.WriteLine("cybersecurity bot: avoid clicking suspicious links and verify email senders.");
                break;
            case "public wifi":
                Console.WriteLine("cybersecurity bot: avoid using public wifi for sensitive transactions.");
                break;
            case "software updates":
                Console.WriteLine("cybersecurity bot: always update your software to fix security vulnerabilities.");
                break;
            default:
                Console.WriteLine("cybersecurity bot: i only answer cybersecurity-related questions.");
                break;
        }
    }
}

