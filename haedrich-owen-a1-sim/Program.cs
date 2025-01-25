int demand = 50000;
bool playerPaid = false;

// Phase 1: Introduction

// Introduce Scenerio, Provide Options to Player
Console.WriteLine($"\n> Hello, your mainframe has been hacked.\n> Luckily, I am in the business of resolving hacks.");
Console.WriteLine($"\n> I'll need a payment of ${demand} to ensure that your critical business infrastructure won't be destroyed.");
Console.WriteLine($"\n*What will you do? Will you INQUIRE for more info, PAY the ${demand} fee, or REBOOT your system?*");
Console.WriteLine("*Choose by inputting INQUIRE, PAY, or REBOOT*\n");

// Get user input - provide first chance to get information
string action = Console.ReadLine();

// Process user input - provide second chance to get information if they don't inquire or pay
if (!(action == "PAY" || action == "INQUIRE"))
{
    if (action == "REBOOT")
    {
        Console.WriteLine("\nRebooting... Please wait.\n");
        Console.WriteLine("\n> HAHAHA! This hack is far too advanced for such a trivial strategy to work.");
    }

    // Process invalid input
    else
    {
        Console.WriteLine("\n> This is not a joke. Please follow the instructions closely unless you want to lose your business.");
    }

    // Increase ransom demand
    demand *= 2;
    Console.WriteLine($"\n> For the trouble, the payment is now doubled to ${demand}.");

    // Provide options to player - second chance to get information
    Console.WriteLine($"\n*What will you do now? Will you INQUIRE for more info, or PAY the ${demand} fee?*");
    Console.WriteLine("*Choose by inputting INQUIRE or PAY*\n");
    action = Console.ReadLine();
}

// Payment skips to the end sequence
if (action == "PAY")
    playerPaid = true;

// Provide information to inquiring players
else if (action == "INQUIRE")
{
    Console.WriteLine($"\n> Who am I? I am an automated business-ransom-resolution AI.");
    Console.WriteLine($"\n> Your machines have been infected with adaptive smart-code. This problem won't be resolved without my help.");
}

// Process invalid input
else
{
    Console.WriteLine("\n> I don't follow.");
}

// Phase 2: Investigation and Negotiation

// Provide player options if they haven't paid
if (!playerPaid)
{
    Console.WriteLine($"\n> Pay close attention. If the ${demand} payment is beyond your means, maybe we can strike a deal.");
    Console.WriteLine($"\n*What will you do? Will you INQUIRE for more info, PAY the ${demand} ransom, or make an OFFER?*");
    Console.WriteLine("*Choose by inputting INQUIRE, PAY, or OFFER*\n");
    action = Console.ReadLine();
}

// Process player input
// Payment skips to the end sequence
if (action == "PAY")
    playerPaid = true;
else
{
    // End inquiry
    if (action == "INQUIRE")
    {
        Console.WriteLine("\n> As a C# program, I can clearly SEE that you aren't so SHARP! WHAHAHA! ");
        Console.WriteLine("\n> Now, please refrain from asking questions. My patience is beyond its maximum.");
    }

    // Process first offer
    else if (action == "OFFER")
    {
        // Ask for integer offer and process it
        Console.WriteLine("\n*How much do you offer?*\n*Make your decision by inputting a whole number.*\n");
        string attemptedOffer = Console.ReadLine();

        // Decline negatives by checking the string for a negative sign
        if (attemptedOffer.Contains("-"))
            Console.WriteLine("\n> I'm not going to pay you! Stop kidding around.");
        else
        {
            // Parse the integer - if the offer is high enough, add it to the demand
            int offer = int.Parse(attemptedOffer);
            if (offer > 1000)
            {
                demand += offer;
                Console.WriteLine($"\n> Great! Let's add that to your bill. The demand is now ${demand}. HAHAHA!");
            }
            else
                Console.WriteLine("\n> I don't think so.");
        }
    }

    // Process invalid input
    else
    {
        Console.WriteLine($"\n> I might be a 32 bit program, but you're the one who need to get real.");
    }

    // Increase demand
    demand *= 2;
    Console.WriteLine($"\n> And for wasting my time, the price doubles to ${demand}.");
}

