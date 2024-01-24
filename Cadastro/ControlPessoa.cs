using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
     class ControlPessoa
    {

        private int opcao;
        DAO conectar;
        public ControlPessoa() 
        { 
               //Instanciar uma variável = Determinar o valor inicial dela
               ConsultarOpcao= 0;
            conectar= new DAO();//Conectando ao banco de dados
        }//fim do construtor
        
        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//fim do getSet

        public void Menu() 
        {
            Console.WriteLine("Escolha um das opções abaixo: \n" +
                "1. Cadastrar\n" +
                "2. Consultar \n" +
                "3. Atualizar \n" +
                "4. Excluir \n" +
                "5. Sair"); 
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu
        public void Operacao() 
        {
            do
            {
                Menu();//Mostrar as opções para o usuário
                switch (ConsultarOpcao)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        //Consultar
                        break;
                    case 3:
                        //Atualizar
                        break;
                    case 4:
                        //Excluir 
                        break;
                    case 5:
                        Console.WriteLine("Obrigado!!");
                        break;
                    default:
                        Console.WriteLine("Informe um codigo de acordo com o menu");
                        break;
                }//fim do escolha caso
            } while (ConsultarOpcao != 5);

        }//fim do metodo
        public void Cadastrar() 
        {
            Console.WriteLine("Informe o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o telefone da pessoa: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Informe a cidade da pessoa:");
            string cidade = Console.ReadLine();
            Console.WriteLine("Informe o endereço da pessoa: ");
            string endereco = Console.ReadLine();
            //Inserir no banco de dados
            conectar.Inserir(nome, telefone, cidade, endereco);
        }// fim do metodo cadastrar 

    }//fim da classe
}//fim do projeto
