int demandValue = 50000;
bool playerPaid = false;

// Phase 1: Introduction

Console.WriteLine($"\n> Hello, your mainframe has been hacked.\n> Luckily, I am in the business of resolving hacks." +
    $"\n> I'll need a payment of ${demandValue} to ensure that your critical business infrastructure won't be destroyed.");
Console.WriteLine($"\n*What will you do? Will you INQUIRE for more info, PAY the ${demandValue} fee, or REBOOT your system?*");
Console.WriteLine("*Choose by inputting INQUIRE, PAY, or REBOOT*\n");
string action = Console.ReadLine();
if (!(action == "PAY" || action == "INQUIRE"))
{
    if (action == "REBOOT")
    {
        Console.WriteLine("Rebooting... Please wait.");
        Console.WriteLine("> HAHAHA! This hack is far too advanced for such a trivial strategy to work.");
        demandValue *= 2;
        Console.WriteLine($"> For the trouble, the payment is now doubled to ${demandValue}.");
    }
    else
    {
        Console.WriteLine("\n> This is not a joke. Please follow the instructions closely unless you want to lose your business.");
    }
    Console.WriteLine($"\n*What will you do now? Will you INQUIRE for more info, or PAY the ${demandValue} fee?*");
    Console.WriteLine("*Choose by inputting INQUIRE or PAY*\n");
    action = Console.ReadLine();
}

if (action == "PAY")
    playerPaid = true;
else if (action == "INQUIRE")
{
    Console.WriteLine($"\n> Who am I? I am an automated business-ransom-resolution AI." +
        $"\n> Your machines have been infected with adaptive smart-code. This problem won't be resolved without my help." +
        $"\n> If the ${demandValue} payment is beyond your means, maybe we can strike a deal.");
}
else
{
    Console.WriteLine("\n> I have no time for such nonsense! You clearly don't understand the gravity of the situation — a rogue AI has captured your livelihood! Make me an offer if you can't handle the full payment.");
}

// Phase 2: Investigation

if (!playerPaid)
{
    Console.WriteLine($"\n*What will you do? Will you INQUIRE for more info, PAY the ${demandValue} ransom, or make an OFFER?*");
    Console.WriteLine("*Choose by inputting INQUIRE, PAY, or OFFER*\n");
    action = Console.ReadLine();
}

if (action == "PAY")
    playerPaid = true;
else if (action == "INQUIRE")
    Console.WriteLine("\n> As a C# program, I can clearly SEE that you aren't so SHARP! WHAHAHA! \n> Now, please refrain from asking questions. My patience is exhausted.");
else if (action == "OFFER")
{
    Console.WriteLine("\n*How much do you offer?*\n*Make your decision by inputting a whole number.*\n");
    int offer = int.Parse(Console.ReadLine());
    demandValue += offer;
    Console.WriteLine($"\n> Great! Let's add that to your bill. The demand is now ${demandValue}. HAHAHA!");
}
else
{
    demandValue *= 2;
    Console.WriteLine($"\n> Quit wasting time! The demand is now ${demandValue}.");
}

// Phase 3: Endgame
if (!playerPaid)
{
    Console.WriteLine("\n*What will you do? Will you PAY the ransom, or make an OFFER?*");
    Console.WriteLine("*Choose by inputting PAY or OFFER*\n");
    action = Console.ReadLine();
}

if (action == "PAY")
    playerPaid = true;
else if (action == "OFFER")
{
    Console.WriteLine("\n*How much do you offer?*\n*Make your decision by inputting a whole number.*\n");
    int offer = int.Parse(Console.ReadLine());
    demandValue += offer;
    Console.WriteLine();
    playerPaid = true;
}
else
    Console.WriteLine("> Clearly you are not serious. We will hold your system until you change your attitude. Re-initialize this program if you want to talk again.");

if (playerPaid)
{
    if (demandValue < 0)
    {
        Console.WriteLine($"*${demandValue} is deposited into your account.*\n*You host an awesome party and it's a great time.*");
        Console.WriteLine("You win!");
    }
    else if (demandValue < 50000)
    {
        Console.WriteLine($"\n*You wire ${demandValue} to the attacker*");
        Console.WriteLine("\n> Thank you for your cooperation!\n> We hope to do business with you again in the future.");
    }
    else 
    {
        Console.WriteLine($"\n*You wire ${demandValue} to the attacker*");
        Console.WriteLine("\n> Thank you for your cooperation!\n> We hope to do business with you again in the future.");
        Console.WriteLine("\n*Your family is forced to take on crippling debt.*");
        Console.WriteLine("\n*Your small business never financially recovers.*");
    }
}