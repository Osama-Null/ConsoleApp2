Console.WriteLine("\nCHALLENGE 1\n");

Console.Write("Enter an integer number: ");
int usrInput = Convert.ToInt16(Console.ReadLine());

if (usrInput % 2 == 0)
{
    Console.WriteLine("Even");
}
else if (usrInput % 2 == 1)
{
    Console.WriteLine("Odd");
}
else Console.WriteLine("Invalid input!");

Console.WriteLine("______________________");

//__________________________________________
Console.WriteLine("\nCHALLENGE 2\n");

Console.Write("Enter your name: "); string name = Console.ReadLine();
Console.Write("Enter your gender: [M/f] "); string gender = Console.ReadLine();
Console.Write("Active or nonActive? [Y/n] "); string stat = Console.ReadLine();

//if (stat == "Y" || stat == "y")
//{
//    if (gender == "M" || gender == "m")
//    {
//        Console.WriteLine("\nAccess granted! ..." + "\n\nWelcome Mr " + name);
//    }
//    else if (gender == "F" || gender == "f") 
//    { 
//        Console.WriteLine("\nAccess granted! ..." + "\n\nWelcome Ms " + name);
//    }
//}
//else if (stat == "N" || stat == "n")
//{
//    Console.WriteLine("\nAccess denied!");
//}
//else Console.WriteLine("\nInvalid input!");

//Enchanced way from Shahad
if ((stat == "Y" || stat == "y") && (gender == "M" || gender == "m"))
    Console.WriteLine("\nAccess granted! ..." + "\n\nWelcome Mr " + name);

else if ((stat == "Y" || stat == "y") && (gender == "F" || gender == "f"))
    Console.WriteLine("\nAccess granted! ..." + "\n\nWelcome Ms " + name);

else if (stat == "N" || stat == "n")
    Console.WriteLine("\nAccess denied!");

else Console.WriteLine("\nInvalid input!");