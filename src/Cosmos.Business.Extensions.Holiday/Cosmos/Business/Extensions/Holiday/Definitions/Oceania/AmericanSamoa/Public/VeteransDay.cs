using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.AmericanSamoa.Public
{
    /// <summary>
    /// Veteran's Day
    /// </summary>
    public class VeteransDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.AmericanSamoa;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <inheritdoc />
        public override string Name { get; } = "Veterans Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 11;

        /// <inheritdoc />
        public override int Day { get; } = 11;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = -1;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_as_veterans";

        /// <inheritdoc />
        public override int? Since { get; } = 1918;
    }
}