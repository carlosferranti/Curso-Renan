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
                // Se a v�riavel idade for maior ou igual � 18 esse trecho de c�digo ser� executado
                Console.WriteLine("Voc� � maior de idade!");
            }
            else // else = sen�o
            {
                // Se a v�riavel idade n�o for maior ou igual � 18 esse trecho de c�digo ser� executado
                Console.WriteLine("Voc� � menor de idade!");
            }

            // ----------------------------------------------------------------------------------------------

            int mes = 2;
            switch (mes)
            {
                case 1:
                    Console.WriteLine("O m�s � Janeiro!");
                    break;
                case 2:
                    Console.WriteLine("O m�s � Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O m�s � Mar�o");
                    break;
                case 4:
                    Console.WriteLine("O m�s � Abril");
                    break;
                case 5:
                    Console.WriteLine("O m�s � Maio");
                    break;
                case 6:
                    Console.WriteLine("O m�s � Junho");
                    break;
                case 7:
                    Console.WriteLine("O m�s � Julho");
                    break;
                case 8:
                    Console.WriteLine("O m�s � Agosto");
                    break;
                case 9:
                    Console.WriteLine("O m�s � Setembro");
                    break;
                case 10:
                    Console.WriteLine("O m�s � Outubro");
                    break;
                case 11:
                    Console.WriteLine("O m�s � Novembro");
                    break;
                case 12:
                    Console.WriteLine("O m�s � Dezembro");
                    break;
                default:
                    Console.WriteLine("M�s inv�lido");
                    break;
            }

            //  ***************** ESTRUTURAS DE REPETI��O

            // WHILE = Enquanto
            //
            int numero = -1;
            while (numero != 10)
            {
                Console.Write("Digite um n�mero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 10)
                {
                    Console.WriteLine("Voc� errou, tente um n�mero maior.");
                }
                else if (numero > 10)
                {
                    Console.WriteLine("Voc� errou, tente um n�mero menor.");
                }
                else
                {
                    Console.WriteLine("Parab�ns, voc� acertou!");
                }
            }

            // do - while = fa�a enquanto
            int contador = 15;
            do
            {
                Console.WriteLine("O contador vale: " + contador);
                contador++;
            } while (contador <= 10);

            // for = para 

            // esse exemplo � quando se sabe quantos itens ter� numa cole��o ou lista (mesma coisa)
            // o int i  = 0 -> � a declara��o da vari�vel i, inicializando em 0
            // o i < 20 = � a condi��o, testa se a vari�vel � menor que 20, aten��o que o contador come�a no 0
            //              ent�o a vari�vel ter� valor zero
            // 0 i++    = faz o incremento de 1 a var�vel, para o la�o for ter o controle de quantas vezes vai
            //              repetir
            for (int i = 0; i < 10; i++)
            {
                int res = i * 2;
                Console.WriteLine(res.ToString());
            }
            Console.WriteLine("\r"); // aplica o <Enter>

            // ----------------------------------------------------------------------------------------------
            // aqui j� tem uma cole��o/lista definida
            // ent�o o foreach vai percorrer por todos items na lista
            string[] nomes = { "Renan", "Cleber", "Carol", "Denis", "Guigo", "Roberto", "Bruna", "Carla", "Daniel" };

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome.ToString());
            }

        }
    }
}