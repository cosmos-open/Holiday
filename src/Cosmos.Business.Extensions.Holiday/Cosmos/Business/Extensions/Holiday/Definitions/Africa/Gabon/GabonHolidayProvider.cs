using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Gabon.Commemoration;
    using Definitions.Africa.Gabon.Public;
    using Definitions.Africa.Gabon.Religion;
    using Definitions.Africa.Gabon.Tradition;

    /// <summary>
    /// Gabon holiday provider
    /// </summary>
    public class GabonHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = GabonRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Gabon;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Gabon;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = GaFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> GaFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new WomensDay(), //4-17
            new LabourDay(), //5-1
            new MartyrsDay(), //5-6
            new IndependenceDay(), //8-17
            new AssumptionDay(), //8-15
            new AllSaintsDay(), //11-1
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = GaVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> GaVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new WhitMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Gabon",
            };
        }
    }
}