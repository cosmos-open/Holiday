using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Liechtenstein.Commemoration
{
    /// <summary>
    /// Saint Joseph's Day
    /// </summary>
    public class SaintJosephsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Liechtenstein;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Liechtenstein;

        /// <inheritdoc />
        public override string Name { get; } = "Josefstag";

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 19;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_li_joseph";
    }
}