using Newtonsoft.Json;

namespace Xml.Options;

public class DbConnectionOptions
{
    [JsonProperty("Server")] public string Server { get; set; }

    [JsonProperty("Database")] public string Database { get; set; }

    [JsonProperty("UserId")] public string UserId { get; set; }

    [JsonProperty("Password")] public string Password { get; set; }

    [JsonProperty("TrustServerCertificate")]
    public bool TrustServerCertificate { get; set; }
}