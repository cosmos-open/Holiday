using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.SouthAfrica.Public
{
    /// <summary>
    /// Youth Day
    /// </summary>
    public class YouthDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SouthAfrica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SouthAfrica;

        /// <inheritdoc />
        public override string Name { get; } = "Youth Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 16;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_za_youth";

        /// <inheritdoc />
        public override int? Since { get; } = 1995;
    }
}