using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuotaModeradoraRepository liquidacionCuotaModeradoraRepository;

        public LiquidacionCuotaModeradoraService()
        {
            liquidacionCuotaModeradoraRepository = new LiquidacionCuotaModeradoraRepository();
        }

        public string Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            try
            {
                liquidacionCuotaModeradoraRepository.Guardar(liquidacionCuotaModeradora);
                return "LA LIQUIDACION MODERADORA HA SIDO RESGISTRADA CORRECTAMENTE";
            }
            catch (Exception)
            {
                return "LA LIQUIDACION MODERADORA NO SE PUDO REGISTRAR ";
            }

        }
    }
}
