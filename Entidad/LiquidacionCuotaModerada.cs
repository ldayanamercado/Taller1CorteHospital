using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public abstract class LiquidacionCuotaModeradora
    {
       

        public string numeroLiquidacion { get; set; }
        public string identificacion { get; set; }
        public string tipoAfiliciacion { get; set; }
        public double salarioDevengado { get; set; }
        public double valorServicio { get; set; }
        public double cuotaModeradora { get; set; }

        public abstract double TCuotaModeradora();

        public override string ToString()
        {
            return $"Numero de liquidacion:{numeroLiquidacion} \nNumero de identificacion: {identificacion}" +
                $"tipo de afiliciacion: {tipoAfiliciacion} \nSalario de vengado: {salarioDevengado}" +
                $" valor del servicio: {valorServicio} \n valor de la cuota moderadora: {cuotaModeradora}";
        }

    }
}
