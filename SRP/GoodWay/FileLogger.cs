using System.IO;

namespace SOLID.SRP.GoodWay
{
    internal class FileLogger
    {
        public void Handle (string error)
        {
            File.WriteAllText (@"C:\SOLID.txt", error);
        }
    }
}
