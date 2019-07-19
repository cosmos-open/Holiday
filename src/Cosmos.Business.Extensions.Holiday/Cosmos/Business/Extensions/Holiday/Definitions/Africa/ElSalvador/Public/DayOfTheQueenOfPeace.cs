using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.ElSalvador.Public
{
    /// <summary>
    /// Day of the Queen of Peace
    /// </summary>
    public class DayOfTheQueenOfPeace : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.ElSalvador;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.ElSalvador;

        /// <inheritdoc />
        public override string Name { get; } = "Dia de la Reina de la Paz";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sv_peace_queen_day";
    }
}