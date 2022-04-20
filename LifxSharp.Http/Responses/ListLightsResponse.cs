using LifxSharp.Http.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Responses
{
    public class ListLightsResponse : LifxHttpResponse
    {
        public Bulb[] Bulbs { get; set; }
    }
}
