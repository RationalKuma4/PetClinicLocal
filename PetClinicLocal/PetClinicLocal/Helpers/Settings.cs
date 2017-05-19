// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace PetClinicLocal.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        { get { return CrossSettings.Current; } }

        public static string GeneralSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(SettingsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(SettingsKey, value);
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        private const string UserKey = "user_key";
        private static readonly string UserKeyDefault = string.Empty;

        private const string PasswordKey = "password_key";
        private static readonly string PasswordKeyDefault = string.Empty;

        #endregion


        #region Setters and getters

        public static string User
        {
            get { return AppSettings.GetValueOrDefault(UserKey, UserKeyDefault); }
            set { AppSettings.AddOrUpdateValue(UserKey, value); }
        }

        public static string Password
        {
            get { return AppSettings.GetValueOrDefault(PasswordKey, PasswordKeyDefault); }
            set { AppSettings.AddOrUpdateValue(PasswordKey, value); }
        }

        #endregion

    }
}