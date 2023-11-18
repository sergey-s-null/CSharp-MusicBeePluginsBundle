﻿using Module.MusicSourcesStorage.Gui.AbstractViewModels;
using Module.MusicSourcesStorage.Gui.Entities.Abstract;
using Module.MusicSourcesStorage.Gui.Enums;
using Module.MusicSourcesStorage.Gui.Extensions;
using Module.MusicSourcesStorage.Logic.Extensions;
using Module.MusicSourcesStorage.Logic.Services.Abstract;
using PropertyChanged;

namespace Module.MusicSourcesStorage.Gui.ViewModels.WizardSteps;

[AddINotifyPropertyChangedInterface]
public sealed class DownloadAndIndexArchiveStepVM : ProcessingStepBaseVM
{
    public override string Text { get; protected set; }
    // todo use it
    public override IProgressVM? Progress { get; protected set; }

    private readonly IAddingVkPostWithArchiveContext _context;
    private readonly IVkDocumentDownloadingTaskManager _vkDocumentDownloadingTaskManager;
    private readonly IArchiveIndexer _archiveIndexer;

    public DownloadAndIndexArchiveStepVM(
        IAddingVkPostWithArchiveContext context,
        IVkDocumentDownloadingTaskManager vkDocumentDownloadingTaskManager,
        IArchiveIndexer archiveIndexer)
        : base(context)
    {
        _context = context;
        _vkDocumentDownloadingTaskManager = vkDocumentDownloadingTaskManager;
        _archiveIndexer = archiveIndexer;

        _context.ValidateHasSelectedDocument();

        Text = "Starting";
    }

    protected override async Task<StepResult> ProcessAsync(CancellationToken token)
    {
        Text = "Downloading archive";
        var downloadingTask = _vkDocumentDownloadingTaskManager
            .CreateDownloadTask()
            .Activated(_context.SelectedDocument!, token);
        var downloadedDocumentPath = await downloadingTask.Task;

        Text = "Indexing archive";
        var files = _archiveIndexer.Index(downloadedDocumentPath);

        _context.IndexedFiles = files;

        return StepResult.Success;
    }
}