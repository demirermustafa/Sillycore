﻿namespace Sillycore.RabbitMq.Configuration
{
    public class RabbitMqConfiguration
    {
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool UseDelayedExchangeMessageScheduler { get; set; }
        public RetryConfiguration Retry { get; set; }
        public int ConcurrencyLimit { get; set; }
    }
}