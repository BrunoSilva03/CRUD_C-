using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList lista = new ArrayList();
            int opc = new int();
            ler read = new ler();
            criar create = new criar();
            alterar update = new alterar();
            excluir delete = new excluir();
            verifica verify = new verifica();
            limpar clean = new limpar();


            Console.WriteLine("OLÁ SEJA BEM - VINDO(A)");

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Exibir Lista");
                Console.WriteLine("2 - Inserir");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Alterar");
                Console.WriteLine("5 - Limpar");
                Console.WriteLine("6 - Verificar se a lista está vazia");
                Console.WriteLine("0 - Sair do Programa");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {

                    case 0:
                        {
                            Console.WriteLine("Saindo do Programa. Obrigado por usar...");
                            Console.WriteLine(".");
                            Console.WriteLine(".");
                            Console.WriteLine(".");
                            Environment.Exit(0);

                        }
                        break;

                    case 1:
                        {
                            read.exibir(lista);

                        }
                        break;



                    case 2:
                        {
                            create.inserir(lista);

                        }
                        break;


                    case 3:
                        {
                            delete.deletar(lista);
                        }
                        break;


                    case 4:
                        {
                            update.alterarLista(lista);

                        }
                        break;


                    case 5:
                        {
                            clean.esvaziarLista(lista);
                        }
                        break;


                    case 6:
                        {
                            if (verify.verificaListaVazia(lista))
                            {
                                Console.WriteLine("Sim, a lista encontra-se vazia atualmente");
                            }
                            else
                            {

                                Console.WriteLine("Não, a lista NÃO está vazia neste exato momento.");
                            }

                        }
                        break;


                    default: {
                            Console.WriteLine("Opção Inválida, Tente outra opção.");

                        }break;



                }

            } while (opc >= 0 && opc <= 6);
            

            Console.ReadKey();
        }
    }
}
