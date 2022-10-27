using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD
{
    class ler
    {
        verifica verify = new verifica();

        public void exibir(ArrayList lista) {

            if (verify.verificaListaVazia(lista))
            {
                Console.WriteLine("A lista encontra-se vazia no momento.");
                Console.ReadKey();

            }
            else
            {
                Console.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine(lista[i]);

                }
                Console.ReadKey();
            }
        }
             
       


        }

        
            
            
    
}
