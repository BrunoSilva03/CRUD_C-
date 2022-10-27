using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD
{
    class criar
    {

        public void inserir(ArrayList lista)
        {

            criar create = new criar();
            string novoElement;

            Console.Clear();
            Console.WriteLine("Digite o elemento que deseja inserir na lista: ");
            novoElement = Console.ReadLine();

            if (lista.Contains(novoElement))
            {
                int option = 1;
                do
                {
                    Console.WriteLine("Este elemento já existe na lista");
                    Console.WriteLine("Você pode: ");
                    Console.WriteLine("1 - Tentar digitar outro elemento");
                    Console.WriteLine("2 - Voltar para o menu principal");
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {

                        case 1:
                            {
                                create.inserir(lista);
                                option = 0;

                            }
                            break;

                        case 2:
                            {
                                Console.WriteLine("Retornando ao menu principal...");

                            }
                            break;

                        default:
                            {
                                Console.Clear();
                                option = 0;
                                Console.WriteLine("Opção inválida, Retornaremos ao menu inicial");
                                Console.ReadKey();


                            }
                            break;
                    }

                } while (option == 1);



            }
            else
            {
                lista.Add(novoElement);
                Console.WriteLine("Elemento inserido na lista com Sucesso!!!");
                Console.ReadKey();
            }


        }
    }
}
