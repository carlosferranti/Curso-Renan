using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsEstudo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // http://www.linhadecodigo.com.br/artigo/1177/serie-aprenda-csharp-estrutura-de-repeticao.aspx

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //  ***************** ESTRUTURAS CONDICIONAIS

            #region if

            Console.WriteLine("--------IF--------");

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

            Console.WriteLine("\r"); // aplica o <Enter>
            #endregion

            #region Switch/Case
            // Switch - Case = � uma estrutura de condi��o que define o c�digo a ser executado com base em uma
            // compara��o de valores.

            Console.WriteLine("--------Switch/Case--------");

            int mes = 2; // criando a vari�vel
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
                default: // se n�o entrou em nenhum "case" acima ent�o assume este valor (default = padr�o) 
                    Console.WriteLine("M�s inv�lido");
                    break;
            }

            Console.WriteLine("\r"); // aplica o <Enter>
            #endregion

            //  ***************** ESTRUTURAS DE REPETI��O

            #region while
            // WHILE = Enquanto

            Console.WriteLine("--------WHILE--------");

            bool condicao = true;
            int valor = 0;

            valor = 50;

            while (condicao)
            {

                if (valor == 60)
                    condicao = false;

                Console.WriteLine(valor++);
            }

            Console.WriteLine("\r"); // aplica o <Enter>

            #endregion

            #region  do-while

            Console.WriteLine("--------do while--------");

            // do - while = fa�a enquanto
            int contador = 15;
            do
            {
                Console.WriteLine("O contador vale: " + contador);
                contador++;
            } while (contador <= 10);

            Console.WriteLine("\r"); // aplica o <Enter>
            #endregion

            #region for
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
            #endregion

            #region foreach

            Console.WriteLine("--------foreach--------");

            // aqui j� tem uma cole��o/lista definida
            // ent�o o foreach vai percorrer por todos items na lista
            string[] nomes = { "Renan", "Cleber", "Carol", "Denis", "Guigo", "Roberto", "Bruna", "Carla", "Daniel" };

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome.ToString());
            }
            Console.WriteLine("\r"); // aplica o <Enter>

            #endregion

        }
    }
}