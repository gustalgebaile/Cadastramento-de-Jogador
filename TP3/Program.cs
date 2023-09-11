// Teste de Performance 3
// Nas etapas 5 e 6 de Fundamentos de desenvolvimento com C#, você, que já compreende como utilizar variáveis e quais são os tipos básicos de objetos disponíveis na linguagem, e que sabe como criar estruturas para controlar fluxos de seleção e de iteração em seu código, também entendeu como criar classes e também como criar bibliotecas.

// Nesse TP03, você deve criar, com o Visual Studio, uma aplicação de cadastro de uma entidade (baseado em um tema escolhido pelo aluno).

// A aplicação deve possuir dois menus principais, um para inclusão e outro para consulta de entidades e uma opção para visualizar o detalhe de uma entidade.

// Menu de inclusão: No menu de inclusão, a aplicação deve solicitar que o usuário informe os dados da entidade. Após o informe dos dados, a aplicação deve "persistir" a entidade.

// Menu de consulta: No momento da consulta, a aplicação deve solicitar que o usuário informe uma cadeia de caracteres contendo a informação a ser pesquisada nas entidades. A aplicação deve realizar pesquisa na propriedade string (exemplo: nome do médico, nome da escola, nome do carro, etc) das entidades "persistidas". A aplicação deve exibir o campo string (completo) de cada entidade encontrada na pesquisa e uma opção numérica para visualizar os detalhes da entidade.

// Opção de visualizar o detalhe da entidade: Quando o usuário informar a opção numérica no resultado da pesquisa, a aplicação deve exibir o detalhe da entidade com todas as suas informações e mais o resultado de algum cálculo com a propriedade do tipo DateTime.

// É obrigatória o uso de classe para representar a sua entidade (baseado no tema escolhido pelo aluno).

// É obrigatório que a entidade tenha pelos menos cinco propriedades (cada propriedade com tipos diferentes: string, DateTime, int, bool, double, Guid, etc).

// É obrigatório que a classe (referente a entidade) contenha pelo menos um método, que será o responsável por realizar o cálculo com a propriedade do tipo DateTime da entidade. O calculo é a idade da entidade inserida na lista.

// É obrigatório que exista um projeto (camada de negócio) do tipo Class Library contendo a classe referente a entidade do seu tema.

// É obrigatório que exista um projeto (camada de dados) do tipo Class Library contendo o repositório da sua aplicação.

// É obrigatório que exista um projeto (camada de apresentação) do tipo Console App contendo a classe Program para obtenção de entradas (inputs) e exibição de saídas (outputs).

// Sua aplicação deve "persistir" as entidades em uma coleção em memória.

// Entregue seu projeto de acordo com as boas práticas de codificação demonstradas em aula. Nome de variáveis com boa semântica e métodos pequenos serão considerados na avaliação.

// Ps:. Caso tenham problema com replit relacionado à criação de projeto, jogue em classes.

// https://diegoadias.online/wp-content/uploads/2023/09/tp3.1.png

// https://diegoadias.online/wp-content/uploads/2023/09/tp3.2.png

// https://diegoadias.online/wp-content/uploads/2023/09/tp3.3.png

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TP3;
using static System.Net.Mime.MediaTypeNames;



class Program
{
    public static void Main(string[] args)
    {
        run();
    }
        static void run()
        {
            Console.WriteLine("Gerenciador de Jogador");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Pesquisar Jogadores");
            Console.WriteLine("2 - Adicionar novo Jogador");
            Console.WriteLine("3 - Sair");
            ICadastrarJogador cadastrarJogador = new CadastroJogadorEmMemoria();
            string Menu = Console.ReadLine();
            do
            {
                if (Menu == "1")
                {

                }
                if (Menu == "2")
                {
                    Console.WriteLine("Quantos jogadores irão ser cadastrados?");
                    int numCadastros = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numCadastros; i++)
                    {
                        int numId = i;
                        Console.WriteLine("Qual o nome do jogador?");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Qual a idade?");
                        int idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o jogador foi convocado? S/N");
                        char booleano = char.Parse(Console.ReadLine());
                        bool convocado;
                        if (booleano.Equals("S"))
                        {
                            convocado = true;
                        }
                        else
                        {
                            convocado = false;
                        }
                    Console.WriteLine("Qual a média de gols/partida do jogador?");
                    double golsPartida = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o numéro da camisa do jogador?");
                    short numCamisa = short.Parse(Console.ReadLine());
                    Console.WriteLine("DIgite a data de estreia do jogador");
                    string dataEstreia = Console.ReadLine();
                    Jogador jogador = new Jogador(numId, nome, idade, convocado, golsPartida, numCamisa, dataEstreia);
                    cadastrarJogador.AdicionarJogador(jogador);
                        run();
                    }
                }
            } while (Menu != "3");
        Console.WriteLine("Saindo...");
        }
    }