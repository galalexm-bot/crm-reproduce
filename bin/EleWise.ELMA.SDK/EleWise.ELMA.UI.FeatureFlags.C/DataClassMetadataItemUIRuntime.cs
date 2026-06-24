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
internal sealed class DataClassMetadataItemUIRuntimeVersionChecker : IUIRuntimeVersionChecker
{
	private readonly ISessionProvider sessionProvider;

	private RuntimeVersion? result;

	private ISession session;

	internal static DataClassMetadataItemUIRuntimeVersionChecker lRgEj5BZIkbnvnUjaiFl;

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
					val = (session = sessionProvider.GetSession(""));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 1;
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

	public DataClassMetadataItemUIRuntimeVersionChecker(ISessionProvider sessionProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kdnj6RBZiytyxUni1aBL();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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
		//Discarded unreachable code: IL_00ce, IL_00dd
		int num = 2;
		int num2 = num;
		long num3 = default(long);
		RuntimeVersion? runtimeVersion = default(RuntimeVersion?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return result.Value;
			case 1:
				num3 = xW6o7rBZKNYGPhBuLWoP(((ICriteria)LbjEegBZqbY6kO2bmuKp(Session.CreateCriteria<DataClassMetadataItem>(), new IProjection[1] { (IProjection)Kd8lEoBZRWVlZAEw0BZA(Projections.Id()) })).UniqueResult());
				num2 = 4;
				break;
			default:
				return runtimeVersion.Value;
			case 5:
				runtimeVersion = runtimeVersion;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!result.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 4:
				runtimeVersion = (result = ((num3 > 0) ? RuntimeVersion.Version2 : RuntimeVersion.Version1));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void kdnj6RBZiytyxUni1aBL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Xavo7ZBZVfBIfni9hWL3()
	{
		return lRgEj5BZIkbnvnUjaiFl == null;
	}

	internal static DataClassMetadataItemUIRuntimeVersionChecker jO7LhNBZSiGI36brNKpo()
	{
		return lRgEj5BZIkbnvnUjaiFl;
	}

	internal static object Kd8lEoBZRWVlZAEw0BZA(object P_0)
	{
		return Projections.Count((IProjection)P_0);
	}

	internal static object LbjEegBZqbY6kO2bmuKp(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static long xW6o7rBZKNYGPhBuLWoP(object P_0)
	{
		return Convert.ToInt64(P_0);
	}
}
