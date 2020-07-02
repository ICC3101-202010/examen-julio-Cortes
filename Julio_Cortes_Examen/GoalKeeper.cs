using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_Cortes_Examen
{
    public class GoalKeeper:Jugador,IGoalKeeper
    {
        public GoalKeeper(string name, int age, string nation, double salary, int atackpoints, int defensepoints, int nofshirt) : base(name, age, nation, salary, atackpoints, defensepoints, nofshirt)
        {
        }

        public void goalKeeper()
        {
            Console.WriteLine("Este jugado es arquero");
        }
    }
}
