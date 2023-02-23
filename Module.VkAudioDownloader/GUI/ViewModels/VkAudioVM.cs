﻿using System.Windows;
using System.Windows.Input;
using Module.Mvvm.Extension;
using Module.VkAudioDownloader.GUI.AbstractViewModels;
using PropertyChanged;

namespace Module.VkAudioDownloader.GUI.ViewModels;

[AddINotifyPropertyChangedInterface]
public sealed class VkAudioVM : IVkAudioVM
{
    public bool IsSelected
    {
        get => _isSelected;
        set
        {
            if (value && IsInIncoming)
            {
                throw new InvalidOperationException("Could not select audio that contains in Incoming.");
            }

            _isSelected = value;
        }
    }

    public long VkId { get; }
    public string Artist { get; }
    public string Title { get; }
    public IVkAudioUrlVM? Url { get; }
    public bool IsInIncoming { get; }
    public IReadOnlyList<string> Warnings { get; }

    public ICommand ShowWarnings => _showWarnings
        ??= new RelayCommand(_ => ShowWarningsInternal());

    private bool _isSelected;
    private ICommand? _showWarnings;

    public VkAudioVM(
        long vkId,
        string artist,
        string title,
        IVkAudioUrlVM? url,
        bool isInIncoming)
    {
        VkId = vkId;
        Artist = artist;
        Title = title;
        Url = url;
        IsInIncoming = isInIncoming;

        Warnings = GetWarnings();
    }

    private IReadOnlyList<string> GetWarnings()
    {
        var warnings = new List<string>();

        if (Url is null)
        {
            warnings.Add("No download url.");
        }

        if (IsInIncoming)
        {
            warnings.Add("Audio already in Incoming.");
        }

        return warnings;
    }

    private void ShowWarningsInternal()
    {
        var message = string.Join("\n", Warnings.Select((x, i) => $"{i + 1}. {x}"));
        MessageBox.Show(message, "Warnings", MessageBoxButton.OK, MessageBoxImage.Warning);
    }
}