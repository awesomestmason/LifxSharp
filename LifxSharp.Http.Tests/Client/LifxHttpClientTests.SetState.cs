using LifxSharp.Http.Helpers;
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
            var selector = new SelectorBuilder(Selector.All()).Build();
            var color = new LifxColor()
            {
                Brightness = 1,
                Hue = 100,
                Kelvin = 4500,
                Saturation = 1
            };
            var result = await client.SetState(selector, color: color, duration: 15);
            Assert.NotNull(result);
            
        }


    }
}
