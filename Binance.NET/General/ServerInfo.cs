using Newtonsoft.Json;

namespace Binance.NET.General
{
    /// <summary>
    /// The server info.
    /// </summary>
    public class ServerInfo
    {
        /// <summary>
        /// Gets or sets the server time.
        /// </summary>
        [JsonProperty("serverTime")]
        public long ServerTime { get; set; }
    }
}
