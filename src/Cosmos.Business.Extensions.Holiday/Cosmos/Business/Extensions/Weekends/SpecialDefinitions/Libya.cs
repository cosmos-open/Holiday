﻿using Cosmos.Abstractions;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Weekends.SpecialDefinitions
{
    /// <summary>
    /// Libya
    /// </summary>
    [WeekendDefinitionIgnoreScanning]
    public class Libya : IBizWeekendDefinition, IBizHolidayDefinition
    {
        /// <summary>
        /// Country or region
        /// </summary>
        public Country Country { get; } = Country.Libya;
        
        /// <summary>
        /// Type of weekend
        /// </summary>
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.SemiUniversal;
    }
}