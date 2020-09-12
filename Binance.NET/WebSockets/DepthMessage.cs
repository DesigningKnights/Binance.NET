using Binance.NET.Market;
using System.Collections.Generic;

namespace Binance.NET.WebSockets
{
    /// <summary>
    /// The depth message.
    /// </summary>
    public class DepthMessage
    {
        /// <summary>
        /// Gets or sets the event type.
        /// </summary>
        public string EventType { get; set; }
        /// <summary>
        /// Gets or sets the event time.
        /// </summary>
        public long EventTime { get; set; }
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or sets the update id.
        /// </summary>
        public int UpdateId { get; set; }
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
