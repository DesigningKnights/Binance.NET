using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.NET.Market.TradingRules
{
    /// <summary>
    /// The filter.
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Gets or sets the filter type.
        /// </summary>
        [JsonProperty("filterType")]
        public string FilterType { get; set; }
        /// <summary>
        /// Gets or sets the min price.
        /// </summary>
        [JsonProperty("minPrice")]
        public decimal MinPrice { get; set; }
        /// <summary>
        /// Gets or sets the max price.
        /// </summary>
        [JsonProperty("maxPrice")]
        public decimal MaxPrice { get; set; }
        /// <summary>
        /// Gets or sets the tick size.
        /// </summary>
        [JsonProperty("tickSize")]
        public decimal TickSize { get; set; }
        /// <summary>
        /// Gets or sets the min qty.
        /// </summary>
        [JsonProperty("minQty")]
        public decimal MinQty { get; set; }
        /// <summary>
        /// Gets or sets the max qty.
        /// </summary>
        [JsonProperty("maxQty")]
        public decimal MaxQty { get; set; }
        /// <summary>
        /// Gets or sets the step size.
        /// </summary>
        [JsonProperty("stepSize")]
        public decimal StepSize { get; set; }
        /// <summary>
        /// Gets or sets the min notional.
        /// </summary>
        [JsonProperty("minNotional")]
        public decimal MinNotional { get; set; }
    }
}
