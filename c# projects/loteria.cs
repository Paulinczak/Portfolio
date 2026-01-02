using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random rand = new Random();
        int wylosowana = rand.Next(1, 101);
        
        Console.WriteLine("Loteria, wylosuj liczbe z zakresu od 1 do 100. ");
        
        do
        {   
            int strzal = int.Parse(Console.ReadLine());
            
            if (strzal != wylosowana)
            {
                Console.WriteLine("Błedny strzał, spróbuj ponowanie");
                
                
            }
            else if (strzal == wylosowana)
            {
                Console.WriteLine("Wygrana!");
            }
            else
            {
                Console.WriteLine("Błąd");
            }
            
        } while (wylosowana<101);
    }
}
        