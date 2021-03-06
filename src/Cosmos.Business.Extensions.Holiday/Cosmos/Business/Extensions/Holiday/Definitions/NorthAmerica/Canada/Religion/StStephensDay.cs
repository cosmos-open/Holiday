using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Canada.Religion
{
    /// <summary>
    /// St. Stephen's Day
    /// </summary>
    public class StStephensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Canada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Canada;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"CA-AB", "CA-NB", "CA-NS", "CA-ON", "CA-PE"};

        /// <inheritdoc />
        public override string Name { get; } = "St. Stephen's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ca_stephen";
    }
}