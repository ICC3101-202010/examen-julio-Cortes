using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio_Cortes_Examen
{
    public abstract class Persona
    {
        protected string name;
        protected int age;
        protected string nation;
        protected double salary;

        protected Persona(string name, int age, string nation, double salary)
        {
            this.name = name;
            this.age = age;
            this.nation = nation;
            this.salary = salary;
        }
        public string Show()
        {
            return $"Nombre: {name}\nEdad: {age.ToString()}\nNacionalidad: {nation}\nSalary: {salary.ToString()}";
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Nation { get => nation; set => nation = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
