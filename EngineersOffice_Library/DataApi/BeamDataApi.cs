using EngineersOffice_Library.Interfaces;
using EngineersOffice_Library.Models.MetalAssortment;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace EngineersOffice_Library.DataApi
{
    public class BeamDataApi:IBeamData
    {
        private HttpClient httpClient { get; set; }

        public BeamDataApi()
        {
            httpClient = new HttpClient();
        }


        public void AddBeam(Beam beam)
        {
            string url = @"https://localhost:44330/api/MetalAssortment/AddBeam";

            var r = httpClient.PostAsync(
                requestUri: url,
                content: new StringContent(JsonConvert.SerializeObject(beam), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
        }

        public void DeleteBeam(int id)
        {
            string url = $"https://localhost:44330/api/MetalAssortment/DeleteBeam/{id}";

            var r = httpClient.DeleteAsync(url).Result;
        }

        public void EditBeam(int id, Beam beam)
        {
            string url = $"https://localhost:44330/api/MetalAssortment/EditBeam/{id}";

            var r = httpClient.PutAsync(
                requestUri: url,
                content: new StringContent(JsonConvert.SerializeObject(beam), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
        }

        public IEnumerable<Beam> GetAllBeams()
        {
            string url = @"https://localhost:44330/api/MetalAssortment/GetAllBeams";

            string json = httpClient.GetStringAsync(url).Result;

            return JsonConvert.DeserializeObject<IEnumerable<Beam>>(json);

        }

        public Beam GetBeam(int Wx)
        {
            string url = $"https://localhost:44330/api/MetalAssortment/GetBeam/{Wx}";

            string json = httpClient.GetStringAsync(url).Result;

            return JsonConvert.DeserializeObject<Beam>(json);
        }

        public Beam GetBeam_Flex(int id,double F_tr, double Lc)
        {
            string url = $"https://localhost:44330/api/MetalAssortment/GetBeam_Flex/{id}/{F_tr}/{Lc}";

            string json = httpClient.GetStringAsync(url).Result;

            return JsonConvert.DeserializeObject<Beam>(json);
        }
    }
}
