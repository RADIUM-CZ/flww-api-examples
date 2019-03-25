using System;
using System.Threading.Tasks;

namespace Cz.Radium.NetCore.Examples.RestApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper.Start();

            new TaskCompletionSource<object>().Task.Wait();
        }
    }
}
