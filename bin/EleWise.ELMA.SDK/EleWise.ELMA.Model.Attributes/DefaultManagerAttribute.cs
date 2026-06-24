using System;
using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Attributes;

public class DefaultManagerAttribute : Attribute
{
	private readonly Type managerType;

	internal static DefaultManagerAttribute VC6KjToIOZE4AuD5HArP;

	public DefaultManagerAttribute(Type managerType) : base()
	{
		this.managerType = managerType;
	}

	public Type GetManagerType(Type objectType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				Woah9woINCbVnjNLJaLr(objectType, e5IZOooI1ZdVbb2Zsj8J(0x10E41EDB ^ 0x10E647C9));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
			{
				Type type = managerType;
				if ((object)type == null)
				{
					num2 = 3;
					continue;
				}
				obj = type.GetInterface(BON9UAoI3kqQQmmx9qnx(typeof(IManagerMaker).TypeHandle).FullName);
				break;
			}
			case 2:
				return eN1e2goIDTmqNvXfqNmA((IManagerMaker)kOIEgjoIa6O0FbdagQOJ(managerType), objectType);
			case 3:
				obj = null;
				break;
			}
			if (!VRLBgRoIprFWOGYFEJuu((Type)obj, null))
			{
				break;
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
			{
				num2 = 1;
			}
		}
		return managerType;
	}

	internal static void UVTC4koIP1dBspBe7f1t()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Fbu7Q6oI2k9U8Xbkxv0C()
	{
		return VC6KjToIOZE4AuD5HArP == null;
	}

	internal static DefaultManagerAttribute mxCcfNoIeGpZPrJ1FT9y()
	{
		return VC6KjToIOZE4AuD5HArP;
	}

	internal static object e5IZOooI1ZdVbb2Zsj8J(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Woah9woINCbVnjNLJaLr(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type BON9UAoI3kqQQmmx9qnx(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool VRLBgRoIprFWOGYFEJuu(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object kOIEgjoIa6O0FbdagQOJ(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static Type eN1e2goIDTmqNvXfqNmA(object P_0, Type objectType)
	{
		return ((IManagerMaker)P_0).MakeManager(objectType);
	}
}
