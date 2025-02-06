using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace primeiroSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Hello, World!!!"); //Mostra texto com quebra de linha
			Console.Write("Olá, Mundo!!!"); //Mostra texto sem quebra de linha
            Console.WriteLine(1 + 3);
            //declaração de variáveis -> tipo de dados | nome da variável | nome da variável | valor
            string nomeAluno = "Mizael";
            Console.WriteLine(nomeAluno);
            Console.WriteLine("==============");
            int idAluno = 1;
            string telAluno = "14 97744-6688";
            double salarioAluno = 1518.55;
            Console.WriteLine(idAluno);
            Console.WriteLine(telAluno);
            Console.WriteLine(salarioAluno);

            string cidadeAluno; //declaração de variáveis
            cidadeAluno = "salvador"; //atribuição de valores nas variáveis
            string estadoAluno;
            estadoAluno = "Bahia";

            Console.WriteLine(cidadeAluno);
            Console.WriteLine(estadoAluno);
            
            //declaração de constante
            const int meuNum = 1;
            Console.WriteLine(meuNum);
            
            string paisAluno;
            paisAluno = "Brasil";
            //Interpolação de strings
            /* Difernça entre concatenação e interpolação e interpolação de strings --> A interpolação ($"...") permite
             *inserir variáveis diretamente na string, melhorando a legbilidade. Ambas as abordagens funcionam, mas a interpolação de strings é mais moderna e facilita a manutenção do código */
            Console.WriteLine("O aluno nasceu no " + paisAluno + " Seja bem-Vindo, " + nomeAluno + "!");
            //Maneira mais usual de interpolação
            Console.WriteLine($"O aluno nasceu no {paisAluno} Seja bem-vindo, {nomeAluno}!");

            //Atividade 1 C# - Declarando variáveis
            int idCurso = 2;
            string nomeCurso = "Técnico de Informática";
            string dtInicioCurso = "03/02/2025";
            string dtFimCurso = "30/06/2026";
            int idadeMinimaCurso = 16;
            int qtdAlunosCurso = 20;
            Console.WriteLine($"O {nomeCurso} de id {idCurso} inicia {dtInicioCurso} e finaliza {dtFimCurso} podendo ter {qtdAlunosCurso} alunos na turma");

            //Variáveis funcionando como operador matemático
            Console.WriteLine("======= Variáveis ==========");
            int X = 10;
            int Y = 20;
            Console.WriteLine(X + Y);

            //Mútiplas variáveis funcionando como operador matemático
            Console.WriteLine("======= Mútiplas Variáveis =========");
            int x1 = 10, y1 = 20, z1 = 30;
            Console.WriteLine(x1 + y1 + z1);

            int meuCodigo = 10;
            double meuSalario = 1000;
            char minhaInicial = 'G';
            bool meuBooleano = false;
            string meuTexto = "Olá TI";
            Console.WriteLine($"Meu código é: {meuCodigo}, meu salário é: R$ {meuSalario}, A inicial é: {minhaInicial} e a mensagem escrita é: {meuTexto}");

            //Conversão de tipo de dados C#

            int meuInt = 10;
            double meuDouble = meuInt; // conversão de int para double

            Console.WriteLine(meuInt);
            Console.WriteLine(meuDouble);

            double meuDouble1 = 10.50;
            int meuInt1 = (int) meuDouble1; // conversão de double para int

            Console.WriteLine(meuDouble1);
            Console.WriteLine(meuInt1);

            int meuInt2 = 10;
            double meuDouble2 = 8.15;
            bool meuBooleano1 = true;

            Console.WriteLine(Convert.ToString(meuInt2));
            Console.WriteLine(Convert.ToDouble(meuInt2));
            Console.WriteLine(Convert.ToInt32(meuDouble2));
            Console.WriteLine(Convert.ToString(meuBooleano1));

            //Entrada de dados
            Console.WriteLine("\n##### Entrada de Dados #####");
            Console.WriteLine("Digite seu nome:");
            string nomeUsuário = Console.ReadLine();
            Console.WriteLine($"Olá, {nomeUsuário}");

            /*Atividade 1 - 05/02/2025
            Ler e escrever a idade do usuário na tela */
            Console.WriteLine("\n######### Entrada de Dados - IDADE ##########");
            Console.WriteLine("Digite sua idade:");
            int idadeUsuario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"você tem: {idadeUsuario} anos");

            //Operadores Aritiméticos (+, -, *, /, %, ++, --)

            int c = 4;
            int d = 6;
            Console.WriteLine(c % d); //Módulo (resto da divisão)
            Console.WriteLine(c + d); //Adição
            Console.WriteLine(c - d); //subtração
            Console.WriteLine(c * d); //multiplicação
            Console.WriteLine(c / d); //divisão                                                                                                                           

            //Operador de Incremento
            int W = 10;
            W++;
            Console.WriteLine(W);

            //Operador de Decremento
            int P = 5;
            P--;
            Console.WriteLine(P);

            //Operador de atribuição
            int valorV = 300;
            valorV += 10;
            Console.WriteLine(valorV);

            /*Alguns operadores de atribuição
            =
            +=
            -=
            *=
            /=
            %=

            */

            //Operador de comparação
            int u = 5;
            int v = 6;
            Console.WriteLine(u < v);
            /*
            == igual a
            != diferente
            > maior que
            < menor que
            >= maior e igual
            <= menor e igual
            */

            Console.WriteLine("Ólá Munodo");
        }

    }
}
