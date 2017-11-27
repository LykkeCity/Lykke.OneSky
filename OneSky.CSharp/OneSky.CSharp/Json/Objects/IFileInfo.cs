namespace Lykke.OneSky.Json
{
    public interface IFileInfo : IFile
    {
        string Format { get; }

        ILocale Locale { get; }
    }
}