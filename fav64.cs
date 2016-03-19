using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Configuration;
using System.Net;

namespace fav64
{
    public class Lib
    {
        // Variantes publicas.
        #region
        public static object SistemaOperacional = null;
        public static object ServicePack = null;
        public static object Build = null;
        public static object User = null;
        public static object Version = null;
        #endregion
    }

    static public class fav64
    {
        static public string Wr(string pid)
        {
            // Captura dos valores.
            #region
            string Data = "[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + " " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "]";

            // Sistema Operacional.
            #region
            RegistryKey KeySistemaOperacional = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            Lib.SistemaOperacional = KeySistemaOperacional.GetValue("ProductName");
            KeySistemaOperacional.Close();
            KeySistemaOperacional.Dispose();
            #endregion

            // Service Pack
            #region
            RegistryKey KeyServicePack = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            Lib.ServicePack = KeyServicePack.GetValue("CSDVersion");
            KeyServicePack.Close();
            KeyServicePack.Dispose();
            #endregion

            // Build
            #region
            RegistryKey KeyBuild = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            Lib.Build = KeyBuild.GetValue("CurrentBuild");
            KeyBuild.Close();
            KeyBuild.Dispose();
            #endregion

            // Nome de usuário
            #region
            Lib.User = Environment.UserName;
            #endregion

            // Versão
            #region
            StreamReader Leitura_Version = new StreamReader("Version.ini");
            Lib.Version = Leitura_Version.ReadLine();
            #endregion

            #endregion

            StreamWriter Escrita_Fav64 = new StreamWriter("fav.log");
            Escrita_Fav64.WriteLine(Data + " # Sistema Operacional: " + Lib.SistemaOperacional);
            Escrita_Fav64.WriteLine(Data + " # Service Pack: " + Lib.ServicePack);
            Escrita_Fav64.WriteLine(Data + " # Build: " + Lib.Build);
            Escrita_Fav64.WriteLine(Data + " # Nome de usuário: " + Lib.User);
            Escrita_Fav64.WriteLine(Data + " # Versão: " + Lib.Version);
            Escrita_Fav64.Close();

            pid = Path.GetRandomFileName() + Path.GetRandomFileName();
            return pid;
        }
    }
}
