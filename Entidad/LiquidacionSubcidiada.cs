using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class LiquidacionSubcidiada : LiquidacionCuotaModeradora
    {

        public override double TCuotaModeradora()
        {
                return CuotaModeradora = ValorServicio * 0.5;
            
        }

        public double CalcularCuotaModeradora()
        {
            if (TCuotaModeradora() >= 20000 )
            {
                return CuotaModeradora = 20000;
            }else
            {
                return TCuotaModeradora();
            }
        }

    }
}
