using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cz.Radium.NetCore.Examples.SignalRClient.Models;
using Microsoft.AspNet.SignalR.Client;

namespace Cz.Radium.NetCore.Examples.SignalRClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radium cz signal R client example!");

            var hubConnection = new HubConnection("<API url address>/FleetwareWebAPI/signalr/");

            //SignalR support only bearer token auth
            hubConnection.Headers.Add("Authorization", "bearer xxxxxxxx");

            IHubProxy stockTickerHubProxy = hubConnection.CreateHubProxy("fleetwareHub");
            stockTickerHubProxy.On<IList<OnlineDataMessage>>("Positions", s =>
            {
                foreach (var item in s)
                {
                    Console.WriteLine($"Received objectId: {item.ObjectId}, lat: {item.Position?.Latitude}, lon: {item.Position?.Longitude}");
                }
                
            });

            hubConnection.Start().Wait();

            //wait forever
            new TaskCompletionSource<object>().Task.Wait();
        }
    }
}
