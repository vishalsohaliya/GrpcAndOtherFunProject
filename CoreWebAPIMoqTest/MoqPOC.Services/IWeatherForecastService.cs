﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPOC.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetWeatherForecast();
    }

    public record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}