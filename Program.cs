using System;
using exercicio3_1112.classes;

namespace exercicio3_1112
{
    class Program
    {
        static void Main(string[] args)

        
        {
            MaquinaCafe maquina = new MaquinaCafe();

            string opcao;
            int opcao2;
            string opcao3;
            int acucarCliente = 10;


            Console.WriteLine("Maquina inicializando, por favor adicione o açucar na maquina indicar a quantidade em gramas:");
            maquina.acucarDisponivel = int.Parse(Console.ReadLine());

            Console.WriteLine($"{maquina.acucarDisponivel} gramas de açucar adicionado, deseja iniciar a maquina?  (s/n)");
            opcao = Console.ReadLine();


            if (opcao == "s")
            {
                for (var i = maquina.acucarDisponivel; i > acucarCliente; i -- )
                {
                        do
                        {
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Escolha um tipo de cafe:");
                            Console.WriteLine("[1] - Cafe sem açucar");
                            Console.WriteLine("[2] - Cafe com açucar");
                            // Console.WriteLine("[3] - Cafe com açucar (a gosto)");
                            Console.WriteLine("[0] - Desligar maquina");

                            opcao2 = int.Parse(Console.ReadLine());

                            switch (opcao2)
                            {
                                case 1:
                                        Console.WriteLine("Fazendo seu cafe sem açucar....");

                                        acucarCliente = 0;
                                    break;
                                case 2:
                                        Console.WriteLine("Você gostaria de definir a quantidade de açucar necessario? (s/n)");
                                        opcao3= Console.ReadLine();


                                    if (opcao3 == "s")
                                    {
                                        Console.WriteLine("Qual a quantidade de açucar desejada? (em gramas)");
                                        acucarCliente = int.Parse(Console.ReadLine());

                                        if (maquina.AcucarDaMaquina(maquina.acucarDisponivel, acucarCliente))
                                        {

                                            Console.WriteLine(maquina.FazerCafe(acucarCliente));
                                        }
                                        else{
                                            Console.WriteLine("A maquina não contem essa quatidade de açucar disponivel, por favor selecione outra opção");
                                        }
                                    }else{

                                            if (maquina.AcucarDaMaquina(maquina.acucarDisponivel, acucarCliente))
                                        {

                                            Console.WriteLine(maquina.FazerCafe());
                                        }
                                        else{
                                            Console.WriteLine("A maquina não contem essa quatidade de açucar disponivel, por favor selecione outra opção");
                                        }

                                    }      
                                    break;

                                case 0:
                                        Console.WriteLine("Desligando maquina de cafe....");
                                    break;
                                default:
                                        Console.WriteLine("Opção invalida, por favor tente novamente");
                                    break;
                                
                            }
                            
                        } while (opcao2 != 0 || maquina.acucarDisponivel > acucarCliente);

                    }
                }

        }
    }
}
