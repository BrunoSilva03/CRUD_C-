using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD
{
    class alterar
    {
        verifica verificar = new verifica();


        public void alterarLista(ArrayList lista)
        {
            alterar modify = new alterar();
            if (verificar.verificaListaVazia(lista))
            {
                Console.WriteLine("A lista encontra-se vazia no momento.");
                Console.ReadKey();

            }
            else
            {
                string element, newElement;
                Console.Clear();

                Console.WriteLine("Digite o elemento que quer substituir na lista: ");
                element = Console.ReadLine();

                if (lista.Contains(element))
                {
                    bool retornarMenu;
                    Console.WriteLine("Digite o elemento que substituirá o antigo elemento \"{0}\" na lista: ", element);
                    newElement = Console.ReadLine();


                    int opc = 1;
                    do
                    {
                        retornarMenu = false;
                        if (lista.Contains(newElement))
                        {

                            Console.WriteLine("\"{0}\" já está presente na lista. Tente Outro ou retorne para o menu principal sem alterar nenhum elemento na lista.", newElement);
                            Console.WriteLine("1 - Digitar outro elemento");
                            Console.WriteLine("2 - Retornar ao menu principal");
                            opc = int.Parse(Console.ReadLine());

                            switch (opc)
                            {

                                case 1:
                                    {
                                        Console.WriteLine("Digite o elemento que substituirá o antigo elemento \"{0}\" na lista: ", element);
                                        newElement = Console.ReadLine();

                                        if (lista.Contains(newElement))
                                        {
                                            opc = 1;
                                        }
                                        else {

                                            opc = 0;
                                        }

                                    }
                                    break;


                                case 2:
                                    {
                                        opc = 0;
                                        retornarMenu = true;

                                    }
                                    break;



                                default:
                                    {
                                        opc = 0;
                                        retornarMenu = true;
                                        Console.WriteLine("Opção Inválida. Retornaremos ao menu inicial.");
                                        Console.ReadKey();

                                    }
                                    break;

                            }



                        }

                        

                    } while (opc == 1);

                    if (retornarMenu == false)
                    {

                        for (int i = 0; i < lista.Count; i++)
                        {


                            if (lista[i].Equals(element))
                            {
                                lista[i] = newElement;

                            }


                        }


                        Console.WriteLine("\"{0}\" substituído por \"{1}\" na lista com Sucesso!!!", element, newElement);
                        Console.ReadKey();


                    }
                    else
                    {
                        Console.WriteLine("Retornando ao menu principal...");
                        Console.ReadKey();

                    }


                }
                else
                {
                    int option = 1;

                    do
                    {

                        Console.WriteLine("A lista não contêm '{0}'", element);
                        Console.WriteLine("Você pode: ");
                        Console.WriteLine("1 - Tentar digitar outro elemento");
                        Console.WriteLine("2 - Retornar ao menu principal");
                        option = int.Parse(Console.ReadLine());


                        switch (option)
                        {

                            case 1:
                                {

                                    modify.alterarLista(lista);
                                    option = 0;

                                }
                                break;


                            case 2:
                                {
                                    option = 0;

                                }
                                break;


                            default:
                                {
                                    Console.WriteLine("Opção inválida. Retornaremos ao menu principal");
                                    Console.ReadKey();

                                }
                                break;

                        }

                    } while (option == 1);



                }

            }

        }
    }
}
