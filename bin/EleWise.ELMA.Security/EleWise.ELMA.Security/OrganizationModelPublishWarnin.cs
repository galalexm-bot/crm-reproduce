using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Security.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Serializable]
public class OrganizationModelPublishWarning : Exception
{
	internal static OrganizationModelPublishWarning p6Gi8PA97xMpQPCaXej;

	public List<OrganizationValidationMessage> mess { get; set; }

	public OrganizationModelPublishWarning()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public OrganizationModelPublishWarning(string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public OrganizationModelPublishWarning(string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		LLxlm5AzQ04AgYDEfW9();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected OrganizationModelPublishWarning(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		LLxlm5AzQ04AgYDEfW9();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			mess = (List<OrganizationValidationMessage>)QTYbRVW5O4JlMRc6YUr(info, sbSorBWkZHiYNNCUbd5(0x3B056A9C ^ 0x3B05778C), O93YhtWpt2qxCliYdtE(typeof(List<OrganizationValidationMessage>).TypeHandle));
			num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
			{
				num = 1;
			}
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				base.GetObjectData(info, context);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				info.AddValue((string)sbSorBWkZHiYNNCUbd5(-698589567 ^ -698596463), mess);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool Hoo8C3Afe3K4gJS4N6Z()
	{
		return p6Gi8PA97xMpQPCaXej == null;
	}

	internal static OrganizationModelPublishWarning eQM2tkA1T3X9gc0XYo2()
	{
		return p6Gi8PA97xMpQPCaXej;
	}

	internal static void LLxlm5AzQ04AgYDEfW9()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object sbSorBWkZHiYNNCUbd5(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type O93YhtWpt2qxCliYdtE(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object QTYbRVW5O4JlMRc6YUr(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}
}
