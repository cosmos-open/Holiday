using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Togo.Religion
{
    /// <summary>
    /// All Saints
    /// </summary>
    public class AllSaints : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Togo;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Togo;

        /// <inheritdoc />
        public override string Name { get; } = "Tutti i santi, Ognissanti";

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ss_all_saints";
    }
}