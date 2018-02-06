﻿using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using IdentityModel.Client;
using RestSharp;

namespace Sillycore.RestClient.Decorators
{
    public class OAuth2Decorator : RestClientDecoratorBase
    {
        private readonly object _syncLock = new object();
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _tokenUrl;
        private readonly string _scope;
        private readonly TokenClient _tokenClient;
        private string _accessToken = String.Empty;
        private bool _isExpired = false;

        public OAuth2Decorator(RestSharp.RestClient decoratedClient, string clientId, string clientSecret, string tokenUrl, string scope) : 
            base(decoratedClient)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _tokenUrl = tokenUrl;
            _scope = scope;

            _tokenClient = new TokenClient(_tokenUrl, _clientId, _clientSecret);

            RefreshAccessToken();
        }

        public override IRestResponse Execute(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse response = DecoratedClient.Execute(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = DecoratedClient.Execute(request);
            }

            return response;
        }

        public override IRestResponse<T> Execute<T>(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = DecoratedClient.Execute<T>(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = DecoratedClient.Execute<T>(request);
            }

            return response;
        }

        public override async Task<IRestResponse> ExecuteGetTaskAsync(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecuteGetTaskAsync(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteGetTaskAsync(request);
            }

            return response;
        }

        public override async Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecuteGetTaskAsync<T>(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteGetTaskAsync<T>(request, token);
            }

            return response;
        }

        public override async Task<IRestResponse> ExecuteGetTaskAsync(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecuteGetTaskAsync(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteGetTaskAsync(request, token);
            }

            return response;
        }

        public override async Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecuteGetTaskAsync<T>(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteGetTaskAsync<T>(request);
            }

            return response;
        }

        public override async Task<IRestResponse> ExecutePostTaskAsync(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecutePostTaskAsync(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecutePostTaskAsync(request);
            }

            return response;
        }

        public override async Task<IRestResponse<T>> ExecutePostTaskAsync<T>(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecutePostTaskAsync<T>(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecutePostTaskAsync<T>(request);
            }

            return response;
        }

        public override async Task<IRestResponse> ExecutePostTaskAsync(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecutePostTaskAsync(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecutePostTaskAsync(request, token);
            }

            return response;
        }

        public override async Task<IRestResponse<T>> ExecutePostTaskAsync<T>(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecutePostTaskAsync<T>(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecutePostTaskAsync<T>(request, token);
            }

            return response;
        }

        public override async Task<IRestResponse> ExecuteTaskAsync(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecuteTaskAsync(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteTaskAsync(request);
            }

            return response;
        }

        public override async Task<IRestResponse> ExecuteTaskAsync(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse response = await DecoratedClient.ExecuteTaskAsync(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteTaskAsync(request, token);
            }

            return response;
        }

        public override async Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecuteTaskAsync<T>(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteTaskAsync<T>(request);
            }

            return response;
        }

        public override async Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request, CancellationToken token)
        {
            InjectAccessToken(request);
            IRestResponse<T> response = await DecoratedClient.ExecuteTaskAsync<T>(request, token);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshAccessToken();
                InjectAccessToken(request);
                response = await DecoratedClient.ExecuteTaskAsync<T>(request, token);
            }

            return response;
        }

        public override RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
        {
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
        }

        public override RestRequestAsyncHandle ExecuteAsync<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback)
        {
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
        }

        public override RestRequestAsyncHandle ExecuteAsyncGet(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, string httpMethod)
        {
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
        }

        public override RestRequestAsyncHandle ExecuteAsyncGet<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, string httpMethod)
        {
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
        }

        public override RestRequestAsyncHandle ExecuteAsyncPost(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, string httpMethod)
        {
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
        }

        public override RestRequestAsyncHandle ExecuteAsyncPost<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, string httpMethod)
        {
            throw new NotSupportedException("Async methods which return RestRequestAsyncHandle is not supported in OAuth2 decorator.");
        }

        private void InjectAccessToken(IRestRequest request)
        {
            Parameter authHeader = request.Parameters.FirstOrDefault(p => p.Type == ParameterType.HttpHeader && p.Name == "Authorization");

            if (authHeader != null)
            {
                authHeader.Value = $"Bearer {_accessToken}";
            }
            else
            {
                request.AddHeader("Authorization", $"Bearer {_accessToken}");
            }
        }

        private void RefreshAccessToken()
        {
            _isExpired = true;

            if (_isExpired)
            {
                lock (_syncLock)
                {
                    if (_isExpired)
                    {
                        GenerateNewAccessToken().Wait();
                        _isExpired = false;
                    }
                }
            }
        }

        private async Task GenerateNewAccessToken()
        {
            TokenResponse tokenResult = await _tokenClient.RequestClientCredentialsAsync(_scope);

            if (tokenResult.HttpStatusCode == HttpStatusCode.OK)
            {
                _accessToken = tokenResult.AccessToken;
            }
        }
    }
}