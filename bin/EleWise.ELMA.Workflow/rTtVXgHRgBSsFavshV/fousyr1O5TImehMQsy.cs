using System;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace rTtVXgHRgBSsFavshV;

internal class fousyr1O5TImehMQsy
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module fou1syrO5;

	private static fousyr1O5TImehMQsy lhOaiJvVGtI5GMm3iGRj;

	internal static void LdtvAh3N0JU(int typemdt)
	{
		//Discarded unreachable code: IL_005a, IL_0069
		int num = 6;
		int num2 = num;
		FieldInfo fieldInfo = default(FieldInfo);
		FieldInfo[] fields = default(FieldInfo[]);
		int num3 = default(int);
		Type type = default(Type);
		MethodInfo method = default(MethodInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fieldInfo = fields[num3];
				num2 = 3;
				break;
			case 5:
				fields = type.GetFields();
				num2 = 9;
				if (OypMPLvV2yTjiaEkMXTr() != null)
				{
					num2 = 3;
				}
				break;
			case 7:
				return;
			case 6:
				type = OVCySGvVoVIviI7bbILK(fou1syrO5, 33554432 + typemdt);
				num2 = 5;
				break;
			case 2:
			case 4:
				if (num3 >= fields.Length)
				{
					num2 = 7;
					break;
				}
				goto case 1;
			default:
				num3++;
				num2 = 2;
				if (OypMPLvV2yTjiaEkMXTr() == null)
				{
					num2 = 4;
				}
				break;
			case 3:
				method = (MethodInfo)fou1syrO5.ResolveMethod(VVQuNEvVF7XhnuFHT5KR(fieldInfo) + 100663296);
				num2 = 8;
				if (f9ETrpvV7wcLNscXNy2u())
				{
					num2 = 8;
				}
				break;
			case 9:
				num3 = 0;
				num2 = 2;
				break;
			case 8:
				q5oOCfvViS6JCaIFC7dE(fieldInfo, null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
				num2 = 0;
				if (OypMPLvV2yTjiaEkMXTr() == null)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public fousyr1O5TImehMQsy()
	{
		//Discarded unreachable code: IL_0026, IL_002b
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (true)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static fousyr1O5TImehMQsy()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				V2FGUivVIgHomr0rPynm();
				num2 = 1;
				if (false)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				fou1syrO5 = (Module)wECOKlvVr25HrBePKtQ3(hi9bHpvVaLkXNH05qdHO(typeof(fousyr1O5TImehMQsy).TypeHandle).Assembly);
				num2 = 0;
				if (true)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Type OVCySGvVoVIviI7bbILK(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveType(P_1);
	}

	internal static int VVQuNEvVF7XhnuFHT5KR(object P_0)
	{
		return ((MemberInfo)P_0).MetadataToken;
	}

	internal static void q5oOCfvViS6JCaIFC7dE(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool f9ETrpvV7wcLNscXNy2u()
	{
		return lhOaiJvVGtI5GMm3iGRj == null;
	}

	internal static fousyr1O5TImehMQsy OypMPLvV2yTjiaEkMXTr()
	{
		return lhOaiJvVGtI5GMm3iGRj;
	}

	internal static void V2FGUivVIgHomr0rPynm()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Type hi9bHpvVaLkXNH05qdHO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object wECOKlvVr25HrBePKtQ3(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
