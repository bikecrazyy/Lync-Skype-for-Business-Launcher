using System.Diagnostics;
using System.IO;

namespace lync_skype_for_business
{
    class Program
    {
        //define settings and lync data location
        public const string regBase = @"Software\Microsoft\Office";
        public const string subKey = "Lync";
        private const string lyncPath32 = @"C:\Program Files (x86)\Microsoft Office\Office15\lync.exe";
        private const string lyncPath64 = @"C:\Program Files\Microsoft Office\Office15\lync.exe";
        private const string arguments = "/fromrunkey";
        
        static void Main(string[] args)
        {
            try
            {
                //on  = 00, 00, 00, 01
                //off = 00, 00, 00, 00
                registry.Write("EnableSkypeUI", new byte[] { 00, 00, 00, 01});

                Process cmd = new Process();

                if (File.Exists(lyncPath32))
                {
                    //define lync to be launched 32bit
                    cmd.StartInfo.FileName = lyncPath32;
                }
                else
                {
                    //define lync to be launched 64bit
                    cmd.StartInfo.FileName = lyncPath64;
                }

                //define arguments for lync.exe
                cmd.StartInfo.Arguments = arguments;

                //launch process
                cmd.Start();

            }
            catch (System.Exception)
            {
            }

        }
    }
}
