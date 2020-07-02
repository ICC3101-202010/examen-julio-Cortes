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
        public bool Evaluar(Jugador jugador)//retorna false si el jugador esta sano
        {
            if (jugador.Healthy)
            {
                Console.WriteLine($"El jugador {jugador.Name} se encuentra sano.");
            }
            else
            {
                Console.WriteLine($"El jugador {jugador.Name} se encuentra lesionado.");
            }
            
            return !(jugador.Healthy);
        }
        public override string Show()
        {
            return base.Show()+$"\nPuntos de experiencia: {xppoints.ToString()}";
        }
        public void Curar(Jugador jugador)
        {
            jugador.Healthy = true;
            Console.WriteLine($"El jugador {jugador.Name} ha sido sanado." );
        }
    }
}
