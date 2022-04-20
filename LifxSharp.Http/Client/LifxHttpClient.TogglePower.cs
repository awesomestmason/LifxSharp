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
        public async Task<SetStateResponse> TogglePower(string selector, TogglePowerRequest data)
        {
            var request = new RestRequest("lights/{selector}/state/toggle");
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

        public async Task<SetStateResponse> TogglePower(string selector, double duration)
            => await TogglePower(selector, new TogglePowerRequest()
                {
                    Duration = duration,
                });

        public async Task<SetStateResponse> TogglePower(string selector)
            => await TogglePower(selector, new TogglePowerRequest());
    }



}
