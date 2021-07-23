using EngineersOffice_Library.Interfaces;
using EngineersOffice_Library.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace EngineersOffice_Library.DataApi
{
    public class SteelGradeDataApi:ISteelGradeData
    {
        private HttpClient httpClient { get; set; }

        public SteelGradeDataApi()
        {
            httpClient = new HttpClient();
        }

        public void AddSteelGrade(SteelGrade steelGrade)
        {
            string url = @"https://localhost:44330/api/SteelGrades";

            var r = httpClient.PostAsync(
                requestUri: url,
                content: new StringContent(JsonConvert.SerializeObject(steelGrade), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
        }
        public void DeleteSteelGrade(int id)
        {
            string url = $"https://localhost:44330/api/SteelGrades/{id}";

            var r = httpClient.DeleteAsync(url).Result;
        }

        public void EditSteelGrade(int id, SteelGrade steelGrade)
        {
           string url = $"https://localhost:44330/api/SteelGrades/{id}";

            var r = httpClient.PutAsync(
                requestUri: url,
                content: new StringContent(JsonConvert.SerializeObject(steelGrade), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
        }

        public IEnumerable<SteelGrade> GetSteelGrades(string searchString)
        {
            string url = $"https://localhost:44330/api/SteelGrades/{searchString}";

            string json = httpClient.GetStringAsync(url).Result;

            return JsonConvert.DeserializeObject<IEnumerable<SteelGrade>>(json);
        }
    }
}
