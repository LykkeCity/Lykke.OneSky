﻿namespace Lykke.OneSky.Json
{
    using System.Collections.Generic;

    internal class PluginSpecialization : IPluginSpecialization
    {
        private Lykke.OneSky.IPluginSpecialization specialization;

        public PluginSpecialization(Lykke.OneSky.IPluginSpecialization specialization)
        {
            this.specialization = specialization;
        }

        public IOneSkyResponse<IMeta, IEnumerable<ISpecialization>> GetSpecializations()
        {
            var plain = this.specialization.GetSpecializations();
            var tuple = JsonHelper.PluginDeserialize(plain, new { specializations = new List<Specialization>() }, x => x.specializations);
            return new OneSkyResponse<IMeta, IEnumerable<ISpecialization>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}