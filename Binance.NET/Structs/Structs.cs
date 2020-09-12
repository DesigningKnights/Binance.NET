namespace Binance.NET.Structs
{
    public struct BinanceUrl
    {
        public static readonly string Us = @"https://api.binance.us";
        public static readonly string Com = @"https://api.binance.com";
    }

    public struct WebSocketStream
    {
        public static readonly string Us = @"wss://stream.binance.us:9443/ws";
        public static readonly string Com = @"wss://stream.binance.com:9443/ws";
    }
}
