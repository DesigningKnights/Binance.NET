using Newtonsoft.Json;

namespace Binance.NET.Market
{
    /// <summary>
    /// The symbol price.
    /// </summary>
    public class SymbolPrice
    {
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }
    }
}
