﻿using System.IO;
using System.Reflection;
using System.Windows.Input;
using Module.MusicSourcesStorage.Gui.AbstractViewModels.Nodes;

namespace Module.MusicSourcesStorage.Gui.DesignTimeViewModels.Nodes;

public sealed class ConnectedDirectoryDTVM : DirectoryDTVM, IConnectedDirectoryVM
{
    private const string DesignTimeCoversPath =
        $"{nameof(Module)}.{nameof(MusicSourcesStorage)}.{nameof(Gui)}.Resources.DesignTime.Covers";


    public bool IsProcessing { get; }

    public bool CanDownload => !IsDownloaded;
    public bool IsDownloaded => false;

    public bool CanDelete => false;
    public bool IsDeleted => true;

    public bool IsListened => false;

    public bool IsAllListened => false;
    public bool IsAllNotListened => true;

    public bool HasDownloadedAndNotAttachedToLibraryFiles { get; }

    public Stream? CoverStream { get; }

    public ICommand Download => null!;
    public ICommand Delete => null!;
    public ICommand DeleteNoPrompt => null!;
    public ICommand MarkAsListened => null!;
    public ICommand MarkAsNotListened => null!;

    public ConnectedDirectoryDTVM()
        : this("Some connected directory")
    {
    }

    public ConnectedDirectoryDTVM(string name)
        : this(name, Array.Empty<INodeVM>())
    {
    }

    public ConnectedDirectoryDTVM(
        string name,
        IReadOnlyList<INodeVM> childNodes,
        string? coverFileName = null,
        bool hasDownloadedAndNotAttachedToLibraryFiles = false,
        bool isProcessing = false)
        : base(name, childNodes)
    {
        CoverStream = GetCoverStream(coverFileName);
        HasDownloadedAndNotAttachedToLibraryFiles = hasDownloadedAndNotAttachedToLibraryFiles;
        IsProcessing = isProcessing;
    }

    private static Stream? GetCoverStream(string? coverFileName)
    {
        if (coverFileName is null)
        {
            return null;
        }

        var resourceName = $"{DesignTimeCoversPath}.{coverFileName}";
        return Assembly.GetAssembly(typeof(ConnectedDirectoryDTVM))
            .GetManifestResourceStream(resourceName);
    }
}