
using System.Net.Http.Headers;
using ProjektLibrary.Models;
using ProjektLibrary.Services;
using zControlMenu;



controller controller = new controller();
             
bool Loop = true;

while (Loop)
{
    
    Console.WriteLine(ControllerMenuText.startmenutext());

    string keyinput = Console.ReadLine();

    switch (keyinput)
    {
        case "1":
            {
                Console.Clear();
                Console.WriteLine(ControllerMenuText.option1text());

                string theinput = Console.ReadLine();

                switch(theinput)
                {
                    case "1":
                    {
                            Console.WriteLine(ControllerMenuText.option1Type()); 
                            string input = Console.ReadLine();
                            switch (input)
                            {
                                case "1": { }break;
                                case "2": { } break;
                                case "3": { } break;
                                case "4": { } break;
                            }
                            Console.Clear();
                        }
                        break;
                        
                    case "2":
                        {
                            Console.WriteLine(ControllerMenuText.option1Type());
                            string input = Console.ReadLine();
                            switch (input)
                            {
                                case "1": { } break;
                                case "2": { } break;
                                case "3": { } break;
                                case "4": { } break;
                                    
                            }
                            Console.Clear();
                        }   break;
                    case "3":
                        {
                            Console.WriteLine(ControllerMenuText.option1Type());
                            string input = Console.ReadLine();
                            switch (input)
                            {
                                case "1": { } break;
                                case "2": { } break;
                                case "3": { } break;
                                case "4": { } break;
                                    
                            }
                            Console.Clear();
                        } break;
                    case "4":
                        {
                            {
                                Console.WriteLine(ControllerMenuText.option1Type());
                                string input = Console.ReadLine();
                                switch (input)
                                {
                                    case "1": { } break;
                                    case "2": { } break;
                                    case "3": { } break;
                                    case "4": { } break;
                                     
                                }
                                Console.Clear();
                            }
                            break;
                        }
                        break;
                }
            }
            break;

        case "2":
            {
                Console.Clear();
                Console.WriteLine(ControllerMenuText.option2text());
                string theinput = Console.ReadLine();
               

                switch (theinput)
                {
                    case "1":
                        {

                        }
                        break;
                    case "2":
                        {

                        }
                        break;
                    case "3":
                        {

                        }
                        break;
                    case "4":
                        {

                        }
                        break;
                    case "5":
                        {

                        }
                        break;
                    case "6":
                        {

                        }
                        break;
                }
            }
            break;
        case "3":
            {
                Console.Clear();
                Console.WriteLine(ControllerMenuText.option3text());
                
                string theinput = Console.ReadLine();

                switch (theinput)
                {
                    case "1":
                        {

                        }
                        break;
                    case "2":
                        {

                        }
                        break;
                    case "3":
                        {

                        }
                        break;
                    case "4":
                        {

                        }
                        break;
                    case "5":
                        {

                        }
                        break;
                }
            }
            break;
       


    }
}

