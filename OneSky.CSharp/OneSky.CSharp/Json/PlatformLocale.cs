namespace Lykke.OneSky.Json
{
    using System.Collections.Generic;

    internal class PlatformLocale : IPlatformLocale
    {
        private Lykke.OneSky.IPlatformLocale locale;

        internal PlatformLocale(Lykke.OneSky.IPlatformLocale locale)
        {
            this.locale = locale;
        }

        public IOneSkyResponse<IMetaList, IEnumerable<ILocale>> List()
        {
            var plain = this.locale.List();
            return JsonHelper.PlatformCompose<IMetaList, IEnumerable<ILocale>, MetaList, List<Localeo>>(plain);
        }
    }
}