using System.IO;

namespace Wizkisoft.DotNet.Wrapper
{
    public class DirectoryWrapper : IDirectory
    {
        public DirectoryInfo CreateDirectory(string path) => Directory.CreateDirectory(path);
    }
}
