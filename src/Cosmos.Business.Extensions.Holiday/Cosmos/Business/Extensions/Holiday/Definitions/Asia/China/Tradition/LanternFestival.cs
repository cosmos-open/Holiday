using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    public class LanternFestival : ChineseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Lantern Festival
        /// </summary>
        public override string Name { get; } = "元宵节";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override int ChineseMonth { get; } = 1;

        protected override int ChineseDay { get; } = 15;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_shangyuan";
    }
}