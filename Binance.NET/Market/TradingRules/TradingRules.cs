using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.NET.Market.TradingRules
{
    /// <summary>
    /// The trading rules.
    /// </summary>
    public class TradingRules
    {
        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        /// <summary>
        /// Gets or sets the server time.
        /// </summary>
        [JsonProperty("serverTime")]
        public long ServerTime { get; set; }
        /// <summary>
        /// Gets or sets the rate limits.
        /// </summary>
        [JsonProperty("rateLimits")]
        public IEnumerable<RateLimit> RateLimits { get; set; }
        /// <summary>
        /// Gets or sets the symbols.
        /// </summary>
        [JsonProperty("symbols")]
        public IEnumerable<Symbol> Symbols { get; set; }
    }
}
