using Microsoft.Toolkit.Uwp.Helpers;

using System;
using System.Threading.Tasks;

using Uv2ray.Views;

using Windows.ApplicationModel.Core;

using Windows.UI.Core;

namespace Uv2ray.Services
{
    public static class FirstRunDisplayService
    {
        private static bool shown = false;

        internal static async Task ShowIfAppropriateAsync()
        {
            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(
                CoreDispatcherPriority.Normal, async () =>
                {
                    if (SystemInformation.Instance.IsFirstRun && !shown)
                    {
                        shown = true;
                        var dialog = new FirstRunDialog();
                        await dialog.ShowAsync();
                    }
                });
        }
    }
}
