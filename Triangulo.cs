
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    public class Triangulo : Formas
    {
        public Triangulo() : base()
        {
            this.Area = 0;
        }

        public Triangulo(String Forma, Double Base, Double Altura, Double Area) : base(Forma, Base, Altura)
        {
            this.Area = Area;
        }

        public Double Area { get; set; }

        public override Double CalcularArea()
        {
            Double areabase = this.Base * this.Altura;
            this.Area = areabase / 2;
            return this.Area;
        }
    }
}
