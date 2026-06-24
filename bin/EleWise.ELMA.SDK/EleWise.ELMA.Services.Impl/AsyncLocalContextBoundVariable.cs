using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services.Impl;

[Service(EnableInterceptors = false, Type = ComponentType.Design)]
internal sealed class AsyncLocalContextBoundVariableService : SimpleBoundVariableServiceBase
{
	private readonly AsyncLocal<IDictionary<string, object>> dictionary;

	private static AsyncLocalContextBoundVariableService j63sY3Bms5R22u1kqErR;

	protected override IDictionary<string, object> Dictionary => this.dictionary.Value ?? (this.dictionary.Value = new ConcurrentDictionary<string, object>());

	public AsyncLocalContextBoundVariableService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		dictionary = new AsyncLocal<IDictionary<string, object>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool jSAkw1Bmc1TEOFh2EpWZ()
	{
		return j63sY3Bms5R22u1kqErR == null;
	}

	internal static AsyncLocalContextBoundVariableService avU0MLBmzieio8FaeZg5()
	{
		return j63sY3Bms5R22u1kqErR;
	}
}
