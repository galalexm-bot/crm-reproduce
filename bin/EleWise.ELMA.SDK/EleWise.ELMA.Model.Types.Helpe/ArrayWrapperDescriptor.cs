using System;
using System.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class ArrayWrapperDescriptor : ITypeWrapperDescriptor
{
	internal static ArrayWrapperDescriptor yDEDOMbhrAUMLPWmQKAv;

	public Type OriginalType => m8kuI5bhjeYCKH8bCO9Q(typeof(Array).TypeHandle);

	public Type WrapperType => m8kuI5bhjeYCKH8bCO9Q(typeof(ArrayWrapper).TypeHandle);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new ArrayWrapper((ICollection)obj);
	}

	public object GetObject(object wrapper)
	{
		int num = 1;
		int num2 = num;
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (vpK1nxbhYLdfSew1EDhw((ArrayWrapper)wrapper) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				value = ((ArrayWrapper)wrapper).Value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 2;
				}
				continue;
			default:
				if (pBS2MYbhUdNdQSIYBPig(XKWe1MbhLgehmh3SOq4D((ArrayWrapper)wrapper)))
				{
					num2 = 3;
					continue;
				}
				break;
			case 2:
				return iU4tJLbhsWmWAOigpJqd(ReflectionType.GetType((string)XKWe1MbhLgehmh3SOq4D((ArrayWrapper)wrapper)), value);
			}
			break;
		}
		return null;
	}

	public bool TestType(Type type)
	{
		return m8kuI5bhjeYCKH8bCO9Q(typeof(Array).TypeHandle).IsAssignableFrom(type);
	}

	public ArrayWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KhvOLPbhcxdJVTBVe9CT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type m8kuI5bhjeYCKH8bCO9Q(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool WB2NDjbhgwGyXI8qnCKf()
	{
		return yDEDOMbhrAUMLPWmQKAv == null;
	}

	internal static ArrayWrapperDescriptor HresPZbh5pCwqwf32lgm()
	{
		return yDEDOMbhrAUMLPWmQKAv;
	}

	internal static object vpK1nxbhYLdfSew1EDhw(object P_0)
	{
		return ((ArrayWrapper)P_0).Value;
	}

	internal static object XKWe1MbhLgehmh3SOq4D(object P_0)
	{
		return ((ArrayWrapper)P_0).ArrayTypeName;
	}

	internal static bool pBS2MYbhUdNdQSIYBPig(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object iU4tJLbhsWmWAOigpJqd(Type typeObject, object P_1)
	{
		return ClassSerializationHelper.DeserializeObjectByJson(typeObject, (string)P_1);
	}

	internal static void KhvOLPbhcxdJVTBVe9CT()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
