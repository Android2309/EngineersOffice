using EngineersOffice_Library.Interfaces;
using EngineersOffice_Library.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace EngineersOffice_Library.DataApi
{
    public class BendingCoefficientDataApi : IBendingCoefficientData
    {
        private HttpClient httpClient { get; set; }

        public BendingCoefficientDataApi()
        {
            httpClient = new HttpClient();
        }


        public void AddBendingCoefficient(BendingCoefficient bendingCoefficient)
        {
            string url = @"https://localhost:44330/api/BendingCoefficients";

            var r = httpClient.PostAsync(
                requestUri: url,
                content: new StringContent(JsonConvert.SerializeObject(bendingCoefficient), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
        }

        public void DeleteBendingCoefficient(int id)
        {
            string url = $"https://localhost:44330/api/BendingCoefficients/{id}";

            var r = httpClient.DeleteAsync(url).Result;
        }

        public void EditBendingCoefficient(int id, BendingCoefficient bendingCoefficient)
        {
            string url = $"https://localhost:44330/api/BendingCoefficients/{id}";

            var r = httpClient.PutAsync(
                requestUri: url,
                content: new StringContent(JsonConvert.SerializeObject(bendingCoefficient), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
        }


        public IEnumerable<BendingCoefficient> GetAllBendingCoefficients()
        {
            string url = @"https://localhost:44330/api/BendingCoefficients/";

            string json = httpClient.GetStringAsync(url).Result;

            return JsonConvert.DeserializeObject<IEnumerable<BendingCoefficient>>(json);
        }

        public BendingCoefficient GetBendingCoefficient_Flex(int flexibility)
        {
            string url = $"https://localhost:44330/api/BendingCoefficients/{flexibility}";

            string json = httpClient.GetStringAsync(url).Result;

            return JsonConvert.DeserializeObject<BendingCoefficient>(json);
        }
    }
}
