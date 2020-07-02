using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_Cortes_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();
            List<Jugador> jugadores = new List<Jugador>();

            for (int j = 0; j < 14; j++)
            {
                Jugador jugador = new Jugador("name", 20, "Chile", 200, 10, 10, 15);
                jugadores.Add(jugador);
            }
            GoalKeeper goalkeeper = new GoalKeeper("name", 20, "Chile", 200, 10, 10, 15);
            jugadores.Add(goalkeeper);
            Entrenador entreador = new Entrenador("trainer", 20, "Chile", 200, 10);
            Medico medico = new Medico("medic", 20, "Chile", 200, 10);
            Equipo equipo = new Equipo(jugadores.ToArray(), entreador, medico, "FC");
            equipos.Add(equipo);

            jugadores.Clear();
            for (int j = 0; j < 14; j++)
            {
                Jugador jugador = new Jugador("name", 20, "Peru", 200, 10, 10, 15);
                jugadores.Add(jugador);
            }
            GoalKeeper goalkeeper1 = new GoalKeeper("name", 20, "Brasil", 200, 10, 10, 15);
            jugadores.Add(goalkeeper1);
            Entrenador entreado1r = new Entrenador("trainer", 20, "Chile", 200, 10);
            Medico medico1 = new Medico("medic", 20, "Chile", 200, 10);
            Equipo equipo1 = new Equipo(jugadores.ToArray(), entreado1r, medico1, "Ft");
            equipos.Add(equipo1);

            TimeSpan time = new TimeSpan();
            Partido partido=new Partido(time, equipos.ToArray());
            partido.EquipoGanador = equipo1;
            partido.EquipoPerdedor = equipo;
            partido.Empate = false;
            entreado1r.JugadorCambiado += partido.OnJugadorCambiado;//Para ver la funcionaldiades es cosa de descomentar los cw debajo

            //Console.WriteLine(partido.validMatch());
            //Console.WriteLine(jugadores[4].Show());
            //Console.WriteLine(equipo1.show());
            //Console.WriteLine(partido.Winner());
            //partido.mostrarParticipantes();

        }
    }
}
