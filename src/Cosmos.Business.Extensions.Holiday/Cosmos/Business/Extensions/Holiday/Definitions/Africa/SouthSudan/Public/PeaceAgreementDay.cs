using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.SouthSudan.Public
{
    /// <summary>
    /// Peace Agreement Day
    /// </summary>
    public class PeaceAgreementDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SouthSudan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SouthSudan;

        /// <inheritdoc />
        public override string Name { get; } = "Peace Agreement Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ss_peace_agreement";
    }
}