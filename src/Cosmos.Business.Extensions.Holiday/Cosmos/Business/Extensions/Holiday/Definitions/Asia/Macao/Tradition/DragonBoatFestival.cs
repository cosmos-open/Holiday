using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Macao, a part of China
 * 澳门，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Macao.Tradition
{
    public class DragonBoatFestival : ChineseVariableHolidayFunc
    {
        public override Country Country { get; set; } = Country.Macao;

        public override Country BelongsToCountry { get; set; } = Country.China;

        /// <summary>
        /// Dragon Boat Festival
        /// </summary>
        public override string Name { get; } = "端午節";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override  int Month { get; } = 5;

        protected override  int Day { get; } = 5;

        public override string I18NIdentityCode { get; } = "i18n_holiday_mo_duanwu";
    }
}