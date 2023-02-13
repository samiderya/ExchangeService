using Newtonsoft.Json;

namespace src.ExchangeService.ExchangeDemo.Models.Dtos
{
    public class ExchangeDto
    {
        [JsonProperty("year_established")]
        public int Year { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("has_trading_incentive")]
        public bool Incentive { get; set; }

        [JsonProperty("trade_volume_24h_btc")]
        public decimal? Trade_volume_24h_btc { get; set; }
    }
}