﻿using System.Windows.Input;
using Module.MusicSourcesStorage.Gui.AbstractViewModels.WizardSteps;
using Module.MusicSourcesStorage.Gui.Entities;
using Module.MusicSourcesStorage.Gui.Helpers;
using PropertyChanged;

namespace Module.MusicSourcesStorage.Gui.DesignTimeViewModels.WizardSteps;

[AddINotifyPropertyChangedInterface]
public sealed class SelectVkPostStepDTVM : ISelectVkPostStepVM
{
    public event EventHandler<StepTransitionEventArgs>? StepTransitionRequested;
    public event EventHandler? CloseWizardRequested;

    public bool CanSafelyCloseWizard => false;

    public bool HasNextStep => true;
    public bool CanGoNext { get; private set; }
    public string? CustomNextStepName => null;

    public bool HasPreviousStep => false;
    public bool CanGoBack => false;

    public string? CustomCloseWizardCommandName => null;

    public ICommand Back => null!;
    public ICommand Next => null!;
    public ICommand CloseWizard => null!;

    [OnChangedMethod(nameof(OnGlobalPostIdChanged))]
    public string PostGlobalId { get; set; } = string.Empty;

    public bool IsValidPostGlobalId { get; private set; }

    public ulong? OwnerId { get; private set; }
    public ulong? PostId { get; private set; }

    private void OnGlobalPostIdChanged()
    {
        if (VkHelper.TryParsePostGlobalId(PostGlobalId, out var postOwnerId, out var postId))
        {
            OwnerId = postOwnerId;
            PostId = postId;
            IsValidPostGlobalId = true;
            CanGoNext = true;
        }
        else
        {
            OwnerId = null;
            PostId = null;
            IsValidPostGlobalId = false;
            CanGoNext = false;
        }
    }
}