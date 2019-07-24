using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Russia.Public
{
    /// <summary>
    /// New Year's Holiday
    /// </summary>
    public class NewYearsHoliday : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Russia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Russia;

        /// <inheritdoc />
        public override string Name { get; } = "Новогодние каникулы";

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (1, 2);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (1, 6);

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ru_newyears_holiday";
    }
}