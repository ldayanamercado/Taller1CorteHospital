using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class LiquidacionContributivaRepository
    {
        public string ruta = @"LiquidacionContributiva.txt";

        public void Guardar(LiquidacionContributiva liquidacionContributiva)
        {
           /* FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(fileStream);
            escritor.WriteLine(LiquidacionContributiva.numeroLiquidacion"+
                 LiquidacionContributiva.identificacion +LiquidacionContributiva.tipoAfiliciacion +
                 LiquidacionContributiva.salarioDevengado + LiquidacionContributiva.valorServicio +
                 LiquidacionContributiva.cuotaModeradora);*/
        }
            
    }
}
