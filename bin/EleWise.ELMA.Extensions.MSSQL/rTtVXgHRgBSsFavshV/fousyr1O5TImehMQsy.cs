using System;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace rTtVXgHRgBSsFavshV;

internal class fousyr1O5TImehMQsy
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module fou1syrO5;

	internal static fousyr1O5TImehMQsy UXAKIk9LJnoGW4c8Wbj;

	internal static void kULy4Sb9SL(int typemdt)
	{
		//Discarded unreachable code: IL_00f8
		int num = 9;
		int num2 = num;
		int num3 = default(int);
		FieldInfo[] fields = default(FieldInfo[]);
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo methodInfo = default(MethodInfo);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				if (num3 >= fields.Length)
				{
					num2 = 3;
					if (s1CBLp96yJpWDhyPSXe() == null)
					{
						num2 = 5;
					}
					break;
				}
				goto case 7;
			case 7:
				fieldInfo = fields[num3];
				num2 = 1;
				if (!HuBWOD9kjr0qctMRCL2())
				{
					num2 = 0;
				}
				break;
			case 1:
				methodInfo = (MethodInfo)fou1syrO5.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				num2 = 3;
				break;
			case 3:
				wQAUnb9oLXsMjrCMq9X(fieldInfo, null, (MulticastDelegate)lE3SNI9Jmvnw0Kwgk8k(type, methodInfo));
				num2 = 2;
				if (!HuBWOD9kjr0qctMRCL2())
				{
					num2 = 2;
				}
				break;
			case 2:
				num3++;
				num2 = 6;
				break;
			case 5:
				return;
			case 4:
				num3 = 0;
				num2 = 0;
				if (!HuBWOD9kjr0qctMRCL2())
				{
					num2 = 0;
				}
				break;
			case 8:
				fields = type.GetFields();
				num2 = 4;
				break;
			case 9:
				type = vLQZmg9C4gnWSfCA1pr(fou1syrO5, 33554432 + typemdt);
				num2 = 1;
				if (s1CBLp96yJpWDhyPSXe() == null)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	public fousyr1O5TImehMQsy()
	{
		//Discarded unreachable code: IL_0026, IL_002b
		StkA849dOGCODimW4KJ();
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
			default:
				fou1syrO5 = (Module)e2YyaJ9wPDt3rs8uCLa(typeof(fousyr1O5TImehMQsy).Assembly);
				num2 = 2;
				if (1 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 1:
				StkA849dOGCODimW4KJ();
				num2 = 0;
				if (false)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Type vLQZmg9C4gnWSfCA1pr(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveType(P_1);
	}

	internal static object lE3SNI9Jmvnw0Kwgk8k(Type P_0, object P_1)
	{
		return Delegate.CreateDelegate(P_0, (MethodInfo)P_1);
	}

	internal static void wQAUnb9oLXsMjrCMq9X(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool HuBWOD9kjr0qctMRCL2()
	{
		return UXAKIk9LJnoGW4c8Wbj == null;
	}

	internal static fousyr1O5TImehMQsy s1CBLp96yJpWDhyPSXe()
	{
		return UXAKIk9LJnoGW4c8Wbj;
	}

	internal static void StkA849dOGCODimW4KJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}

	internal static object e2YyaJ9wPDt3rs8uCLa(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
