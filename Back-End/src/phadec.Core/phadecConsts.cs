using phadec.Debugging;

namespace phadec
{
    public class phadecConsts
    {
        public const string LocalizationSourceName = "phadec";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "29e104e87c0f4394810a75333f9b0656";
    }
}
