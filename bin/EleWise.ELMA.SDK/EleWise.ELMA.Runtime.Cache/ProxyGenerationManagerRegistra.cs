using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Properties;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Cache;

[Component(Type = ComponentType.Test, InjectProerties = true)]
internal sealed class ProxyGenerationManagerRegistrar : INHManagerRegistrar
{
	private static ProxyGenerationManagerRegistrar EfxrrWW2c2XpdvUMvIbQ;

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void Register(NHManagerRegisterParams parameters)
	{
		//Discarded unreachable code: IL_0072, IL_0081
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					((ModelRegistrarImpl)L244MZWeQALKBsTcL5vT((ILicensedModuleAssembly)vIKBDZWef9GtZvUN2Mlt(ICFs2lWeGEmFXyUZPpYY(ENHTCYWehNJRL0UyTEtP()), t831BaWeEitnfm6VdHDx()))).RegisterEntityManagers(parameters, null);
					num2 = 5;
					continue;
				case 3:
					return;
				case 5:
					return;
				case 1:
				{
					IRuntimeApplication runtimeApplication = RuntimeApplication;
					if (runtimeApplication == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					object obj2 = pycfI1WeBXSGvfVsLA2f(runtimeApplication);
					if (obj2 == null)
					{
						break;
					}
					object obj3 = sZXHx9WeW4QAkusopwpC(obj2);
					if (obj3 == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 3;
						}
						continue;
					}
					obj = cbnArPWeou5Ka7JWMqCx(obj3).FullName;
					goto IL_0119;
				}
				default:
					obj = null;
					goto IL_0119;
				case 4:
					obj = null;
					goto IL_0119;
				case 6:
					{
						obj = null;
						goto IL_0119;
					}
					IL_0119:
					if (!((string)obj == (string)NOnwmoWebUrxByw8juZx(0x1A33FE36 ^ 0x1A31F6B8)))
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				}
				break;
			}
			num = 4;
		}
	}

	public ProxyGenerationManagerRegistrar()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		myf6RnWeC6QteXQHlq9l();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rVB8kYW2zsGqtigXFUDY()
	{
		return EfxrrWW2c2XpdvUMvIbQ == null;
	}

	internal static ProxyGenerationManagerRegistrar BeB4H8WeF5W2p59VE8h4()
	{
		return EfxrrWW2c2XpdvUMvIbQ;
	}

	internal static object pycfI1WeBXSGvfVsLA2f(object P_0)
	{
		return ((IRuntimeApplication)P_0).TransformationProvider;
	}

	internal static object sZXHx9WeW4QAkusopwpC(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static Type cbnArPWeou5Ka7JWMqCx(object P_0)
	{
		return P_0.GetType();
	}

	internal static object NOnwmoWebUrxByw8juZx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ENHTCYWehNJRL0UyTEtP()
	{
		return ComponentManager.Current;
	}

	internal static object ICFs2lWeGEmFXyUZPpYY(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static Guid t831BaWeEitnfm6VdHDx()
	{
		return __AssemblyInfo.UID;
	}

	internal static object vIKBDZWef9GtZvUN2Mlt(object P_0, Guid uid)
	{
		return ((IModuleManager)P_0).FindUnitByUid(uid);
	}

	internal static object L244MZWeQALKBsTcL5vT(object P_0)
	{
		return ((ILicensedModuleAssembly)P_0).LicenseUnit;
	}

	internal static void myf6RnWeC6QteXQHlq9l()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
