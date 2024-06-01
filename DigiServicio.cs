using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Json;

public class DigiServicios
{
    private readonly HttpClient _httpClient;
    public DigiServicios(HttpClient httpClient){
        this._httpClient= httpClient;
    }

    public async Task<List<Digimon>> GetDigimonsAsync(){
        string url="https://digi-api.com/api/v1/digimon";
        var r= await this._httpClient.GetFromJsonAsync<DigiList>(url);
        return r.Content;
    }

    public class DigiList{
        public List<Digimon> Content {get; set;}
    }

    public class Digimon{
        public int Id{get; set;}
        public string Name{get; set;}
        public string Url{get; set;}
        public string Image{get; set;}
    }
}