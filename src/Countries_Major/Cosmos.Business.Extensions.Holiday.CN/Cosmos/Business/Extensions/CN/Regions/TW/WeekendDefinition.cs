﻿using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Weekends;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.CN.Regions.TW
{
    public class WeekendDefinition : IBizWeekendDefinition, IBizHolidayDefinition, IBizRegionHolidayDefinition
    {
        public CountryCode CountryCode { get; } = CountryCode.TW;
        public CountryCode BelongsToCountryCode { get; } = CountryCode.CN;
        
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.Universal;
    }
}