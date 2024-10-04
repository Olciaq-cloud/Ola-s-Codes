using System;
namespace c_03._0
// Całkowite bez znaku to uint
{
    class Program // Klasa program
    {
        public static void Main(string[] args) // metoda główna - wykonawcza
        {
        	// Wybór opcji
            Console.WriteLine("1 - Jednostki długości");
            Console.WriteLine("2 - Jednostki masy");
            Console.WriteLine("3 - Jednostki objętości");
            // Odczytanie która opcja została wybrana
            uint opcja=uint.Parse(Console.ReadLine());
            // Zmienne dla zmiany jednostek
            double ang,pol;
            switch(opcja){
            // Jednostki długości
            	case 1:
                    Console.WriteLine("Wybrałeś jednostki długości");
            		// Wybór opcji zamiany jednostek
                    Console.WriteLine("1 - mile/kilometry");
                    Console.WriteLine("2 - jardy/metry");
                    Console.WriteLine("3 - stopy/metry");
                    Console.WriteLine("4 - cale/centymetry");
            		// Odczytanie wyboru
                    uint opcja1 = uint.Parse(Console.ReadLine());
            		// Przeliczanie jednostek ze względu na wybór
                    switch(opcja1){
                        //Przeliczenie mil na kilometry
                        case 1:
                            Console.WriteLine("Podaj liczbę mil: ");
                            ang=double.Parse(Console.ReadLine());
                            pol = 1.609*ang;
                            Console.WriteLine("{0} mil to jest {1} kilometrów",ang,pol);
                        break;    
                        //Przeliczenie jardów na kilometry
                        case 2:
                            Console.WriteLine("Podaj liczbę jardów: ");
                            ang=double.Parse(Console.ReadLine());
                            pol = 0.9144*ang;
                            Console.WriteLine("{0} jardów to jest {1} metrów",ang,pol);
                        break;
                        // Przeliczenie stóp na metry
                        case 3:
                            Console.WriteLine("Podaj liczbę stóp: ");
                            ang=double.Parse(Console.ReadLine());
                            pol = 0.3048*ang;
                            Console.WriteLine("{0} stóp to jest {1} metrów",ang,pol);
                        break;
                        // Przeliczenie cali na centymetry
                        case 4:
                            Console.WriteLine("Podaj liczbę cali: ");
                            ang=double.Parse(Console.ReadLine());
                            pol = 2.54*ang;
                            Console.WriteLine("{0} cali to jest {1} centymeteów",ang,pol);
                        break;
                        // Podanie nieprawidłowego wyboru
                        default:
                            Console.WriteLine("Nie ma takiego wyboru");
                        break;
                    }
                break;
                // Jednostki masy
                case 2:
                    // Wybór opcji zamiany jednostek
                    Console.WriteLine("Wybrałeś jednostki masy");
                    Console.WriteLine("1 - funty/kilogramy");
                    Console.WriteLine("2 - uncje/gramy");
                    Console.WriteLine("3 - karaty/gramy");
                    // Odczytanie wyboru
                    uint opcja2 = uint.Parse(Console.ReadLine());
                    // Przeliczanie jednostek ze względu na wybór
                    switch(opcja2){
                    	case 1:
                            //Przeliczenie funtów na kilogramy
                    		Console.WriteLine("Podaj liczbę funtów: ");
                    		ang=double.Parse(Console.ReadLine());
                    		pol=0.45359237*ang;
                    		Console.WriteLine("{0} funtów to {1} kilogramów",ang,pol);
                    	break;
                            //Przeliczenie uncji na kilogramy
                    	case 2:
                    		Console.WriteLine("Podaj liczbę uncji: ");
                    		ang=double.Parse(Console.ReadLine());
                    		pol=0.0283495231*ang;
                    		Console.WriteLine("{0} uncji to {1} kilogramów",ang,pol);
                    	break;
                    	case 3:
                            //Przeliczenie karatów na kilogramy
                   		 	Console.WriteLine("Podaj liczbę karatów: ");
                   		 	ang=double.Parse(Console.ReadLine());
                    		pol=0.0002*ang;
                    		Console.WriteLine("{0} karatów to {1} kilogramów",ang,pol);
                    	break;
                        // Podanie nieprawidłowego wyboru
                    	default:
                    	Console.WriteLine("Nie ma takiego wyboru");
                		break;
                    }
                break;
                case 3:
                    // Wybór opcji zamiany jednostek
                    Console.WriteLine("Wybrałeś jednostki objętości");
                    Console.WriteLine("1- galony/litry");
                    Console.WriteLine("2 - baryłki/litry");
                    // Odczytanie wyboru
                    uint opcja3 = uint.Parse(Console.ReadLine());
                    // Przeliczanie jednostek ze względu na wybór
                    switch(opcja3){
                    	case 1:
                            // Przeliczenie galonów na litry
                    		Console.WriteLine("Podaj liczbę galonów: ");
                    		ang=double.Parse(Console.ReadLine());
                    		pol=3.78541178*ang;
                    		Console.WriteLine("{0} galonów to {1} litrów",ang,pol);
                    	break;
                    	case 2:
                            // Przeliczenie baryłek na litry
                    		Console.WriteLine("Podaj liczbę baryłek: ");
                    		ang=double.Parse(Console.ReadLine());
                    		pol=159*ang;
                    		Console.WriteLine("{0} baryłek to {1} litrów",ang,pol);
                    	break;
                        // Podanie nieprawidłowego wyboru
                    	default:
                    	Console.WriteLine("Nie ma takiego wyboru");
                		break;
                    }
                break;
                // Podanie nieprawidłowego wyboru
                default:
                    Console.WriteLine("Nie ma takiego wyboru");
                break;
            }
            // Zakończenie kodu
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
