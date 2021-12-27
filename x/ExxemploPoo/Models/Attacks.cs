using System;


namespace ExxemploPoo.Models
{
    public class Attacks
    {
        private bool Tem_Mana = true;
        protected double Dano = 10;
        private double Mana = 10;

        public void DefineSeAttack(double Mana, double Dano)
        {
            this.Mana = Mana;
            this.Dano = Dano;
        }

       
    }
}