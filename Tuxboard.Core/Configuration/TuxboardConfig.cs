namespace Tuxboard.Core.Configuration
{
    public class TuxboardConfig
    {
        public const string ConfigKey = "TuxboardConfig";

        public string ConnectionString { get; set; }
        public string DefaultUser { get; set; }
    }
}
