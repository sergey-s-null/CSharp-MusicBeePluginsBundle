﻿using Root.Settings;

namespace Module.VkAudioDownloader.Settings
{
    public interface IMusicDownloaderSettings : ISettings
    {
        string DownloadDirTemplate { get; set; }
        string FileNameTemplate { get; set; }
    }
}