﻿namespace VattenMedia.Infrastructure
{
    public class AppConfiguration
    {
        public string TwitchApiUrl { get; set; }
        public string StreamUtilityPath { get; set; }
        public string StreamUtilityRcPath { get; set; }
        public bool TwitchEnabled { get; set; }
        public bool YoutubeEnabled { get; set; }
    }
}
