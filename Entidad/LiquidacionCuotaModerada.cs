using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public abstract class LiquidacionCuotaModeradora
    {
        protected LiquidacionCuotaModeradora()
        {
        }

        protected LiquidacionCuotaModeradora(string numeroLiquidacion,
            string identificacion, string tipoAfiliciacion, double salarioDevengado,
            double valorServicio, double cuotaModeradora)
        {
            this.numeroLiquidacion = numeroLiquidacion;
            this.identificacion = identificacion;
            this.tipoAfiliciacion = tipoAfiliciacion;
            this.salarioDevengado = salarioDevengado;
            this.valorServicio = valorServicio;
            this.cuotaModeradora = cuotaModeradora;
        }

        public String numeroLiquidacion { get; set; }
        public String identificacion { get; set; }
        public String tipoAfiliciacion { get; set; }
        public double salarioDevengado { get; set; }
        public double valorServicio { get; set; }
        public double cuotaModeradora { get; set; }

        public abstract double CuotaModeradora();

        public override string ToString()
        {
            return $"Numero de liquidacion:{numeroLiquidacion} \nNumero de identificacion: {identificacion}" +
                $"tipo de afiliciacion: {tipoAfiliciacion} \nSalario de vengado: {salarioDevengado}" +
                $" valor del servicio: {valorServicio} \n valor de la cuota moderadora: {cuotaModeradora}";
        }

    }
}
