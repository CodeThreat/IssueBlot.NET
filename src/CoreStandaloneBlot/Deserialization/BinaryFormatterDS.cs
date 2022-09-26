using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CoreStandaloneBlot.Deserialization
{
    public class BinaryFormatterDS
    {
        private async Task HandleRequestAsync(NamedPipeServerStream pipeServer)
        {
            try
            {
                using (NamedPipeServerStream server = pipeServer)
                {
                    byte[] sizeBytes = new byte[4];
                    await server.ReadAsync(sizeBytes, 0, sizeBytes.Length);
                    int size = BitConverter.ToInt32(sizeBytes, 0);
                    byte[] requestBytes = new byte[size];
                    await server.ReadAsync(requestBytes, 0, requestBytes.Length);
                    BinaryFormatter bf = new BinaryFormatter();
                    PipeRequest request = (PipeRequest)bf.Deserialize(new MemoryStream(requestBytes, 0, requestBytes.Length, false));
                }
            }
            catch (Exception err)
            {

            }

        }
    }
    public class PipeRequest
    {
    }
}