using System;
using System.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Class)]
public class ServiceAttribute : Attribute
{
	private bool injectProerties;

	private ServiceScope scope;

	private bool enableInterceptors;

	private ComponentType type;

	private static ServiceAttribute J1eXcufZr7KWWODZZI4Z;

	[DefaultValue(true)]
	public bool InjectProperties
	{
		get
		{
			return injectProerties;
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
				case 1:
					injectProerties = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[DefaultValue(ServiceScope.Application)]
	public ServiceScope Scope
	{
		get
		{
			return scope;
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
				case 1:
					scope = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[DefaultValue(true)]
	public bool EnableInterceptors
	{
		get
		{
			return enableInterceptors;
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
				case 1:
					enableInterceptors = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[DefaultValue(ComponentType.All)]
	public ComponentType Type
	{
		get
		{
			return type;
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
					type = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ServiceAttribute()
	{
		//Discarded unreachable code: IL_005e, IL_0063
		SingletonReader.JJCZtPuTvSt();
		injectProerties = true;
		scope = ServiceScope.Application;
		enableInterceptors = true;
		type = ComponentType.All;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool vbYHvBfZgmaRVcrTrlWt()
	{
		return J1eXcufZr7KWWODZZI4Z == null;
	}

	internal static ServiceAttribute lbPG1tfZ5XdjEcODi4rH()
	{
		return J1eXcufZr7KWWODZZI4Z;
	}
}
