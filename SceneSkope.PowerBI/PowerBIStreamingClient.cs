﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SceneSkope.PowerBI
{
    public class PowerBIStreamingClient : BasePowerBIClient
    {
#if NETSTANDARD1_4
        private static readonly Task CompletedTask = Task.CompletedTask;
#else
        private static readonly Task CompletedTask = Task.FromResult(true);
#endif

        public string Url { get; }

        public PowerBIStreamingClient(string url, HttpClient client) : base(client)
        {
            Url = url;
        }

        protected override Task AuthenticateRequestAsync(HttpRequestMessage request, CancellationToken ct) => CompletedTask;

        public async Task AddRowsAsync(object[] rows, CancellationToken ct)
        {
            var json = JsonConvert.SerializeObject(rows, _dataSettings);
            using (var request = new HttpRequestMessage(HttpMethod.Post, Url)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            })
            {
                using (var response = await AuthenticateAndSendRequestAsync(request, ct).ConfigureAwait(false))
                {
                    await CheckForFailureAndLogIfRequired(response).ConfigureAwait(false);
                }
            }
        }
    }
}
