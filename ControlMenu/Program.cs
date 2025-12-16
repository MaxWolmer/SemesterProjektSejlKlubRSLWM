
using System.Net.Http.Headers;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using zControlMenu;



controller Acontroller = new controller();

string options = " press 1 to " +
                "\n press 2 " +
                "\n press 3 " +
                "\n press 4 " +
                "\n press 5 \n";


bool loop = true;

while (loop)
{
    
    Console.WriteLine(options);

    string keyinput = Console.ReadLine();

    switch (keyinput)
    {
        case "1":
            {
                Console.WriteLine("you press 1");
            }
            break;

        case "2":
            {
                Console.WriteLine("2");
            }
            break;
        case "3":
            {
                Console.WriteLine("2");
            }
            break;
        case "4":
            {
                Console.WriteLine("2");
            }
            break;
        case "5":
            {
                Console.WriteLine("2");
            }
            break;
        case "6":
            {
                Console.WriteLine("2");
            }
            break;


    }
}

