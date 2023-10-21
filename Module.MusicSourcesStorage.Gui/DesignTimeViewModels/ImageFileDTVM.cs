﻿using Module.MusicSourcesStorage.Gui.AbstractViewModels;

namespace Module.MusicSourcesStorage.Gui.DesignTimeViewModels;

public class ImageFileDTVM : IImageFileVM
{
    public string Name { get; }
    public string Path { get; }
    public bool IsCover { get; }
    public IReadOnlyList<INodeVM> ChildNodes { get; } = Array.Empty<INodeVM>();

    // ReSharper disable once UnusedMember.Global
    public ImageFileDTVM() : this("some/path/to/image.png", true)
    {
    }

    public ImageFileDTVM(string path, bool isCover)
    {
        Name = System.IO.Path.GetFileName(path);
        Path = path;
        IsCover = isCover;
    }
}