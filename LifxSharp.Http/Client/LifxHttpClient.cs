using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Client
{
    public partial class LifxHttpClient : IDisposable
    {
        private const string ApiVersion = "1";
        private const string BaseUrl = "api.lifx.com";

        private RestClient _client;

        public LifxHttpClient(string appToken, string baseUrl = BaseUrl, IWebProxy? proxy = null) => Initialize(baseUrl, appToken);
        public IWebProxy WebProxy { get; private set; }
        public string AppToken { get; private set; }

        private void Initialize(string baseUrl,  string appToken)
        {
            if (string.IsNullOrWhiteSpace(baseUrl))
                throw new ArgumentException(nameof(baseUrl));

            if (string.IsNullOrWhiteSpace(appToken))
                throw new ArgumentException(nameof(appToken));

            AppToken = appToken;

            if (baseUrl.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                baseUrl = baseUrl.Substring("https://".Length);

            string httpScheme = "https";

            var options = new RestClientOptions(new Uri(string.Format("{0}://{1}/v{2}/", httpScheme, baseUrl, ApiVersion)))
            {
                Proxy = WebProxy,
            };
            _client = new RestClient(options)
            {
                Authenticator = new JwtAuthenticator(AppToken)
            };
            _client.UseNewtonsoftJson(new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = new List<JsonConverter>()
                {
                    new Newtonsoft.Json.Converters.StringEnumConverter()
                }
            });

        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
