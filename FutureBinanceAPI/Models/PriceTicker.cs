﻿using FutureBinanceAPI.Models.Enums;

namespace FutureBinanceAPI.Models
{
    public class PriceTicker
    {
        public TraidingPair Symbol { get; set; }

        public decimal Price { get; set; }

        public long Time { get; set; }
    }
}
