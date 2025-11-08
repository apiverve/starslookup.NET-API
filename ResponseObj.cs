using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("starName")]
        public string StarName { get; set; }

        [JsonProperty("mass")]
        public int Mass { get; set; }

        [JsonProperty("diameter")]
        public int Diameter { get; set; }

        [JsonProperty("galX")]
        public double GalX { get; set; }

        [JsonProperty("galY")]
        public double GalY { get; set; }

        [JsonProperty("galZ")]
        public double GalZ { get; set; }

        [JsonProperty("dist")]
        public double Dist { get; set; }

        [JsonProperty("starType")]
        public string StarType { get; set; }

        [JsonProperty("temp")]
        public int Temp { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
