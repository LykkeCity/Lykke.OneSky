namespace Lykke.OneSky.Json
{
    public interface IOrderTaskBase
    {
        int Id { get; }

        ILocale FromLanguage { get; }

        ILocale ToLanguage { get; }
    }
}