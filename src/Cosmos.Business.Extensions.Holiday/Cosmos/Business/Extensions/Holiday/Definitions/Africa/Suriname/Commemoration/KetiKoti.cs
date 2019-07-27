using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Suriname.Commemoration
{
    /// <summary>
    /// Keti Koti
    /// </summary>
    public class KetiKoti : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Suriname;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Suriname;

        /// <inheritdoc />
        public override string Name { get; } = "Keti Koti";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sr_keti_koti";
    }
}