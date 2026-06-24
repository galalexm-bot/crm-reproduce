using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.UI.FeatureFlags.Components;

[Component]
internal sealed class ComponentMetadataItemUIRuntimeVersionChecker : IUIRuntimeVersionChecker
{
	private readonly ISessionProvider sessionProvider;

	private RuntimeVersion? result;

	private ISession session;

	private static ComponentMetadataItemUIRuntimeVersionChecker Y6L9NvBZETewM3K4gNxC;

	private ISession Session
	{
		get
		{
			int num = 2;
			int num2 = num;
			ISession obj;
			ISession val = default(ISession);
			while (true)
			{
				switch (num2)
				{
				case 2:
					obj = session;
					if (obj == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 1:
					val = (session = sessionProvider.GetSession(""));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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

	public ComponentMetadataItemUIRuntimeVersionChecker(ISessionProvider sessionProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vvmYUgBZC1qHyxvjlZIf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
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
				this.sessionProvider = sessionProvider;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public RuntimeVersion CheckRuntimeVersion()
	{
		int num = 3;
		int num2 = num;
		RuntimeVersion? runtimeVersion = default(RuntimeVersion?);
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return runtimeVersion.Value;
			case 2:
				return result.Value;
			case 3:
				if (!result.HasValue)
				{
					num3 = hDO7VnBZuvGQhQNhkRaY(((ICriteria)EawC9aBZZmN4TW8mKflV(Session.CreateCriteria<ComponentMetadataItem>(), new IProjection[1] { (IProjection)CA0JNVBZ8hi5VTTHLvFn(jPlXFjBZviZ6DoN9yw8n()) })).UniqueResult());
					num2 = 4;
				}
				else
				{
					num2 = 2;
				}
				break;
			default:
				runtimeVersion = runtimeVersion;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				runtimeVersion = (result = ((num3 > 0) ? RuntimeVersion.Version2 : RuntimeVersion.Version1));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void vvmYUgBZC1qHyxvjlZIf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool DJHyvPBZfh6lu1XK2y3P()
	{
		return Y6L9NvBZETewM3K4gNxC == null;
	}

	internal static ComponentMetadataItemUIRuntimeVersionChecker jnfEJQBZQCp8II0OpJf2()
	{
		return Y6L9NvBZETewM3K4gNxC;
	}

	internal static object jPlXFjBZviZ6DoN9yw8n()
	{
		return Projections.Id();
	}

	internal static object CA0JNVBZ8hi5VTTHLvFn(object P_0)
	{
		return Projections.Count((IProjection)P_0);
	}

	internal static object EawC9aBZZmN4TW8mKflV(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static long hDO7VnBZuvGQhQNhkRaY(object P_0)
	{
		return Convert.ToInt64(P_0);
	}
}
