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
        private List<Persona> personas = new List<Persona>();
        private bool empate;

        public Partido(TimeSpan duration, Equipo[] equipos)
        {
            this.Duration = duration;
            this.Equipos = equipos;
            foreach (Equipo equipo in equipos)
            {
                equipo.Entrenador.JugadorCambiado += this.OnJugadorCambiado;
                personas.Add(equipo.Entrenador);
                personas.Add(equipo.Medico);
                personas.AddRange(equipo.Jugadores);
            }
        }


        public TimeSpan Duration { get => duration; set => duration = value; }
        public Equipo[] Equipos { get => equipos; set => equipos = value; }
        public Equipo EquipoGanador { get => equipoGanador; set => equipoGanador = value; }
        public bool Empate { get => empate; set => empate = value; }
        public Equipo EquipoPerdedor { get => equipoPerdedor; set => equipoPerdedor = value; }

        public bool validMatch()//si los equipos no son del mismo tipo (nacional o de liga) retorna false
        {
            string equipos = Equipos[1].nationalTeam().ToString();
            return (Equipos[0].nationalTeam() == Equipos[1].nationalTeam());
           
        }
        public void mostrarParticipantes()//Metodo creado para demostrar polimorfismo
        {
            foreach (Persona persona in personas)
            {
                Console.WriteLine( persona.Show());
            }
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
            if (!Empate)
            {
                return $"El equipo ganador es: {EquipoGanador.Name}";
            }
            else
            {
                return Draw();
            }
            
        }
        public string Loser()
        {
            if (!Empate)
            {
                return $"El equipo perdedor es: {EquipoPerdedor.Name}";
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
        public void OnJugadorCambiado(object source,EventArgs e)
        {
            Console.WriteLine("Cambio de jugador Realizado...");
        }
        public void simularPartido()
        { }



    }
}
