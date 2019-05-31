﻿using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Weekends;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.CN
{
    public class WeekendDefinition : IBizWeekendDefinition, IBizHolidayDefinition
    {
        public CountryCode CountryCode { get; } = CountryCode.CN;
        
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.Universal;
    }
}