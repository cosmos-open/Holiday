using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Mongolia.Public
{
    /// <summary>
    /// International Women's Day
    /// </summary>
    public class InternationalWomensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Mongolia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Mongolia;

        /// <inheritdoc />
        public override string Name { get; } = "Олон Улсын Эмэгтэйчүүдийн Баяр";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mn_women";
    }
}