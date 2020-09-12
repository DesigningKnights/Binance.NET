using Binance.NET.Enums;
using Binance.NET.WebSockets;
using System.Threading.Tasks;
using static Binance.NET.Abstracts.BinanceApiAbstract;

namespace Binance.NET.Interfaces
{
    public interface IBinanceApi
    {
        /// <summary>
        /// Calls API Methods.
        /// </summary>
        /// <typeparam name="T">Type to which the response content will be converted.</typeparam>
        /// <param name="method">HTTPMethod (POST-GET-PUT-DELETE)</param>
        /// <param name="endpoint">Url endpoint.</param>
        /// <param name="isSigned">Specifies if the request needs a signature.</param>
        /// <param name="parameters">Request parameters.</param>
        /// <returns></returns>
        Task<T> CallAsync<T>(ApiMethod method, string endpoint, bool isSigned = false, string parameters = null);

        /// <summary>
        /// Connects to a Websocket endpoint.
        /// </summary>
        /// <typeparam name="T">Type used to parsed the response message.</typeparam>
        /// <param name="parameters">Parameters to send to the Websocket.</param>
        /// <param name="messageDelegate">Delegate to callback after receive a message.</param>
        /// <param name="useCustomParser">Specifies if needs to use a custom parser for the response message.</param>
        void ConnectToWebSocket<T>(string parameters, MessageHandler<T> messageDelegate, bool useCustomParser = false);

        /// <summary>
        /// Connects to a UserData Websocket endpoint.
        /// </summary>
        /// <param name="parameters">Parameters to send to the Websocket.</param>
        /// <param name="accountHandler">Delegate to callback after receive a account info message.</param>
        /// <param name="tradeHandler">Delegate to callback after receive a trade message.</param>
        /// <param name="orderHandler">Delegate to callback after receive a order message.</param>
        void ConnectToUserDataWebSocket(string parameters, MessageHandler<AccountUpdatedMessage> accountHandler,
            MessageHandler<OrderOrTradeUpdatedMessage> tradeHandler,
            MessageHandler<OrderOrTradeUpdatedMessage> orderHandler);

    }
}
