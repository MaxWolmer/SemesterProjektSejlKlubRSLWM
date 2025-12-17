
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
                            controller.BoatRepo.PrintAllBoats();

                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        {
                            controller.BookingRepo.printall();
                        }
                        break;
                    case "3":
                        {
                          int bookings  = controller.BookingRepo.BookingsOnBoat(2);
                            
                            Console.WriteLine(bookings);
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
                            controller.UserRepo.PrintAllUsers();

                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("enter a name");
                            string name = Console.ReadLine();

                            Console.WriteLine("enter a email");
                            string email = Console.ReadLine();

                            Console.WriteLine("enter a phonenumber");
                            string phone = Console.ReadLine();

                            Console.WriteLine("enter a Y for adming N for not");
                            string adminkey = Console.ReadLine();
                            bool admin = false;

                            if(adminkey == "Y")
                            {
                                admin = true;
                            }

                            User Auser = new User(name, email, phone, admin);
                           
                                controller.UserRepo.AddUser(Auser);

                            Console.WriteLine("user added");
                        }
                        break;
                    case "3":
                        {
                            controller.BlogRepo.PrintListOfPosts();
                            Console.ReadLine();
                        }
                        break;
                    case "4":
                        {
                           

                            controller.EventRepo.PrintListOfEvents();
                            Console.ReadLine();
                        }
                        break;
                    
                }
            }
            break;
       


    }
}

