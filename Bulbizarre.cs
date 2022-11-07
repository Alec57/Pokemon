using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2
{
    public class Bulbizarre : Personnage
    {
        public Bulbizarre(string nom) : base(nom)
        {
            pointsDeVie = 100;
            degatsMin = 20;
            degatsMax = 40;
            vitesse = 4;
        }
    }
}
