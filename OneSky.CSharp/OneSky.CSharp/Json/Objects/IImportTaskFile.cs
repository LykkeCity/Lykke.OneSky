namespace Lykke.OneSky.Json
{
    public interface IImportTaskFile : IImportTaskStatus, IImportTaskCreated
    {
        IFile File { get; }
    }
}