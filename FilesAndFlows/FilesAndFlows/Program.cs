using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndFlows
{
    class Program
    {
        static void Main(string[] args)
        {

            File.Delete("./cp866.txt");
            File.Delete("./koi8.txt");
            File.Delete("./windows.txt");
            File.Delete("./utf8.txt");
            File.Delete("./utf16.txt");

            string sampleText = "Используя BinaryFormatter и атрибут [Serializable], сериализовать на диск в бинарном формате объекты классов Student и Teacher, после чего десериализовать.";

            var textInMSDOS = Encoding.GetEncoding("cp866").GetBytes(sampleText);
            var textInKOI8 = Encoding.GetEncoding("koi8-u").GetBytes(sampleText);
            var textInWINDOWS = Encoding.GetEncoding("windows-1251").GetBytes(sampleText);
            var textInUTF8 = Encoding.GetEncoding("utf-8").GetBytes(sampleText);
            var textInUTF16 = Encoding.GetEncoding("utf-16").GetBytes(sampleText);

            File.WriteAllBytes("./cp866.txt", textInMSDOS);
            File.WriteAllBytes("./koi8.txt", textInKOI8);
            File.WriteAllBytes("./windows.txt", textInWINDOWS);
            File.WriteAllBytes("./utf8.txt", textInUTF8);
            File.WriteAllBytes("./utf16.txt", textInUTF16);

            Console.WriteLine("Text in cp866\n");
            var output = File.ReadAllText("./cp866.txt");
            Console.WriteLine(output);
            output = Encoding.GetEncoding("cp866").GetString(File.ReadAllBytes("./cp866.txt"));
            Console.WriteLine(output + "\n----------------------------------------------------");
            
            Console.WriteLine("Text in koi8-u\n");
            output = File.ReadAllText("./koi8.txt");
            Console.WriteLine(output);
            output = Encoding.GetEncoding("koi8-u").GetString(File.ReadAllBytes("./koi8.txt"));
            Console.WriteLine(output + "\n----------------------------------------------------");


            Console.ReadKey();
        }
    }
}
