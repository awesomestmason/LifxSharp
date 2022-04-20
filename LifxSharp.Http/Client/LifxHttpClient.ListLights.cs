using LifxSharp.Http.Helpers;
using LifxSharp.Http.Objects;
using LifxSharp.Http.Responses;
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
        public async Task<ListLightsResponse> ListLightsAsync(string selector)
        {
            var request = new RestRequest("lights/{selector}");
            request.AddUrlSegment("selector", selector);
            return await _client.GetAsync<ListLightsResponse>(request).ConfigureAwait(false);
        }
        public async Task<ListLightsResponse> ListLightsAsync() => await ListLightsAsync(Selector.All());

    }
}
