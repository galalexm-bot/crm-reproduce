using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class ActorContextService : IActorContextManagementService, IActorContextService
{
	private readonly ILazy<IContextBoundVariableService> contextService;

	private static ActorContextService RC37dkBaeEACq7YsK1i1;

	public ActorContextService(ILazy<IContextBoundVariableService> contextService)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.contextService = contextService;
	}

	public IDictionary<string, object> Get()
	{
		if (contextService.IsRegistered)
		{
			return contextService.Value.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488831067), () => new SerializableDictionary<string, object>());
		}
		return null;
	}

	public bool TryGet(string key, out object value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (contextService.IsRegistered)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				value = null;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return false;
			default:
				return contextService.Value.GetOrAdd((string)JERnkgBaNvbjQjqdjUvs(0x18A6761F ^ 0x18A73271), () => new SerializableDictionary<string, object>()).TryGetValue(key, out value);
			}
		}
	}

	public void Set(string key, object value)
	{
		int num = 1;
		int num2 = num;
		SerializableDictionary<string, object> orAdd = default(SerializableDictionary<string, object>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				orAdd[key] = value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return;
			case 2:
				XjsOknBapoYXxtjLFn7d(contextService.Value, JERnkgBaNvbjQjqdjUvs(-672123589 ^ -672042667), orAdd);
				num2 = 4;
				break;
			case 1:
				if (!rSUHYnBa3GhWhFubiyKN(contextService))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				orAdd = contextService.Value.GetOrAdd((string)JERnkgBaNvbjQjqdjUvs(-195614443 ^ -195662469), () => new SerializableDictionary<string, object>());
				num2 = 3;
				break;
			}
		}
	}

	public void Set(IDictionary<string, object> incomingContext)
	{
		if (incomingContext == null || incomingContext.Count == 0 || !contextService.IsRegistered)
		{
			return;
		}
		SerializableDictionary<string, object> orAdd = contextService.Value.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F313CD8), () => new SerializableDictionary<string, object>());
		foreach (KeyValuePair<string, object> item in incomingContext)
		{
			orAdd[item.Key] = item.Value;
		}
		contextService.Value.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x744DA6C), orAdd);
	}

	internal static object JERnkgBaNvbjQjqdjUvs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool REsss5BaPk9Fg9grmZy0()
	{
		return RC37dkBaeEACq7YsK1i1 == null;
	}

	internal static ActorContextService XZCXqgBa1h0sNOh4Fvwb()
	{
		return RC37dkBaeEACq7YsK1i1;
	}

	internal static bool rSUHYnBa3GhWhFubiyKN(object P_0)
	{
		return ((ILazy<IContextBoundVariableService>)P_0).IsRegistered;
	}

	internal static void XjsOknBapoYXxtjLFn7d(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}
}
