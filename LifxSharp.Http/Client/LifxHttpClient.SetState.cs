using LifxSharp.Http.Helpers;
using LifxSharp.Http.Requests;
using LifxSharp.Http.Responses;
using Newtonsoft.Json;
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
        /// <summary>
        /// Set the state of bulbs matching a selector
        /// </summary>
        /// <param name="selector">The selector to limit which lights are controlled</param>
        /// <param name="data">SetStateRequest data</param>
        /// <returns></returns>
        public async Task<SetStateResponse> SetState(string selector, SetStateRequest data)
        {
            var request = new RestRequest("lights/{selector}/state");
            request.AddUrlSegment("selector", selector);
            request.AddJsonBody(data);
            var response = await _client.PutAsync<SetStateResponse>(request)
                                .ConfigureAwait(false);
            if(response == null)
            {
                throw new Exception("Error deserializing response");
            }
            return response;
        }

    }
}
