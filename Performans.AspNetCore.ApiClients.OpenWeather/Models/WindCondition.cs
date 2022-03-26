using System;
using System.Collections.Generic;
namespace Performans.AspNetCore.ApiClients.OpenWeather.Models;

public class WindCondition
{
    /// <summary>
    /// Wind speed. Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour.
    /// </summary>
    public double Speed { get; set; }

    /// <summary>
    /// Wind direction, degrees (meteorological)
    /// </summary>
    public long Deg { get; set; }

    /// <summary>
    /// Wind gust. Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour
    /// </summary>
    public double Gust { get; set; }
}