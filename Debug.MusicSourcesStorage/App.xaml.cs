﻿using System.Windows;
using Autofac;
using Module.MusicSourcesStorage.Gui.Services.Abstract;
using Module.MusicSourcesStorage.Gui.Views;

namespace Debug.MusicSourcesStorage
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = Container.Create(true);
            OpenMusicSourcesWindow(container);
        }

        private static void OpenMusicSourcesWindow(IComponentContext container)
        {
            var window = container.Resolve<MusicSourcesWindow>();
            window.ShowDialog();
        }

        private static void AddVkPostWithArchiveSource(IComponentContext container)
        {
            container.Resolve<IWizardService>().AddVkPostWithArchiveSource();
        }
    }
}