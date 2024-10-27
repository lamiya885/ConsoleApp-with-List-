using System.Net.NetworkInformation;
using CORE1.Data;
using CORE1.Models;

Hotel hotel = new Hotel(Console.ReadLine());
List<Hotel> list = new List<Hotel>();

Room room1;

bool f = true;
string operation = Console.ReadLine();
do
{
    Console.WriteLine("1.Sisteme giris ,0.Cixis");
    switch (operation)
    {
        case "1":
            Console.WriteLine("sisteme giris edildi");
            bool f1 = true;
            do
            {
                Console.WriteLine("1.Hotel yarat ,2.butun hotelleri gor,3.hotel sec,0.EXIT");
                string option = Console.ReadLine();
                switch (option)
                {

                    case "1":

                        Console.WriteLine("hotel adi daxil edin");
                        string hotelName = Console.ReadLine();
                        Hotel newHotel = new Hotel(hotelName);

                        if (hotelName == hotel.Name)
                        {
                            Console.WriteLine(" bu adda Hotel var");
                        }
                        else
                        {
                            Console.WriteLine("Hotel ugurla yaradildi");
                        }





                        break;
                    case "2":

                        Console.WriteLine("hotel ADI DAXIL EDIN");
                        string name = Console.ReadLine();
                        hotel = new Hotel(name);
                        
                        
                        break;
                    case "3":

                        bool f2= true;
                        
                        do
                        {
                            Console.WriteLine("1.room yarat ,2. roomlari gor ,3.rezervation et,4,evvel ki menuya qayit,0.exit ");
                            string operation2= Console.ReadLine();
                            switch(operation2)
                            {
                                case "0":
                                    f= true;
                                    break;
                                case "1":
                                    string name1= Console.ReadLine();
                                    reset:
                                    bool l = double.TryParse(Console.ReadLine, out  double price);
                                    if (l=false)
                                    {
                                        Console.WriteLine("duzgun eded daxil edin");
                                        goto reset;
                                    }
                                    Personcapacity personcapacity = new Personcapacity();
                                    Room room = new Room(name1, price, personcapacity);
                                    break;
                                    case "2":
                                    
                                     break;
                                    case "3":
                                    
                                    break;
                                    case "4":
                                    f2 = true;
                                    break;
                                    
                            }

                        } while (!f2);

                        break;

                    case "0":
                        f = false;
                        break;
                }
            } while (!f);
            break;

        case "2":
            f = false;
            break;

    }
} while (!f);
