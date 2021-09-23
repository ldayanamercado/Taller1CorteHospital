using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class LiquidacionContributiva : LiquidacionCuotaModeradora
    {
        double salarioMinimo = 877803;


        public override double TCuotaModeradora()
        {
            

            if (salarioDevengado < salarioMinimo*2)
            {
                return cuotaModeradora = valorServicio * 0.15;
            }
            else if ((salarioDevengado>=salarioMinimo*2)&&(salarioDevengado<=salarioMinimo*5))
            {
                return cuotaModeradora = valorServicio * 0.20;

            }else if (salarioDevengado > salarioMinimo * 5)
            {
                return cuotaModeradora = valorServicio * 0.25;

            } return 0;


        }

        public double CalcularCuotaModeradora()
        {
            if (TCuotaModeradora() >= 250000 && salarioDevengado < salarioMinimo * 2)
            {
                return cuotaModeradora = 250000;
            } else if (TCuotaModeradora() >= 900000 &
                (salarioDevengado >= salarioMinimo * 2) && (salarioDevengado <= salarioMinimo * 5))
            {
                return cuotaModeradora = 900000;

            }else if (TCuotaModeradora()>=1500000 && salarioDevengado > salarioMinimo * 5)
            {
                return cuotaModeradora = 1500000;

            }
            else
            {
                return TCuotaModeradora();
            }
        }

       
    }
}
