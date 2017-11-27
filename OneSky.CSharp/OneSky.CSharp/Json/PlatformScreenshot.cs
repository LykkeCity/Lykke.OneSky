namespace Lykke.OneSky.Json
{
    using System.Collections.Generic;
    using System.Linq;

    using Newtonsoft.Json;

    internal class PlatformScreenshot : IPlatformScreenshot
    {
        private Lykke.OneSky.IPlatformScreenshot screenshot;

        public PlatformScreenshot(Lykke.OneSky.IPlatformScreenshot screenshot)
        {
            this.screenshot = screenshot;
        }

        public IOneSkyResponse<IMeta, INull> Upload(int projectId, IEnumerable<IScreenshot> screenshots)
        {
            var plainScreenshots = screenshots.Select(JsonConvert.SerializeObject);
            var plain = this.screenshot.Upload(projectId, plainScreenshots);
            return JsonHelper.PlatformCompose<IMeta, INull, Meta, Null>(plain);
        }
    }
}