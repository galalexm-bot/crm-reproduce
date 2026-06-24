using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class NHCastExtensions
{
	private static NHCastExtensions TZ9GApGAZwZyyvCjYIcS;

	public static T CastAs<T>(this object source)
	{
		return (T)source.CastAs(typeof(T));
	}

	public static object CastAs(this object source, Type neededType)
	{
		//Discarded unreachable code: IL_00d9, IL_00e8
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ApplicationException(string.Format((string)XdoYPJGARP0moUjbrmnM(0x103FE975 ^ 0x103BEC0F), hU1bcTGAq8pZfZxBa8cY(type), hU1bcTGAq8pZfZxBa8cY(neededType)));
			case 5:
				return MABoo2GAXnwiB5YbQe5j(CltCXWGAKxtiEwO2B3My((object)(INHibernateProxy)source));
			case 1:
				if (neededType.IsAssignableFrom(type))
				{
					num2 = 5;
					break;
				}
				goto default;
			case 3:
				type = BpmPNfGASs7blFdjo7xw(source);
				num2 = 2;
				break;
			case 2:
				if (p5ya8BGAiB7OweH6qQgg(type, neededType))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 4:
				if (!afjCGbGAVbibEf3KDsiV(source))
				{
					return source;
				}
				num2 = 3;
				break;
			}
		}
	}

	public static T CastAsRealType<T>(this T source)
	{
		return (T)((object)source).CastAsRealType();
	}

	public static object CastAsRealType(this object source)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return source;
			case 1:
				if (afjCGbGAVbibEf3KDsiV(source))
				{
					return MABoo2GAXnwiB5YbQe5j(CltCXWGAKxtiEwO2B3My((object)(INHibernateProxy)source));
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Type GetTypeWithoutProxy(this Type type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!zp4INMGATfPwfZMXVe3u(type))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return type.BaseType;
			default:
				return type;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CCastAsRealTypeAsync_003Ed__5<>))]
	public static Task<T> CastAsRealTypeAsync<T>(this T source, CancellationToken token)
	{
		_003CCastAsRealTypeAsync_003Ed__5<T> stateMachine = default(_003CCastAsRealTypeAsync_003Ed__5<T>);
		stateMachine.source = source;
		stateMachine.token = token;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<T> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCastAsRealTypeAsync_003Ed__6))]
	public static Task<object> CastAsRealTypeAsync(this object source, CancellationToken token)
	{
		_003CCastAsRealTypeAsync_003Ed__6 stateMachine = default(_003CCastAsRealTypeAsync_003Ed__6);
		stateMachine.source = source;
		stateMachine.token = token;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool afjCGbGAVbibEf3KDsiV(object P_0)
	{
		return NHibernateProxyHelper.IsProxy(P_0);
	}

	internal static Type BpmPNfGASs7blFdjo7xw(object P_0)
	{
		return NHibernateUtil.GetClass(P_0);
	}

	internal static bool p5ya8BGAiB7OweH6qQgg(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object XdoYPJGARP0moUjbrmnM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hU1bcTGAq8pZfZxBa8cY(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object CltCXWGAKxtiEwO2B3My(object P_0)
	{
		return ((INHibernateProxy)P_0).get_HibernateLazyInitializer();
	}

	internal static object MABoo2GAXnwiB5YbQe5j(object P_0)
	{
		return ((ILazyInitializer)P_0).GetImplementation();
	}

	internal static bool a7wkAiGAuPMNwIcnWjkI()
	{
		return TZ9GApGAZwZyyvCjYIcS == null;
	}

	internal static NHCastExtensions XIoF1lGAI77rV9WXV8Dk()
	{
		return TZ9GApGAZwZyyvCjYIcS;
	}

	internal static bool zp4INMGATfPwfZMXVe3u(Type type)
	{
		return type.IsProxy();
	}
}
