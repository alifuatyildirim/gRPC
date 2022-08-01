using Grpc.Net.Client;
using GrpcServiceClient;
using System;

namespace gRPCClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var greetClient = new Greeter.GreeterClient(channel);
            HelloReply response = greetClient.SayHello(new HelloRequest { Name = "Gençay" });
            Console.WriteLine($"Gelen Cevap : {response.Message}");
        }
    }
}
