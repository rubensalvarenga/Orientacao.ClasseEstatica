using System;

namespace Orientacao.ClasseEstatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("As classes estáticas são úteis em cenários onde você precisa agrupar funções relacionadas e ");
            Console.WriteLine("fornecer acesso fácil a elas sem criar instâncias da classe. Elas são comumente usadas para ");
            Console.WriteLine("utilitários, bibliotecas de funções auxiliares, métodos matemáticos, manipulação de datas, ");
            Console.WriteLine("gerenciadores de configuração.");
            Console.WriteLine("");
            Console.WriteLine($"Versão do APP : {Ambiente.Versao}");
            Console.WriteLine("");
            Console.WriteLine($"Sistame Operacional : {Ambiente.SistemaOperacional()}");
            Console.WriteLine("");
            Console.WriteLine($"Equação : {Ambiente.Soma(34, 56)}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine($"Todas as configurações são {Ambiente.Configuracoes}");
            Console.WriteLine("");   
            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();

        }
    }

    public static class Ambiente
    {
        public static string Versao = "1.45 e";
        public static int Soma(int menor, int maior)
        {
            return (maior * menor / 45);
        }
        public static bool Configuracoes = false;

        public static string SistemaOperacional()
        {
            //Get Operating system information.
            OperatingSystem os = Environment.OSVersion;
            //Get version information about the os.
            Version vs = os.Version;

            //Variable to hold our return value
            string operatingSystem = "";

            if (os.Platform == PlatformID.Win32Windows)
            {
                //This is a pre-NT version of Windows
                switch (vs.Minor)
                {
                    case 0:
                        operatingSystem = "95";
                        break;
                    case 10:
                        if (vs.Revision.ToString() == "2222A")
                            operatingSystem = "98SE";
                        else
                            operatingSystem = "98";
                        break;
                    case 90:
                        operatingSystem = "Me";
                        break;
                    default:
                        break;
                }
            }
            else if (os.Platform == PlatformID.Win32NT)
            {
                switch (vs.Major)
                {
                    case 3:
                        operatingSystem = "NT 3.51";
                        break;
                    case 4:
                        operatingSystem = "NT 4.0";
                        break;
                    case 5:
                        if (vs.Minor == 0)
                            operatingSystem = "2000";
                        else
                            operatingSystem = "XP";
                        break;
                    case 6:
                        if (vs.Minor == 0)
                            operatingSystem = "Vista";
                        else if (vs.Minor == 1)
                            operatingSystem = "7";
                        else if (vs.Minor == 2)
                            operatingSystem = "8";
                        else
                            operatingSystem = "8.1";
                        break;
                    case 10:
                        operatingSystem = "10";
                        break;
                    default:
                        break;
                }
            }

            if (operatingSystem != "")
            {
                //Got something.  Let's prepend "Windows" and get more info.
                operatingSystem = "Windows " + operatingSystem;
                //See if there's a service pack installed.
                if (os.ServicePack != "")
                {
                    //Append it to the OS name.  i.e. "Windows XP Service Pack 3"
                    operatingSystem += " " + os.ServicePack;
                }
                //Append the OS architecture.  i.e. "Windows XP Service Pack 3 32-bit"
                //operatingSystem += " " + getOSArchitecture().ToString() + "-bit";
            }
            //Return the information we've gathered.
            return operatingSystem;

        }
    }
}

        

