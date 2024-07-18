using System;  

namespace Blackjack 
{  
    public class BS
    {  
        public void beginn()
        {
            Console.WriteLine("Willkommen zu Blackjack!");
        }
        public void einsatz() 
        { 
            Console.WriteLine("den Einsatz bitte"); 
        }  

        public void Karten() 
        { 
            Console.WriteLine("hier sind deine Karten"); 
        } 
    }  
}  
namespace Poker  
{  
    public class PS 
    {  
        public void beginn()
        {
            Console.WriteLine("Willkommen zu Blackjack!");
        }
        public void einsatz() 
        { 
            Console.WriteLine("Dein Einsatz"); 
        }  

        public void Karten() 
        { 
            Console.WriteLine("Deine Karten"); 
        }  
    }  
}  

namespace Rolett 
{  
    public class RS 
    {  
        public void beginn()
        {
            Console.WriteLine("Willkommen zu Rolett!");
        }
        public void einsatz() 
        { 
            Console.WriteLine("Dein Einsatz bitte!"); 
        }  

        public void Karten() 
        { 
            Console.WriteLine("Deine Karten"); 
        }  
    }  
}  
public class Casino  
{  
        public static void Main()  
        {  
            Blackjack.BS bs = new Blackjack.BS();  
            Poker.PS ps = new Poker.PS();  
            Rolett.RS rs = new Rolett.RS();  

            Console.WriteLine("Was möchtest du spielen?");
            Console.WriteLine("Blackjack: B, Poker: P oder Rolett: R");
            string game = Console.ReadLine();

            if (game == "B")
            {
                bs.beginn();
                bs.einsatz(); 
                bs.Karten();
            }
            else if (game == "P")
            {
                ps.beginn();
                ps.einsatz(); 
                ps.Karten();
            }
            else if(game == "R")
            {
                rs.beginn();
                rs.einsatz(); 
                rs.Karten();
            }
            else
            {
                Console.WriteLine("Kein gültiges Spiel ausgewählt!");
            }
        
        }  
}  
