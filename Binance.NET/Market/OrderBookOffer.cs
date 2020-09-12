namespace Binance.NET.Market
{
    /// <summary>
    /// The order book offer.
    /// </summary>
    public class OrderBookOffer
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public decimal Quantity { get; set; }
    }
}
