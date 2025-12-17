
using System.Net.Http.Headers;
using System.Transactions;
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
                                //båd
                                case "1": { Console.WriteLine("indtast Type");
                                        string boattype = Console.ReadLine();

                                        Console.WriteLine("indtast brand");
                                        string boatbrand = Console.ReadLine();

                                        Console.WriteLine("indtast name");
                                        string boatname = Console.ReadLine();

                                        Console.WriteLine("indtastdimensions");
                                        string boatdimensioner = Console.ReadLine();

                                        
                                        bool avaible = true;
                                        bool admin = true;

                                        Console.WriteLine("indtast dine oplysinger");
                                        
                                            Console.WriteLine("indtast navn");
                                            string nameboatmaker = Console.ReadLine();

                                            Console.WriteLine("indtast email");
                                            string emailboat = Console.ReadLine();

                                            Console.WriteLine("indtast phonenumber");
                                            string phoneboat = Console.ReadLine();

                                            bool adminboat = true;
                                            

                                            User boatuser = new User(nameboatmaker, emailboat, phoneboat, adminboat, UserTypeEnum.Senior);


                                            Boat newboat = new Boat(boattype, boatbrand, boatname, boatdimensioner, avaible, admin, boatuser);
                                       
                                        controller.BoatRepo.AddBoat(newboat);
                                    }
                                    break;

                                    //event
                                case "2": { Console.WriteLine("indtast Titel");
                                        Console.WriteLine("indtast Description");
                                        Console.WriteLine("indtast startidstpunkt");
                                        Console.WriteLine("indtast slutidspunkt");
                                    } break;

                                    // blog
                                case "3":
                                    {
                                        Console.WriteLine("indtast Titel");
                                        Console.WriteLine("indtast Description");
                                        Console.WriteLine("indtast Tidspunkt");
                                        Console.WriteLine("indtast Dine oplysninger");
                                    } break;
                                   
                                //user
                                case "4":
                                    {
                                        Console.WriteLine("indtast name");

                                        Console.WriteLine("indtast email");
                                        Console.WriteLine("indtast phone");
                                        Console.WriteLine("indtast admin");
                                        Console.WriteLine("indtast Usertype");
                                    } break;

                                    //repair
                                case "5": { Console.WriteLine("Beskrivlese af skade");
                                        Console.WriteLine("status af repair");

                                        Console.WriteLine("Hvilken båd");
                                        Console.WriteLine("Dine oplysninger");
                                    } break;
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
                                case "1": { Console.WriteLine("indtast båd id på båd du vil finde");
                                        Console.ReadLine();
                                    } break;
                                case "2": { Console.WriteLine("indtast event id på event du vil finde");
                                        Console.ReadLine();
                                    } break;
                                case "3": { Console.WriteLine("indtast blog id på event du vil finde");
                                        Console.ReadLine(); } break;
                                case "4": { Console.WriteLine("indtast user id på event du vil finde");
                                        Console.ReadLine();
                                    } break;
                                case "5": { Console.WriteLine("indtast repair id på event du vil finde");
                                        Console.ReadLine();
                                    } break;
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
                                case "5": { } break;
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
                                    case "1": { Console.WriteLine("indtast båd id på båd du vil slette");
                                            Console.ReadLine();
                                      
                                        } break;

                                    case "2": { Console.WriteLine("indtast event id på event du vil slette");
                                            Console.ReadLine();
                                        
                                        } break;

                                    case "3": { Console.WriteLine("indtast blog id på event du vil slette");
                                            Console.ReadLine();
                                        
                                        } break;

                                    case "4": { Console.WriteLine("indtast user id på event du vil slette");
                                            Console.ReadLine();
                                        
                                        } break;

                                    case "5": { Console.WriteLine("indtast repair id på event du vil slette");
                                            Console.ReadLine();
                                        
                                        } break;
                                }
                                Console.Clear();
                            }
                            break;
                        }
                      
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
                            Console.WriteLine("enter a name");
                            string name = Console.ReadLine();

                            Console.WriteLine("enter a email");
                            string email = Console.ReadLine();

                            Console.WriteLine("enter a phonenumber");
                            string phone = Console.ReadLine();

                            Console.WriteLine("enter a Y for adming N for not");
                            string adminkey = Console.ReadLine();
                            bool admin = false;

                            if (adminkey == "Y")
                            {
                                admin = true;
                            }
                            Console.WriteLine("hvad er din user status");
                            string menutype = Console.ReadLine();

                            UserTypeEnum themenutype = Enum.Parse<UserTypeEnum>(menutype);

                            User Auser = new User(name, email, phone, admin, themenutype);

                            Console.WriteLine("enter båd du vil booke");
                            controller.BoatRepo.PrintAllBoats();
                            Console.WriteLine("enther the boat id of the boat you want to book");
                            string id = Console.ReadLine();

                            int idnumber = int.Parse(id);
                            Boat aboat = controller.BoatRepo.FindBoatByID(idnumber);


                            Console.WriteLine("hvornår vil du starte din booking i timer");
                            string timestart = Console.ReadLine();
                            int timestartint = int.Parse(timestart);

                            //DateTime start = new DateTime(18, 22);

                            //Booking abooking = new Booking(Auser ,aboat);

                            //controller.BookingRepo.AddBooking(abooking);
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

                            if (adminkey == "Y")
                            {
                                admin = true;
                            }
                            Console.WriteLine("hvad er din user status");
                            string menutype = Console.ReadLine();

                            UserTypeEnum themenutype = Enum.Parse<UserTypeEnum>(menutype);

                            User Auser = new User(name, email, phone, admin, themenutype);

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

