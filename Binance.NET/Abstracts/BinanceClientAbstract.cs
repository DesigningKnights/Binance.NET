using Binance.NET.Interfaces;
using Binance.NET.Market.TradingRules;

namespace Binance.NET.Abstracts
{
    /// <summary>
    /// The binance client abstract.
    /// </summary>
    public abstract class BinanceClientAbstract
    {
        /// <summary>
        /// Secret used to authenticate within the API.
        /// </summary>
        public TradingRules _tradingRules;

        /// <summary>
        /// Client to be used to call the API.
        /// </summary>
        public readonly IBinanceApi _binanceApi;

        /// <summary>
        /// Defines the constructor of the Binance client.
        /// </summary>
        /// <param name="binanceApi">API client to be used for API calls.</param>
        public BinanceClientAbstract(IBinanceApi binanceApi)
        {
            _binanceApi = binanceApi;
        }
    }
}