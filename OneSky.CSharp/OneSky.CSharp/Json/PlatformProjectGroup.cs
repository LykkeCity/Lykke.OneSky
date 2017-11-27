﻿namespace Lykke.OneSky.Json
{
    using System.Collections.Generic;

    internal class PlatformProjectGroup : IPlatformProjectGroup
    {
        private readonly Lykke.OneSky.IPlatformProjectGroup projectGroup;

        public PlatformProjectGroup(Lykke.OneSky.IPlatformProjectGroup projectGroup)
        {
            this.projectGroup = projectGroup;
        }

        public IOneSkyResponse<IMetaPagedList, IEnumerable<IProjectGroup>> List(int page = 1, int perPage = 50)
        {
            var plain = this.projectGroup.List(page, perPage);
            return JsonHelper.PlatformCompose<IMetaPagedList, IEnumerable<IProjectGroup>, MetaPagedList, List<ProjectGroup>>(plain);
        }

        public IOneSkyResponse<IMeta, IProjectGroupDetails> Show(int projectGroupId)
        {
            var plain = this.projectGroup.Show(projectGroupId);
            return JsonHelper.PlatformCompose<IMeta, IProjectGroupDetails, Meta, ProjectGroupDetails>(plain);
        }

        public IOneSkyResponse<IMeta, IProjectGroupNew> Create(string name, string locale = "en")
        {
            var plain = this.projectGroup.Create(name, locale);
            return JsonHelper.PlatformCompose<IMeta, IProjectGroupNew, Meta, ProjectGroupNew>(plain);
        }

        public IOneSkyResponse<IMeta, INull> Delete(int projectGroupId)
        {
            var plain = this.projectGroup.Delete(projectGroupId);
            return JsonHelper.PlatformCompose<IMeta, INull, Meta, Null>(plain);
        }

        public IOneSkyResponse<IMetaList, IEnumerable<ILocaleGroup>> Languages(int projectGroupId)
        {
            var plain = this.projectGroup.Languages(projectGroupId);
            return JsonHelper.PlatformCompose<IMetaList, IEnumerable<ILocaleGroup>, MetaList, List<LocaleGroup>>(plain);
        }
    }
}