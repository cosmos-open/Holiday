using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Réunion.Public
{
    /// <summary>
    /// Abolition of Slavery<br />
    /// fr: Abolition de l’esclavage
    /// </summary>
    public class AbolitionOfSlavery : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Réunion;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.France;

        /// <inheritdoc />
        public override string Name { get; } = "Abolition of Slavery";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 20;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_re_slavery";
    }
}