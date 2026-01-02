using System;
using System.Collections.Generic;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        List<string> nazwa= new List<string> {"bela", "rura", "cegla"};
        List<int> ilosc= new List<int> {32, 50, 21};
        List<double> cena= new List<double> {15, 20, 18};
        double portfel= 0;
        
        
        while(true)
        {   Console.WriteLine("---------------");
            Console.WriteLine("1.Kup produkt");
            Console.WriteLine("2.Dodaj produkt do magazynu");
            Console.WriteLine("3.Wyświetl sumę zakupów");
            Console.WriteLine("4.Wyjście");
            Console.WriteLine("---------------");
            
            Console.WriteLine("Wybierz opcje: ");
            string wybor= Console.ReadLine();
            
            if(wybor == "1")
            {
               Console.WriteLine($"Prosze podać nazwe wybranego produktu. Do wyboru: ");
               foreach(var produkt in nazwa)
                {
                    Console.Write(produkt+", ");

                }
               string name=Console.ReadLine().Trim();
               int indeks= -1;
                for (int i=0 ; i<nazwa.Count; i++)
                {
                   if (name == nazwa[i])
                   {    indeks = i;
                       Console.WriteLine("wybrano produkt");
                       break;
                   }
                }
                if (indeks == -1)
                {
                    Console.WriteLine("Brak takiego produktu");
                }
                else
                {
                  Console.WriteLine($"Prosze podać ilość {nazwa[indeks]}");
                  int iloscDoKupienia= int.Parse(Console.ReadLine());
                  
                  if (iloscDoKupienia<=0)
                  {
                      Console.WriteLine("Błędna ilość");
                  }
                  else if (iloscDoKupienia>ilosc[indeks])
                  {
                      Console.WriteLine($"Niewystarczająca ilość produktu {nazwa[indeks]}, ilość produktu w magazynie to {ilosc[indeks]}");
                  }
                  else
                  { 
                      double oplata= cena[indeks]* iloscDoKupienia;
                      portfel += oplata;
                      ilosc[indeks] -= iloscDoKupienia;
                      Console.WriteLine($"Dziękujemy za dokonanie zakupu produktu {nazwa[indeks]}");
                      Console.WriteLine($"Opłata wynosi {oplata}zł");
                      Console.WriteLine($"Saldo portfela to {portfel}zł");
                  }
                }
               
            }    
            else if(wybor == "2")
            {
                Console.WriteLine("Podaj nazwę produktu, który chciałbyś dodać");
                string NowyProdukt = Console.ReadLine();
                Console.WriteLine("Podaj ilość produktu, który chciałbyś dodać");
                int NowaIlosc = int.Parse(Console.ReadLine());
                
                if (NowaIlosc<=0)
                {
                    Console.WriteLine("Błedna ilość do dodania");
                }
                else
                {
                    int indeksD= -1;
                    for (int i=0; i<nazwa.Count; i++)
                    {
                        if (nazwa[i].Equals(NowyProdukt, StringComparison.OrdinalIgnoreCase))
                        {
                            indeksD= i;
                            break;
                        }
                    }
                    if (indeksD != -1)
                    {
                        Console.WriteLine("Wartość dodano do magazynu");
                        ilosc[indeksD] += NowaIlosc;
                    }
                    else 
                    {
                        Console.WriteLine("produkt spoza listy.Prosze podać jego cene:");
                        int NowaCena = int.Parse(Console.ReadLine());
                        
                        if(NowaCena<=0)
                        {
                            Console.WriteLine("cena musi być dodatnią liczbą całkowitą");
                        }
                        else
                        {
                            nazwa.Add(NowyProdukt);
                            ilosc.Add(NowaIlosc);
                            cena.Add(NowaCena);
                    
                            Console.WriteLine($"Nowy produkt '{NowyProdukt}' dodany do magazynu.");
                        }
                    }
                }
                
            }
            else if(wybor == "3")
            {   
                Console.WriteLine($"Suma zakupów wynosi {portfel}zł");
                
            }
            else if(wybor == "4")
            {
               Console.WriteLine("Zamykanie programu...");
               break;
            }
            else
            {
                Console.WriteLine("Brak takiej opcji");
            }
        }
    }
}
