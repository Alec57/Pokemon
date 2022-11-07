using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2
{
    public abstract class Entité
    {
        protected string nom;
        protected bool estMort = false;
        protected int pointsDeVie;
        protected int degatsMin;
        protected int degatsMax;
        protected int vitesse;
        protected Random random = new Random();

        public Entité(string nom)
        {
            this.nom = nom;
        }
        public void Attaquer(Entité uneEntité)
        {
            int degats = random.Next(degatsMin, degatsMax);

            uneEntité.PerdrepointsDeVie(degats);
            Console.WriteLine(this.nom + "(" + this.pointsDeVie + ")" + "attaque :" + uneEntité.nom);
            Console.WriteLine(uneEntité.nom + " a perdu " + degats + " points de vie");
            Console.WriteLine("Il reste " + uneEntité.pointsDeVie + " points de vie a " + uneEntité.nom);
            if(uneEntité.estMort)
            {
                Console.WriteLine(uneEntité.nom + " est mort mdr");
            }
        
        }


        protected void PerdrepointsDeVie(int pointsDeVie)
        {
            this.pointsDeVie -= pointsDeVie;
            if(this.pointsDeVie <= 0)
            {
                this.pointsDeVie = 0;
                estMort = true;
            }
        }

        public bool EstMort()
        {
            return this.estMort;
        }


    }
}
