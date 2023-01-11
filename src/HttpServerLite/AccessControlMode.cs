﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpServerLite
{
    /// <summary>
    /// Access control mode of operation.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccessControlMode
    {
        /// <summary>
        /// Permit requests from any endpoint by default.
        /// </summary>
        [EnumMember(Value = "DefaultPermit")]
        DefaultPermit,
        /// <summary>
        /// Deny requests from any endpoint by default.
        /// </summary>
        [EnumMember(Value = "DefaultDeny")]
        DefaultDeny
    }
}
