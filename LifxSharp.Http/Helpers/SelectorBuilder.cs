using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Helpers
{
    public static class Selector
    {
        public static string All() => "all";
        public static string Label(string label) => $"label:{label}";
        public static string Id(string id) => $"id:{id}";
        public static string GroupId(string groupId) => $"group_id:{groupId}";
        public static string Group(string group) => $"group:{group}";
        public static string LocationId(string locationId) => $"location_id:{locationId}";
        public static string Location(string location) => $"location:{location}";
        public static string SceneId(string sceneId) => $"scene_id:{sceneId}";

    }
    public class SelectorBuilder
    {
        private List<string> selectors = new List<string>();
        private List<string> zones = new List<string>();
        private bool random = false;
        public SelectorBuilder()
        {
        }

        public SelectorBuilder(string selector)
        {
            selectors.Add(selector);
        }

        public SelectorBuilder Or(string selector)
        {
            selectors.Add(selector);
            return this;
        }

        public SelectorBuilder Random()
        {
            random = true;
            return this;
        }

        public SelectorBuilder Random(bool random)
        {
            this.random = random;
            return this;
        }

        public SelectorBuilder Zone(int zone)
        {
            zones.Add(zone.ToString());
            return this;
        }

        public SelectorBuilder ZoneRange(int startInclusive, int stopInclusive)
        {
            zones.Add($"{startInclusive}-{stopInclusive}");
            return this;
        }
        public string Build()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(selectors.Count > 0)
            {
                stringBuilder.Append(string.Join(',', selectors));
            }
            else
            {
                stringBuilder.Append("all");
            }
            if (random)
            {
                stringBuilder.Append(":random");
            }
            if(zones.Count > 0)
            {
                stringBuilder.Append('|');
                stringBuilder.Append(string.Join('|', zones));
            }
            return stringBuilder.ToString();
        }

    }
}
