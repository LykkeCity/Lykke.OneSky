namespace Lykke.OneSky.Json
{
    public interface IQuotation
    {
        ILocale FromLanguage { get; }

        ILocale ToLanguage { get; }
    }
}