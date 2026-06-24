using System;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace rTtVXgHRgBSsFavshV;

internal class fousyr1O5TImehMQsy
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module fou1syrO5;

	internal static fousyr1O5TImehMQsy ES5nkdptv8eawGBW5pei;

	internal static void ik3phDxZckb(int typemdt)
	{
		//Discarded unreachable code: IL_00bc, IL_00cb
		int num = 2;
		int num2 = num;
		FieldInfo[] fields = default(FieldInfo[]);
		Type type = default(Type);
		int num3 = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo methodInfo = default(MethodInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fields = type.GetFields();
				num2 = 8;
				break;
			case 6:
				return;
			case 8:
				num3 = 0;
				num2 = 0;
				if (nnfGTPptCrLsVGXrdSeA())
				{
					num2 = 0;
				}
				break;
			default:
				if (num3 >= fields.Length)
				{
					num2 = 6;
					break;
				}
				goto case 4;
			case 2:
				type = fou1syrO5.ResolveType(33554432 + typemdt);
				num2 = 0;
				if (KgyIF3ptUhCuGJ9lbnZi() == null)
				{
					num2 = 1;
				}
				break;
			case 5:
				num3++;
				num2 = 7;
				break;
			case 9:
				XChZYPpttcHOWF7qC359(fieldInfo, null, (MulticastDelegate)CywYsiptKClCRLUNU1Rl(type, methodInfo));
				num2 = 5;
				if (!nnfGTPptCrLsVGXrdSeA())
				{
					num2 = 0;
				}
				break;
			case 4:
				fieldInfo = fields[num3];
				num2 = 3;
				break;
			case 3:
				methodInfo = (MethodInfo)IqoAATptJvXEXT1FuaCe(fou1syrO5, fPqZ09ptou7A1F4S1eHF(fieldInfo) + 100663296);
				num2 = 9;
				break;
			}
		}
	}

	public fousyr1O5TImehMQsy()
	{
		//Discarded unreachable code: IL_0026, IL_002b
		tl6eNvpthDT7hQ3tiHXj();
		base._002Ector();
		int num = 0;
		if (false)
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
				tl6eNvpthDT7hQ3tiHXj();
				num2 = 0;
				if (1 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				fou1syrO5 = (Module)hjsSTEptqWFf3wxjJ8g2(YDmZ9mptOlpUo0ppQ4Ar(typeof(fousyr1O5TImehMQsy).TypeHandle).Assembly);
				num2 = 2;
				if (1 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static int fPqZ09ptou7A1F4S1eHF(object P_0)
	{
		return ((MemberInfo)P_0).MetadataToken;
	}

	internal static object IqoAATptJvXEXT1FuaCe(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveMethod(P_1);
	}

	internal static object CywYsiptKClCRLUNU1Rl(Type P_0, object P_1)
	{
		return Delegate.CreateDelegate(P_0, (MethodInfo)P_1);
	}

	internal static void XChZYPpttcHOWF7qC359(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool nnfGTPptCrLsVGXrdSeA()
	{
		return ES5nkdptv8eawGBW5pei == null;
	}

	internal static fousyr1O5TImehMQsy KgyIF3ptUhCuGJ9lbnZi()
	{
		return ES5nkdptv8eawGBW5pei;
	}

	internal static void tl6eNvpthDT7hQ3tiHXj()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static Type YDmZ9mptOlpUo0ppQ4Ar(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object hjsSTEptqWFf3wxjJ8g2(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
