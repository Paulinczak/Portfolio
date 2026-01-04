using System;
using System.Collections.Generic;

public class HelloWorld
{   
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        List<string> ListaZadan = new List<string>();
        List<bool> Statusy = new List<bool>();

        while(true)
        {
            Console.WriteLine ("Witaj w systemie zarządzania listą zadań!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Wyświetl listę zadań");
            Console.WriteLine("2. Dodaj zadanie");
            Console.WriteLine("3. Usuń zadanie");
            Console.WriteLine("4. Oznacz zadanie jako wykonane");
            Console.WriteLine("5. Zakończ program");
            Console.WriteLine("--------------------------------");
            int wybor = int.Parse(Console.ReadLine());
            
            if (wybor == 1)
            {
                Console.WriteLine("Lista zadań: ");
                if(ListaZadan.Count == 0)
                {
                    Console.WriteLine("Brak zadań.");
                }
                else
                {
                    
                    for (int i = 0; i < ListaZadan.Count; i++)
                    {   
                        Console.Write($"{i + 1}. {ListaZadan[i]}, ");
                        if (Statusy[i] == false) 
                        {
                            Console.WriteLine("Niewykonane");
                        }
                        else
                        {
                            Console.WriteLine("Wykonane");
                        }
                    }
                }
            }
            else if (wybor == 2)
            {   
                Console.WriteLine("Podaj treść zadania:");
                string zadanie=Console.ReadLine();
                ListaZadan.Add(zadanie);
                Statusy.Add(false);
                Console.WriteLine("Zadanie zostało dodane.");
            }
            else if (wybor == 3)
            {
                Console.WriteLine("Podaj numer zadanie, które ma zostać usunięte:");
                int numer= int.Parse(Console.ReadLine());
                numer = numer-1; 
                if (numer != -1)
                {
                    ListaZadan.RemoveAt(numer);
                    Statusy.RemoveAt(numer);
                    Console.WriteLine("Zadanie usunięto pomyślnie.");
                }
                else
                {
                    Console.WriteLine("Podano błędy numer, spróbuj ponownie.");
                }
            }
            else if (wybor == 4)
            {
                Console.WriteLine("Podaj numer zadania, którego status ma zostać zmieniony na wykonany:");
                int numer= int.Parse(Console.ReadLine());
                numer = numer-1; 
                if (numer>=0 && numer<ListaZadan.Count)
                {
                    Statusy[numer]= true;
                    Console.WriteLine("Status zmieniono pomyślnie");
                }
                else
                {
                    Console.WriteLine("Podano błędy numer, spróbuj ponownie.");
                }
            }
            else if (wybor == 5)
            {
                Console.WriteLine("Do zobaczenia!");
                break;
            }
            else
            {
                Console.WriteLine("Wystąpił błąd. Spróbuj ponownie.");
            }
        }
    }
}
