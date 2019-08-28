using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Chile.Commemoration
{
    /// <summary>
    /// Our Lady of Mount Carmel
    /// </summary>
    public class OurLadyOfMountCarmel: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Chile;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Chile;

        /// <inheritdoc />
        public override string Name { get; } = "Virgen del Carmen";

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 16;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cl_mount_carmel_lady";
    }
}