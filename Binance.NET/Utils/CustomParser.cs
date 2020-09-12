using System.Collections;
using Binance.NET.Market;
using Binance.NET.WebSockets;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace Binance.NET.Utils
{
    /// <summary>
    /// Class to parse some specific entities.
    /// </summary>
    public class CustomParser
    {
        /// <summary>
        /// Gets the orderbook data and generates an OrderBook object.
        /// </summary>
        /// <param name="orderBookData">Dynamic containing the orderbook data.</param>
        /// <returns></returns>
        public OrderBook GetParsedOrderBook(dynamic orderBookData)
        {
            OrderBook result = new OrderBook
            {
                LastUpdateId = orderBookData.lastUpdateId.Value
            };

            List<OrderBookOffer> bids = ((JArray) orderBookData.bids).ToArray().Select(item => new OrderBookOffer() {Price = decimal.Parse(item[0].ToString()), Quantity = decimal.Parse(item[1].ToString())}).ToList();

            List<OrderBookOffer> asks = ((JArray) orderBookData.asks).ToArray().Select(item => new OrderBookOffer() {Price = decimal.Parse(item[0].ToString()), Quantity = decimal.Parse(item[1].ToString())}).ToList();

            result.Bids = bids;
            result.Asks = asks;

            return result;
        }

        /// <summary>
        /// Gets the candlestick data and generates an Candlestick object.
        /// </summary>
        /// <param name="candlestickData">Dynamic containing the candlestick data.</param>
        /// <returns></returns>
        public IEnumerable<Candlestick> GetParsedCandlestick(dynamic candlestickData)
        {
            return ((JArray) candlestickData).ToArray()
                .Select(item => new Candlestick()
                {
                    OpenTime = long.Parse(item[0].ToString()),
                    Open = decimal.Parse(item[1].ToString()),
                    High = decimal.Parse(item[2].ToString()),
                    Low = decimal.Parse(item[3].ToString()),
                    Close = decimal.Parse(item[4].ToString()),
                    Volume = decimal.Parse(item[5].ToString()),
                    CloseTime = long.Parse(item[6].ToString()),
                    QuoteAssetVolume = decimal.Parse(item[7].ToString()),
                    NumberOfTrades = int.Parse(item[8].ToString()),
                    TakerBuyBaseAssetVolume = decimal.Parse(item[9].ToString()),
                    TakerBuyQuoteAssetVolume = decimal.Parse(item[10].ToString())
                })
                .ToList();
        }

        /// <summary>
        /// Gets the parsed depth message.
        /// </summary>
        /// <param name="messageData">The message data.</param>
        /// <returns>A DepthMessage.</returns>
        public DepthMessage GetParsedDepthMessage(dynamic messageData)
        {
            DepthMessage result = new DepthMessage
            {
                EventType = messageData.e,
                EventTime = messageData.E,
                Symbol = messageData.s,
                UpdateId = messageData.u
            };

            List<OrderBookOffer> bids = ((JArray) messageData.b).ToArray().Select(item => new OrderBookOffer() {Price = decimal.Parse(item[0].ToString()), Quantity = decimal.Parse(item[1].ToString())}).ToList();

            List<OrderBookOffer> asks = ((JArray) messageData.a).ToArray().Select(item => new OrderBookOffer() {Price = decimal.Parse(item[0].ToString()), Quantity = decimal.Parse(item[1].ToString())}).ToList();

            result.Bids = bids;
            result.Asks =  asks;

            return result;
        }
    }
}
