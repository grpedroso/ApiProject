using System;
using System.Net.Http;
using System.Threading.Tasks;
using ConsoleApp1.CriptoServices;
using ConsoleApp1.Modelos;
using Newtonsoft.Json;

namespace ConsoleApp1.CriptoServices
{
    public class CriptoServices
    {
        public async Task<Cripto> Integracao()
        {
            try
            {
                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync("https://pro-api.coinmarketcap.com/v1/cryptocurrency/map?CMC_PRO_API_KEY=1690b914-781b-4437-802a-18ce2ecfa798");

                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();

                    Cripto jsonObject = JsonConvert.DeserializeObject<Cripto>(jsonString);

                    return jsonObject;
                }
                else
                {
                    Console.WriteLine("Erro ao fazer a requisição à API: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return null;
            }
        }
    }
}
