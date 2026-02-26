using System;
using System.IO;
using System.Collections.Generic;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";
            string target = @"d:\bkp\newfolder";

            try
            {
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folder)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //Copia pastas, subpastas com arquivos 
                Console.WriteLine();
                CopiarDiretorio(path, target, true);
                Console.WriteLine("Pasta copiada com sucesso!");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred: ");

            }
        }
        public static void CopiarDiretorio(string origem, string destino, bool incluirSubpastas)
        {


            // Obtém informações da pasta de origem
            DirectoryInfo dir = new DirectoryInfo(origem);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException($"Pasta de origem não encontrada: {dir.FullName}");
            }

            // Cria a pasta de destino se não existir
            Directory.CreateDirectory(destino);

            // Copia os arquivos da pasta atual
            foreach (FileInfo file in dir.GetFiles())
            {
                string caminhoDestinoArquivo = Path.Combine(destino, file.Name);
                file.CopyTo(caminhoDestinoArquivo, true); // true = sobrescrever se existir
            }


            // Copia subpastas recursivamente
            if (incluirSubpastas)
            {
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    string caminhoDestinoSubDir = Path.Combine(destino, subDir.Name);
                    CopiarDiretorio(subDir.FullName, caminhoDestinoSubDir, true);
                }
            }

        }
    }
}