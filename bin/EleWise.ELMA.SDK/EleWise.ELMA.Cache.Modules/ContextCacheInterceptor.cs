using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Runtime.AOP;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache.Modules;

public class ContextCacheInterceptor : CacheInterceptorBase<ContextCacheAttribute>
{
	private readonly IContextBoundVariableService contextBoundVariableService;

	internal static ContextCacheInterceptor HqSi3mfKLFtSpI5DObRx;

	public ContextCacheInterceptor(IContextBoundVariableService contextBoundVariableService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NJ80wxfKcov1fCytV1jt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.contextBoundVariableService = contextBoundVariableService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void Invoke(IInvocation invocation, string cacheKey, string cacheRegion, ContextCacheAttribute cacheAttribute)
	{
		//Discarded unreachable code: IL_0064
		int num = 2;
		int num2 = num;
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				cacheRegion = (string)TklZBsfKzY5KgCxf7lTQ(cacheAttribute);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 7;
				}
				break;
			case 5:
				return;
			case 4:
				gO8h9ZfXB4m9XmTbtl9P(invocation);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				eXVgxYfXFBeDJulxn8vN(invocation, result);
				num2 = 5;
				break;
			case 3:
				return;
			case 2:
				if (TklZBsfKzY5KgCxf7lTQ(cacheAttribute) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			default:
				Set(contextBoundVariableService, cacheKey, cacheRegion, KAnrM6fXWHFwyA2C5a96(invocation));
				num2 = 3;
				break;
			case 7:
				if (!TryGetValue(contextBoundVariableService, cacheKey, cacheRegion, out result))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__4))]
	protected override Task InvokeAsync(IInvocationAsync invocation, string cacheKey, string cacheRegion, ContextCacheAttribute cacheAttribute, CancellationToken cancellationToken)
	{
		int num = 3;
		_003CInvokeAsync_003Ed__4 stateMachine = default(_003CInvokeAsync_003Ed__4);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					stateMachine.cacheAttribute = cacheAttribute;
					num2 = 7;
					continue;
				case 6:
					stateMachine.cacheRegion = cacheRegion;
					num2 = 8;
					continue;
				case 2:
					break;
				case 1:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
					stateMachine._003C_003E4__this = this;
					num2 = 2;
					continue;
				case 4:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					stateMachine._003C_003E1__state = -1;
					num2 = 4;
					continue;
				case 7:
					stateMachine._003C_003Et__builder = fBIKLmfXofOlG5EvjIk4();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return stateMachine._003C_003Et__builder.Task;
				case 9:
					stateMachine.cacheKey = cacheKey;
					num2 = 6;
					continue;
				}
				break;
			}
			stateMachine.invocation = invocation;
			num = 9;
		}
	}

	internal static void Set(IContextBoundVariableService contextBoundVariableService, string key, string region, object value)
	{
		//Discarded unreachable code: IL_0106, IL_0115, IL_0166, IL_0175
		int num = 7;
		object obj = default(object);
		IDictionary<string, IDictionary<string, object>> value3 = default(IDictionary<string, IDictionary<string, object>>);
		IDictionary<string, object> value2 = default(IDictionary<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (obj != null)
					{
						num2 = 2;
						continue;
					}
					goto case 8;
				case 4:
					return;
				case 8:
					obj = MemoryCacheService.NullValue.Null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					obj = value;
					num = 10;
					break;
				case 5:
					if (value3.TryGetValue(region, out value2))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 3:
					value3.Add(region, value2 = new Dictionary<string, object>());
					num2 = 9;
					continue;
				case 7:
					if (!contextBoundVariableService.TryGetValue<IDictionary<string, IDictionary<string, object>>>((string)pwoawDfXbTD35iLI7NVs(-629844702 ^ -630189594), out value3))
					{
						num2 = 6;
						continue;
					}
					goto case 5;
				case 6:
					WnpxorfXhdOOCcZDuOrW(contextBoundVariableService, pwoawDfXbTD35iLI7NVs(--1867379187 ^ 0x6F48B537), value3 = new Dictionary<string, IDictionary<string, object>>());
					num2 = 5;
					continue;
				case 1:
				case 2:
					value2[key] = obj;
					num = 4;
					break;
				}
				break;
			}
		}
	}

	internal static bool TryGetValue(IContextBoundVariableService contextBoundVariableService, string key, string region, out object result)
	{
		//Discarded unreachable code: IL_009e
		int num = 3;
		int num2 = num;
		IDictionary<string, IDictionary<string, object>> value2 = default(IDictionary<string, IDictionary<string, object>>);
		IDictionary<string, object> value = default(IDictionary<string, object>);
		while (true)
		{
			switch (num2)
			{
			default:
				result = null;
				num2 = 4;
				continue;
			case 2:
				if (!value2.TryGetValue(region, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			case 3:
				if (contextBoundVariableService.TryGetValue<IDictionary<string, IDictionary<string, object>>>((string)pwoawDfXbTD35iLI7NVs(0x463A0F3C ^ 0x463F4BF8), out value2))
				{
					num2 = 2;
					continue;
				}
				goto default;
			case 4:
				return false;
			case 6:
				result = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				if (value.TryGetValue(key, out result))
				{
					if (result is MemoryCacheService.NullValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					break;
				}
				num2 = 7;
				continue;
			case 1:
				break;
			}
			break;
		}
		return true;
	}

	internal static void ClearRegion(IContextBoundVariableService contextBoundVariableService, string region)
	{
		int num = 3;
		int num2 = num;
		IDictionary<string, IDictionary<string, object>> value = default(IDictionary<string, IDictionary<string, object>>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 3:
				if (contextBoundVariableService.TryGetValue<IDictionary<string, IDictionary<string, object>>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939720632), out value))
				{
					num2 = 2;
					break;
				}
				return;
			case 2:
			{
				if (!value.TryGetValue(region, out var value2))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					value2.Clear();
					num2 = 4;
				}
				break;
			}
			case 4:
				value.Remove(region);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void Remove(IContextBoundVariableService contextBoundVariableService, string key, string region)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 4;
		int num2 = num;
		IDictionary<string, IDictionary<string, object>> value = default(IDictionary<string, IDictionary<string, object>>);
		IDictionary<string, object> value2 = default(IDictionary<string, object>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (value.TryGetValue(region, out value2))
				{
					num2 = 2;
					break;
				}
				return;
			case 0:
				return;
			case 2:
				value2.Remove(key);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 4:
				if (!contextBoundVariableService.TryGetValue<IDictionary<string, IDictionary<string, object>>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x539E867), out value))
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static void Clear(IContextBoundVariableService contextBoundVariableService)
	{
		//Discarded unreachable code: IL_007f, IL_0089, IL_012c, IL_0164, IL_0173
		int num = 2;
		int num2 = num;
		IDictionary<string, IDictionary<string, object>> value = default(IDictionary<string, IDictionary<string, object>>);
		IEnumerator<KeyValuePair<string, IDictionary<string, object>>> enumerator = default(IEnumerator<KeyValuePair<string, IDictionary<string, object>>>);
		KeyValuePair<string, IDictionary<string, object>> current = default(KeyValuePair<string, IDictionary<string, object>>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				if (!contextBoundVariableService.TryGetValue<IDictionary<string, IDictionary<string, object>>>((string)pwoawDfXbTD35iLI7NVs(-2138958856 ^ -2138613956), out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					enumerator = value.GetEnumerator();
					num2 = 4;
				}
				continue;
			case 4:
				try
				{
					while (true)
					{
						IL_00e0:
						int num3;
						if (!iQTS4OfXExule5WLQnxi(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num3 = 0;
							}
							goto IL_008d;
						}
						goto IL_00bd;
						IL_00bd:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num3 = 1;
						}
						goto IL_008d;
						IL_008d:
						while (true)
						{
							switch (num3)
							{
							case 1:
								J9DpuEfXGxx69aCcrqu1(current.Value);
								num3 = 3;
								continue;
							case 2:
								goto IL_00bd;
							case 3:
								goto IL_00e0;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								tpdPaSfXfWZpGoD4DnVm(enumerator);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				break;
			case 1:
				return;
			}
			YGJIp0fXQjPdHZc7TwwY(value);
			num2 = 3;
		}
	}

	internal static void NJ80wxfKcov1fCytV1jt()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool nqlxECfKUMAFiLjW3lob()
	{
		return HqSi3mfKLFtSpI5DObRx == null;
	}

	internal static ContextCacheInterceptor C3BoJrfKsNMvHRSbCCkO()
	{
		return HqSi3mfKLFtSpI5DObRx;
	}

	internal static object TklZBsfKzY5KgCxf7lTQ(object P_0)
	{
		return ((ContextCacheAttribute)P_0).Region;
	}

	internal static void eXVgxYfXFBeDJulxn8vN(object P_0, object P_1)
	{
		((IInvocation)P_0).set_ReturnValue(P_1);
	}

	internal static void gO8h9ZfXB4m9XmTbtl9P(object P_0)
	{
		((IInvocation)P_0).Proceed();
	}

	internal static object KAnrM6fXWHFwyA2C5a96(object P_0)
	{
		return ((IInvocation)P_0).get_ReturnValue();
	}

	internal static AsyncTaskMethodBuilder fBIKLmfXofOlG5EvjIk4()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static object pwoawDfXbTD35iLI7NVs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void WnpxorfXhdOOCcZDuOrW(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}

	internal static void J9DpuEfXGxx69aCcrqu1(object P_0)
	{
		((ICollection<KeyValuePair<string, object>>)P_0).Clear();
	}

	internal static bool iQTS4OfXExule5WLQnxi(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void tpdPaSfXfWZpGoD4DnVm(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void YGJIp0fXQjPdHZc7TwwY(object P_0)
	{
		((ICollection<KeyValuePair<string, IDictionary<string, object>>>)P_0).Clear();
	}
}
