using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

[Service]
public class ExpirationInfoService
{
	private ModuleManager moduleManager;

	private IEnumerable<ModuleManager.StoreComponentConfigurationInfo> components;

	private static ExpirationInfoService _expirationInfoService;

	internal static ExpirationInfoService NxwgwFBwtk8A9EsZ1a8h;

	internal ModuleManager ModuleManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			ModuleManager obj;
			ModuleManager moduleManager = default(ModuleManager);
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = this.moduleManager;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					moduleManager = (this.moduleManager = Pun1eSBwHaPQPr8qDJQX(nvQhmlBw6RB4xRYyTWlm()) as ModuleManager);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					obj = moduleManager;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public static ExpirationInfoService Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			ExpirationInfoService expirationInfoService;
			while (true)
			{
				switch (num2)
				{
				case 1:
					expirationInfoService = _expirationInfoService;
					if (expirationInfoService != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					expirationInfoService = (_expirationInfoService = Locator.GetServiceNotNull<ExpirationInfoService>());
					break;
				}
				break;
			}
			return expirationInfoService;
		}
	}

	public PackageService PackageService
	{
		[CompilerGenerated]
		get
		{
			return _003CPackageService_003Ek__BackingField;
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
					_003CPackageService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime? GetExpirationDate(IStoreComponentInfo info)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.info = info;
		DateTime? result = null;
		if (CS_0024_003C_003E8__locals0.info != null)
		{
			ILicenseInfo licenseInfo = CS_0024_003C_003E8__locals0.info.LicensedUnit?.GetLicenseInfo();
			if (licenseInfo == null)
			{
				if (components == null)
				{
					components = ModuleManager.GetInstalledComponentInfos();
				}
				licenseInfo = components.FirstOrDefault((ModuleManager.StoreComponentConfigurationInfo x) => string.Equals(x.Id, (string)_003C_003Ec__DisplayClass11_0.ETk4gvQXm3yXvHNxbQWa(CS_0024_003C_003E8__locals0.info)))?.LicensedUnit?.GetLicenseInfo();
			}
			return (licenseInfo is ITrialLicenseInfo trialLicenseInfo && trialLicenseInfo.TrialExpiration.HasValue) ? new DateTime?(trialLicenseInfo.TrialExpiration.Value) : null;
		}
		return result;
	}

	[IteratorStateMachine(typeof(_003CGetExpiringComponents_003Ed__12))]
	public IEnumerable<IStoreComponentInfo> GetExpiringComponents(int daysBeforExp)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetExpiringComponents_003Ed__12(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__daysBeforExp = daysBeforExp
		};
	}

	public ExpirationInfoService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		N5yhkrBwAYQKqGk9Fp8h();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object nvQhmlBw6RB4xRYyTWlm()
	{
		return ComponentManager.Current;
	}

	internal static object Pun1eSBwHaPQPr8qDJQX(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static bool e7xt5ZBwwRRBFE7SYXe5()
	{
		return NxwgwFBwtk8A9EsZ1a8h == null;
	}

	internal static ExpirationInfoService NNd6pxBw4MtKrjaDbomO()
	{
		return NxwgwFBwtk8A9EsZ1a8h;
	}

	internal static void N5yhkrBwAYQKqGk9Fp8h()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
