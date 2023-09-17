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
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Globalization;


class Program
{
    public static void Main(string[] args)
    {
        var repoJogador = new RepoJogador();

        while (true)
        {
            Console.WriteLine("Gerenciador de Jogador de Futebol");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Pesquisar Jogador(es)");
            Console.WriteLine("2 - Adicionar novo Jogador");
            Console.WriteLine("3 - Sair");
            int Menu = int.Parse(Console.ReadLine());
            switch (Menu)
            {
                case 1:
                    Console.Write("Digite o nome para consulta: ");
                    string procurarNome = Console.ReadLine();
                    var resultadoProcura = repoJogador.ProcurarJogadorPorNome(procurarNome);

                    if (resultadoProcura.Count > 0)
                    {
                        Console.WriteLine("Resultados da pesquisa:");
                        for (int i = 0; i < resultadoProcura.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. Nome: {resultadoProcura[i].Nome}, Sobrenome: {resultadoProcura[i].UltSobrenome}, Time: {resultadoProcura[i].Time}");
                        }

                        Console.Write("Escolha o número do Jogador para ver detalhes: ");
                        int choiceIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (choiceIndex >= 0 && choiceIndex < resultadoProcura.Count)
                        {
                            var jogadorSelecionado = resultadoProcura[choiceIndex];
                            Console.WriteLine($"Detalhes do Jogador: Nome: {jogadorSelecionado.Nome}, Sobrenome: {jogadorSelecionado.UltSobrenome}, Time: {jogadorSelecionado.Time}, Idade: {jogadorSelecionado.CalcularIdade()}, Convocado: {jogadorSelecionado.Convacado}, Gols na Temporada: {jogadorSelecionado.Gols}, Número da Camisa: {jogadorSelecionado.NumCamisa}");
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum Jogador encontrado com esse nome.");
                    }

                        break;
                case 2:
                    Console.WriteLine("Quantos jogador(es) serão ser cadastrado(s)?");
                    int numCadastros = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numCadastros; i++)
                    {
                        Console.WriteLine("Qual o nome do jogador?");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Qual o último sobrenome do jogador?");
                        string ultSobrenome = Console.ReadLine();
                        Console.WriteLine("Qual o time do jogador?");
                        string time = Console.ReadLine();
                        Console.WriteLine("Qual a data de nascimento do jogador? yyyy-MM-dd");
                        DateTime dataDeNasc = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("O jogador foi convocado? S/N");
                        char booleano = char.Parse(Console.ReadLine());
                        bool convocado;
                        if (booleano == 'S')
                        {
                            convocado = true;
                        }
                        if (booleano == 's')
                        {
                            convocado = true;
                        }
                        else
                        {
                            convocado = false;
                        }
                        Console.WriteLine("Quantos gol(s) o jogador fez?");
                        double gols = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o numéro da camisa do jogador?");
                        ushort numCamisa = ushort.Parse(Console.ReadLine());
                        var jogador = new Jogador
                        {
                            Nome = nome,
                            UltSobrenome = ultSobrenome,
                            Time = time,
                            DataDeNasc = dataDeNasc,
                            Convacado = convocado,
                            Gols = gols,
                            NumCamisa = numCamisa,
                        };

                        repoJogador.AdicionarJogador(jogador);
                        Console.WriteLine("Jogador cadastrado com sucesso.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
