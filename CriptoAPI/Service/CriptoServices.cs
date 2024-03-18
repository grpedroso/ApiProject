﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using ConsoleApp1.Modelos;
using Newtonsoft.Json;

internal class CriptoServices
{
    public async Task<Criptos> Integracao()
    {
        try
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("X-CoinAPI-Key", "5BB6DE8C-0339-4DCF-97EA-4F27E2152A8E");

            HttpResponseMessage response = await client.GetAsync("https://pro-api.coinmarketcap.com/v1/cryptocurrency/map?CMC_PRO_API_KEY=1690b914-781b-4437-802a-18ce2ecfa798");

            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();

                Criptos jsonObject = JsonConvert.DeserializeObject<Criptos>(jsonString);

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