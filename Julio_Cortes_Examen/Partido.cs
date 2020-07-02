using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_Cortes_Examen
{
    public class Partido
    {
        private TimeSpan duration;
        private Equipo[] equipos = new Equipo[2];
        private Equipo equipoGanador;
        private Equipo equipoPerdedor;
        private bool empate;

        public Partido(TimeSpan duration, Equipo[] equipos)
        {
            this.Duration = duration;
            this.Equipos = equipos;
            foreach (Equipo equipo in equipos)
            {
                equipo.Entrenador.JugadorCambiado += this.JugadorCambiado;
            }
        }

        public Equipo EquipoGanador { get => equipoGanador; }
        public Equipo EquipoPerdedor { get => equipoPerdedor;}
        public bool Empate { get => empate; }
        public TimeSpan Duration { get => duration; set => duration = value; }
        public Equipo[] Equipos { get => equipos; set => equipos = value; }

        public bool validMatch()//si los equipos no son del mismo tipo (nacional o de liga) retorna false
        {
            return (Equipos[0].nationalTeam() == Equipos[1].nationalTeam());
        }
        public string MatchType()
        {
            if (validMatch())
            {
                return equipos[0].Jugadores[0].Nation;
            }
            else
            {
                return "El partido no es valido, pues es liga vs nacional";
            }
        }
        public string Lenght()
        {
            return Duration.TotalMinutes.ToString();
        }
        public string Winner()
        {
            if (!empate)
            {
                return $"El equipo ganador es: {equipoGanador.Name}";
            }
            else
            {
                return Draw();
            }
            
        }
        public string Loser()
        {
            if (!empate)
            {
                return $"El equipo perdedor es: {equipoPerdedor.Name}";
            }
            else
            {
                return Draw();
            }
        }
        public string Draw()
        {
            return $"Hubo un empate entre los equipos: {Equipos[0].Name} y {Equipos[1].Name}";
        }
        public void JugadorCambiado(object source,EventArgs e)
        {
            Console.WriteLine("Cambio de jugadorrRealizado...");
        }
        public void simularPartido()
        { }



    }
}
