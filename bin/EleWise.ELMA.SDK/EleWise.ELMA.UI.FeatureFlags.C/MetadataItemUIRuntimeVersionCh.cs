using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.FeatureFlags.Components;

[Component]
internal sealed class MetadataItemUIRuntimeVersionChecker : IUIRuntimeVersionChecker
{
	private readonly ISessionProvider sessionProvider;

	private RuntimeVersion? result;

	private ISession session;

	private static MetadataItemUIRuntimeVersionChecker q24lPXBZDXgLZwsU0XbD;

	private ISession Session
	{
		get
		{
			int num = 2;
			int num2 = num;
			ISession val = default(ISession);
			ISession obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					val = (session = (ISession)FujQVABZyS4VbfGUXdmo(sessionProvider, ""));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = session;
					if (obj != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = val;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public MetadataItemUIRuntimeVersionChecker(ISessionProvider sessionProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YvVWpHBZ4ctgBvYREEPi();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
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
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num = 1;
			}
		}
	}

	public RuntimeVersion CheckRuntimeVersion()
	{
		//Discarded unreachable code: IL_0047, IL_0056
		int num = 5;
		int num2 = num;
		RuntimeVersion? runtimeVersion = default(RuntimeVersion?);
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 2:
				runtimeVersion = runtimeVersion;
				num2 = 3;
				break;
			case 3:
				return runtimeVersion.Value;
			case 1:
				return result.Value;
			case 4:
				num3 = xJ9bAiBZmNprfCpdi4dT(sQqTXdBZ0dTH6cpVGsWl(dWPrl8BZxk3Ef4B7BtEg(aiIJ4EBZHayxlQ4RyeOC(Session.CreateCriteria<IMetadataItem>(), tAIRVEBZ6Ax4FsbbXnSL(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7ECE0E9))), new IProjection[1] { (IProjection)J5uk6OBZ7felwxU9AN5a(X9IrRJBZAxyInxBgAbwM()) })));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (!result.HasValue)
				{
					num2 = 4;
					break;
				}
				goto case 1;
			default:
				runtimeVersion = (result = ((num3 > 0) ? RuntimeVersion.Version2 : RuntimeVersion.Version1));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void YvVWpHBZ4ctgBvYREEPi()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FmuAcQBZtAPVxi6GTs4s()
	{
		return q24lPXBZDXgLZwsU0XbD == null;
	}

	internal static MetadataItemUIRuntimeVersionChecker bNelFQBZwdCjk9kbmeS2()
	{
		return q24lPXBZDXgLZwsU0XbD;
	}

	internal static object tAIRVEBZ6Ax4FsbbXnSL(object P_0)
	{
		return Restrictions.IsNotNull((string)P_0);
	}

	internal static object aiIJ4EBZHayxlQ4RyeOC(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object X9IrRJBZAxyInxBgAbwM()
	{
		return Projections.Id();
	}

	internal static object J5uk6OBZ7felwxU9AN5a(object P_0)
	{
		return Projections.Count((IProjection)P_0);
	}

	internal static object dWPrl8BZxk3Ef4B7BtEg(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static object sQqTXdBZ0dTH6cpVGsWl(object P_0)
	{
		return ((ICriteria)P_0).UniqueResult();
	}

	internal static long xJ9bAiBZmNprfCpdi4dT(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object FujQVABZyS4VbfGUXdmo(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}
}
