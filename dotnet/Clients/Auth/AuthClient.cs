﻿using System;
using Branch.Clients.Branch;
using Branch.Packages.Interfaces.ServiceAuth;
using Branch.Packages.Models.ServiceAuth;
using System.Threading;
using System.Threading.Tasks;

namespace Branch.Clients.Auth
{
	public class AuthClient : BranchClient, IService
	{
		public AuthClient(string baseUrl, string key)
			: base(baseUrl, key) { }

		public async Task<ResGetHalo4Token> GetHalo4Token(ReqGetHalo4Token req)
		{
			return await base.Do<ReqGetHalo4Token, ResGetHalo4Token>("1/2018-03-21/get_halo4_token", req);
		}

		public async Task<ResGetXboxLiveToken> GetXboxLiveToken(ReqGetXboxLiveToken req)
		{
			return await base.Do<ReqGetXboxLiveToken, ResGetXboxLiveToken>("1/2018-03-21/get_xboxlive_token", req);
		}
	}
}