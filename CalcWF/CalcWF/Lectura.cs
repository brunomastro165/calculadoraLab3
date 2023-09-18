using System;
using System.Collections.Generic;

namespace CalcWF
{
    public class Lectura
    {
        private List<string> ecuaciónFinal = new List<string>();

        public static bool lecturaDeEcuación(string operación)
        {

            bool comprobación = true;
            foreach (var i in operación)
            {
                if (i == '(' || i == ')' || i == '0' || i == '1' || i == '2' || i == '3' || i == '4'
                    || i == '5' || i == '6' || i == '7' || i == '8' || i == '9' || i == '+' || i == '-'
                    || i == '*' || i == '/')
                {

                }
                else
                {
                    comprobación = false;
                }

            }

            return comprobación;
        }


        public static bool comprobacionLogica(string operacion)
        {
            bool comprobacion = true;
            for (int i = 0; i < operacion.Length - 1; i++)
            {
                if (i == 0 && (operacion[i] == '+' || operacion[i] == '*' || operacion[i] == '/' ||
                               operacion[i] == ')'))
                {
                    comprobacion = false;
                    break;
                }

                if (operacion[operacion.Length - 1] == '(' || operacion[operacion.Length - 1] == '*'
                                                           || operacion[operacion.Length - 1] == '+'
                                                           || operacion[operacion.Length - 1] == '-'
                                                           || operacion[operacion.Length - 1] == '/')
                {
                    comprobacion = false;
                    break;
                }

                switch (operacion[i])
                {
                    case '(':
                        if (operacion[i + 1] != '0' && operacion[i + 1] != '1' && operacion[i + 1] != '2' &&
                            operacion[i + 1] != '3' && operacion[i + 1] != '4' && operacion[i + 1] != '5' &&
                            operacion[i + 1] != '6' && operacion[i + 1] != '7' && operacion[i + 1] != '8' &&
                            operacion[i + 1] != '9' && operacion[i + 1] != '(' && operacion[i + 1] != '-')
                        {
                            comprobacion = false;
                        }

                        break;
                    case '*':
                        if (operacion[i + 1] != '0' && operacion[i + 1] != '1' && operacion[i + 1] != '2' &&
                            operacion[i + 1] != '3' && operacion[i + 1] != '4' && operacion[i + 1] != '5' &&
                            operacion[i + 1] != '6' && operacion[i + 1] != '7' && operacion[i + 1] != '8' &&
                            operacion[i + 1] != '9' && operacion[i + 1] != '(' && operacion[i + 1] != '-')
                        {
                            comprobacion = false;
                        }

                        break;
                    case '-':
                        if (operacion[i + 1] != '0' && operacion[i + 1] != '1' && operacion[i + 1] != '2' &&
                            operacion[i + 1] != '3' && operacion[i + 1] != '4' && operacion[i + 1] != '5' &&
                            operacion[i + 1] != '6' && operacion[i + 1] != '7' && operacion[i + 1] != '8' &&
                            operacion[i + 1] != '9' && operacion[i + 1] != '(')
                        {
                            comprobacion = false;
                        }

                        break;
                    case '+':
                        if (operacion[i + 1] != '0' && operacion[i + 1] != '1' && operacion[i + 1] != '2' &&
                            operacion[i + 1] != '3' && operacion[i + 1] != '4' && operacion[i + 1] != '5' &&
                            operacion[i + 1] != '6' && operacion[i + 1] != '7' && operacion[i + 1] != '8' &&
                            operacion[i + 1] != '9' && operacion[i + 1] != '(')
                        {
                            comprobacion = false;
                        }

                        break;
                    case '/':
                        if (operacion[i + 1] != '0' && operacion[i + 1] != '1' && operacion[i + 1] != '2' &&
                            operacion[i + 1] != '3' && operacion[i + 1] != '4' && operacion[i + 1] != '5' &&
                            operacion[i + 1] != '6' && operacion[i + 1] != '7' && operacion[i + 1] != '8' &&
                            operacion[i + 1] != '9' && operacion[i + 1] != '(' && operacion[i + 1] != '-')
                        {
                            comprobacion = false;
                        }

                        break;
                    case ')':
                        if (operacion[i + 1] != '+' && operacion[i + 1] != '-' && operacion[i + 1] != '*' &&
                            operacion[i + 1] != '/' && operacion[i + 1] != ')')
                        {
                            comprobacion = false;
                        }

                        break;
                    default:
                        if (operacion[i + 1] != '+' && operacion[i + 1] != '-' && operacion[i + 1] != '*' &&
                            operacion[i + 1] != '/' && operacion[i + 1] != ')' && operacion[i + 1] != '0' &&
                            operacion[i + 1] != '1' && operacion[i + 1] != '2' && operacion[i + 1] != '3' &&
                            operacion[i + 1] != '4' && operacion[i + 1] != '5' && operacion[i + 1] != '6' &&
                            operacion[i + 1] != '7' && operacion[i + 1] != '8' && operacion[i + 1] != '9')
                        {
                            comprobacion = false;
                        }

                        break;
                }

            }

            return comprobacion;
        }


