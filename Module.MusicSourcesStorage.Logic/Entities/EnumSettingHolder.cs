﻿using Module.MusicSourcesStorage.Logic.Entities.Abstract;
using Module.Settings.Database.Services.Abstract;

namespace Module.MusicSourcesStorage.Logic.Entities;

public sealed class EnumSettingHolder<T> : ISettingHolder<T> where T : Enum
{
    public string Area { get; }
    public string Id { get; }

    public T DefaultValue { get; }

    public T Value
    {
        get => (T?)(object?)_settingsRepository.FindInt32(Area, Id) ?? DefaultValue;
        set => _settingsRepository.Set(Area, Id, (int)(object)value);
    }

    private readonly ISettingsRepository _settingsRepository;

    public EnumSettingHolder(
        string area,
        string id,
        T defaultValue,
        ISettingsRepository settingsRepository)
    {
        Area = area;
        Id = id;
        DefaultValue = defaultValue;

        _settingsRepository = settingsRepository;
    }
}