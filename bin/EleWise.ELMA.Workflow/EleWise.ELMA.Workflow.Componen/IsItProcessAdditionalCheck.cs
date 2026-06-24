using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = 100)]
public class IsItProcessAdditionalCheck : IDocumentsAdditionalChecks
{
	internal static IsItProcessAdditionalCheck grQywZOJY4juSTREIr3l;

	public bool IsItNecessaryType(IEntity ent)
	{
		return TRXMDLOJl0nDqXPlVM0s(ent.GetType().FullName, qTX6cEOJJUX8G1PW3Dx7(-682910880 ^ -682912518));
	}

	public object GetFromEntity(IEntity ent)
	{
		//Discarded unreachable code: IL_0102, IL_0111, IL_0165
		int num = 3;
		int num2 = num;
		IEntity entity = default(IEntity);
		IEntity parentOrThis = default(IEntity);
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 4:
				entity = parentOrThis;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!hYfxoFOJy9F08bEokTR7(propertyInfo, null))
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 5;
			case 1:
				parentOrThis = GetParentOrThis(entity);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
				{
					num2 = 6;
				}
				break;
			case 5:
				return AwNyJXOJtSwWAo95vx0O(kVkiQHOJmpYvl3B1R6Lk(propertyInfo, entity, null));
			case 8:
				return ent;
			case 9:
				propertyInfo = (PropertyInfo)FcsD4mOJ0TsdflkZau4b(entity.GetType(), qTX6cEOJJUX8G1PW3Dx7(0x628167BE ^ 0x62813F14));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
			case 7:
				if (parentOrThis == entity)
				{
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 4;
			case 3:
				entity = ent;
				num2 = 2;
				break;
			case 2:
				parentOrThis = GetParentOrThis(entity);
				num2 = 7;
				break;
			}
		}
	}

	private IEntity GetParentOrThis(IEntity ent)
	{
		//Discarded unreachable code: IL_0060
		int num = 4;
		int num2 = num;
		PropertyInfo propertyInfo = default(PropertyInfo);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (hYfxoFOJy9F08bEokTR7(propertyInfo, null))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
					{
						num2 = 0;
					}
					break;
				}
				return ent.CastAsRealType();
			case 2:
				return (IEntity)AwNyJXOJtSwWAo95vx0O(obj);
			case 5:
				return null;
			case 4:
				propertyInfo = (PropertyInfo)FcsD4mOJ0TsdflkZau4b(ent.GetType(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4943A554));
				num2 = 3;
				break;
			case 1:
				if (obj == null)
				{
					num2 = 5;
					break;
				}
				goto case 2;
			default:
				obj = AwNyJXOJtSwWAo95vx0O(propertyInfo.GetValue(ent, null));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public IsItProcessAdditionalCheck()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object qTX6cEOJJUX8G1PW3Dx7(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool TRXMDLOJl0nDqXPlVM0s(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static bool ocikWrOJ8ARlWS09n1G8()
	{
		return grQywZOJY4juSTREIr3l == null;
	}

	internal static IsItProcessAdditionalCheck xaJ8EaOJsocjWJqK4fDC()
	{
		return grQywZOJY4juSTREIr3l;
	}

	internal static object FcsD4mOJ0TsdflkZau4b(Type P_0, object P_1)
	{
		return P_0.GetReflectionProperty((string)P_1);
	}

	internal static bool hYfxoFOJy9F08bEokTR7(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static object kVkiQHOJmpYvl3B1R6Lk(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object AwNyJXOJtSwWAo95vx0O(object P_0)
	{
		return P_0.CastAsRealType();
	}
}
