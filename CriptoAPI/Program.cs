using System;
using System.Net.Http;
using System.Threading.Channels;
using System.Threading.Tasks;
using ConsoleApp1.Modelos;
using Newtonsoft.Json;

class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            CriptoServices services = new CriptoServices();
            Criptos lista = await services.Integracao();

            if (lista != null && lista.Data != null && lista.Data.Count > 0)
            {
                foreach (var cripto in lista.Data)
                {
                    Console.WriteLine("ID: " + cripto.Id);
                    Console.WriteLine("Nome: " + cripto.Name);
                    Console.WriteLine("Símbolo: " + cripto.Symbol);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nenhuma criptomoeda encontrada.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}

