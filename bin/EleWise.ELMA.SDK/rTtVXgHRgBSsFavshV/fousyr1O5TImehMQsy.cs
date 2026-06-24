using System;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace rTtVXgHRgBSsFavshV;

internal class fousyr1O5TImehMQsy
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module fou1syrO5;

	internal static fousyr1O5TImehMQsy VhS1xYZDvQgHLPlDKKjk;

	internal static void PfsZt2h2WRD(int typemdt)
	{
		//Discarded unreachable code: IL_00f4, IL_0103, IL_0113
		int num = 4;
		FieldInfo fieldInfo = default(FieldInfo);
		FieldInfo[] fields = default(FieldInfo[]);
		int num3 = default(int);
		MethodInfo methodInfo = default(MethodInfo);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 10:
					fieldInfo = fields[num3];
					num2 = 5;
					continue;
				case 5:
					methodInfo = (MethodInfo)fou1syrO5.ResolveMethod(xmokcSZDIgccbImxTuou(fieldInfo) + 100663296);
					num = 9;
					break;
				case 4:
					type = wvfpo5ZDuRfraCwqCJuj(fou1syrO5, 33554432 + typemdt);
					num2 = 2;
					if (OeIt4mZD8wVJ6YgxjfCA())
					{
						num2 = 3;
					}
					continue;
				case 7:
					num3 = 0;
					num2 = 6;
					if (!OeIt4mZD8wVJ6YgxjfCA())
					{
						num2 = 6;
					}
					continue;
				case 2:
					num3++;
					num2 = 0;
					if (!OeIt4mZD8wVJ6YgxjfCA())
					{
						num2 = 0;
					}
					continue;
				case 9:
					dj3iYcZDSo1GtHtLT8Yr(fieldInfo, null, (MulticastDelegate)NCapjLZDVAlJHevK9tZy(type, methodInfo));
					num = 2;
					break;
				case 8:
					return;
				case 3:
					fields = type.GetFields();
					num2 = 7;
					continue;
				default:
					if (num3 >= fields.Length)
					{
						return;
					}
					num2 = 0;
					if (OeIt4mZD8wVJ6YgxjfCA())
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	public fousyr1O5TImehMQsy()
	{
		//Discarded unreachable code: IL_0026, IL_002b
		NVnOtoZDilkdREZZSnSU();
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
				NVnOtoZDilkdREZZSnSU();
				num2 = 0;
				if (0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				fou1syrO5 = (Module)XM6ATDZDqg4yHPRKeeeK(mhv8bdZDRZgcgavAkTnr(typeof(fousyr1O5TImehMQsy).TypeHandle).Assembly);
				num2 = 2;
				if (false)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static Type wvfpo5ZDuRfraCwqCJuj(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveType(P_1);
	}

	internal static int xmokcSZDIgccbImxTuou(object P_0)
	{
		return ((MemberInfo)P_0).MetadataToken;
	}

	internal static object NCapjLZDVAlJHevK9tZy(Type P_0, object P_1)
	{
		return Delegate.CreateDelegate(P_0, (MethodInfo)P_1);
	}

	internal static void dj3iYcZDSo1GtHtLT8Yr(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool OeIt4mZD8wVJ6YgxjfCA()
	{
		return VhS1xYZDvQgHLPlDKKjk == null;
	}

	internal static fousyr1O5TImehMQsy T5PVTmZDZs4kbda7JWoN()
	{
		return VhS1xYZDvQgHLPlDKKjk;
	}

	internal static void NVnOtoZDilkdREZZSnSU()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type mhv8bdZDRZgcgavAkTnr(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object XM6ATDZDqg4yHPRKeeeK(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
