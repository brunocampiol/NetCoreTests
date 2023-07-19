﻿using RichardSzalay.MockHttp;

namespace NetCoreTests.Common
{
    public class MockHttpClientFactory : IHttpClientFactory
    {
        private readonly MockHttpMessageHandler _mockHttpMessageHandler;

        public MockHttpClientFactory(MockHttpMessageHandler mockHttpMessageHandler)
        {
            _mockHttpMessageHandler = mockHttpMessageHandler ?? throw new ArgumentNullException(nameof(mockHttpMessageHandler));
        }

        public HttpClient CreateClient(string name)
        {
            return _mockHttpMessageHandler.ToHttpClient();
        }
    }
}