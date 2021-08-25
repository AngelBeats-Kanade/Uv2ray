using System;
using System.Threading.Tasks;
using System.Windows.Input;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

using Uv2ray.Helpers;
using Uv2ray.Services;
using Uv2ray.Behaviors;

using Windows.ApplicationModel;
using Windows.UI.Xaml;

namespace Uv2ray.ViewModels
{
    // TODO WTS: Add other settings as necessary. For help see https://github.com/Microsoft/WindowsTemplateStudio/blob/release/docs/UWP/pages/settings.md
    public class SettingsViewModel : ObservableObject
    {
        private ElementTheme _elementTheme = ThemeSelectorService.Theme;

        public ElementTheme ElementTheme
        {
            get => _elementTheme;

            set => SetProperty(ref _elementTheme, value);
        }

        private NavigationViewHeaderMode _navigationViewHeaderMode;

        public NavigationViewHeaderMode NavigationViewHeaderMode
        {
            get => _navigationViewHeaderMode;
            set => SetProperty(ref _navigationViewHeaderMode, value);
        }

        private string _versionDescription;

        public string VersionDescription
        {
            get => _versionDescription;

            set => SetProperty(ref _versionDescription, value);
        }

        private Uri _githubUri;

        public Uri GithubUri
        {
            get => _githubUri;
            set => SetProperty(ref _githubUri, value);
        }

        private string _imageSource;

        public string ImageSource
        {
            get => _imageSource;
            set => SetProperty(ref _imageSource, value);
        }

        private string _copyRight;

        public string CopyRight
        {
            get => _copyRight;
            set => SetProperty(ref _copyRight, value);
        }

        private ICommand _switchThemeCommand;

        public ICommand SwitchThemeCommand
        {
            get
            {
                if (_switchThemeCommand == null)
                {
                    _switchThemeCommand = new RelayCommand<ElementTheme>(
                        async (param) =>
                        {
                            ElementTheme = param;
                            await ThemeSelectorService.SetThemeAsync(param);
                        });
                }

                return _switchThemeCommand;
            }
        }

        public Visibility FeedbackLinkVisibility => Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.IsSupported() ? Visibility.Visible : Visibility.Collapsed;

        private ICommand _launchFeedbackHubCommand;

        public ICommand LaunchFeedbackHubCommand
        {
            get
            {
                if (_launchFeedbackHubCommand == null)
                {
                    _launchFeedbackHubCommand = new RelayCommand(
                        async () =>
                        {
                            // This launcher is part of the Store Services SDK https://docs.microsoft.com/windows/uwp/monetize/microsoft-store-services-sdk
                            var launcher = Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.GetDefault();
                            await launcher.LaunchAsync();
                        });
                }

                return _launchFeedbackHubCommand;
            }
        }

        public SettingsViewModel()
        {
        }

        public async Task InitializeAsync()
        {
            VersionDescription = GetVersionDescription();
            GithubUri = GetGithubUri();
            ImageSource = GetImageSource();
            CopyRight = GetCopyRight();
            NavigationViewHeaderMode = GetNavigationViewHeaderMode();
            await Task.CompletedTask;
        }

        private string GetVersionDescription()
        {
            var appName = "AppDisplayName".GetLocalized();
            var package = Package.Current;
            var packageId = package.Id;
            var version = packageId.Version;

            return $"{appName} - {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
        }

        private Uri GetGithubUri()
        {
            return new Uri("https://github.com/AngelBeats-Kanade/Uv2ray");
        }

        private string GetImageSource()
        {
            return string.Format("ms-appx:///Assets/horizontal.png");
        }

        private string GetCopyRight()
        {
            return string.Format("Copyright © 2021 AngelBeats-Kanade");
        }

        private NavigationViewHeaderMode GetNavigationViewHeaderMode()
        {
            return NavigationViewHeaderMode.Always;
        }
    }
}