        public static bool contarParentesis(String operación)
        {
            int contA = 0;
            int contC = 0;
            int contG = 0;
            foreach (var i in operación)
            {
                if (i == '(' || i == ')')
                {
                    contG++;
                }

                if (i == '(')
                {
                    contA++;
                }

                if (i == ')')
                {
                    contC++;
                    if (contC > contA)
                    {
                        return false;
                    }
                }
            }

            if (contA == contC && contG % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static List<int> ordenOperaciónParentesis(string operación)
        {
            List<int> cantidadAbiertos = new List<int>();
            int cont = 0;
            foreach (var i in operación)
            {
                if (i == '(')
                {
                    cantidadAbiertos.Add(cont);
                    Console.WriteLine(cont);
                }

                cont++;
            }

            return cantidadAbiertos;
        }

        public static List<int> ordenOperaciónParentesisC(string operación)
        {
            List<int> cantidadCerrados = new List<int>();
            int cont = 0;
            foreach (var i in operación)
            {
                if (i == ')')
                {
                    cantidadCerrados.Add(cont);
                    Console.WriteLine(cont);
                }

                cont++;
            }

            return cantidadCerrados;
        }

        public static string priorizarParentesis(string operación)
        {
            List<String> resultado = new List<string>();

            string resultadoF = "";
            if (operación.Contains("("))
            {
                while (operación.Contains("("))
                {
                    int indiceInicioParentesis = operación.LastIndexOf("(");
                    int indiceFinParentesis = operación.IndexOf(")", indiceInicioParentesis);

                    string dentroParentesis = operación.Substring(indiceInicioParentesis + 1,
                        indiceFinParentesis - indiceInicioParentesis - 1);
                    string resultadoDentroParentesis = separarTérminos(dentroParentesis);

                    operación = operación.Remove(indiceInicioParentesis,
                        indiceFinParentesis - indiceInicioParentesis + 1);
                    operación = operación.Insert(indiceInicioParentesis, resultadoDentroParentesis.ToString());

                }

                //Console.WriteLine(hacerOperaciones(resultadoF));
                //Console.WriteLine(resultadoF);
                //Console.WriteLine(operación);
                Console.WriteLine(separarTérminos(operación));
                return separarTérminos((operación));
            }
            else
            {
                // string resultadoSP = separarTérminos(hacerOperaciones(operación));
                //  Console.WriteLine(resultadoSP);
                Console.WriteLine(separarTérminos(operación));
                return separarTérminos((operación));
            }
            //Console.WriteLine(separarTérminos(operación));

        }

        public static string modificarOperación(string operación)
        {
            //santo grial de las ideas
            if (operación.Contains("--"))
            {
                operación = operación.Replace("--", "+");
            }
            else if (operación.Contains("++"))
            {
                operación = operación.Replace("++", "+");
            }
            else if (operación.Contains("+-"))
            {
                operación = operación.Replace("+-", "-");
            }
            else if (operación.Contains("-+"))
            {
                operación = operación.Replace("-+", "+");
            }

            return operación;

        }

        public static string separarTérminos(string operación)
        {

            //Usamos las leyes PEMDAS de la matemática para priorizar cálculos
            string partes = "";
            string resultado = "";
            string auxOp = "";
            for (int i = 0; i < operación.Length; i++)
            {
                operación = modificarOperación(operación); //Corregir posibles errores
                partes += operación[i];

                if (i > 0 && i < operación.Length - 1

                          //Si hay un menos no precedido de ningún simbolo
                          && operación[i].Equals('-') && !operación[i + 1].Equals('/') && !operación[i + 1].Equals('*')
                          && !operación[i - 1].Equals('/') && !operación[i - 1].Equals('*')

                    //Si hay un mas no precedido de ningún simbolo    
                    || i > 0 && i < operación.Length - 1 && operación[i].Equals('+') && !operación[i + 1].Equals('/') &&
                    !operación[i + 1].Equals('*')
                    && !operación[i - 1].Equals('/') && !operación[i - 1].Equals('*') && i < operación.Length - 1

                    || i == operación.Length - 1)
                {
                    operación = modificarOperación(operación);
                    resultado += hacerOperaciones(partes);

                    partes = "";
                }
            }

            resultado = hacerOperaciones(resultado);
            return resultado;
        }

        public static int calcular(int num1, int num2, char operacion)
        {
            switch (operacion)
            {
                case '+':
                    return num1 + num2;
                case '*':
                    return num1 * num2;
                case '-':
                    return num1 - num2;
                case '/':
                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("No es posible la división entre 0");
                        throw new ArithmeticException("No es posible la división entre 0");
                    }

                    return num1 / num2;
            }

            return 0;
        }

        public static string hacerOperaciones(string ecuacion)
        {
            ecuacion.Replace(" ", "");
            ecuacion = modificarOperación(ecuacion);

            char finalOperator = ' ';
            if (ecuacion[ecuacion.Length - 1].Equals('+') || ecuacion[ecuacion.Length - 1].Equals('-'))
            {
                finalOperator = ecuacion[ecuacion.Length - 1];
                ecuacion = ecuacion.Remove(ecuacion.Length - 1);
            }

            char simbol = ' ';
            string n1S = "";
            string n2S = "";
            bool start = false;
            int cont = 0;
            for (int i = 0; i < ecuacion.Length; i++)
            {
                ecuacion = modificarOperación(ecuacion);

                if (ecuacion[i].Equals('+') || ecuacion[i].Equals('-')
                                            || ecuacion[i].Equals('/') || ecuacion[i].Equals('*'))
                {
                    if (n1S.Equals(""))
                    {
                        n1S += ecuacion[i];
                        continue;
                    }
                    else if (simbol.Equals(' '))
                    {
                        simbol = ecuacion[i];
                        cont++;
                        continue;
                    }
                    else if (!simbol.Equals(' ') && n2S != "")
                    {
                        n1S = calcular(int.Parse(n1S), int.Parse(n2S), simbol).ToString();
                        n2S = "";
                        simbol = ecuacion[i];
                        continue;
                    }
                }

                if (simbol.Equals(' '))
                {
                    n1S += ecuacion[i];
                }

                if (!simbol.Equals(' ') && !n1S.Equals(""))
                {
                    n2S += ecuacion[i];
                }
            }

            if (n2S.Equals(""))
            {
                if (finalOperator.Equals(' '))
                {
                    return ecuacion;

                }
                else
                {
                    return ecuacion + finalOperator;
                }
            }
            else
            {
                if (finalOperator.Equals(' '))
                {
                    return calcular(int.Parse(n1S), int.Parse(n2S), simbol).ToString();
                }
                else
                {
                    return calcular(int.Parse(n1S), int.Parse(n2S), simbol).ToString() + finalOperator;
                }
            }

            return "";
        }
    }
}
