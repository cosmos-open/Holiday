using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.Tonga.Religion
{
    /// <summary>
    /// Good Friday
    /// </summary>
    public class GoodFriday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Tonga;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Tonga;

        /// <inheritdoc />
        public override string Name { get; } = "Good Friday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_to_good_friday";
    }
}