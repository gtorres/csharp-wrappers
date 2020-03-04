using System;

namespace Wizkisoft.DotNet.Wrapper
{
    public interface IStreamWriter : IDisposable
    {
        void WriteLine(string value);
    }
}
