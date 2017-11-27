namespace Lykke.OneSky.Json
{
    public interface IImportTaskStatus : IImportTask
    {
        string Status { get; }
    }
}