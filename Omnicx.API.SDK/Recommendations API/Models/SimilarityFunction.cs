﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Omnicx.API.SDK.Recomendation.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SimilarityFunction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SimilarityFunction
    {
        [EnumMember(Value = "Jaccard")]
        Jaccard,
        [EnumMember(Value = "Cooccurrence")]
        Cooccurrence,
        [EnumMember(Value = "Lift")]
        Lift
    }
}
