using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Finland.Public
{
    /// <summary>
    /// Midsummer Day
    /// </summary>
    public class MidsummerDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Finland;
        
        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Finland;
        
        /// <inheritdoc />
        public override string Name { get; } = "Juhannusaatto";
        
        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;
        
        /// <inheritdoc />
        public override int Month { get; } = 6;
        
        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 3;
        
        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Saturday;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_fi_midsummer_day";
    }
}