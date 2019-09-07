using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Chile.Public
{
    /// <summary>
    /// National Miner's Day
    /// </summary>
    public class NationalMinersDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Chile;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Chile;

        /// <inheritdoc />
        public override string RegionCode { get; } = "CL-AT";

        /// <inheritdoc />
        public override string Name { get; } = "Día del Minero";

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 10;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cl_national_miners";
    }
}