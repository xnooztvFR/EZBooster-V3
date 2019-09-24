using System.IO;

namespace HourBoostr
{
    class EndPoint
    {
        public static string SETTINGS_FILE_PATH = "Settings.json";
        public static string GLOBAL_SETTINGS_FILE_PATH = "GlobalDB.hb";
        public static string SENTRY_FOLDER_PATH = "Sentryfiles";
        public static string LOG_FOLDER_PATH = "Logs";
        public static string CONSOLE_TITLE = $"EZBooster v{Utils.GetVersion()}";
        public static string STEAM_GROUP_URL = "https://steamcommunity.com/groups/teampandoryafr";
        public static string VERSION_FILE = "https://raw.githubusercontent.com/xnooztvFR/EZBooster-V3/master/version.txt";
    }
}