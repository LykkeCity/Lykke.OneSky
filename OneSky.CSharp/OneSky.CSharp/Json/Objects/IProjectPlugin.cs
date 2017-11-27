namespace Lykke.OneSky.Json
{
    public interface IProjectPlugin : IProject
    {
        string Platform { get; }

        ILocale BaseLanguage { get; }
    }
}
