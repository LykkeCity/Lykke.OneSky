namespace Lykke.OneSky.Json
{
    public interface IOrderPlatformEntry : IOrder
    {
        string Status { get; }
    }
}