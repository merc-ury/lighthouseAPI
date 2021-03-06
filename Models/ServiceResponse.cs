using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LighthouseAPI.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(
                this,
                new JsonSerializerSettings {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });
        }
    }
}