using System;
using System.IO;

namespace Aula15TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Permissao app = new Permissao();
            app.Autorizar();

            try{
                using (StreamReader sr = File.OpenText("data.txt"))
                {
                    System.Console.WriteLine($"A primeira linha desse arquivo e: \n {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException)
            {
                System.Console.WriteLine($"O arquivo nao foi encontrado");
            }
            catch (DirectoryNotFoundException)
            {
                System.Console.WriteLine($"O diretorio nao foi encontrado");
            }
            catch (IOException)
            {
                System.Console.WriteLine($"O arquivo nao pode ser aberto");
            }
        }
    }
}
