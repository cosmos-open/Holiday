using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Guatemala Holiday Provider Extensions
    /// </summary>
    public static class GuatemalaHolidayProviderExtensions
    {
        /// <summary>
        /// Use Guatemala holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseGuatemala<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<GuatemalaHolidayProvider>(holidayTypes);
        }
    }
}