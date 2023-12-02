﻿using System.Windows.Input;

namespace Module.MusicSourcesStorage.Gui.AbstractViewModels.Nodes;

public interface IConnectedImageFileVM :
    IConnectedNodeVM,
    ICoverRemovableVM
{
    bool IsCover { get; }
    bool CanSelectAsCover { get; }

    ICommand SelectAsCover { get; }
}