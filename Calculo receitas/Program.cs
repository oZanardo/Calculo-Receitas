using System;
using System.Globalization;

namespace Calculo_receitas
{
    class program
    {
        static void Main(string[] args)
        {


            Ingredientes ingredientes = new Ingredientes();

            Tabela Nutricional = new Tabela();


            double valorTotal = 0;
            double calTotal = 0;
            double carbTotal = 0;
            double protTotal = 0;
            double gordTotal = 0;
            double hora = 0;
            double real = 0;
            double qtd = 0;

            Console.WriteLine("Digite 1.Para ver o valor da receita 2.Para fazer a tabela nutricional 3.Para fazer ambos");

            string a = Console.ReadLine();

            
            //VALOR DA RECEITA
            if (a == "1")
            {

                Console.WriteLine("Digite quantos ingredientes vão na receita :");
                int n = int.Parse(Console.ReadLine());
                int i = 0;

                do
                {
                    i++;

                    Console.Write("Digite o nome do ingrediente : ");
                    ingredientes.Ingrediente = Console.ReadLine();

                    Console.Write("Digite a quantidade(ml/gr) que é usado na receita : ");
                    ingredientes.Quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Digite a quantidade(ml/gr) que é vendido : ");
                    ingredientes.Pacote = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do produto : ");
                    ingredientes.Valor = double.Parse(Console.ReadLine());

                    double valor = ingredientes.Preco();//Valor(ingredientes.Valor, ingredientes.Quantidade, ingredientes.Pacote);

                    Console.WriteLine(ingredientes);

                    valorTotal = valor + valorTotal;

                } while (i < n);

                Console.WriteLine("Valor da receita = " + valorTotal);

            }


            //TABELA NUTRICIONAL
            else if (a == "2")
            {
                Console.WriteLine("Digite quantos ingredientes vão na receita :");
                int n = int.Parse(Console.ReadLine());
                int i = 0;

                do
                {
                    i++;

                    Console.Write("Valor base da tabela nutricional : ");
                    Nutricional.ValorBase = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor que é utilizado na receita : ");
                    Nutricional.ValorUsado = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor energético que está indicado no rótulo : ");
                    Nutricional.ValorEnergetico = double.Parse(Console.ReadLine());
                    double cal = Info(Nutricional.ValorBase, Nutricional.ValorUsado, Nutricional.ValorEnergetico);

                    Console.Write("Digite o valor de carboidrato : ");
                    Nutricional.Carbo = double.Parse(Console.ReadLine());
                    double carbo = Info(Nutricional.ValorBase, Nutricional.ValorUsado, Nutricional.Carbo);

                    Console.Write("Digite a quantidade de proteína : ");
                    Nutricional.Prot = double.Parse(Console.ReadLine());
                    double prot = Info(Nutricional.ValorBase, Nutricional.ValorUsado, Nutricional.Prot);

                    Console.Write("Digite a quantidade de Gorduras totais : ");
                    Nutricional.GorduraTotais = double.Parse(Console.ReadLine());
                    double gorduras = Info(Nutricional.ValorBase, Nutricional.ValorUsado, Nutricional.GorduraTotais);

                    Console.WriteLine("Calorias" + cal);
                    Console.WriteLine("Carboidratos : " + carbo);
                    Console.WriteLine("Proteínas : " + prot);
                    Console.WriteLine("Gorduras Totais : " + gorduras);

                    calTotal += cal;
                    carbTotal += carbo;
                    protTotal += prot;
                    gordTotal += gorduras;


                } while (i < n);

                Console.WriteLine("Valor Nutricional da receita :");
                Console.WriteLine("Calorias" + calTotal);
                Console.WriteLine("Carboidratos : " + carbTotal);
                Console.WriteLine("Proteínas : " + protTotal);
                Console.WriteLine("Gorduras Totais : " + gordTotal);

            }

            else if (a == "3") {


                Console.WriteLine("Digite quantos ingredientes vão na receita :");
                int n = int.Parse(Console.ReadLine());
                int i = 0;


                //TABELA NUTRICIONAL E VALOR DA RECEITA
                do
                {
                    i++;

                    Console.Write("Digite o nome do ingrediente : ");
                    ingredientes.Ingrediente = Console.ReadLine();

                    Console.Write("Digite o valor que é usado na receita : ");
                    ingredientes.Quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Digite o tamanho do pacote (Gr/ml) que é vendido : ");
                    ingredientes.Pacote = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor(preço) do produto : ");
                    ingredientes.Valor = double.Parse(Console.ReadLine());

                    Console.WriteLine("TABELA NUTRICIONAL");

                    Console.Write("Valor base da tabela nutricional : ");
                    Nutricional.ValorBase = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor que é utilizado na receita : ");
                    Nutricional.ValorUsado = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor energético(cal) que está indicado no rótulo : ");
                    Nutricional.ValorEnergetico = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor de carboidrato : ");
                    Nutricional.Carbo = double.Parse(Console.ReadLine());

                    Console.Write("Digite a quantidade de proteína : ");
                    Nutricional.Prot = double.Parse(Console.ReadLine());

                    Console.Write("Digite a quantidade de Gorduras totais : ");
                    Nutricional.GorduraTotais = double.Parse(Console.ReadLine());

                    double valor = ingredientes.Preco();

                    Console.WriteLine(ingredientes);

                    //Calculos

                    double cal = Funcoes.Info(Nutricional.ValorBase, Nutricional.ValorUsado, Nutricional.ValorEnergetico);

                    double carbo = Funcoes.Info(Nutricional.ValorBase, Nutricional.ValorUsado, Nutricional.Carbo);

                    double prot = Funcoes.Info(Nutricional.ValorBase, Nutricional.ValorUsado, Nutricional.Prot);

                    double gorduras = Funcoes.Info(Nutricional.ValorBase, Nutricional.ValorUsado, Nutricional.GorduraTotais);




                    Console.WriteLine("Calorias" + cal);
                    Console.WriteLine("Carboidratos : " + carbo);
                    Console.WriteLine("Proteínas : " + prot);
                    Console.WriteLine("Gorduras Totais : " + gorduras);

                    valorTotal = valor + valorTotal;

                    calTotal += cal;
                    carbTotal += carbo;
                    protTotal += prot;
                    gordTotal += gorduras;


                } while (i < n);

                Console.WriteLine("Valor da receita = " + valorTotal);

                Console.WriteLine("Valor Nutricional da receita :");
                Console.WriteLine("Calorias" + calTotal);
                Console.WriteLine("Carboidratos : " + carbTotal);
                Console.WriteLine("Proteínas : " + protTotal);
                Console.WriteLine("Gorduras Totais : " + gordTotal);


            }
            
            else
            {
                Console.WriteLine("Comando inválido");
            }
            Console.WriteLine();

            //Preço horas 
            Console.Write("Quanto tempo você leva para preparar uma receita : ");
            hora = double.Parse(Console.ReadLine());
            Console.Write("Quantas receitas consegue fazer ao mesmo tempo : ");
            qtd = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Escreva por quanto a RECEITA é vendida : ");
            real = double.Parse(Console.ReadLine());

            if (ingredientes.Valor > 0)
            {
                real = real - ingredientes.Valor;
            }
            else
            {
                Console.Write("Digite o valor da receita : ");
                real = double.Parse(Console.ReadLine());
            }

            double salarioHora = Funcoes.PrecoHora(hora, real, qtd);

            Console.WriteLine("Salário/Hora = " + salarioHora);
            //

            Console.ReadLine();
        }

        }
    }
