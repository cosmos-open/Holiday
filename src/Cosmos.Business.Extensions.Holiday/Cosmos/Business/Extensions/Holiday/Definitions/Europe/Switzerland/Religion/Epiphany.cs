using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Switzerland.Religion
{
    /// <summary>
    /// Epiphany
    /// </summary>
    public class Epiphany : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"CH-UR", "CH-SZ", "CH-GR", "CH-TI"};

        /// <inheritdoc />
        public override string Name { get; } = "Heilige Drei Könige";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ch_epiphany";
    }
}