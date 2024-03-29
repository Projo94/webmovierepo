﻿namespace WebApp.Movies.Application.Models.Authentication
{
    public class JwtSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double DurationInHours { get; set; }
    }
}
