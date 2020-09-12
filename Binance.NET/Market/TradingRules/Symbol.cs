using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.NET.Market.TradingRules
{
    /// <summary>
    /// The symbol.
    /// </summary>
    public class Symbol
    {
        /// <summary>
        /// Gets or sets the symbol name.
        /// </summary>
        [JsonProperty("symbol")]
        public string SymbolName { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// Gets or sets the base asset.
        /// </summary>
        [JsonProperty("baseAsset")]
        public string BaseAsset { get; set; }
        /// <summary>
        /// Gets or sets the base asset precision.
        /// </summary>
        [JsonProperty("baseAssetPrecision")]
        public int BaseAssetPrecision { get; set; }
        /// <summary>
        /// Gets or sets the quote asset.
        /// </summary>
        [JsonProperty("quoteAsset")]
        public string QuoteAsset { get; set; }
        /// <summary>
        /// Gets or sets the quote precision.
        /// </summary>
        [JsonProperty("quotePrecision")]
        public int QuotePrecision { get; set; }
        /// <summary>
        /// Gets or sets the order types.
        /// </summary>
        [JsonProperty("orderTypes")]
        public IEnumerable<string> OrderTypes { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether iceberg allowed.
        /// </summary>
        [JsonProperty("icebergAllowed")]
        public bool IcebergAllowed { get; set; }
        /// <summary>
        /// Gets or sets the filters.
        /// </summary>
        [JsonProperty("filters")]
        public IEnumerable<Filter> Filters { get; set; }
    }
}
