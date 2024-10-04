using System;

namespace jakiescoskwadraty
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Zmienne w naszym kodzie
            double a,b,c,delta,x1,x2,x3;
            // Współczynnik a - przy x^2
            Console.Write("Podaj współczynnik a:");
            a = double.Parse(Console.ReadLine());
            // Współczynnik b - przy x
            Console.Write("Podaj współczynnik b:");
            b = double.Parse(Console.ReadLine());
            // Współczynnik c - wyraz wolny
            Console.Write("Podaj współczynnik c:");
            c = double.Parse(Console.ReadLine());
            //Sprawdzanie czy równanie jest kwadratowe
            if(a==0){
                Console.Write("To nie jest równanie kwadratowe!!!");
                Console.Write("Jest to równanie liniowe");
                x1=-c/b;
                Console.Write("Równanie liniowe ma 1 rozwiązanie {0}",x1);
            }
            else{
            // Równanie 
            Console.Write("\nRównanie ma postać: {0}x^2 + {1}x + {2} = 0",a,b,c);
            // Obliczanie delty
            delta = b*b-(4*a*c);
            // Delta == wynik
            Console.Write("\nDelta wynosi: "+delta);
            // Delta < 0 - 0 rozwiązań
            if(delta<0){
                Console.Write("\nRównanie nie ma rozwiązania gdyż delta jest mniejsza od 0");
            }
            // Delta = 0 - 1 rozwiązanie 
            if(delta==0){
                Console.Write("\nRównanie ma 1 rozwiązanie bo delta jest równa 0");
                x1 = -b/(2*a);
                Console.Write("\nPierwiastkiem tego rozwiązania jest x0 = "+x1);
            }
	// Delta > 0 - 2 rozwiązania
            if(delta>0){
                Console.Write("\nRównanie ma 2 rozwiązania bo delta jest większa od 0");
                x2 = (-b - Math.Sqrt(delta))/(2*a);
                x3 = (-b + Math.Sqrt(delta))/(2*a);
                Console.WriteLine("\nRozwiązaniami są x1 = {0} i x2 = {1}",x2,x3);
            }
            }
            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
