using LifxSharp.Http.Helpers;
using LifxSharp.Http.Objects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Client
{
    public partial class LifxHttpClient
    {
        public async Task<Bulb[]> ListLightsAsync(string selector)
        {
            var request = new RestRequest("lights/{selector}");
            request.AddUrlSegment("selector", selector);
            return await _client.GetAsync<Bulb[]>(request)
                                .ConfigureAwait(false)
                                ?? Array.Empty<Bulb>();
        }
        public async Task<Bulb[]> ListLightsAsync() => await ListLightsAsync(Selector.All());

    }
}
