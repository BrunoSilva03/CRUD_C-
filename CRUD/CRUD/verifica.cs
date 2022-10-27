using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD
{
    class verifica
    {

        public bool verificaListaVazia(ArrayList lista) {
            if (lista.Count > 0) {
                return false;
            }

            return true;

        }
    }
}
