using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Belarus.Public
{
    /// <summary>
    /// International Women's Day
    /// </summary>
    public class InternationalWomensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belarus;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belarus;

        /// <inheritdoc />
        public override string Name { get; } = "Мiжнародны жаночы дзень";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_by_women";
    }
}