using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD
{
    class limpar
    {
        verifica verify = new verifica();

        public void esvaziarLista(ArrayList lista) {

            if (verify.verificaListaVazia(lista))
            {
                Console.Clear();
                Console.WriteLine("A lista encontra-se vazia no momento");
                Console.ReadKey();
            }
            else {
                lista.Clear();
                Console.WriteLine("Lista esvaziada com Sucesso!!!");
                Console.ReadKey();

            }
        }
    }
}
