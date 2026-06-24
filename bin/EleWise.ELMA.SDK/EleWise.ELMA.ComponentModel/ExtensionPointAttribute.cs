using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Interface)]
public class ExtensionPointAttribute : Attribute
{
	private readonly bool createInstance;

	private readonly ServiceScope serviceScope;

	private readonly ComponentType type;

	internal static ExtensionPointAttribute rXEhcCfuW0ZPBajlZAAP;

	public bool CreateInstance => createInstance;

	public ServiceScope ServiceScope => serviceScope;

	public ComponentType Type => type;

	public bool ForceRegister
	{
		[CompilerGenerated]
		get
		{
			return _003CForceRegister_003Ek__BackingField;
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
					_003CForceRegister_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ExtensionPointAttribute(ComponentType type = ComponentType.All)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		iCQQQlfuhPIJNU2mBMIi();
		this._002Ector(createInstance: true, type);
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

	public ExtensionPointAttribute(bool createInstance, ComponentType type = ComponentType.All, ServiceScope scope = ServiceScope.Application)
	{
		//Discarded unreachable code: IL_0052, IL_0057
		iCQQQlfuhPIJNU2mBMIi();
		this.createInstance = true;
		serviceScope = ServiceScope.Application;
		this.type = ComponentType.All;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 2:
				this.type = type;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				serviceScope = scope;
				num = 3;
				break;
			default:
				this.createInstance = createInstance;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public ExtensionPointAttribute(ServiceScope serviceScope, ComponentType type = ComponentType.All)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		iCQQQlfuhPIJNU2mBMIi();
		this._002Ector(createInstance: true, type);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
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
				this.serviceScope = serviceScope;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void iCQQQlfuhPIJNU2mBMIi()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool NJtcIufuoB06dTPDMDC6()
	{
		return rXEhcCfuW0ZPBajlZAAP == null;
	}

	internal static ExtensionPointAttribute U0IndlfubRJCp2WQaZnR()
	{
		return rXEhcCfuW0ZPBajlZAAP;
	}
}
