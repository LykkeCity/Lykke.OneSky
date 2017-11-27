﻿namespace Lykke.OneSky.Json
{
    public interface IMetaPagedList : IMetaList
    {
        int PageCount { get; }

        string NextPage { get; }

        string PreviousPage { get; }

        string FirstPage { get; }

        string LastPage { get; }
    }
}