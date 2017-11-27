namespace Lykke.OneSky.Json
{
    public interface IOrderPlugin : IOrder
    {
        decimal Amount { get; }
    }
}