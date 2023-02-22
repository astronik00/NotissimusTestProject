using Newtonsoft.Json;

namespace Xml.Options;

public class XmlReadFileOptions
{
    [JsonProperty("Url")] public string Url { get; set; }
}