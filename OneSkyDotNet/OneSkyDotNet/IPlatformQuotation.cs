﻿namespace OneSkyDotNet
{
    using System.Collections.Generic;

    public interface IPlatformQuotation
    {
        string Show(
            int projectId,
            IEnumerable<string> files,
            string toLocale,
            bool isIncludingNotTranslated = true,
            bool isIncludingNotApproved = true,
            bool isIncludingOutdated = true,
            string specialization = "general");
    }
}