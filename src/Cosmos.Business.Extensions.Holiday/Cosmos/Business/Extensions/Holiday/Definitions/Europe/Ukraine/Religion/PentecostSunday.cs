using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Ukraine.Religion
{
    /// <summary>
    /// Pentecost Sunday
    /// </summary>
    public class PentecostSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Ukraine;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ukraine;

        /// <inheritdoc />
        public override string Name { get; } = "Трійця";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 7 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ua_pentecost_sunday";
    }
}