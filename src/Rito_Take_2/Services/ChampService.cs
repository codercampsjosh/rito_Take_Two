using Newtonsoft.Json;
using Rito_Take_2.ViewModels.Champs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rito_Take_2.Services
{
    public class ChampService
    {
        private const string _apiKey = "4ea62465-85f2-4964-8350-657bee2e0f4c";
        private HttpClient _httpClient;

        public ChampService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetChampsBasic()
        {
            var info = await _httpClient.GetStreamAsync("https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion?api_key=" + _apiKey);
            string result = new StreamReader(info).ReadToEnd();
            return result;
        }

        public async Task<string> GetChampDetailed(int id)
        {
            var info = await _httpClient.GetStreamAsync("/api/lol/static-data/na/v1.2/champion/" + id + "?api_key=" +_apiKey);
            //  
            string result = new StreamReader(info).ReadToEnd();
            return result;
        }


    }   
}
