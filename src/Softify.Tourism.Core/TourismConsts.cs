using Softify.Tourism.Debugging;

namespace Softify.Tourism
{
    public class TourismConsts
    {
        public const string LocalizationSourceName = "Tourism";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4713e187fdc8494a97a81abca0243add";
    }
}
