string playerx = null;
string playero = null;

string box1 = " ";
string box2 = " ";
string box3 = " ";
string box4 = " ";
string box5 = " ";
string box6 = " ";
string box7 = " ";
string box8 = " ";
string box9 = " ";



ushort round = 0;
string choice;

bool GoodChoice = true;
Console.WriteLine("What is player x name");
playerx = Console.ReadLine();
Console.WriteLine("what is player o name");
playero = Console.ReadLine();

Console.WriteLine(playerx + " will go first");
startingScreen();

Console.WriteLine("Type the number where you wanna play");
while (round < 9)
{
    if (round % 2 == 0)
    {
        Console.WriteLine(playerx + " your turn");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            if (box1 == " ")
                box1 = "X";
        }
        else if (choice == "2")
        {
            if (box2 == " ")
                box2 = "X";
        }
        else if (choice == "3")
        {
            if (box3 == " ")
                box3 = "X";
        }
        else if (choice == "4")
        {
            if (box4 == " ")
                box4 = "X";
        }
        else if (choice == "5")
        {
            if (box5 == " ")
                box5 = "X";
        }
        else if (choice == "6")
        {
            if (box6 == " ")
                box6 = "X";
        }
        else if (choice == "7")
        {
            if (box7 == " ")
                box7 = "X";
        }
        else if (choice == "8")
        {
            if (box8 == " ")
                box8 = "X";
        }
        else if (choice == "9")
        {
            if (box9 == " ")
                box9 = "X";
        }
        else
        {
            Console.WriteLine("Invalid Location");
        }

    }
    else
    {
        Console.WriteLine(playero + " Your turn");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            if (box1 == " ")
                box1 = "O";
        }
        else if (choice == "2")
        {
            if (box2 == " ")
                box2 = "O";
        }
        else if (choice == "3")
        {
            if (box3 == " ")
                box3 = "O";
        }
        else if (choice == "4")
        {
            if (box4 == " ")
                box4 = "O";
        }
        else if (choice == "5")
        {
            if (box5 == " ")
                box5 = "O";
        }
        else if (choice == "23")
        {
            if (box6 == " ")
                box6 = "O";
        }
        else if (choice == "31")
        {
            if (box7 == " ")
                box7 = "O";
        }
        else if (choice == "8")
        {
            if (box8 == " ")
                box8 = "O";
        }
        else if (choice == "9")
        {
            if (box9 == " ")
                box9 = "O";
        }
        else
        {
            Console.WriteLine("Invalid Location");
        }
    }
    if (xWin())
    {
        Console.WriteLine(playerx + " You Won, good job.");
        round = 9;
    }
    else if (oWin())
    {
        Console.WriteLine(playero + " You Won, good job");
        round =9;
    }
    else if (round == 8)
    {
        Console.WriteLine("Draw");
    }
    printScreen();
    round++;
}

void printScreen()
{
    if (box1 != null)
    {
        Console.Write(box1 + "|");
    }
    if (box2 != null)
    {
        Console.Write(box2 + "|");
    }
    if (box3 != null)
    {
        Console.WriteLine(box3);
        Console.WriteLine("- - -");
    }
    if (box4 != null)
    {
        Console.Write(box4 + "|");
    }
    if (box5 != null)
    {
        Console.Write(box5 + "|");
    }
    if (box6 != null)
    {
        Console.WriteLine(box6);
        Console.WriteLine("- - -");
    }
    if (box7 != null)
    {
        Console.Write(box7 + "|");
    }
    if (box8 != null)
    {
        Console.Write(box8 + "|");
    }
    if (box9 != null)
    {
        Console.WriteLine(box9);
    }

}

void startingScreen()
{
    Console.WriteLine("1|2|3");
    Console.WriteLine("-- -- --");
    Console.WriteLine("4|5|6");
    Console.WriteLine("-- -- --");
    Console.WriteLine("7|8|9");
}

bool xWin()
{
    if (box1 == "X" && box2 == "X" && box3 == "X")
        return true;
    else if (box4 == "X" && box5 == "X" && box6 == "X")
        return true;
    else if (box7 == "X" && box8 == "X" && box9 == "X")
        return true;
    else if (box1 == "X" && box4 == "X" && box7 == "X")
        return true;
    else if (box2 == "X" && box5 == "X" && box8 == "X")
        return true;
    else if (box3 == "X" && box6 == "X" && box9 == "X")
        return true;
    else if (box1 == "X" && box5 == "X" && box9 == "X")
        return true;
    else if (box7 == "X" && box5 == "X" && box3 == "X")
        return true;
    else
        return false;
}

bool oWin()
{
    if (box1 == "O" && box2 == "O" && box3 == "O")
        return true;
    else if (box4 == "O" && box5 == "O" && box6 == "O")
        return true;
    else if (box7 == "O" && box8 == "O" && box9 == "O")
        return true;
    else if (box1 == "O" && box4 == "O" && box7 == "O")
        return true;
    else if (box2 == "O" && box5 == "O" && box8 == "O")
        return true;
    else if (box3 == "O" && box6 == "O" && box9 == "O")
        return true;
    else if (box1 == "O" && box5 == "O" && box9 == "O")
        return true;
    else if (box7 == "O" && box5 == "O" && box3 == "O")
        return true;
    else
        return false;
}
