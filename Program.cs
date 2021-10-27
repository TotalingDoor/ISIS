using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

namespace Iris
{
    class Program
    {

        //stackoverflow is almighty lol ;)

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(
        IntPtr hWnd,
        IntPtr hWndInsertAfter,
        int x,
        int y,
        int cx,
        int cy,
        int uFlags);

        private const int HWND_TOPMOST = -1;
        private const int SWP_NOMOVE = 0x0002;
        public static string ip;
        public static int threadingnumber = 0;
        private const int SWP_NOSIZE = 0x0001;

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public static void alwaysontop()
        {
            IntPtr hWnd = Process.GetCurrentProcess().MainWindowHandle;
            while (true)
            {
                MoveWindow(hWnd, 0, 30, 550, 400, true);
                SetWindowPos(hWnd,
                new IntPtr(HWND_TOPMOST),
                0, 0, 0, 0,
                SWP_NOMOVE | SWP_NOSIZE);
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Thread t = new Thread(alwaysontop);
            t.Start();
            Thread i = new Thread(Intro);
            i.Start();
            GetCommand();
        }

        public static void Intro()
        {

            //Not related to 911 i promise gg sad fs in the chat bois mission failed 

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("IIIIIIIIII   SSSSSSSSSSSSSSS IIIIIIIIII   SSSSSSSSSSSSSSS ");
            Console.WriteLine("I::::::::I SS:::::::::::::::SI::::::::I SS:::::::::::::::S");
            Console.WriteLine("I::::::::IS:::::SSSSSS::::::SI::::::::IS:::::SSSSSS::::::S");
            Console.WriteLine("II::::::IIS:::::S     SSSSSSSII::::::IIS:::::S     SSSSSSS");
            Console.WriteLine("  I::::I  S:::::S              I::::I  S:::::S            ");
            Console.WriteLine("  I::::I  S:::::S              I::::I  S:::::S            ");
            Console.WriteLine("  I::::I   S::::SSSS           I::::I   S::::SSSS         ");
            Console.WriteLine("  I::::I    SS::::::SSSSS      I::::I    SS::::::SSSSS    ");
            Console.WriteLine("  I::::I      SSS::::::::SS    I::::I      SSS::::::::SS  ");
            Console.WriteLine("  I::::I         SSSSSS::::S   I::::I         SSSSSS::::S ");
            Console.WriteLine("  I::::I              S:::::S  I::::I              S:::::S");
            Console.WriteLine("  I::::I              S:::::S  I::::I              S:::::S");
            Console.WriteLine("II::::::IISSSSSSS     S:::::SII::::::IISSSSSSS     S:::::S");
            Console.WriteLine("I::::::::IS::::::SSSSSS:::::SI::::::::IS::::::SSSSSS:::::S");
            Console.WriteLine("I::::::::IS:::::::::::::::SS I::::::::IS:::::::::::::::SS ");
            Console.WriteLine("IIIIIIIIII SSSSSSSSSSSSSSS   IIIIIIIIII SSSSSSSSSSSSSSS   ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("Author : LegAreStrech");
            Console.WriteLine("");
            Console.Write("Write Ip Here : ");
        }

        public static void BruteForcePortScanner1()
        {
            TcpClient tcpClient = new TcpClient();
            int minuminport = 1;
            int maxport = 1666;
            for (int i = minuminport; i <= maxport; i++)
            {
                try
                {
                    tcpClient.Connect(ip, i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i + " : Port open");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i + " : Port closed");
                }
            }
            threadingnumber = threadingnumber + 1;
        }
        public static void BruteForcePortScanner2()
        {
            TcpClient tcpClient = new TcpClient();
            int minuminport = 1666;
            int maxport = 3332;
            for (int i = minuminport; i <= maxport; i++)
            {
                try
                {
                    tcpClient.Connect(ip, i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i + " : Port open");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i + " : Port closed");
                }
            }
            threadingnumber = threadingnumber + 1;
        }
        public static void BruteForcePortScanner3()
        {
            TcpClient tcpClient = new TcpClient();
            int minuminport = 3332;
            int maxport = 4998;
            for (int i = minuminport; i <= maxport; i++)
            {
                try
                {
                    tcpClient.Connect(ip, i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i + " : Port open");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i + " : Port closed");
                }
            }
            threadingnumber = threadingnumber + 1;
        }
        public static void BruteForcePortScanner4()
        {
            TcpClient tcpClient = new TcpClient();
            int minuminport = 4998;
            int maxport = 6664;
            for (int i = minuminport; i <= maxport; i++)
            {
                try
                {
                    tcpClient.Connect(ip, i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i + " : Port open");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i + " : Port closed");
                }
            }
            threadingnumber = threadingnumber + 1;
        }
        public static void BruteForcePortScanner5()
        {
            TcpClient tcpClient = new TcpClient();
            int minuminport = 6664;
            int maxport = 8330;
            for (int i = minuminport; i <= maxport; i++)
            {
                try
                {
                    tcpClient.Connect(ip, i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i + " : Port open");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i + " : Port closed");
                }
            }
            threadingnumber = threadingnumber + 1;
        }
        public static void BruteForcePortScanner6()
        {
            TcpClient tcpClient = new TcpClient();
            int minuminport = 8330;
            int maxport = 9996;
            for (int i = minuminport; i <= maxport; i++)
            {
                try
                {
                    tcpClient.Connect(ip, i);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i + " : Port open");
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i + " : Port closed");
                }
            }
            threadingnumber = threadingnumber + 1;
        }
        public static void GetCommand()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ip = Console.ReadLine();
            Console.WriteLine("");
            using (var client = new WebClient())
            {
                var contents = client.DownloadString("http://ip-api.com/json/" + ip);
                Console.WriteLine(contents);
                Console.WriteLine("");
                Console.Write("Do you want to bruteforce open ports (y for yes/n for no) : ");
                string whatdidusersay;
                whatdidusersay = Console.ReadLine();
                if (whatdidusersay == "y")
                {
                    var thread = new Thread(new ThreadStart(BruteForcePortScanner1));
                    thread.Start();
                    thread = new Thread(new ThreadStart(BruteForcePortScanner2));
                    thread.Start();
                    thread = new Thread(new ThreadStart(BruteForcePortScanner3));
                    thread.Start();
                    thread = new Thread(new ThreadStart(BruteForcePortScanner4));
                    thread.Start();
                    thread = new Thread(new ThreadStart(BruteForcePortScanner5));
                    thread.Start();
                    thread = new Thread(new ThreadStart(BruteForcePortScanner6));
                    thread.Start();
                    Console.WriteLine("");
                    while (threadingnumber < 6)
                    {
                        //
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Done!");
                    Console.WriteLine("");
                    //if they said yes
                    Console.Write("Write Ip Here : ");
                    GetCommand();
                    return;
                }

                else
                {
                    Console.Write("Do you want to scan for common ports (y for yes/n for no) : ");
                    string whatdidusersay1;
                    whatdidusersay1 = Console.ReadLine();
                    if (whatdidusersay1 == "y")
                    {
                        int i = 21;
                        TcpClient tcpClient = new TcpClient();
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");
                        }
                        i = 22;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 23;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 25;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 53;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 443;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 110;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 135;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 137;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 138;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 139;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 1433;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                        i = 1434;
                        try
                        {
                            tcpClient.Connect(ip, i);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i + " : Port open");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i + " : Port closed");


                        }
                    }
                    Console.WriteLine("");
                    Console.Write("Write Ip Here : ");
                    GetCommand();
                    return;
                }
            }
        }
    }
}
