using System;
using Logica;
using Entidad;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("");
            LiquidacionCuotaModeradora liquidacionCuotaModeradora = new LiquidacionContributiva();
            liquidacionCuotaModeradora.cuotaModeradora = 100000;
            liquidacionCuotaModeradora.identificacion = "1065";
            liquidacionCuotaModeradora.numeroLiquidacion = "456";
            liquidacionCuotaModeradora.salarioDevengado = 1200000;
            liquidacionCuotaModeradora.tipoAfiliciacion = "Contributivo";
            liquidacionCuotaModeradora.valorServicio = 700000;
            Console.WriteLine($"la liquidacion de la cuota moderadora es :{liquidacionCuotaModeradora.TCuotaModeradora()}");
            Console.ReadKey();*/

            string numeroLiquidacion;
            string identificacion;
            string tipoAfiliciacion;
            double salarioDevengado;
            double valorServicio;
            double cuotaModeradora;
            double FechaLiquidacion;
            int opcion;

            Console.WriteLine("MENU");
            Console.WriteLine("1. REGISTRAR");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("SELECCIONE UNA OPCION: ");
            opcion = int.Parse(Console.ReadLine());

            LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
            switch (opcion)
            {
                case 1:

                    Console.Write("Numero de Liquidacion: ");
                    numeroLiquidacion = Console.ReadLine();
                    Console.Write("Identificacion: ");
                    identificacion = Console.ReadLine();
                    Console.Write("tipo De Afiliciacion: ");
                    tipoAfiliciacion = Console.ReadLine();
                    Console.WriteLine("Salario Devengado");
                    salarioDevengado = double.Parse(Console.ReadLine());
                    Console.WriteLine("Valor Del servicio");
                    valorServicio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Fecha De Liquidacion");
                    FechaLiquidacion = double.Parse(Console.ReadLine());

                    if (tipoAfiliciacion.ToUpper().Equals("SUBSIDIADO"))
                    {
                        LiquidacionCuotaModeradora liquidacionCuotaModeradora = new LiquidacionSubcidiada();

                        liquidacionCuotaModeradora.NumeroLiquidacion = numeroLiquidacion;
                        liquidacionCuotaModeradora.Identificacion = identificacion;
                        liquidacionCuotaModeradora.TipoAfiliciacion = tipoAfiliciacion;
                        liquidacionCuotaModeradora.SalarioDevengado = salarioDevengado;
                        liquidacionCuotaModeradora.ValorServicio = valorServicio;
                        liquidacionCuotaModeradora.FechaLiquidacion = FechaLiquidacion;
                        Console.WriteLine($"la liquidacion de la cuota moderadora es :{liquidacionCuotaModeradora.TCuotaModeradora()}");

                        Console.WriteLine(liquidacionCuotaModeradoraService.Guardar(liquidacionCuotaModeradora));
                    }
                    else
                    {
                        if (tipoAfiliciacion.ToUpper().Equals("CONTRIBUTIVO"))
                        {
                            LiquidacionCuotaModeradora liquidacionCuotaModeradora = new LiquidacionContributiva();
                            liquidacionCuotaModeradora.NumeroLiquidacion = numeroLiquidacion;
                            liquidacionCuotaModeradora.Identificacion = identificacion;
                            liquidacionCuotaModeradora.TipoAfiliciacion = tipoAfiliciacion;
                            liquidacionCuotaModeradora.SalarioDevengado = salarioDevengado;
                            liquidacionCuotaModeradora.ValorServicio = valorServicio;
                            liquidacionCuotaModeradora.FechaLiquidacion = FechaLiquidacion;
                            Console.WriteLine($"la liquidacion de la cuota moderadora es :{liquidacionCuotaModeradora.TCuotaModeradora()}");

                            Console.WriteLine(liquidacionCuotaModeradoraService.Guardar(liquidacionCuotaModeradora));
                        }
                    }
                    break;
            }
        }
    }
}
