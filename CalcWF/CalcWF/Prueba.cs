using System;

namespace CalcWF
{
    public class prueba
    {
        public static string ingreso(string operación)
        {
            
                if (Lectura.lecturaDeEcuación(operación) && Lectura.comprobacionLogica(operación) && Lectura.contarParentesis(operación))
                {
                    operación = Lectura.priorizarParentesis(operación);
                    return operación;
                }
                else
                {
                    Console.WriteLine("La ecuación tiene un error de formato");
                    return "Error de formato";
                }
            }
    }
}