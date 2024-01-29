using Org.BouncyCastle.Crypto.Digests;
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
        public int codigo;
        public ControlPessoa()
        {
            //Instanciar uma variável = Determinar o valor inicial dela
            ConsultarOpcao = 0;
            conectar = new DAO();//Conectando ao banco de dados
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
                "3. Consultar Individual\n" +
                "4. Atualizar \n" +
                "5. Excluir \n" +
                "6. Sair");
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
                        ConsultarTudo();
                        break;
                    case 3:
                        ConsultarIndividual();
                        break;
                    case 4:
                        MenuAtualizar();
                        break;
                    case 5:
                        Deletar();
                        break;
                    case 6:
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

        public void ConsultarTudo()
        {

            Console.WriteLine(conectar.ConsultarTudo());
        }//fim do consultarTudo

        public void ConsultarIndividual()
        {
            Console.WriteLine("Informe o código que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Mostrar na tela 
            Console.WriteLine(conectar.ConsultarTudo(codigo));
        }//fim do consultar


        public void MostrarMenuAtualizar()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: " +
                "\n1. Nome " +
                "\n2. telefone" +
                "\n3.Cidade" +
                "\n4.Endereço");
        }//fim menu atualizar       

        public void MenuAtualizar() 
        {
            MostrarMenuAtualizar();
            switch(opcao) 
            {
                case 1:
                    Console.WriteLine("Informe o codigo do dado que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o novo nome:  ");
                    string nome = Console.ReadLine();
                    //metodo que deseja atualizar
                    conectar.Atualizar(codigo, "nome", nome);
                    break;
                case 2:
                    Console.WriteLine("Informe o codigo do dado que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o novo telefone:  ");
                    string telefone = Console.ReadLine();
                    //metodo que deseja atualizar
                    conectar.Atualizar(codigo, "telefone", telefone);
                    break;
                    
                case 3:
                    Console.WriteLine("Informe o codigo do dado que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe a nova cidade:  ");
                    string cidade = Console.ReadLine();
                    //metodo que deseja atualizar
                    conectar.Atualizar(codigo, "cidade", cidade);
                    break;
                    
                case 4:
                    Console.WriteLine("Informe o codigo do dado que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o novo endereço:  ");
                    string endereco = Console.ReadLine();
                    //metodo que deseja atualizar
                    Console.WriteLine("\n\n" + conectar.Atualizar(codigo, "endereço", endereco));
                    break;
                default:
                    Console.WriteLine("Opção escolhida não é valida!");
                    break;
            }//fim do escolha
        }//fim do metodo

        public void Deletar()
        {
            Console.WriteLine(" Informe um código: ");
            codigo = Convert.ToInt32(Console.ReadLine());
            //Utilizar o metodo excluir 
            Console.WriteLine("\n\n" + conectar.Excluir(codigo));
        }//fim do metodo

    }//fim da classe
}//fim do projeto
