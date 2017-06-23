﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace SceneSkope.PowerBI.Authenticators
{
    public class DeviceCodeAuthenticator : BaseAdalAuthenticator
    {
        private readonly Action<string, string> _notifyDeviceCodeRequest;

        public DeviceCodeAuthenticator(string clientId, Action<string, string> notifyDeviceCodeRequest)
            : base(clientId)
        {
            _notifyDeviceCodeRequest = notifyDeviceCodeRequest;
        }

        public DeviceCodeAuthenticator(string clientId, byte[] initialState)
            : base(clientId, initialState)
        {
            _notifyDeviceCodeRequest = (uri, code) => throw new InvalidOperationException($"Device code authentication failed");
        }

        protected override async Task<AuthenticationResult> InitialGetAccessCodeAsync(CancellationToken ct)
        {
            var codeResult = await AuthenticationContext.AcquireDeviceCodeAsync(ResourceUri, ClientId).ConfigureAwait(false);
            _notifyDeviceCodeRequest(codeResult.VerificationUrl, codeResult.UserCode);
            return await AuthenticationContext.AcquireTokenByDeviceCodeAsync(codeResult).ConfigureAwait(false);
        }
    }
}
