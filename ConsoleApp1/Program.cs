using System;
using System.Net.Http;
using System.Threading.Channels;
using System.Threading.Tasks;
using ConsoleApp1.Filters;
using ConsoleApp1.Modelos;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            CriptoServices services = new CriptoServices();
            Criptos lista = await services.Integracao();
            LinqOrder.ExibirListaCriptosOrdenadas(lista);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}

