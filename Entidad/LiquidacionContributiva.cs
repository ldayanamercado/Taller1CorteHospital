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
            

            if (SalarioDevengado < salarioMinimo*2)
            {
                return CuotaModeradora = ValorServicio * 0.15;
            }
            else if ((SalarioDevengado>=salarioMinimo*2)&&(SalarioDevengado<=salarioMinimo*5))
            {
                return CuotaModeradora = ValorServicio * 0.20;

            }else if (SalarioDevengado > salarioMinimo * 5)
            {
                return CuotaModeradora = ValorServicio * 0.25;

            } return 0;


        }

        public double CalcularCuotaModeradora()
        {
            if (TCuotaModeradora() >= 250000 && SalarioDevengado < salarioMinimo * 2)
            {
                return CuotaModeradora = 250000;
            } else if (TCuotaModeradora() >= 900000 &
                (SalarioDevengado >= salarioMinimo * 2) && (SalarioDevengado <= salarioMinimo * 5))
            {
                return CuotaModeradora = 900000;

            }else if (TCuotaModeradora()>=1500000 && SalarioDevengado > salarioMinimo * 5)
            {
                return CuotaModeradora = 1500000;

            }
            else
            {
                return TCuotaModeradora();
            }
        }

       
    }
}
