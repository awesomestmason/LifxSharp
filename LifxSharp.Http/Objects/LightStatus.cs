using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Objects
{
    public enum LightStatus
    {
        [EnumMember(Value = "ok")]
        Ok,
        [EnumMember(Value = "timed_out")]
        TimedOut,
        [EnumMember(Value = "offline")]
        Offline
    }

}
