namespace Lykke.OneSky.Json
{
    public interface IItemEntry : IItemContainer
    {
        IItem Translateables { get; }

        ILocale Language { get; }
    }
}