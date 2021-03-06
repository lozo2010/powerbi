﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace SceneSkope.PowerBI.Authenticators
{
    public class UsernameTokenProvider : BaseAdalTokenProvider
    {
        public string RedirectUri { get; set; } = "https://login.live.com/oauth20_desktop.srf";

        public string Username { get; }

        public UsernameTokenProvider(string clientId, string username) : base(clientId)
        {
            Username = username;
        }

        protected override Task<AuthenticationResult> InitialGetAccessCodeAsync(CancellationToken ct)
            => AuthenticationContext.AcquireTokenAsync(ResourceUri, ClientId, new UserCredential(Username));
    }
}
