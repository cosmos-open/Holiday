using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CentralAfrican.Religion
{
    /// <summary>
    /// Ascension Day<br />
    /// fr: Ascension
    /// </summary>
    public class AscensionDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CentralAfrican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CentralAfrican;

        /// <inheritdoc />
        public override string Name { get; } = "Ascension";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 4 + 5 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cf_ascension_day";
    }
}