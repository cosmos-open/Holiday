using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Rwanda.Religion
{
    /// <summary>
    /// Assumption<br />
    /// hr: Velika Gospa
    /// </summary>
    public class Assumption : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Rwanda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Rwanda;

        /// <inheritdoc />
        public override string Name { get; } = "Assumption";

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_rw_assumption";
    }
}