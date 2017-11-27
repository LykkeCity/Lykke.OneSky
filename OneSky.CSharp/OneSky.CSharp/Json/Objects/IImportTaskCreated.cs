namespace Lykke.OneSky.Json
{
    using System;

    public interface IImportTaskCreated : IImportTask
    {
         DateTime CreatedAt { get; }

         long CreatedAtTimestamp { get; }
    }
}