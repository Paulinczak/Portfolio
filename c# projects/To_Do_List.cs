using System;
using System.Collections.Generic;

public class HelloWorld
{   static void WyswietlMenu()
    {
        Console.WriteLine ("Witaj w systemie zarządzania listą zadań!");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("1. Wyświetl listę zadań");
        Console.WriteLine("2. Dodaj zadanie");
        Console.WriteLine("3. Usuń zadanie");
        Console.WriteLine("4. Oznacz zadanie jako wykonane");
        Console.WriteLine("5. Zakończ program");
        Console.WriteLine("--------------------------------");
    }
    static void WyswietlZadanie(List<string> lista, List<bool> statusy)
    {   
        Console.WriteLine("Lista zadań: ");
        if(lista.Count == 0)
        {
            Console.WriteLine("Brak zadań.");
        }
        else
        {
           for (int i = 0; i < lista.Count; i++)
            {   
                Console.Write($"{i + 1}. {lista[i]}, ");
                if (statusy[i] == false) 
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
    static void DodajZadanie(List<string> lista, List<bool> statusy)
    {   
        Console.WriteLine("Podaj treść zadania:");
        string zadanie=Console.ReadLine();
        lista.Add(zadanie);
        statusy.Add(false);
        Console.WriteLine("Zadanie zostało dodane.");  
    }
    static void UsunZadanie(List<string> lista, List<bool> statusy)
    {
        Console.WriteLine("Podaj numer zadanie, które ma zostać usunięte:");
        int numer= int.Parse(Console.ReadLine());
        numer = numer-1; 
        if (numer>=0 && numer<lista.Count)
        {
            lista.RemoveAt(numer);
            statusy.RemoveAt(numer);
            Console.WriteLine("Zadanie usunięto pomyślnie.");
        }
        else
        {
            Console.WriteLine("Podano błędy numer, spróbuj ponownie.");
        }
    }
    static void OznaczJakoWykonane(List<string> lista, List<bool> statusy)
    {
        Console.WriteLine("Podaj numer zadania, którego status ma zostać zmieniony na wykonany:");
        int numer= int.Parse(Console.ReadLine());
        numer = numer-1; 
        if (numer>=0 && numer<lista.Count)
        {
            statusy[numer]= true;
            Console.WriteLine("Status zmieniono pomyślnie");
        }
        else
        {
            Console.WriteLine("Podano błędy numer, spróbuj ponownie.");
        }  
    }
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        List<string> ListaZadan = new List<string>();
        List<bool> Statusy = new List<bool>();

        while(true)
        {
            WyswietlMenu();
            int wybor = int.Parse(Console.ReadLine());
            
            if (wybor == 1)
            {
                WyswietlZadanie(ListaZadan, Statusy);   
            }
            else if (wybor == 2)
            {  
                DodajZadanie(ListaZadan, Statusy);
            }
            else if (wybor == 3)
            {
                UsunZadanie(ListaZadan, Statusy);
            }
            else if (wybor == 4)
            {
                OznaczJakoWykonane(ListaZadan, Statusy);
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
