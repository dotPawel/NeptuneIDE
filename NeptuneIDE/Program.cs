using DiscordRPC;
using System;
using Windows.Media.Protection.PlayReady;

namespace NeptuneIDE
{
    internal class Program
    {
        public static string ver = "1.0d";
        // d - debug
        // r - release
        // rc - release candidate

        public static bool enableCLI = false;

        public static string time = DateTime.Now.ToString("t");

        public static DiscordRpcClient client = new DiscordRpcClient("1070356992385896469");

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" NeptuneIDE // Build " + ver);
                Console.WriteLine("--------------------------------------");

                if (enableCLI)
                {
                    Console.WriteLine(time + " // CLI enabled");
                    CLI.CMD();
                }

                Console.WriteLine(time + " // Neptune started");

                Application.EnableVisualStyles();
                Console.WriteLine(time + " // Enabled VisualStyles");

                Console.WriteLine(time + " // Initializing DiscordRPC");
                client.Initialize();

                Console.WriteLine(time + " // Setting RPC");
                SetEmptyRPC();

                Console.WriteLine(time + " // Opening StartUp form");
                Application.Run(new StartUp());
            }
            catch (Exception ex)
            {
                crashHandler(ex);
            }
        }
        public static void log(string msg)
        {
            Console.WriteLine(time + " // " + msg);
        }
        public static void SetEmptyRPC()
        {
            client.ClearPresence();

            client.SetPresence(new RichPresence()
            {
                Details = "No file loaded.",
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "NeptuneIDE version " + ver,
                }
            });
        }
        public static void SetFileRPC()
        {  
            client.ClearPresence();

            client.SetPresence(new RichPresence()
            {
                Details = "Editting an " + Editor.editorLanguage + " file.",
                State = "File name : " + Path.GetFileName(Editor.filePath),
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "NeptuneIDE version " + ver,
                }
            });
        }
        public static void crashHandler(Exception exception)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            try
            {
                Console.WriteLine("\n--------------------------------------");
                Console.WriteLine(" NeptuneIDE has crashed!");
                Console.WriteLine("(just to clarify this is no good)");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Version : " + ver);
                Console.WriteLine("Time : " + time);
                Console.WriteLine("CLI : " + enableCLI);
                Console.WriteLine("filePath : " + Editor.filePath);
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(" Exception : \n" + exception);
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(" --- Press any key to exit ---");
                Console.ReadKey();
                Application.Exit();
            }
            catch
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("You managed to crash the crash hander");
                Console.WriteLine("press any key to exit");
                Console.WriteLine("--------------------------------------");
                Console.ReadKey();
                Application.Exit();
            }
        }
    }
}