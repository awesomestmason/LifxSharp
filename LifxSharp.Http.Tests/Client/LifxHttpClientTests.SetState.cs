using LifxSharp.Http.Helpers;
using LifxSharp.Http.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LifxSharp.Http.Tests.Client
{
    public partial class LifxHttpClientTests
    {
        [Fact]
        public async Task SetAllLightStates() {
            var selector = new SelectorBuilder(Selector.Label("customLabel1"))
                .Or(Selector.Label("customLabel2"))
                .Or(Selector.Label("customLabel3"))
                .Build();

            var color = new LifxColor()
            {
                Brightness = 1,
                Hue = 100,
                Kelvin = 4500,
                Saturation = 1
            };
            var request = new SetStateRequest() { Color = color.AsLifxColorString(), Duration = 15 };
            var result = await client.SetState(selector, request);
            Assert.NotNull(result);
            
        }


    }
}
