using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Uganda.Commemoration
{
    /// <summary>
    /// Martyrs' Day
    /// </summary>
    public class MartyrsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Uganda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Uganda;

        /// <inheritdoc />
        public override string Name { get; } = "Martyr's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ug_martyr";
    }
}