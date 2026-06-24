using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Components;

[Component(Type = ComponentType.Server, Order = int.MaxValue)]
internal sealed class SystemComponentContainerEvents : IModuleContainerEvents
{
	internal static SystemComponentContainerEvents fJfXqofGuKy52pyQsS9H;

	public void Activated()
	{
		//Discarded unreachable code: IL_0083, IL_0092, IL_00f2, IL_0101, IL_019a, IL_01d2, IL_01e1
		int num = 2;
		ComponentMetadataItemManager instance2 = default(ComponentMetadataItemManager);
		ComponentMetadataItemHeaderManager instance = default(ComponentMetadataItemHeaderManager);
		IEnumerator<ISystemComponentCreator> enumerator = default(IEnumerator<ISystemComponentCreator>);
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					instance2 = ComponentMetadataItemManager.Instance;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					instance = ComponentMetadataItemHeaderManager.Instance;
					num2 = 3;
					continue;
				case 3:
					break;
				case 4:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num3 = 5;
								}
								goto IL_00a1;
							}
							goto IL_0139;
							IL_0139:
							componentMetadataItem = (ComponentMetadataItem)CKOWPJfGS7RofMjEMhoA(enumerator.Current);
							num3 = 4;
							goto IL_00a1;
							IL_00a1:
							while (true)
							{
								switch (num3)
								{
								case 5:
									return;
								case 2:
								case 6:
									break;
								default:
									eH4xgffGqJdpsNme1brT(instance, VCDyMofGRqMXSIpMqVYQ(componentMetadataItem));
									num3 = 6;
									continue;
								case 4:
									if (componentMetadataItem == null)
									{
										int num4 = 2;
										num3 = num4;
										continue;
									}
									goto case 3;
								case 1:
									goto IL_0139;
								case 3:
									AATQTBfGi8A5ft8UMdvO(instance2, componentMetadataItem);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									xGionNfGKf7J78v2mhtt(enumerator);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
				break;
			}
			enumerator = Locator.GetServiceNotNull<IEnumerable<ISystemComponentCreator>>().GetEnumerator();
			num = 4;
		}
	}

	public void Terminating()
	{
	}

	public SystemComponentContainerEvents()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		X11KHSfGXPcdMsW9as0l();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object CKOWPJfGS7RofMjEMhoA(object P_0)
	{
		return ((ISystemComponentCreator)P_0).Create();
	}

	internal static void AATQTBfGi8A5ft8UMdvO(object P_0, object P_1)
	{
		((ComponentMetadataItemManager)P_0).AddSystemComponent((ComponentMetadataItem)P_1);
	}

	internal static object VCDyMofGRqMXSIpMqVYQ(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Header;
	}

	internal static void eH4xgffGqJdpsNme1brT(object P_0, object P_1)
	{
		((ComponentMetadataItemHeaderManager)P_0).AddSystemComponent((ComponentMetadataItemHeader)P_1);
	}

	internal static void xGionNfGKf7J78v2mhtt(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool sfgQ2FfGIpigGYb6ikqD()
	{
		return fJfXqofGuKy52pyQsS9H == null;
	}

	internal static SystemComponentContainerEvents T65gL7fGVybJVbSIqZLH()
	{
		return fJfXqofGuKy52pyQsS9H;
	}

	internal static void X11KHSfGXPcdMsW9as0l()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