// Phase 3: Final Offer

// Allow the player to make a final offer if they haven't paid
if (!playerPaid)
{
    Console.WriteLine("\n*What will you do? Will you PAY the ransom, or make an OFFER?*");
    Console.WriteLine("*Choose by inputting PAY or OFFER*\n");
    action = Console.ReadLine();
}

if (action == "PAY")
    playerPaid = true;

// Handle invalid input
else if (action != "OFFER")
    Console.WriteLine("\n> Get real.");

// Give hints and let the player make their final offer
if (!playerPaid)
{
    Console.WriteLine($"\n> I will let you make one final offer. Think carefully.");
    Console.WriteLine($"\n> And consider that I will put my 2x fee on top. BWAHAHA!");
    Console.WriteLine("\n> I am overflowing with excitement that we can make a good deal.");
    Console.WriteLine("\n*How much do you offer?*\n*Make your decision by inputting a whole number.*\n");

    // Read input
    string attemptedOffer = Console.ReadLine();

    // Decline negative offers
    if (attemptedOffer.Contains("-"))
        Console.WriteLine("> You can't offer a negative amount. You must be joking.");
    else
    {
        // Parse the offer as an integer
        int offer = int.Parse(attemptedOffer);

        // Accept the offer if it's greater than the demand
        if (offer > demand)
        {
            Console.WriteLine($"\n> I see... ${offer} is not too bad. I'll take it.");
            demand = offer;
        }

        // Add the offer to the demand otherwise
        else
        {
            demand += offer;
            Console.WriteLine($"\n> Lowballing? The demand is now ${demand}.");
        }
    }

    // Increase demand
    demand *= 2;
    Console.WriteLine("\n> Alright. I'm done here. With my 2x fee added I'll arrange the transfer.");
}

// Phase 4: Payment

// Show the player the final deal and ask for payment
var transfer = -demand;
if (transfer > 0)
    Console.WriteLine($"\n>> A PRE-AUTHORIZED DEPOSIT IS PENDING ON YOUR ACCOUNT: ${transfer}.");
else
    Console.WriteLine($"\n>> A PAYMENT IS PENDING ON YOUR ACCOUNT: ${demand}.");
Console.WriteLine($">> DO YOU ACCEPT? (Y/N)");
Console.WriteLine("\n*Choose by inputting Y or N*\n");
string accept = Console.ReadLine();

// Evaluate win condition and provide ending
if (accept == "Y")
{

    // Player gets epic win if the demand is negative
    if (demand < 0)
    {
        Console.WriteLine($"*${transfer} is deposited into your account.*\n*You host an awesome party and it's a great time.*");
        Console.WriteLine("Epic win!");
    }

    // Player wins if the demand is zero
    else if (demand == 0)
    {
        Console.WriteLine("You win!");
    }

    // Player loses if they pay the demand
    else if (demand < 10000000)
    {
        Console.WriteLine($"\n*You wire ${demand} to the attacker*");
        Console.WriteLine("\n> Thank you for your cooperation!\n> We hope to do business with you again in the future.");
        Console.WriteLine("\nYou lose!\nPlease play again.");
    }

    // Players gets epic loss if they pay too much
    else
    {
        Console.WriteLine($"\n*You wire ${demand} to the attacker*");
        Console.WriteLine("\n> Thank you for your cooperation!\n> We hope to do business with you again in the future.");
        Console.WriteLine("\n*Your small business never financially recovers.*");
        Console.WriteLine("\n*Your family is forced to take on crippling debt.*");
        Console.WriteLine("\nEpic loss!\nPlease try again.");
    }
}

// Player is told to play again if they don't accept any deal
else
{
    Console.WriteLine("\n> Clearly you are not serious. We will hold your system until you change your attitude. Re-initialize this program if you want to talk again.");
    Console.WriteLine("\nPlease play again.");
}
