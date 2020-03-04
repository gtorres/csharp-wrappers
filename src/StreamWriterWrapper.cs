using System.IO;

namespace Wizkisoft.DotNet.Wrapper
{
    public class StreamWriterWrapper : IStreamWriter
    {
        public StreamWriterWrapper(string filePath) => this.streamWriter = new StreamWriter(filePath);

        private StreamWriter streamWriter;

        public void Dispose() => this.streamWriter.Dispose();

        public void WriteLine(string value) =>
            this.streamWriter.WriteLine(value);
    }
}
