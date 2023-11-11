﻿using Module.MusicSourcesStorage.Logic.Entities;
using Module.MusicSourcesStorage.Logic.Entities.Abstract;
using Module.MusicSourcesStorage.Logic.Extensions;
using Module.MusicSourcesStorage.Logic.Services.Abstract;

namespace Module.MusicSourcesStorage.Logic.Services;

public sealed class VkArchiveFilesDownloadingService : IVkArchiveFilesDownloadingService
{
    private readonly IVkDocumentDownloadingTaskManager _vkDocumentDownloadingTaskManager;
    private readonly IArchiveExtractor _archiveExtractor;

    public VkArchiveFilesDownloadingService(
        IVkDocumentDownloadingTaskManager vkDocumentDownloadingTaskManager,
        IArchiveExtractor archiveExtractor)
    {
        _vkDocumentDownloadingTaskManager = vkDocumentDownloadingTaskManager;
        _archiveExtractor = archiveExtractor;
    }

    public IMultiStepTaskWithProgress<string> DownloadAsync(
        VkDocument document,
        SourceFile file,
        string targetPath,
        bool activateTask,
        CancellationToken token)
    {
        var task = _vkDocumentDownloadingTaskManager.GetOrCreateNewAsync(document, false, token)
            .Chain(archiveFilePath => _archiveExtractor.ExtractAsync(
                archiveFilePath,
                file.Path,
                targetPath,
                true,
                false,
                token
            ));

        if (activateTask)
        {
            task.Activate();
        }

        return task;
    }
}