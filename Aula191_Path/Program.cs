/* CLASSE PATH:
    - Namespace System.IO;
    - Realiza operacores com strings que contem informacoes de arquivos ou pastas. 
*/

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.IO;

namespace Aula191_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\MyFolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); /* Exibe o caminho da pasta TEMP do sistema, onde podemos
                                                                      * manipular dados temporarios de aplicacoes */
        }
    }
}
