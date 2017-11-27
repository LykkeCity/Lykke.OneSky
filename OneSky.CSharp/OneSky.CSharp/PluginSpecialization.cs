﻿namespace Lykke.OneSky
{
    internal class PluginSpecialization : IPluginSpecialization
    {
        private const string GetSpecializationsAddress = "https://plugin.api.onesky.io/1/specializations";

        private OneSkyHelper oneSky;

        internal PluginSpecialization(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse GetSpecializations()
        {
            return this.oneSky.CreateRequest(GetSpecializationsAddress).Get();
        }
    }
}