using LifxSharp.Http.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LifxSharp.Http.Tests.Helpers
{
    public class SelectorBuilderTests
    {
        [Fact]
        public void SelectorBuildsSingleProperty()
        {
            Assert.Equal("all", new SelectorBuilder(Selector.All()).Build());
        }
        [Fact]
        public void SelectorBuildsSingleParameterizedProperty()
        {
            Assert.Equal("label:test", new SelectorBuilder(Selector.Label("test")).Build());
            Assert.Equal("id:test", new SelectorBuilder(Selector.Id("test")).Build());
        }

        [Fact]
        public void SelectorBuildsMultipleProperties()
        {
            Assert.Equal("label:office,label:kitchen",
                new SelectorBuilder(Selector.Label("office"))
                .Or(Selector.Label("kitchen"))
                .Build());
        }

        [Fact]
        public void SelectorBuildsRandom()
        {
            Assert.Equal("label:test:random",
                new SelectorBuilder(Selector.Label("test"))
                .Random()
                .Build());
        }


        [Fact]
        public void SelectorBuildsZone()
        {
            Assert.Equal("label:test|1",
                new SelectorBuilder(Selector.Label("test"))
                .Zone(1)
                .Build());
        }
        [Fact]
        public void SelectorBuildsMultipleZones()
        {
            Assert.Equal("label:test|1|2|99",
                new SelectorBuilder(Selector.Label("test"))
                .Zone(1)
                .Zone(2)
                .Zone(99)
                .Build());
        }
        [Fact]
        public void SelectorBuildsZoneRange()
        {
            Assert.Equal("label:test|1-99",
                new SelectorBuilder(Selector.Label("test"))
                .ZoneRange(1,99)
                .Build());
        }
    }
}
