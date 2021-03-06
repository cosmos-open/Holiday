using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Togo.Religion
{
    /// <summary>
    /// Whit Monday<br />
    /// fr: Lundi de Pentecôte
    /// </summary>
    public class WhitMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Togo;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Togo;

        /// <inheritdoc />
        public override string Name { get; } = "Lundi de Pentecôte";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1 + 7 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tg_whit_monday";
    }
}