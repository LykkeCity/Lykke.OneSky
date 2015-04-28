﻿namespace OneSkyDotNetExamples.Plain
{
    using System;
    using System.Collections.Generic;

    public static class PlatformQuotationExample
    {
        public static void QuotationPlainShow()
        {
            var oneSky = OneSkyDotNet.OneSkyClient.CreatePlainClient(Settings.PublicKey, Settings.PrivateKey);
            var quotation = oneSky.Platform.Quotation.Show(
                56704,
                new List<string> { "zecond.txt", "Main.txt" },
                "fr",
                specialization: "game");
            Console.WriteLine(quotation);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}