using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class CompositeEntityPartAttribute : Attribute
{
	private Type entityType;

	private int tableNumber;

	internal static CompositeEntityPartAttribute AU0RQjouG2bGCdnuiLAI;

	public Type EntityType => entityType;

	public int TableNumber => tableNumber;

	public CompositeEntityPartAttribute(Type entityType, int tableNumber)
	{
		//Discarded unreachable code: IL_002a
		WNvbXAouQZNXFCdohLNA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				this.tableNumber = tableNumber;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			default:
			{
				this.entityType = entityType;
				int num2 = 2;
				num = num2;
				break;
			}
			}
		}
	}

	internal static void WNvbXAouQZNXFCdohLNA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rh3TWuouEP2ASOPEx3rZ()
	{
		return AU0RQjouG2bGCdnuiLAI == null;
	}

	internal static CompositeEntityPartAttribute vg0WYuoufOpyY55AQVDi()
	{
		return AU0RQjouG2bGCdnuiLAI;
	}
}
