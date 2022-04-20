using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Responses
{
    public class LifxHttpResponse
    {
        public bool HasError => Errors.Length != 0;
        public LifxError[] Errors { get; set; }
    }
    public class LifxError
    {
        public string Field { get; set; }
        public string Message { get; set; }
    }
    public class LifxWarning
    {
        public string Warning { get; set; }
        public Dictionary<string, string> UnknownParameters { get; set; }
    }
}
