using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_Cortes_Examen
{
    public class Entrenador : Persona
    {
        private int tacticpoints;
        public Entrenador(string name, int age, string nation, double salary,int tacticpoints) : base(name, age, nation, salary)
        {
            this.tacticpoints = tacticpoints;
        }

        public int Tacticpoints { get => tacticpoints; set => tacticpoints = value; }
        public delegate void CambiarJugadorEventHandler(object source, EventArgs e);
        public event CambiarJugadorEventHandler JugadorCambiado;
        public void OnJugadorLesionado(object source, EventArgs e)
        {
            OnJugadorCambiado();
        }
        protected virtual void OnJugadorCambiado()
        {
            if (JugadorCambiado!=null)
            {
                Console.WriteLine("Solicito cambio de jugador");
                JugadorCambiado(this, EventArgs.Empty);
            }
        }
        public override string Show()
        {
            return base.Show()+$"\nPuntos tacticos: {tacticpoints.ToString()}";
        }

    }
}
