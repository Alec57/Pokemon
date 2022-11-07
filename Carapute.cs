using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2
{
    public class Carapute : Personnage
    {
        public Carapute(string nom) : base(nom)
        {
            pointsDeVie = 100;
            degatsMin = 25;
            degatsMax = 45;
            vitesse = 3;
        }
    }
}

