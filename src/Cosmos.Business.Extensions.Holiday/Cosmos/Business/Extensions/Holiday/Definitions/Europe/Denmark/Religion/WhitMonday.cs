using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Denmark.Religion
{
    /// <summary>
    /// Whit Monday
    /// </summary>
    public class WhitMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Denmark;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Denmark;

        /// <inheritdoc />
        public override string Name { get; } = "2. Pinsedag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1 + 7 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_dk_with_monday";
    }
}