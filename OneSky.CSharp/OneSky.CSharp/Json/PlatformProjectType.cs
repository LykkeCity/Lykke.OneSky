namespace Lykke.OneSky.Json
{
    using System.Collections.Generic;

    internal class PlatformProjectType : IPlatformProjectType
    {
        private Lykke.OneSky.IPlatformProjectType projectType;

        public PlatformProjectType(Lykke.OneSky.IPlatformProjectType projectType)
        {
            this.projectType = projectType;
        }

        public IOneSkyResponse<IMetaList, IEnumerable<IProjectType>> List()
        {
            var plain = this.projectType.List();
            return JsonHelper.PlatformCompose<IMetaList, IEnumerable<IProjectType>, MetaList, List<ProjectType>>(plain);
        }
    }
}