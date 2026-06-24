using System;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Events.Impl;

public static class Extensions
{
	private static Extensions vp7Ql8GLE0Rc0VnY1R0I;

	public static MethodInfo GetGenericMethod(this Type t, string name, Type[] genericArgTypes, Type[] argTypes, Type returnType)
	{
		int num = 5;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				case 5:
					_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
					num2 = 4;
					continue;
				default:
					return (MethodInfo)S5feUoGLCVLx2VmTrnhc(t.GetMethods(BindingFlags.Static | BindingFlags.Public).Where(_003C_003Ec__DisplayClass0_._003CGetGenericMethod_003Eb__0).Single(), _003C_003Ec__DisplayClass0_.genericArgTypes);
				case 1:
					_003C_003Ec__DisplayClass0_.argTypes = argTypes;
					num2 = 2;
					continue;
				case 3:
					_003C_003Ec__DisplayClass0_.genericArgTypes = genericArgTypes;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass0_.returnType = returnType;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass0_.name = name;
			num = 3;
		}
	}

	internal static object S5feUoGLCVLx2VmTrnhc(object P_0, object P_1)
	{
		return ((MethodInfo)P_0).MakeGenericMethod((Type[])P_1);
	}

	internal static bool Q8ojR6GLf5juZVp9hrml()
	{
		return vp7Ql8GLE0Rc0VnY1R0I == null;
	}

	internal static Extensions H2inaXGLQbx7yVI6hp4r()
	{
		return vp7Ql8GLE0Rc0VnY1R0I;
	}
}
