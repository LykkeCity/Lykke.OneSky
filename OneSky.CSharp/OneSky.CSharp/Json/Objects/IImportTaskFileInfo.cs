﻿namespace Lykke.OneSky.Json
{
    public interface IImportTaskFileInfo : IImportTaskStatus, IImportTaskCreated
    {
        IFileInfo File { get; }

        int StringCount { get; }

        int WordCount { get; }
    }
}