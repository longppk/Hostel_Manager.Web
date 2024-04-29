﻿using BHSystem.Web.Constants;
using BHSytem.Models.Entities;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.SignalR.Client;
using System.Security.Claims;
using System.Security.Policy;
using System.Text.Json;

namespace BHSystem.Web.Providers
{
    public class ApiAuthenticationStateProvider : AuthenticationStateProvider, IDisposable
    {
        private readonly ILocalStorageService _localStorage;
        private readonly NavigationManager _nav;
        private readonly IConfiguration _configuration;
        private HubConnection? hubConnection { get; set; }
        public ApiAuthenticationStateProvider(ILocalStorageService localStorage, NavigationManager nav, IConfiguration configuration)
        {
            _localStorage = localStorage;
            _nav = nav;
            _configuration = configuration;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var savedToken = await _localStorage.GetItemAsync<string>("authToken");
                if (string.IsNullOrWhiteSpace(savedToken))
                {
                    string sPath = _nav.ToBaseRelativePath(_nav.Uri);
                    if($"{sPath}".ToUpper().Contains("ADMIN") 
                        && !$"{sPath}".ToUpper().Contains("ADMIN/LOGIN")
                        && !$"{sPath}".ToUpper().Contains("ADMIN/LOGOUT")) _nav.NavigateTo("/trang-chu");
                    return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
                }
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(savedToken), "jwt")));
            }
            catch (InvalidOperationException)
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
        }

        public void MarkUserAsAuthenticated(string fullName)
        {
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, fullName) }, "apiauth"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public void MarkUserAsLoggedOut()
        {
            var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(anonymousUser));
            NotifyAuthenticationStateChanged(authState);
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            claims.AddRange(keyValuePairs!.Select(kvp => new Claim(kvp.Key, $"{kvp.Value}")));
            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }

        private void connectHub(string userId)
        {
            try
            {
                string urlChat = _configuration!.GetSection("appSettings:ApiUrl").Value + "Signalhub";
                hubConnection = new HubConnectionBuilder()
                .WithUrl(urlChat, options =>{ options.Headers.Add("UserName", userId) ;}).Build();

                hubConnection.On<Messages>("ReceiveEmployee", (incomingEmp) =>
                {
                    
                });
            }
            catch
            {

            }
        }

        public void Dispose() => hubConnection?.DisposeAsync();
    }
}