using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Macao, a part of China
 * 澳门，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Macao.Religion
{
    /// <summary>
    /// 圣诞节
    /// </summary>
    public class Christmas : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Macao;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "聖誕節";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /*
         * 圣诞节（Christmas）又称耶诞节，译名为“基督弥撒”，它源自古罗马人迎接新年的农神节，
         * 与基督教本无关系。在基督教盛行罗马帝国后，教廷随波逐流地将这种民俗节日纳入基督教
         * 体系，同时以庆祝耶稣的降生。但在圣诞节这天不是耶稣的生辰，因为《圣经》未有记载耶稣
         * 具体生于哪天，同样没提到过有此种节日，是基督教吸收了古罗马神话的结果。
         *
         * 大部分的天主教教堂都会先在12月24日的平安夜，亦即12月25日凌晨举行子夜弥撒，而一些基
         * 督教会则会举行报佳音，然后在12月25日庆祝圣诞节；基督教的另一大分支——东正教的圣诞节
         * 庆则在每年的1月7日。
         *
         * 圣诞节也是西方世界以及其他很多地区的公共假日，例如：在亚洲的中国香港和澳门地区、马
         * 来西亚、新加坡。
         */

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mo_christmas";

    }
}