using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Gabon.Public
{
    /// <summary>
    /// Christmas Day
    /// </summary>
    public class ChristmasDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Gabon;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Gabon;

        /// <inheritdoc />
        public override string Name { get; } = "Božić";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ga_christmas";
    }
}