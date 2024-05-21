using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PUNTO UNO, NUMEROS CORRELATIVOS DEL 1 HASTA EL INGRESADO

           /* int numeroing = 0;
            int cont = 1;

            Console.WriteLine(" ingrese un numero positivo");
            numeroing = int.Parse(Console.ReadLine());

            while (numeroing > 0 && cont <= numeroing)
            {
                Console.WriteLine(" los numero son " + cont);
                cont++;
            }

           // PUNTO DOS, CARGA Y SUMA DE 10 VALORES

             double valor = 0;
            double sumValor = 0;
            double promedio = 0;
            int cont2 = 1;

            while (cont2 <= 10)
            {
                Console.WriteLine(" ingrese el valor");
                valor = double.Parse(Console.ReadLine());
                sumValor = sumValor + valor;
                promedio = sumValor / 10;
                cont2++;
            }
            Console.WriteLine(" la suma es igual a:  " + sumValor);
            Console.WriteLine(" el promedio es igual a: " + promedio);
            Console.WriteLine(" saliste del bucle");

            // PUNTO TRES, FABRICA DE PERFILES

            int cantPiezas = 0;
             double longiPiezas = 0;
             int cont3 = 0;
             int valido = 0;

             Console.WriteLine(" ingrese la cantidad de piezas ");
             cantPiezas = int.Parse(Console.ReadLine());

             while (cont3 < cantPiezas)
             {
                 Console.WriteLine(" ingrese las longitudes en centimetros");
                 longiPiezas = double.Parse(Console.ReadLine());

                 if (longiPiezas >= 1200 && longiPiezas <= 1300) 
                 {
                     valido++;
                 }
                 cont3++;

             }

             Console.WriteLine(" la cantida de piezas validad son " + valido);



             // PUNTO CUATRO, NOTAS DE ALUMNO


             int cont4 = 0;
             int nota = 0;
             int notasMay = 0;
             int notasMen = 0 ;

             while ( cont4 < 10 )
             {
                 Console.WriteLine(" ingrese la nota del alumno"); 
                 nota = int.Parse( Console.ReadLine() );
                 cont4++;
                 if ( nota >= 7 ) 
                 {
                    notasMay++;
                 }
                 else 
                 {
                     notasMen++;
                 }
             }

             Console.WriteLine(" la cantidad de notas mayores o iguales a 7 son " + notasMay++);
             Console.WriteLine(" la cantidad de notas menores a 7 son " + notasMen++);

             //PUNTO CINCO, ALTURA DE LAS PERSONAS

             double altura = 0;
             double promedio1 = 0;
             double sumaAlt = 0;
             int cont5 = 0;
             int cantiAlt = 0;

             Console.WriteLine(" ingrese la cantidad de alturas");
             cantiAlt = int.Parse(Console.ReadLine());

             while ( cont5 < cantiAlt )
             {
                 Console.WriteLine(" ingrese la altura");
                 altura = double.Parse(Console.ReadLine());
                 sumaAlt = sumaAlt + altura;
                 promedio1 = sumaAlt / cantiAlt;

                 cont5++;
             }
             Console.WriteLine(" el promedio de la altura es " + promedio1);

             //PUNTO SEIS, LECTURA DE SUELDOS

            int xEmpleados = 0;
            double sueldos = 0;
            double gastos = 0; 
            int cont6 =  1;
            int sueldosMay = 0;
            int sueldosMen = 0;


            Console.WriteLine(" ingrese la cantidad de empleados");
            xEmpleados = int.Parse(Console.ReadLine());

            while ( cont6 <= xEmpleados ) 
            { 
               Console.WriteLine(" ingrese el sueldo del empleado");
                sueldos = double.Parse(Console.ReadLine());

                if ( sueldos >= 100 && sueldos <= 300 )
                {
                    sueldosMen++;
                    gastos = gastos + sueldos; 
                    cont6 ++;
                } 
                else if ( sueldos >= 300 && sueldos <= 500)
                {
                    sueldosMay++;
                    gastos = gastos + sueldos;
                    cont6++;
                }
                else
                {
                    Console.WriteLine(" el sueldo ingresados no es valido ");
                }
            }
            Console.WriteLine(" la cantidad de empleados con sueldos entre 100 y 300 son:  " + sueldosMen);
            Console.WriteLine(" la cantidad de empleados con sueldos mayores a 300 y menores o iguales a 500 son:  " + sueldosMay);
            Console.WriteLine(" los gastos de la empresa son; " + gastos );


            //PUNTO SIETE TERMINOS DE LA SERIE

            int cont7 = 0;
             int num11 = 11;

             Console.WriteLine(" los terminos de la serie son 25 ");
             while (cont7 < 25)
             { 
               Console.WriteLine(num11);
                 num11 += 11;
                 cont7++;
             }

            // PUNTO OCHO, MULTIPLOS DE OCHO 

            int cont8 = 0;
            int multiplos = 8;     

            Console.WriteLine(" multiplos de 8 hasta el valor 500");

            while (cont8 <= 61)
            {
                Console.WriteLine( multiplos);
                multiplos += 8;
                cont8++;
            }

            //PUNTO NUEVE LISTA DE VALORES

            double valor1 = 0;
            double valor2 = 0;
            double mayor1 = 0;
            double mayor2 = 0;
            double listIG = 0;
            int cont9 = 0;

            while (cont9 < 30)
            {
                if (cont9 < 15)
                {
                    Console.WriteLine(" informe los valores de la primer lista");
                    valor1 = double.Parse(Console.ReadLine());
                    mayor1 = mayor1 + valor1;

                    cont9++;
                }
                else if (cont9 < 30 && cont9 >= 15) 
                {
                    Console.WriteLine(" informe los valores de la segunda lista");
                    valor2 = double.Parse(Console.ReadLine());
                    mayor2 = mayor2 + valor2;
                    cont9++;
                }
            
            
            }
            Console.WriteLine(" la lista 1 tiene una suma acumulada de " + mayor1);
            Console.WriteLine(" la lista 2 tiene una suma acumulada de " + mayor2);

            if (mayor1 > mayor2)
            {
                Console.WriteLine(" la suma de la lista 1 es mayor a la suma de la lista 2");
            }
            else if (mayor2 > mayor1) 
            {
               Console.WriteLine(" la suma de la lista 2 es mayor a la suma de la lista 1");
            }
            else if (mayor1 == mayor2)
            {
                Console.WriteLine(" los valores de las listas son iguales");
            }*/

            //PUNTO DIEZ, LECTURA DE SUELDOS 

            int Xnum = 0;
            int numPar  = 0;
            int numImpar = 0;
            int  cont10 = 0;
            int numeros = 0;

            Console.WriteLine(" ingrese la cantidad de numeros");
            Xnum = int.Parse(Console.ReadLine());

            while (cont10 < Xnum) 
            {
                Console.Write(" ingrese el numero: ");
                numeros = int.Parse(Console.ReadLine());

                  
                if ( numeros %2 == 0 ) 
                {
                   
                 numPar++;

                }
                else
                {
                    numImpar++;
                }



                cont10++;
            }

            Console.WriteLine($" los numero que ingreso tienen {numPar} numeros pares y {numImpar} numeros impares ");














        }

    }
}
