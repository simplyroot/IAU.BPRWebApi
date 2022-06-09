using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IAU.WebApp
{
    public class ApiResult
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Response { get; set; }

        public static ApiResult SendPostRequestFromBody(string _url, List<ServiceParameterObject> _params)
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromMinutes(30);
                var content = new StringContent(JsonConvert.SerializedObject(_params), Encoding.UTF8, "application/json");
                var result = client.PostAsync(_url, content).Result;
                string resultContent = result.Content.ReadAsStringAsync().Result;

                var apiResult = JsonConver.DeserializedObject<ApiResult>(resultContent);
                return apiResult;
            }
        }
    }
}
