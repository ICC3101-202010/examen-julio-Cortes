using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_Cortes_Examen
{
    public class Equipo
    {
        private Jugador[] jugadores = new Jugador[15];
        private Entrenador entrenador;
        private Medico medico;
        private string name;
        private bool national;


        public Equipo(Jugador[] jugadores, Entrenador entrenador, Medico medico, string name)
        {
            this.jugadores = jugadores;
            this.entrenador = entrenador;
            this.medico = medico;
            this.name = name;
            this.national = this.nationalTeam();
            foreach (Jugador jugador in jugadores)
            {
                jugador.JugadorLesionado += entrenador.OnJugadorCambiado;     
            }
        }

        public Jugador[] Jugadores { get => jugadores; set => jugadores = value; }
        public Entrenador Entrenador { get => entrenador; set => entrenador = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public string Name { get => name; set => name = value; }
        public bool National { get => national; set => national = value; }

        public bool nationalTeam() //retorna true si todos los jugadores tienen la misma nacionalidad
        {
            string nationality = this.jugadores[0].Nation;
            return !(jugadores.Any(u => u.Nation.ToLower() != nationality.ToLower()));
        }
    }
}
