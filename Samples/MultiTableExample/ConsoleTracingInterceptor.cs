﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Rest;

namespace MultiTableExample
{
    public class ConsoleTracingInterceptor : IServiceClientTracingInterceptor
    {
        private void Write(string message, params object[] arguments)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (arguments == null || arguments.Length == 0)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine(message, arguments);
            }
            Console.ResetColor();
        }

        public void Information(string message)
        {
            Write(message);
        }

        public void Configuration(string source, string name, string value)
        {
        }

        public void EnterMethod(string invocationId, object instance, string method, IDictionary<string, object> parameters)
        {
            Write("{0} - [{1}]: Entered method {2} with arguments: {3}", invocationId, instance, method, parameters.AsFormattedString());
        }

        public void SendRequest(string invocationId, HttpRequestMessage request)
        {
            Write("{0} - {1}", invocationId, request.AsFormattedString());
        }

        public void ReceiveResponse(string invocationId, HttpResponseMessage response)
        {
            Write("{0} - {1}", invocationId, response.AsFormattedString());
        }

        public void TraceError(string invocationId, Exception exception)
        {
            Write("{0} - Error: {1}", invocationId, exception);
        }

        public void ExitMethod(string invocationId, object returnValue)
        {
            Write("{0} - Exited method with result: {1}", invocationId, returnValue);
        }
    }
}
