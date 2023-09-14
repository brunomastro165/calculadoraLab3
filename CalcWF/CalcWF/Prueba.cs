using System;

namespace CalcWF
{
    public class prueba
    {
        public static void ingreso()
        {
            bool condition = true;
            bool condition2 = true;
            while (condition)
            {
                Console.WriteLine("Ingrese una operación aritmética. (usando +, -, *, /, paréntesis y sin espacios)");
                condition = true;
            
                string operación = Console.ReadLine();
                if (Lectura.lecturaDeEcuación(operación) && Lectura.comprobacionLogica(operación) && Lectura.contarParentesis(operación))
                {
                    Lectura.priorizarParentesis(operación);
                    condition = true;
                }
                else
                {
                    Console.WriteLine("La ecuación tiene un error de formato");
                }

                condition2 = true;
                Console.WriteLine("¿Desea continuar? 1-Si 2-No");
                while (condition2)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            condition2 = false;
                            break;
                        
                        case "2":
                            condition = false;
                            condition2 = false;
                            break;
                        
                        default:
                            Console.WriteLine("Ingrese una opción válida");
                            break;
                    }
                }


            }
        }
    }
}