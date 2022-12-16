using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
//using GodSharp.Opc.Da;
//using GodSharp.Opc;
//using GodSharp.Opc.Da.Options;
using TitaniumAS.Opc.Client.Da;
using TitaniumAS.Opc.Client.Da.Browsing;
using TitaniumAS.Opc.Client.Common;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servidorTCP_OPC
{
    internal class Program
    {
        
   
         static void Main(string[] args)
        {
            OpcDaServer client;

            Uri url = UrlBuilder.Build("Matrikon.OPC.Simulation.1");
            client = new OpcDaServer(url);
            client.Connect();
            if (client.IsConnected)
            {
                Console.WriteLine("Conectou ao Matrikon");
            }
            else
            {
                Console.WriteLine("Não Conectou ao Matrikon");

            }

            int value = 2;
            OpcDaGroup group = client.AddGroup("Group0");
            group.IsActive = true;

            //var items = new List<OpcDaItemDefinition>();
            //var item = new OpcDaItemDefinition { ItemId = "G13", IsActive = true };
            //items.Add(item);
            //group.AddItems(items);
            var definition1 = new OpcDaItemDefinition
            {
                ItemId = ".D13",
                IsActive = true
            };
            
            OpcDaItemDefinition[] definitions = { definition1 };
            OpcDaItemResult[] results = group.AddItems(definitions);

            // Handle adding results.
            foreach (OpcDaItemResult result in results)
            {
                if (result.Error.Failed)
                    Console.WriteLine("Error adding items: {0}", result.Error);
            }


            //OpcDaGroup group = CreateGroupWithItems(server);

            OpcDaItem item3 = group.Items.FirstOrDefault(i => i.ItemId == ".D13");


            OpcDaItem[] items2 = { item3 };



            // Criar um novo Socket
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Vincular o Socket à porta 8080
            server.Bind(new IPEndPoint(IPAddress.Any, 8080));

            // Iniciar a escuta de novas conexões
            server.Listen(10);

            // Fica em loop infinito, aceitando novas conexões
            while (true)
            {
                Console.WriteLine("Aguardando conexões");
                // Aceitar uma nova conexão
                Socket clientSocket = server.Accept();

                // Obter o stream de rede da conexão
                NetworkStream stream = new NetworkStream(clientSocket);

                // Lê dados da conexão e os imprime na tela
                while (clientSocket.Connected)
                {
                    // Ler dados do stream
                    byte[] data = new byte[1024];
                    int bytesRead = stream.Read(data, 0, data.Length);

                    // Imprimir os dados lidos na tela
                    Console.WriteLine(Encoding.ASCII.GetString(data, 0, bytesRead));
                    // Fechar a conexão quando terminar

                    string aux = Encoding.ASCII.GetString(data, 0, bytesRead);
                    int value3 = Int32.Parse(aux);

                    object[] values = { value3 };

                    HRESULT[] results2 = group.Write(items2, values);

                    // Handle write result.
                    if (results2[0].Failed)
                    {
                        Console.WriteLine("Error writing value");
                    }

                    clientSocket.Close();
                }


            }


        }
        
    }
   
}
