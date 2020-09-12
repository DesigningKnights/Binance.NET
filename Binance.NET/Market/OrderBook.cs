using System.Collections.Generic;

namespace Binance.NET.Market
{
    /// <summary>
    /// The order book.
    /// </summary>
    public class OrderBook
    {
        /// <summary>
        /// Gets or sets the last update id.
        /// </summary>
        public long LastUpdateId { get; set; }
        /// <summary>
        /// Gets or sets the bids.
        /// </summary>
        public IEnumerable<OrderBookOffer> Bids { get; set; }
        /// <summary>
        /// Gets or sets the asks.
        /// </summary>
        public IEnumerable<OrderBookOffer> Asks { get; set; }
    }
}
