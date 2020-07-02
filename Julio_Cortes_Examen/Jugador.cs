using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_Cortes_Examen
{
    public class Jugador : Persona
    {
        private int atackpoints;
        private int defensepoints;
        private int nofshirt;
        private bool healthy;
        public delegate void LesionJugadorEventHandler(object source, EventArgs e);
        public event LesionJugadorEventHandler JugadorLesionado;


        public Jugador(string name, int age, string nation, double salary, int atackpoints, int defensepoints, int nofshirt) : base(name, age, nation, salary)
        {
            this.Atackpoints = atackpoints;
            this.Defensepoints = defensepoints;
            this.Nofshirt = nofshirt;
            this.healthy = true;
        }

        protected virtual void OnJugadorLesionado()
        {
            if (JugadorLesionado!=null)
            {
                this.healthy = false; ;
                JugadorLesionado(this, EventArgs.Empty);
                Console.WriteLine("Profe! cambio porfa");
            }
        }
        public override string Show()
        {
            return base.Show()+$"\nPuntos de ataque: {atackpoints.ToString()}\nPuntos de defensa: {defensepoints.ToString()}\nNumero de polera: {nofshirt.ToString()}";
        }

        public int Atackpoints { get => atackpoints; set => atackpoints = value; }
        public int Defensepoints { get => defensepoints; set => defensepoints = value; }
        public int Nofshirt { get => nofshirt; set => nofshirt = value; }
        public bool Healthy { get => healthy; set => healthy = value; }
    }
}
