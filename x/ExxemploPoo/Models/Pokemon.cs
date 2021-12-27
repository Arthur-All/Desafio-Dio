using System;

namespace ExxemploPoo.Models
{
    public class Pokemon
    {
        public string Nome {get; set;}
        public int Vida {get; set;} 
        public int Attack {get;set;}


        public void status_() /*Status (Aprensentação do pokemon)*/
        {
            Console.WriteLine($"Nome:{Nome} Vida:{Vida}"); 
        }
    }
}