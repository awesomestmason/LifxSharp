using LifxSharp.Http.Objects;

namespace LifxSharp.Http.Responses
{
    public class SetStateResponse
    {
        public class Result
        {
            public string Id { get; set; }
            public string Label { get; set; }
            public LightStatus Status { get; set; }
        }

        public Result[] Results { get; set; }
    }

    
}
