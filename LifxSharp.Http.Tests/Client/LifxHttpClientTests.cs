using LifxSharp.Http.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Tests.Client
{
    public partial class LifxHttpClientTests
    {
        private LifxHttpClient client;
        public LifxHttpClientTests()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<LifxHttpClientTests>()
                .Build();
            client = new LifxHttpClient(config["LifxApiKey"]);
        }
    }
}
