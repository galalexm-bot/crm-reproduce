using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Security.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Diagrams.Elements;

[Serializable]
[Shape(typeof(PositionShape))]
public class PositionElement : OrganizationElement
{
	private static PositionElement zIWARrH6EisX8kZhZac;

	public bool IsChief
	{
		[CompilerGenerated]
		get
		{
			return _003CIsChief_003Ek__BackingField;
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
					_003CIsChief_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
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

	public override void InitNew()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ho1PVNHZMH3hhJoL3a5(this);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				base.EmployeeCount = (string)DfgyfOHxtQtZub4ggxZ(0x738E3073 ^ 0x738E3FDB);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public PositionElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		r9tAdjHBiPWWlo4o6VJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Hr2UDJHlJsAKQWjUkof()
	{
		return zIWARrH6EisX8kZhZac == null;
	}

	internal static PositionElement chxxOSHNlUPG3ilUtmW()
	{
		return zIWARrH6EisX8kZhZac;
	}

	internal static void ho1PVNHZMH3hhJoL3a5(object P_0)
	{
		((Element)P_0).InitNew();
	}

	internal static object DfgyfOHxtQtZub4ggxZ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void r9tAdjHBiPWWlo4o6VJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
