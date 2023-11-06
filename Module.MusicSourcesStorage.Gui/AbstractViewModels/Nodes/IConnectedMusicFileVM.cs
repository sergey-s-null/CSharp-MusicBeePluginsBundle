﻿using System.Windows.Input;
using Module.MusicSourcesStorage.Gui.Enums;

namespace Module.MusicSourcesStorage.Gui.AbstractViewModels.Nodes;

public interface IConnectedMusicFileVM : IMusicFileVM, IDownloadableVM, IMarkableAsListenedVM, IDeletableVM
{
    MusicFileLocation Location { get; }

    ICommand DeleteAndMarkAsListened { get; }
}