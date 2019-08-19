using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Switzerland.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "CH-ZH", "CH-BE", "CH-LU", "CH-UR", "CH-SZ", "CH-OW", "CH-NW",
            "CH-GL", "CH-ZG", "CH-FR", "CH-SO", "CH-BS", "CH-BL", "CH-SH",
            "CH-AR", "CH-AI", "CH-SG", "CH-GR", "CH-AG", "CH-TG", "CH-TI",
            "CH-VD", "CH-NE", "CH-GE", "CH-JU"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Ostermontag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ch_easter_monday";

        /// <inheritdoc />
        public override int? Since { get; } = 1642;
    }
}