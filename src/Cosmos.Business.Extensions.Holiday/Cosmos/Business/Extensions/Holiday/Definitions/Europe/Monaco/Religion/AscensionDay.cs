using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Monaco.Religion
{
    /// <summary>
    /// Ascension Day
    /// </summary>
    public class AscensionDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Monaco;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Monaco;

        /// <inheritdoc />
        public override string Name { get; } = "L’Ascension";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 4 + 5 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mc_ascension_day";
    }
}