using System;
using eSupport.Common.Resilience.Resilience.Http;

namespace eSupport.Application.Infrastructure
{
    public interface IResilientHttpClientFactory
    {
        ResilientHttpClient CreateResilientHttpClient();
    }
}