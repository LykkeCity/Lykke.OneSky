namespace Lykke.OneSky.Tests
{
    using FluentAssertions;

    using Lykke.OneSky.Json;

    using Xunit;

    public class PluginAccount
    {
        private IPluginAccount account =
            OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Plugin.Account;

        [Fact]
        public void Credits()
        {
            var response = this.account.GetCredit();

            response.StatusCode.Should().BeInRange(200, 299);

            response.Data.RemainingCredit.Should().BeGreaterOrEqualTo(0);
        }
    }
}