using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Security.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Serializable]
public class OrganizationModelPublishException : Exception
{
	private static OrganizationModelPublishException KUI043Adr4LLpnQwdqk;

	public List<OrganizationValidationMessage> mess { get; set; }

	public OrganizationModelPublishException()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xnhENlA888BATZpLA3x();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public OrganizationModelPublishException(string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		xnhENlA888BATZpLA3x();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public OrganizationModelPublishException(string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		xnhENlA888BATZpLA3x();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected OrganizationModelPublishException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector(info, context);
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				mess = (List<OrganizationValidationMessage>)cVTKyoAyOrAaKLTjW4i(info, EklqXfArMHA4U4VckWQ(-185816410 ^ -185813066), bmuKqkA3x1A9nrqkWVX(typeof(List<OrganizationValidationMessage>).TypeHandle));
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				VvuVRAAbWVcEEIdxFed(this, info, context);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a != 0)
				{
					num2 = 0;
				}
				break;
			default:
				hMrgkGAS3AQf9ibG2S1(info, EklqXfArMHA4U4VckWQ(0x417D81DE ^ 0x417D9CCE), mess);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void xnhENlA888BATZpLA3x()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool UaPmNXATOuxw4xjJ9Fn()
	{
		return KUI043Adr4LLpnQwdqk == null;
	}

	internal static OrganizationModelPublishException GsM5FNAg6OBSAnTWnyH()
	{
		return KUI043Adr4LLpnQwdqk;
	}

	internal static object EklqXfArMHA4U4VckWQ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type bmuKqkA3x1A9nrqkWVX(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object cVTKyoAyOrAaKLTjW4i(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static void VvuVRAAbWVcEEIdxFed(object P_0, object P_1, StreamingContext P_2)
	{
		((Exception)P_0).GetObjectData((SerializationInfo)P_1, P_2);
	}

	internal static void hMrgkGAS3AQf9ibG2S1(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
