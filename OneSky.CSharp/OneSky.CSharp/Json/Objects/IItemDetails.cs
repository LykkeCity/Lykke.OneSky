namespace Lykke.OneSky.Json
{
    public interface IItemDetails : IItemContainer
    {
        IItemTranslateables Translateables { get; }
    }
}