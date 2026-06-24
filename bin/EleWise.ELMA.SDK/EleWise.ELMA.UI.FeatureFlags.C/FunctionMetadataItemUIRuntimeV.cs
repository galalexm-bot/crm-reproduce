using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.UI.FeatureFlags.Components;

[Component]
internal sealed class FunctionMetadataItemUIRuntimeVersionChecker : IUIRuntimeVersionChecker
{
	private readonly ISessionProvider sessionProvider;

	private RuntimeVersion? result;

	private ISession session;

	internal static FunctionMetadataItemUIRuntimeVersionChecker qB5boLBZXMMdZlSjSmj4;

	private ISession Session
	{
		get
		{
			int num = 1;
			int num2 = num;
			ISession val = default(ISession);
			ISession obj;
			while (true)
			{
				switch (num2)
				{
				default:
					val = (session = (ISession)hBwJDqBZNAcTGoonsCrA(sessionProvider, ""));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = session;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = val;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public FunctionMetadataItemUIRuntimeVersionChecker(ISessionProvider sessionProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IVlRtuBZn7r4Sww8KKpA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.sessionProvider = sessionProvider;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
			{
				num = 0;
			}
		}
	}

	public RuntimeVersion CheckRuntimeVersion()
	{
		int num = 2;
		int num2 = num;
		RuntimeVersion? runtimeVersion = default(RuntimeVersion?);
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return result.Value;
			default:
				runtimeVersion = runtimeVersion;
				num2 = 4;
				break;
			case 2:
				if (!result.HasValue)
				{
					num3 = GWmxPtBZ1uEGkftY1O0j(OmUuA0BZPYBSHhuSwKUg(l80IYoBZeWBRL4gt2mvS(Session.CreateCriteria<FunctionMetadataItem>(), new IProjection[1] { (IProjection)VSgq2fBZ2Ds1ERvr2eKm(Tghq4UBZOx4mxlusaCF8()) })));
					num2 = 3;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return runtimeVersion.Value;
			case 3:
				runtimeVersion = (result = ((num3 > 0) ? RuntimeVersion.Version2 : RuntimeVersion.Version1));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void IVlRtuBZn7r4Sww8KKpA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool cao9eTBZTKilWlbkgd8V()
	{
		return qB5boLBZXMMdZlSjSmj4 == null;
	}

	internal static FunctionMetadataItemUIRuntimeVersionChecker Gn1l7pBZkbt69F5CqZWY()
	{
		return qB5boLBZXMMdZlSjSmj4;
	}

	internal static object Tghq4UBZOx4mxlusaCF8()
	{
		return Projections.Id();
	}

	internal static object VSgq2fBZ2Ds1ERvr2eKm(object P_0)
	{
		return Projections.Count((IProjection)P_0);
	}

	internal static object l80IYoBZeWBRL4gt2mvS(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static object OmUuA0BZPYBSHhuSwKUg(object P_0)
	{
		return ((ICriteria)P_0).UniqueResult();
	}

	internal static long GWmxPtBZ1uEGkftY1O0j(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object hBwJDqBZNAcTGoonsCrA(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}
}
