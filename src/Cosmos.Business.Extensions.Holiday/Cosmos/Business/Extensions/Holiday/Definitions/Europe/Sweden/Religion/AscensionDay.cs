using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Sweden.Religion
{
    /// <summary>
    /// Ascension Day
    /// </summary>
    public class AscensionDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Sweden;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Sweden;

        /// <inheritdoc />
        public override string Name { get; } = "Kristi himmelsfärds dag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 4 + 5 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_se_ascension_day";
    }
}