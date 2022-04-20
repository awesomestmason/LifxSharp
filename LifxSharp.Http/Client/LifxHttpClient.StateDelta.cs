using LifxSharp.Http.Requests;
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
        public async Task<SetStateResponse> StateDelta(string selector, SetStateRequest data)
        {
            var request = new RestRequest("lights/{selector}/state/delta");
            request.AddUrlSegment("selector", selector);
            request.AddJsonBody(data);
            var response = await _client.PostAsync<SetStateResponse>(request)
                                .ConfigureAwait(false);
            if (response == null)
            {
                throw new Exception("Error deserializing response");
            }
            return response;
        }
    }
}
