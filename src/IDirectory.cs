using System.IO;

namespace Wizkisoft.DotNet.Wrapper
{
    public interface IDirectory
    {
        DirectoryInfo CreateDirectory(string path);
    }
}
