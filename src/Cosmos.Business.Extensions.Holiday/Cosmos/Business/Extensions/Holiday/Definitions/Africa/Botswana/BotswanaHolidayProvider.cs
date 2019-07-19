using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Botswana.Commemoration;
    using Definitions.Africa.Botswana.Public;
    using Definitions.Africa.Botswana.Religion;

    /// <summary>
    /// Botswana holiday provider
    /// </summary>
    public class BotswanaHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = BotswanaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Botswana;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Botswana;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BwFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BwFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new SirSeretseKhamaDay(),//7-1
            new IndependenceDay(), //9-30
            new BotswanaDay(), //10-1
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BwVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BwVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new EasterMonday(),
            new PresidentsDay(),//7-3rd-monday
            new AscensionDay(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Botswana"
            };
        }
    }
}