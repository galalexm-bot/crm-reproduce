using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Impl;

internal class EventsInterceptor : AbstractAsyncInterceptor
{
	private readonly IEnumerable<IEventBus> eventBuses;

	private readonly IEnumerable<IEventBusAsync> eventBusesAsync;

	[ThreadStatic]
	private static Stack<string> notifying;

	private static readonly AsyncLocal<Stack<string>> notifyingAsyncLocal;

	internal static EventsInterceptor kKT63oGYMTXqZUCH6bMI;

	public EventsInterceptor(IEnumerable<IEventBus> eventBuses, IEnumerable<IEventBusAsync> eventBusesAsync)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.eventBuses = eventBuses;
		this.eventBusesAsync = eventBusesAsync;
	}

	public override void Intercept(IInvocation invocation)
	{
		//Discarded unreachable code: IL_0125, IL_016e, IL_017d, IL_0188, IL_0273, IL_02ab, IL_0339, IL_034c, IL_035b
		int num = 4;
		string text2 = default(string);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		List<object> list = default(List<object>);
		IEnumerator<IEventBus> enumerator = default(IEnumerator<IEventBus>);
		IEnumerable enumerable = default(IEnumerable);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 8:
					text2 = (string)fQJwRQGYldsEheDA4og6(_003C_003Ec__DisplayClass3_.invocation.get_Method());
					num = 2;
					break;
				case 4:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 3;
					continue;
				case 11:
					notifying = new Stack<string>();
					num2 = 9;
					continue;
				case 5:
					try
					{
						Dictionary<string, object> eventData = ((IEnumerable<ParameterInfo>)l7i4e2GYY682ljafaIA9(sJ20MjGYjBlkJQePFqUG(_003C_003Ec__DisplayClass3_.invocation))).Select(_003C_003Ec__DisplayClass3_._003CIntercept_003Eb__0).ToDictionary(kv => kv.Name, kv => kv.Value);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								list = new List<object>();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								try
								{
									while (true)
									{
										int num4;
										if (!PDdl7uGYL8HS9l19y9GS(enumerator))
										{
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
											{
												num4 = 0;
											}
											goto IL_018c;
										}
										goto IL_0219;
										IL_0219:
										enumerable = enumerator.Current.Notify(text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138154820) + text2, eventData);
										num4 = 4;
										goto IL_018c;
										IL_018c:
										while (true)
										{
											switch (num4)
											{
											default:
												list.AddRange(enumerable.Cast<object>());
												num4 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
												{
													num4 = 2;
												}
												continue;
											case 2:
												break;
											case 4:
												if (enumerable != null)
												{
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
													{
														num4 = 0;
													}
													continue;
												}
												break;
											case 1:
												goto IL_0219;
											case 3:
												goto end_IL_01d2;
											}
											break;
										}
										continue;
										end_IL_01d2:
										break;
									}
								}
								finally
								{
									if (enumerator != null)
									{
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											default:
												VVs4A4GYU88ILOk1u6MI(enumerator);
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
												{
													num5 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								break;
							default:
								enumerator = eventBuses.GetEnumerator();
								num3 = 3;
								continue;
							case 4:
								break;
							case 2:
								return;
							}
							eLWlGQGYc87jPT47j62L(_003C_003Ec__DisplayClass3_.invocation, Adjust(list, kAskIKGYsCmNrBFAa35i(sJ20MjGYjBlkJQePFqUG(_003C_003Ec__DisplayClass3_.invocation))));
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
							{
								num3 = 1;
							}
						}
					}
					finally
					{
						notifying.Pop();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
				case 10:
					return;
				case 7:
					if (!EventSettings.Enabled)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					text = (string)fQJwRQGYldsEheDA4og6(zaVfk5GYduwpRDGMVYhc(_003C_003Ec__DisplayClass3_.invocation.get_Method()));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (notifying == null)
					{
						num2 = 11;
						continue;
					}
					goto case 9;
				case 3:
					_003C_003Ec__DisplayClass3_.invocation = invocation;
					num = 7;
					break;
				case 6:
					((ILogger)RmU7waGYgYoo2yVV5vHm()).Error(gmLrwUGY5KCdZhqkpgnE(-3333094 ^ -3590038));
					num2 = 10;
					continue;
				case 1:
					return;
				case 9:
					if (I8TqyuGYrNggSyh9BbAF(notifying) <= 1000)
					{
						notifying.Push(text);
						num2 = 5;
					}
					else
					{
						num2 = 6;
					}
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CInterceptAsync_003Ed__4))]
	public override Task InterceptAsync(IInvocationAsync invocation, CancellationToken cancellationToken)
	{
		int num = 5;
		_003CInterceptAsync_003Ed__4 stateMachine = default(_003CInterceptAsync_003Ed__4);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					stateMachine._003C_003E1__state = -1;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					stateMachine.cancellationToken = cancellationToken;
					num2 = 3;
					continue;
				case 5:
					stateMachine._003C_003E4__this = this;
					num2 = 4;
					continue;
				default:
					_003C_003Et__builder.Start(ref stateMachine);
					num = 2;
					break;
				case 3:
					stateMachine._003C_003Et__builder = cyh8mZGYzLZGo1SSiQon();
					num = 6;
					break;
				case 2:
					return stateMachine._003C_003Et__builder.Task;
				case 1:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					stateMachine.invocation = invocation;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	private object Adjust(IEnumerable results, Type returnType)
	{
		//Discarded unreachable code: IL_00c7, IL_00d6, IL_00e6, IL_0105, IL_0114, IL_0123
		int num = 9;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (!zdBUedGLBBv542sUhEFQ(returnType, TypeOf<System.Threading.Tasks.ValueTask>.Raw))
				{
					num2 = 2;
					break;
				}
				goto case 3;
			case 9:
				if (zdBUedGLBBv542sUhEFQ(returnType, sc32O8GLFc0rC8etH7am(typeof(void).TypeHandle)))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 6;
			case 6:
				if (zdBUedGLBBv542sUhEFQ(returnType, TypeOf<Task>.Raw))
				{
					num2 = 3;
					break;
				}
				goto default;
			case 1:
				if (!zdBUedGLBBv542sUhEFQ(results.GetType(), returnType))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 2:
				if (results == null)
				{
					num2 = 7;
					break;
				}
				goto case 1;
			case 3:
			case 5:
			case 7:
			case 8:
				return results;
			case 4:
			{
				object obj = pSBekEGLbvu1PBPFjI7x(sc32O8GLFc0rC8etH7am(typeof(Enumerable).TypeHandle), gmLrwUGY5KCdZhqkpgnE(-1217523399 ^ -1217786369), (kPZyaOGLooxnuwF0Pnrv(returnType, QQ0iKGGLWx7EJ9ofYEiw(TypeOf.Task1)) || kPZyaOGLooxnuwF0Pnrv(returnType, QQ0iKGGLWx7EJ9ofYEiw(TypeOf.ValueTask1))) ? returnType.GetGenericArguments()[0].GetGenericArguments() : returnType.GetGenericArguments(), new Type[1] { typeof(IEnumerable) }, sc32O8GLFc0rC8etH7am(typeof(IEnumerable<>).TypeHandle));
				object[] array = new IEnumerable[1] { results };
				return utpmPeGLhTf0PlVVhHUI(obj, null, array);
			}
			}
		}
	}

	static EventsInterceptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				notifyingAsyncLocal = new AsyncLocal<Stack<string>>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 1:
				miOONlGLG7nUdiobF93s();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Type zaVfk5GYduwpRDGMVYhc(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static object fQJwRQGYldsEheDA4og6(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static int I8TqyuGYrNggSyh9BbAF(object P_0)
	{
		return ((Stack<string>)P_0).Count;
	}

	internal static object RmU7waGYgYoo2yVV5vHm()
	{
		return Logger.Log;
	}

	internal static object gmLrwUGY5KCdZhqkpgnE(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object sJ20MjGYjBlkJQePFqUG(object P_0)
	{
		return ((IInvocation)P_0).get_Method();
	}

	internal static object l7i4e2GYY682ljafaIA9(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static bool PDdl7uGYL8HS9l19y9GS(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void VVs4A4GYU88ILOk1u6MI(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Type kAskIKGYsCmNrBFAa35i(object P_0)
	{
		return ((MethodInfo)P_0).ReturnType;
	}

	internal static void eLWlGQGYc87jPT47j62L(object P_0, object P_1)
	{
		((IInvocation)P_0).set_ReturnValue(P_1);
	}

	internal static bool U05IaKGYJea5rVo9M9Dg()
	{
		return kKT63oGYMTXqZUCH6bMI == null;
	}

	internal static EventsInterceptor xrWvpTGY9T54NC5cpMZ4()
	{
		return kKT63oGYMTXqZUCH6bMI;
	}

	internal static AsyncTaskMethodBuilder cyh8mZGYzLZGo1SSiQon()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static Type sc32O8GLFc0rC8etH7am(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool zdBUedGLBBv542sUhEFQ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type QQ0iKGGLWx7EJ9ofYEiw(object P_0)
	{
		return ((RipeType)P_0).Raw;
	}

	internal static bool kPZyaOGLooxnuwF0Pnrv(Type type, Type genericType)
	{
		return type.IsAssignableToGenericType(genericType);
	}

	internal static object pSBekEGLbvu1PBPFjI7x(Type t, object P_1, object P_2, object P_3, Type returnType)
	{
		return t.GetGenericMethod((string)P_1, (Type[])P_2, (Type[])P_3, returnType);
	}

	internal static object utpmPeGLhTf0PlVVhHUI(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static void miOONlGLG7nUdiobF93s()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
