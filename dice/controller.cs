using System;
using System.Collections.Generic;
using System.Text;

namespace dice
{
    public class Controleur
    {
        int total;
        public string BrasserDee(int nombreDeFace)
        {
            int valeur;
            Dee Dice = new Dee(nombreDeFace);
            if (Dice.type)
            {
                valeur = Dice.brasser();
                if (valeur <= 3)
                {
                    int valeur2 = Dice.brasser();
                    if (valeur2 >= valeur)
                    {
                        total += valeur2;
                        return "votre dé est pipé, la valeur du dé est : " + valeur2 + " et votre total de point est : " + total;
                    }
                    else
                    {
                        total += valeur;
                        return "votre dé est pipé, la valeur du dé est : " + valeur + " et votre total de point est : " + total;
                    }
                }
                else
                {
                    total += valeur;
                    return "votre dé est pipé, la valeur du dé est : " + valeur + " et votre total de point est : " + total;
                }
            }
            else
            {
                valeur = Dice.brasser();
                total += valeur;
                return "votre dé est ordinaire, la valeur du dé est : " + valeur + " et votre total de point est : " + total;
            }
        }
    }
}
