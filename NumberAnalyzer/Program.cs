int numInput;
string contInput;
bool active = true;
string name;

Console.WriteLine("What is your name:");
name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");

while (active)
{
    Console.WriteLine("Enter a number between 1 and 100:");
    numInput = int.Parse(Console.ReadLine());
    if (1 <= numInput && numInput <= 100) //only continues if the input is between 1 and 100 inclusive
    {
        if (numInput % 2 == 1) //checks for odd numbers
        {
            if (numInput < 60)
            {
                Console.WriteLine($"{numInput}, Odd and less than 60");
            }
            else if (numInput > 60)
            {
                Console.WriteLine($"{numInput}, Odd and greater than 60");
            }
        }
        else if (numInput % 2 == 0) //checks for even numbers
        {
            if (2 <= numInput && numInput <= 24)
            {
                Console.WriteLine($"{numInput}, Even and less than 25");
            }
            else if (26 <= numInput && numInput <= 60)
            {
                Console.WriteLine($"{numInput}, Even and between 26 and 60 inclusive");
            }
            else if (numInput > 60)
            {
                Console.WriteLine($"{numInput}, Even and greater than 60");
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid number");
    }
    Console.WriteLine("Do you want to continue? y/n");
    contInput = Console.ReadLine();
    if (contInput == "n")
    {
        Console.WriteLine($"Bye, {name}!");
        active = false; //stops the loop causing the program to end
    }
    else if (contInput == "y") 
    {
        Console.WriteLine($"Okay, {name}!"); //doesnt change active status allowing the program to continue
    } 
    else
    {
        Console.WriteLine($"Invalid response. Bye, {name}!");
        active = false; //stops the loop causing the program to end
    }
}