﻿namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IPlatformLocale
    {
        IOneSkyResponse<IMetaList, IEnumerable<ILocale>> List();
    }
}