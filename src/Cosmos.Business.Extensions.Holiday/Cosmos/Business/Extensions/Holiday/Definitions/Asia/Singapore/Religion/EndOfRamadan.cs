using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Singapore.Religion
{
    /// <summary>
    /// End of Ramadan<br />
    /// fr: Fête de fin du Ramadan
    /// </summary>
    public class EndOfRamadan : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Singapore;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Singapore;

        /// <inheritdoc />
        public override string Name { get; } = "End of Ramadan (Eid al-Fitr)";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.Shawwal;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sg_end_of_ramadan";
    }
}