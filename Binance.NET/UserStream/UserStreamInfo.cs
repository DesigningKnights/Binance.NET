using Newtonsoft.Json;

namespace Binance.NET.UserStream
{
    /// <summary>
    /// The user stream info.
    /// </summary>
    public class UserStreamInfo
    {
        /// <summary>
        /// Gets or sets the listen key.
        /// </summary>
        [JsonProperty("listenKey")] public string ListenKey { get; set; }
    }
}