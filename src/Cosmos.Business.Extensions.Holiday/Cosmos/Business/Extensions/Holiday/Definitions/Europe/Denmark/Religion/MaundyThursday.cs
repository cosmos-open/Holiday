using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Denmark.Religion
{
    /// <summary>
    /// Maundy Thursday
    /// </summary>
    public class MaundyThursday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Denmark;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Denmark;

        /// <inheritdoc />
        public override string Name { get; } = "Skærtorsdag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_dk_maundy_thursday";
    }
}