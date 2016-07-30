// -----------------------------------------
// --------- Made By Andrax ----------------
// andrax@andrax.nl  |  http://www.andrax.nl 
// github.com/andraxb
// Copyright (c) Andrax
// -----------------------------------------
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using ModernHttpClient;

namespace owncloudpcl
{
	/// <summary>
	/// OwnCloud client.
	/// </summary>
	public class OwnCloudClient
	{
		private HttpClient _httpClient;
			
		/// <summary>
		/// The base URL for your OwnCloudClient.
		/// </summary>
		private string _baseUrl;

		/// <summary>
		/// Initializes a new instance of the <see cref="owncloudpcl.OwnCloudClient"/> class.
		/// </summary>
		/// <param name="url">Base URL for your OwnCloudClient.</param>
		public OwnCloudClient (string url)
		{
			this._baseUrl = url;
			this._httpClient = CreateHttpClient ();
		}

		/// <summary>
		/// Creates the http client.
		/// Any defaults for the HttpClient will be set here, such as the _baseUrl over which all requests will be made.
		/// </summary>
		/// <returns>The http client.</returns>
		private HttpClient CreateHttpClient ()
		{
			var httpClient = new HttpClient (new NativeMessageHandler()) { 
				BaseAddress = new Uri (this._baseUrl)
			};

			return httpClient;
		}

		/// <summary>
		/// Log in the specified user and password to the OwnCloud API.
		/// </summary>
		/// <param name="user">User.</param>
		/// <param name="password">Password.</param>
		public void Login(string user, string password) {

		}

		/// <summary>
		/// Logs the User out.
		/// </summary>
		public void Logout() {
			
		}
	}
}