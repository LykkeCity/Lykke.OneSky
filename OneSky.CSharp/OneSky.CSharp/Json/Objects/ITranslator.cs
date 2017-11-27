namespace Lykke.OneSky.Json
{
    using System;

    public interface ITranslator
    {
        DateTime WillCompleteAt { get; }

        long WillCompleteAtTimestamp { get; }

        int SecondsToComplete { get; }
    }
}