using System.Configuration;

namespace FERD.Helpers
{
    public static class SettingsHelper
    {
        private static Properties.Settings _settings => Properties.Settings.Default;

        /// <summary>
        /// Creates a setting with the value set to the default value of the type "T"
        /// </summary>
        /// <typeparam name="T">The type of the setting</typeparam>
        /// <param name="settingName">The name of the settings</param>
        public static void CreateSetting<T>(string settingName)
        {
            // Create the setting
            SettingsProperty newSettingProperty = new SettingsProperty(settingName);
            newSettingProperty.PropertyType = typeof(T); 
            newSettingProperty.Attributes.Add(typeof(UserScopedSettingAttribute), new UserScopedSettingAttribute());
            newSettingProperty.Provider = Properties.Settings.Default.Providers["LocalFileSettingsProvider"];
            newSettingProperty.SerializeAs = SettingsSerializeAs.String;
            _settings.Properties.Add(newSettingProperty);

            // Add default value
            SettingsPropertyValue newSettingValue = new SettingsPropertyValue(newSettingProperty);
            newSettingValue.PropertyValue = default(T);
            Properties.Settings.Default.PropertyValues.Add(newSettingValue);

            // save the setting
            _settings.Save();
        }

        public static void UpdateSetting<T>(string settingName, T settingValue)
        {
            _settings[settingName] = settingValue;

            // save the setting
            _settings.Save();
        }

        public static T? GetSetting<T>(string settingName)
        {
            try
            {
                var settingValue = _settings[settingName];
            }
            catch (System.Configuration.SettingsPropertyNotFoundException ex)
            {
                return default(T);
            }
            return (T)_settings[settingName];
        }

        public static void DeleteSetting(string settingName)
        {
            _settings.Properties.Remove(settingName);
        }
    }
}
