using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Semana_7
{
    class Program
    {
        private const int MAX_VAL= 50;
        private static Dictionary<int, bool> primos = new Dictionary<int, bool>(MAX_VAL);
        static void Main(string[] args)
        {
            // CONSTRUCTOR O INSTANCIA
            var builder = BuildPrimeSelector();
          
            while (true)
            {
                // LOOP QUE AUMENTARA EL CONTADOR DEL BUILDER
               int prime = builder();
                // SI EL NUMERO RETORNADO ES MAYOR O IGUAL BREAK
                if (prime >= MAX_VAL)
                    break;
            }
            foreach(var numero in primos.OrderBy(a=>a.Key))
            {
                if (numero.Value)
                    Console.WriteLine(numero.Key);
            }
            Console.ReadLine();

        }

        static Func<int> BuildPrimeSelector(){
            int i=1;
            // EL UNO SE CONSIDERA PRIMO, PERO SI LO MULTIPLICAS POR TODOS SUS MULTIPLOS
            // LOS DEMAS NO SERAN PRIMOS
            primos.Add(i, true);
            return ()=>{
                i++;
                // SI EL DICCIONARIO DE PRIMOS NO CONTIENE EL VALOR DE I
                // Y EL VALOR DE I ES MENOR QUE EL MAX VALUE
                if (!primos.ContainsKey(i) && i< MAX_VAL)
                {
                    // SE AGREGA EN EL DICCIONARIO CON TRUE YA QUE LOS NUMEROS QUE ENTREN AQUI SERAN PRIMOS
                    primos.Add(i, true);
                    // SE CUMPLE ESTA CONDICION SIEMPRE Y CUANDO SEA MENOR QUE MAX VAL &
                    // EL VALOR DE I EN EL DICCIONARIO SEA TRUE (PRIMO)
                    if (i < MAX_VAL && (primos[i]))
                    {
                        // C ES EL VALOR DONDE SE INICIARA A SACAR LOS MULTIPLOS
                        // (NO ES 1 YA QUE SI MULTIPLICAS EL VALOR DE I * 1 TE DARA I Y YA I ESTA 
                        // MARCADO COMO PRIMO
                        int c = 2;
                        // SIEMPRE Y CUANDO I * C SEA MENOR QUE MAX_VAL
                        while (i * c < MAX_VAL)
                        {
                            // SE GUARDA EL VALOR DE LA MULTIPLICACION QUE SERA EL MULTIPLO
                            var multiple = i * c;
                            // SI EL VALOR DE I ES DIFERENTE DEL MULTIPLO Y EL VALOR DEL MULTIPLO
                            // NO ESTA EN EL DICCIONARIO, ENTONCES AGREGAR LE MULTIPLO EN EL DICCIONARIO
                            // COMO FALSE (NO ES PRIMO)
                            if (i != multiple && (!primos.ContainsKey(multiple)))
                                primos.Add(multiple, false);
                            // SE INCREMENTA EL VALOR DE C QUE ES EL NUMERO POR EL CUAL SE MULTIPLICARA PARA
                            // OBTENER EL MULTIPLO
                            c++;
                        }
                    }
                }
                return i;

             
               
            };
        }
    }
}
