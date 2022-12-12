using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace WinFormsEstudo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //http://www.linhadecodigo.com.br/artigo/1177/serie-aprenda-csharp-estrutura-de-repeticao.aspx

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            //  ***************** ESTRUTURAS CONDICIONAIS

            int idade = 18;
            if (idade >= 18) // if = se
            {
                // Se a váriavel idade for maior ou igual à 18 esse trecho de código será executado
                Console.WriteLine("Você é maior de idade!");
            }
            else // else = senão
            {
                // Se a váriavel idade não for maior ou igual à 18 esse trecho de código será executado
                Console.WriteLine("Você é menor de idade!");
            }

            // ----------------------------------------------------------------------------------------------

            int mes = 2;
            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mês é Janeiro!");
                    break;
                case 2:
                    Console.WriteLine("O mês é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mês é Março");
                    break;
                case 4:
                    Console.WriteLine("O mês é Abril");
                    break;
                case 5:
                    Console.WriteLine("O mês é Maio");
                    break;
                case 6:
                    Console.WriteLine("O mês é Junho");
                    break;
                case 7:
                    Console.WriteLine("O mês é Julho");
                    break;
                case 8:
                    Console.WriteLine("O mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("O mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("O mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("O mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("O mês é Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }

            //  ***************** ESTRUTURAS DE REPETIÇÃO

            // WHILE = Enquanto
            //
            int numero = -1;
            while (numero != 10)
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 10)
                {
                    Console.WriteLine("Você errou, tente um número maior.");
                }
                else if (numero > 10)
                {
                    Console.WriteLine("Você errou, tente um número menor.");
                }
                else
                {
                    Console.WriteLine("Parabéns, você acertou!");
                }
            }

            // do - while = faça enquanto
            int contador = 15;
            do
            {
                Console.WriteLine("O contador vale: " + contador);
                contador++;
            } while (contador <= 10);

            // for = para 

            // esse exemplo é quando se sabe quantos itens terá numa coleção ou lista (mesma coisa)
            // o int i  = 0 -> é a declaração da variável i, inicializando em 0
            // o i < 20 = é a condição, testa se a variável é menor que 20, atenção que o contador começa no 0
            //              então a variável terá valor zero
            // 0 i++    = faz o incremento de 1 a varável, para o laço for ter o controle de quantas vezes vai
            //              repetir
            for (int i = 0; i < 10; i++)
            {
                int res = i * 2;
                Console.WriteLine(res.ToString());
            }
            Console.WriteLine("\r"); // aplica o <Enter>

            // ----------------------------------------------------------------------------------------------
            // aqui já tem uma coleção/lista definida
            // então o foreach vai percorrer por todos items na lista
            string[] nomes = { "Renan", "Cleber", "Carol", "Denis", "Guigo", "Roberto", "Bruna", "Carla", "Daniel" };

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome.ToString());
            }

        }
    }
}