using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public abstract class LiquidacionCuotaModeradora
    {
       

        public string NumeroLiquidacion { get; set; }
        public string Identificacion { get; set; }
        public string TipoAfiliciacion { get; set; }
        public double SalarioDevengado { get; set; }
        public double ValorServicio { get; set; }
        public double CuotaModeradora { get; set; }
        public double  FechaLiquidacion { get; set; }




    public abstract double TCuotaModeradora();

        public override string ToString()
        {
            return $"Numero de liquidacion:{NumeroLiquidacion} \nNumero de identificacion: {Identificacion}" +
                $"tipo de afiliciacion: {TipoAfiliciacion} \nSalario de vengado: {SalarioDevengado}" +
                $" valor del servicio: {ValorServicio} \n valor de la cuota moderadora: {CuotaModeradora} \n Feccha de liquidacion : {FechaLiquidacion}";
        }

    }
}
