using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Managers;

[Component(Type = ComponentType.WebServer)]
public class WebHostEnvironmentManager : DTOManager, IWebHostEnvironmentManager, IConfigurationService
{
	private Guid hostSessionUid;

	private static WebHostEnvironmentManager Gm4MoEWMLA5926aouQ3b;

	public IWebHostEnvironmentService WebHostEnvironmentService
	{
		[CompilerGenerated]
		get
		{
			return _003CWebHostEnvironmentService_003Ek__BackingField;
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
				case 1:
					_003CWebHostEnvironmentService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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

	public virtual void RestartHost()
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					return;
				case 3:
					if (WebHostEnvironmentService != null)
					{
						break;
					}
					goto end_IL_0012;
				}
				WebHostEnvironmentService.RestartHost();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public virtual Guid GetHostSessionUid()
	{
		return hostSessionUid;
	}

	public WebHostEnvironmentManager()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		hostSessionUid = PJW5DZWMcoyBBII4KIeI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool yS9232WMUaBc325qO38w()
	{
		return Gm4MoEWMLA5926aouQ3b == null;
	}

	internal static WebHostEnvironmentManager ml5BdhWMs1Xs4aoDoVZr()
	{
		return Gm4MoEWMLA5926aouQ3b;
	}

	internal static Guid PJW5DZWMcoyBBII4KIeI()
	{
		return Guid.NewGuid();
	}
}
