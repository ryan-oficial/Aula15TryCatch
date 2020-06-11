using System;

namespace Aula15TryCatch
{
    public class Permissao
    {
        private bool Acesso { get; set; }

        public void Autorizar(){
            try{

                System.Console.WriteLine("Acessar aplicaçao? True/False");
                Acesso = Boolean.Parse( Console.ReadLine());

            }catch(Exception){
                System.Console.WriteLine("Erro nos dados inseridos, erro gerado");

            }
            }

        }
}