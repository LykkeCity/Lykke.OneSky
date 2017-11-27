namespace Lykke.OneSky.Json
{
    public interface ILocaleGroup : ILocale
    {
        bool IsBaseLanguage { get; }
    }
}