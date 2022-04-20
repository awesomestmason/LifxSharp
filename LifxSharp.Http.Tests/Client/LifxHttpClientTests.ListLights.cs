using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using LifxSharp.Http.Objects;

namespace LifxSharp.Http.Tests.Client
{
    public partial class LifxHttpClientTests
    {
        [Fact]
        public async Task ListLights()
        {
            var result = await client.ListLightsAsync();
            foreach (var bulb in result)
            {
                Assert.NotEqual(DateTime.MinValue, bulb.LastSeen);
            }
        }

    }
}
