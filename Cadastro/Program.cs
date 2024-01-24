using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
     class Program
    {
        static void Main(string[] args)
        {
            ControlPessoa pessoa = new ControlPessoa(); //Conectando a control e a model
            pessoa.Operacao();
            Console.ReadLine();//Manter o prompt aberto
        }//fim do método
    }//fim da classe
}//fim do projeto
