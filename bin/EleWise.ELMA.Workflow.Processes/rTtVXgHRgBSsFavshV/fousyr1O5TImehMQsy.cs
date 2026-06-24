using System;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace rTtVXgHRgBSsFavshV;

internal class fousyr1O5TImehMQsy
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module fou1syrO5;

	private static fousyr1O5TImehMQsy aGpKZ1ikUCDyy2ktJan;

	internal static void NVouWDOoyO(int typemdt)
	{
		//Discarded unreachable code: IL_0115, IL_0124
		int num = 9;
		int num2 = num;
		int num3 = default(int);
		FieldInfo[] fields = default(FieldInfo[]);
		Type type = default(Type);
		MethodInfo method = default(MethodInfo);
		FieldInfo fieldInfo = default(FieldInfo);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			default:
				if (num3 >= fields.Length)
				{
					num2 = 2;
					if (UibB6ZiU9EpNwJteDgS() == null)
					{
						num2 = 4;
					}
					break;
				}
				goto case 5;
			case 6:
				num3 = 0;
				num2 = 0;
				if (UibB6ZiU9EpNwJteDgS() != null)
				{
					num2 = 0;
				}
				break;
			case 9:
				type = fou1syrO5.ResolveType(33554432 + typemdt);
				num2 = 8;
				break;
			case 8:
				fields = type.GetFields();
				num2 = 6;
				if (!Q02N2mibQ8LJVE74TTn())
				{
					num2 = 1;
				}
				break;
			case 2:
				method = (MethodInfo)pv7dsyimaAOevYHRn95(fou1syrO5, fieldInfo.MetadataToken + 100663296);
				num2 = 1;
				if (!Q02N2mibQ8LJVE74TTn())
				{
					num2 = 1;
				}
				break;
			case 5:
				fieldInfo = fields[num3];
				num2 = 2;
				break;
			case 3:
				num3++;
				num2 = 7;
				break;
			case 1:
				InqrObiAv6DoXXNGJyZ(fieldInfo, null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
				num2 = 3;
				if (UibB6ZiU9EpNwJteDgS() != null)
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
		bjd4CEipk8fEeklpdX2();
		base._002Ector();
		int num = 0;
		if (1 == 0)
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
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				bjd4CEipk8fEeklpdX2();
				num2 = 0;
				if (1 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				fou1syrO5 = (Module)BO9XSgiGNwfgNNTPb8M(typeof(fousyr1O5TImehMQsy).Assembly);
				num2 = 0;
				if (0 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object pv7dsyimaAOevYHRn95(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveMethod(P_1);
	}

	internal static void InqrObiAv6DoXXNGJyZ(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool Q02N2mibQ8LJVE74TTn()
	{
		return aGpKZ1ikUCDyy2ktJan == null;
	}

	internal static fousyr1O5TImehMQsy UibB6ZiU9EpNwJteDgS()
	{
		return aGpKZ1ikUCDyy2ktJan;
	}

	internal static void bjd4CEipk8fEeklpdX2()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object BO9XSgiGNwfgNNTPb8M(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
