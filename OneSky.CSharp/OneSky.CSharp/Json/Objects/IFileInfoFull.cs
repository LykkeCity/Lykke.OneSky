namespace Lykke.OneSky.Json
{
    public interface IFileInfoFull : IFileInfo
    {
        IImportTaskCreated Import { get; }
    }
}