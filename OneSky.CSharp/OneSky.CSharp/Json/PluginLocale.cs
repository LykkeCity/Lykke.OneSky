namespace Lykke.OneSky.Json
{
    using System.Collections.Generic;

    internal class PluginLocale : IPluginLocale
    {
        private Lykke.OneSky.IPluginLocale locale;

        internal PluginLocale(Lykke.OneSky.IPluginLocale locale)
        {
            this.locale = locale;
        }

        public IOneSkyResponse<IMeta, IEnumerable<ILocale>> GetLocales()
        {
            var plain = this.locale.GetLocales();
            var tuple = JsonHelper.PluginDeserialize(plain, new { locales = new List<Localeo>() }, x => x.locales);
            return new OneSkyResponse<IMeta, IEnumerable<ILocale>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}