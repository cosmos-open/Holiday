using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Andorra.Commemoration
{
    /// <summary>
    /// Encamp Annual Festival
    /// </summary>
    public class EncampAnnualFestival : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Andorra;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Andorra;

        /// <inheritdoc />
        public override string Name { get; } = "Encamp";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (8, 15);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (8, 16);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ad_encamp";
    }
}