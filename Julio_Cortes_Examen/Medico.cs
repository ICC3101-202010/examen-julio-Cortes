using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_Cortes_Examen
{
    public class Medico : Persona
    {
        private int xppoints;
        public Medico(string name, int age, string nation, double salary,int xppoints) : base(name, age, nation, salary)
        {
            this.xppoints = xppoints;
        }

        public int Xppoints { get => xppoints; set => xppoints = value; }
        public bool Evaluar(Jugador jugador)
        {
            return true;
        }
        public void Curar(Jugador jugador)
        {

        }
    }
}
