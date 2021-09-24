using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LiquidacionCuotaModeradoraRepository
    {
        string ruta = @"LiquidacionCuotaModeradora.txt";
        public void Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{liquidacionCuotaModeradora.NumeroLiquidacion};{liquidacionCuotaModeradora.FechaLiquidacion};" +
                $"{liquidacionCuotaModeradora.Identificacion};{liquidacionCuotaModeradora.TipoAfiliciacion};" +
                $"{liquidacionCuotaModeradora.SalarioDevengado};{liquidacionCuotaModeradora.ValorServicio}");
            escritor.Close();
            file.Close();
        }

    }
}
