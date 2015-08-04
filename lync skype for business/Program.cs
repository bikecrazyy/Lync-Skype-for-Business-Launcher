using System.Diagnostics;

namespace lync_skype_for_business
{
    class Program
    {
        //define settings and lync data location
        public const string regBase = @"Software\Microsoft\Office";
        public const string subKey = "Lync";
        private const string lyncPath = @"C:\Program Files\Microsoft Office\Office15\lync.exe";
        private const string arguments = "/fromrunkey";
        
        static void Main(string[] args)
        {
            //on  = 00, 00, 00, 01
            //off = 00, 00, 00, 00
            registry.Write("EnableSkypeUI", new byte[] { 00, 00, 00, 01});

            Process cmd = new Process();

            //define lync to be launched
            cmd.StartInfo.FileName = lyncPath;

            //define arguments for lync.exe
            cmd.StartInfo.Arguments = arguments;

            //launch process
            cmd.Start();

        }
    }
}
