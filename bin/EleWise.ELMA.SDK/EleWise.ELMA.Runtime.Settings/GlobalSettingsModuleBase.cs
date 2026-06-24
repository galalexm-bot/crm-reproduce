using System;
using System.Collections.Generic;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Settings;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public abstract class GlobalSettingsModuleBase<TSettings> : IGlobalSettingsGroupModule, IGlobalSettingsModule, IGlobalSettingsModulePermission where TSettings : GlobalSettingsBase, new()
{
	protected TSettings _settings;

	private ICacheService _cacheService;

	private string _cacheKey;

	private string _timestamp;

	private static object ERGUHmWhrv1t5tcwEGeq;

	public virtual string ModuleNamespace
	{
		get
		{
			int num = 2;
			int num2 = num;
			IModule module = default(IModule);
			while (true)
			{
				switch (num2)
				{
				default:
					return module.Id;
				case 2:
					module = ComponentManager.Current.ModuleManager.FindModuleByAssembly(GetType().Assembly);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (module == null)
					{
						return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867198071);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public abstract string ModuleName { get; }

	public virtual Permission AdminPermission => CommonPermissions.AdminPermission;

	public virtual string GroupName => string.Empty;

	public virtual TSettings Settings
	{
		get
		{
			string text = ((CacheService != null) ? CacheService.Get<string>(_cacheKey, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108683276)) : null);
			if (_timestamp != text || _settings == null)
			{
				LoadSettings();
				_timestamp = text;
			}
			return _settings;
		}
		set
		{
			_settings = value;
		}
	}

	public abstract Guid ModuleGuid { get; }

	object IGlobalSettingsModule.Settings
	{
		get
		{
			return Settings;
		}
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
					Settings = (TSettings)value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected ICacheService CacheService
	{
		get
		{
			//Discarded unreachable code: IL_005d, IL_006c
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 2:
					return _cacheService;
				case 3:
					if (_cacheService != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
				_cacheService = Locator.GetServiceNotNull<ICacheService>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	public virtual void SaveSettings()
	{
		int num = 1;
		int num2 = num;
		IDictionary<string, string> storageValues = default(IDictionary<string, string>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				CacheService.Insert(_cacheKey, DateTime.Now.Ticks.ToString(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3C72BA));
				num2 = 4;
				break;
			case 3:
				if (CacheService != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 1:
				storageValues = Settings.GetStorageValues();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				DataAccessManager.SettingsManager.SetStrings(ModuleGuid, storageValues);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				return;
			}
		}
	}

	protected virtual void LoadSettings()
	{
		//Discarded unreachable code: IL_011e
		int num = 6;
		int num2 = num;
		IDictionary<string, string> allStrings = default(IDictionary<string, string>);
		TSettings val2 = default(TSettings);
		while (true)
		{
			TSettings val;
			switch (num2)
			{
			default:
				return;
			case 9:
				allStrings = DataAccessManager.SettingsManager.GetAllStrings(ModuleGuid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				if (allStrings == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 8;
			case 8:
				val2.SetStorageValues(allStrings);
				num2 = 4;
				continue;
			case 4:
				if (val2.GlobalSettingsEventHandler != null)
				{
					num2 = 7;
					continue;
				}
				goto case 2;
			case 0:
				return;
			case 2:
			case 3:
				_settings = val2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				val2.GlobalSettingsEventHandler.LoadSettings(val2);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 2;
				}
				continue;
			case 6:
				val = _settings;
				if (val != null)
				{
					break;
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				val = new TSettings();
				break;
			}
			val2 = val;
			num2 = 9;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
			{
				num2 = 7;
			}
		}
	}

	public virtual void ClearCache()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				_settings = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Locator.GetServiceNotNull<ICacheService>().ClearRegion(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998509314));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			default:
				_timestamp = null;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	protected GlobalSettingsModuleBase()
	{
		//Discarded unreachable code: IL_0059, IL_005e
		SingletonReader.JJCZtPuTvSt();
		_cacheKey = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542694279) + typeof(TSettings).FullName;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool jYEJtPWhg6kjZqTonrmS()
	{
		return ERGUHmWhrv1t5tcwEGeq == null;
	}

	internal static object LIV5lSWh5Vj5Di7O2RCF()
	{
		return ERGUHmWhrv1t5tcwEGeq;
	}
}
