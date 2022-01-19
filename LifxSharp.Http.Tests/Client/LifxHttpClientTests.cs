using LifxSharp.Http.Client;
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
            client = new LifxHttpClient("c84c300db65d9a1ed88fa523fc9aa077c8d244bbe042a22f69ffa620967ade21");
        }
    }
}
