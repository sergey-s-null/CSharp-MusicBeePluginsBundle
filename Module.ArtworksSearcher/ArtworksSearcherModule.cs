﻿using Module.ArtworksSearcher.Factories;
using Module.ArtworksSearcher.GUI.SearchWindow;
using Module.ArtworksSearcher.GUI.Settings;
using Module.ArtworksSearcher.Helpers;
using Module.ArtworksSearcher.ImagesProviders;
using Module.ArtworksSearcher.Settings;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using Root.MusicBeeApi;

namespace Module.ArtworksSearcher
{
    public class ArtworksSearcherModule : NinjectModule
    {
        private readonly MusicBeeApiMemoryContainer _mbApi;
        
        public ArtworksSearcherModule(MusicBeeApiMemoryContainer mbApi)
        {
            _mbApi = mbApi;
        }
        
        public override void Load()
        {
            Bind<IArtworksSearcherSettings>()
                .To<ArtworksSearcherSettings>()
                .InSingletonScope()
                .WithConstructorArgument("filePath",
                    ConfigurationHelper.GetSettingsFilePath(_mbApi));
            
            Bind<IArtworksSearcherSettingsVM>()
                .To<ArtworksSearcherSettingsVM>();

            Bind<IGoogleImagesEnumeratorFactory>()
                .ToFactory()
                .InSingletonScope();
            Bind<IImagesProvidersFactory>()
                .To<ImagesProvidersFactory>()
                .InSingletonScope();

            Bind<ISearchWindowFactory>()
                .ToFactory();

            Bind<OsuImagesProvider>().ToSelf();
            Bind<GoogleImagesProvider>().ToSelf();
            Bind<SearchWindowVM>().ToSelf();
            Bind<SearchWindow>().ToSelf();
        }
    }
}