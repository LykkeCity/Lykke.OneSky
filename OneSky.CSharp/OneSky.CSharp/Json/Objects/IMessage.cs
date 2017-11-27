﻿namespace Lykke.OneSky.Json
{
    using System;

    public interface IMessage
    {
        int Id { get; }

        string Content { get; }

        DateTime CreatedAt { get; }

        long CreatedAtTimestamp { get; }

        IPerson Author { get; }
    }
}