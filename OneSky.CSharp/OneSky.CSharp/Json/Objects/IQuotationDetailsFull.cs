namespace Lykke.OneSky.Json
{
    public interface IQuotationDetailsFull : IQuotationDetails
    {
        int StringCount { get; }

        int WordCount { get; }

        ITranslator PreferredTranslator { get; }
    }
}