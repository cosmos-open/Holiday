using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Tanzania.Religion
{
    /// <summary>
    /// Easter Sunday<br />
    /// fr: Lundi de Pâques
    /// </summary>
    public class EasterSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Tanzania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Tanzania;

        /// <inheritdoc />
        public override string Name { get; } = "Easter Sunday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tz_easter_sunday";
    }
}