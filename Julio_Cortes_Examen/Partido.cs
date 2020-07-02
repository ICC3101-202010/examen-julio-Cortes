using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_Cortes_Examen
{
    public class Partido
    {
        private TimeSpan duration;
        private Equipo[] equipos = new Equipo[2];

        public Partido(TimeSpan duration, Equipo[] equipos)
        {
            this.duration = duration;
            this.equipos = equipos;
        }

        public bool nationalMatch()
        {
            foreach (Equipo equipo in equipos)
            {

            }
            return true;
        }

    }
}
