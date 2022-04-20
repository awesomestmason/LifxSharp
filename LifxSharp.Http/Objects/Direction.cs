using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Objects
{
    public enum Direction
    {
        [EnumMember(Value = "forward")]
        Forward,
        [EnumMember(Value = "backward")]
        Backward
    }
}
