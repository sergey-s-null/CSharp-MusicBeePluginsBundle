﻿using System.IO;
using System.Windows.Input;
using Module.MusicSourcesStorage.Gui.AbstractViewModels.Nodes;
using Module.MusicSourcesStorage.Gui.Enums;
using Module.Mvvm.Extension;
using PropertyChanged;

namespace Module.MusicSourcesStorage.Gui.ViewModels.Nodes;

[AddINotifyPropertyChangedInterface]
public sealed class ConnectedDirectoryVM : DirectoryVM, IConnectedDirectoryVM
{
    public bool CanDownload => throw new NotImplementedException();
    public bool IsDownloaded => throw new NotImplementedException();

    public DirectoryListenedState ListenedState => throw new NotImplementedException();

    public Stream? CoverStream => throw new NotImplementedException();

    public ICommand Download => _downloadCmd ??= new RelayCommand(DownloadCmd);
    public ICommand MarkAllAsListened => _markAllAsListenedCmd ??= new RelayCommand(MarkAllAsListenedCmd);
    public ICommand MarkAllAsNotListened => _markAllAsNotListenedCmd ??= new RelayCommand(MarkAllAsNotListenedCmd);

    private ICommand? _downloadCmd;
    private ICommand? _markAllAsListenedCmd;
    private ICommand? _markAllAsNotListenedCmd;

    public ConnectedDirectoryVM(string name, IReadOnlyList<INodeVM> childNodes) : base(name, childNodes)
    {
    }

    private void DownloadCmd()
    {
        throw new NotImplementedException();
    }

    private void MarkAllAsListenedCmd()
    {
        throw new NotImplementedException();
    }

    private void MarkAllAsNotListenedCmd()
    {
        throw new NotImplementedException();
    }
}