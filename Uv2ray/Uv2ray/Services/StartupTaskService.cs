using System;
using System.Threading.Tasks;

using Uv2ray.Helpers;

using Windows.ApplicationModel;
using Windows.Storage;

namespace Uv2ray.Services
{
    public static class StartupTaskService
    {
        private static StartupTask _startupTask;

        private const string SettingsKey = "DefaultAutoStartupSetting";

        public static bool IsOn { get; set; }

        public static async Task InitializeAsync()
        {
            _startupTask = await StartupTask.GetAsync("Uv2ray");
            IsOn =  await LoadStartupOnFromSettingsAsync();
        }

        public static async Task SetStartupTaskAsync(bool setting)
        {
            IsOn = setting;
            await SetRequestedStartupTaskAsync();
            await SaveStartupOnInSettingsAsync(IsOn);
        }

        public static async Task SetRequestedStartupTaskAsync()
        {
            if (IsOn)
            {
                await SetStartupTaskEnableAsync();
            }
            else
            {
                await SetStartupTaskDisableAsync();
            }
        }

        public static async Task SetStartupTaskEnableAsync()
        {
            _ = await _startupTask.RequestEnableAsync();
        }

        public static async Task SetStartupTaskDisableAsync()
        {
            _startupTask.Disable();
            await Task.CompletedTask;
        }

        private static async Task<bool> LoadStartupOnFromSettingsAsync()
        {
            bool cacheSetting = false;
            string settingName = await ApplicationData.Current.LocalSettings.ReadAsync<string>(SettingsKey);

            if (!string.IsNullOrEmpty(settingName))
            {
                cacheSetting = settingName == "True";
            }

            return cacheSetting;
        }

        private static async Task SaveStartupOnInSettingsAsync(bool settings)
        {
            await ApplicationData.Current.LocalSettings.SaveAsync(SettingsKey, settings.ToString());
        }
    }
}
