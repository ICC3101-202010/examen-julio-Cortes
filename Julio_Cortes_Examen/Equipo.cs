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

        public Jugador[] Jugadores { get => jugadores; set => jugadores = value; }
        public Entrenador Entrenador { get => entrenador; set => entrenador = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public string Name { get => name; set => name = value; }
        public bool nationalTeam()
        {
            return true;
        }
    }
}
