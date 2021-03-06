﻿using System;
using System.Threading.Tasks;
using Model;

namespace Hotfix
{
	[ActorMessageHandler(AppType.Map)]
	public class C2M_TestActorRequestHandler : AMActorRpcHandler<Unit, C2M_TestActorRequest, M2C_TestActorResponse>
	{
		protected override async Task Run(Unit unit, C2M_TestActorRequest message, Action<M2C_TestActorResponse> reply)
		{
			Log.Debug(message.Info);
			reply(new M2C_TestActorResponse(){Info = "actor rpc response"});
			await Task.CompletedTask;
		}
	}
}