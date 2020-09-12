using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.NET.Market.TradingRules
{
    /// <summary>
    /// The rate limit.
    /// </summary>
    public class RateLimit
    {
        /// <summary>
        /// Gets or sets the rate limit type.
        /// </summary>
        [JsonProperty("rateLimitType")]
        public string RateLimitType { get; set; }
        /// <summary>
        /// Gets or sets the interval.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }
        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}
