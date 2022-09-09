using System;
using System.Collections.Generic;
using System.Text;

namespace dice
{
    public class Dee
    {
        private readonly int NombreDeFace;
        private readonly bool Type;

        public bool type => Type;

        public Dee(int face)
        {
            Random random = new Random();
            int type = random.Next(2);
            if (type == 0)
            {
                this.Type = false;
            }
            else
            {
                this.Type = true;
            }
            this.NombreDeFace = face;
        }

        public int brasser()
        {
            Random random = new Random();
            int valeur = random.Next(1, NombreDeFace + 1);
            return valeur;
        }
    }
}
