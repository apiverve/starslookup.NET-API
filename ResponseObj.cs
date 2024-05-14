using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("starName")]
    public string starName { get; set; }

    [JsonProperty("mass")]
    public double mass { get; set; }

    [JsonProperty("diameter")]
    public int diameter { get; set; }

    [JsonProperty("galX")]
    public double galX { get; set; }

    [JsonProperty("galY")]
    public double galY { get; set; }

    [JsonProperty("galZ")]
    public double galZ { get; set; }

    [JsonProperty("dist")]
    public double dist { get; set; }

    [JsonProperty("starType")]
    public string starType { get; set; }

    [JsonProperty("temp")]
    public int temp { get; set; }

    [JsonProperty("color")]
    public string color { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
