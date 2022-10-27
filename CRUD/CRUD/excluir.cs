using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD
{
    class excluir
    {
        verifica verify = new verifica();

        public void deletar(ArrayList lista)
        {
            Console.Clear();
            if (verify.verificaListaVazia(lista))
            {
                Console.WriteLine("A lista encontra-se vazia no momento. Nada a deletar");
                Console.ReadKey();
            }
            else
            {
                string element;
                Console.WriteLine("Digite o elemento que deseja deletar/excluir da lista");
                element = Console.ReadLine();

                if (!lista.Contains(element))
                {
                    int opc = 1;

                    do
                    {
                        Console.WriteLine(element + " não está presente na lista");
                        Console.WriteLine("Você pode: ");
                        Console.WriteLine("1 - Tentar digitar outro elemento");
                        Console.WriteLine("2 - Retornar ao menu principal");
                        opc = int.Parse(Console.ReadLine());

                        switch (opc)
                        {

                            case 1:
                                {
                                    Console.WriteLine("Digite o elemento que deseja deletar/excluir da lista");
                                    element = Console.ReadLine();


                                }
                                break;



                            case 2:
                                {
                                    opc = 0;
                                    Console.WriteLine("Retornando ao menu inicial...");


                                }
                                break;

                            default:
                                {
                                    opc = 0;
                                    Console.WriteLine("Opção inválida, retornaremos ao menu inicial.");
                                    Console.ReadKey();
                                }
                                break;
                        }

                    } while (opc == 1);


                }
                else
                {

                    lista.Remove(element);
                    Console.WriteLine(element + " removido da lista com Sucesso!!!");
                    Console.ReadKey();
                }

            }

        }
    }
}
