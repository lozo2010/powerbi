﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace SceneSkope.PowerBI.Authenticators
{
    public class DeviceCodeTokenProvider : BaseAdalTokenProvider
    {
        private readonly Action<string, string> _notifyDeviceCodeRequest;

        public DeviceCodeTokenProvider(string clientId, Action<string, string> notifyDeviceCodeRequest)
            : base(clientId)
        {
            _notifyDeviceCodeRequest = notifyDeviceCodeRequest;
        }

        public DeviceCodeTokenProvider(string clientId, byte[] initialState) : base(clientId, initialState)
        {
#pragma warning disable RCS1163 // Unused parameter.
            _notifyDeviceCodeRequest = (uri, code) => throw new InvalidOperationException("Device code authentication failed");
#pragma warning restore RCS1163 // Unused parameter.
        }

        protected override async Task<AuthenticationResult> InitialGetAccessCodeAsync(CancellationToken ct)
        {
            var codeResult = await AuthenticationContext.AcquireDeviceCodeAsync(ResourceUri, ClientId).ConfigureAwait(false);
            _notifyDeviceCodeRequest(codeResult.VerificationUrl, codeResult.UserCode);
            return await AuthenticationContext.AcquireTokenByDeviceCodeAsync(codeResult).ConfigureAwait(false);
        }
    }
}
