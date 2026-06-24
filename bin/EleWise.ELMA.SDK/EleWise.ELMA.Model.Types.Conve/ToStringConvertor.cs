using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Convertors;

public class ToStringConvertor : TypeConvertor
{
	internal static ToStringConvertor Oy2mvZojPO51hG4Xew4E;

	public override List<Guid> SourceTypeUids => new List<Guid>
	{
		Int16Descriptor.UID,
		Int32Descriptor.UID,
		Int64Descriptor.UID,
		GuidDescriptor.UID,
		BoolDescriptor.UID,
		EnumDescriptor.UID,
		DateTimeDescriptor.UID,
		DoubleDescriptor.UID,
		HtmlStringDescriptor.UID,
		TextDescriptor.UID,
		StringDescriptor.UID
	};

	public override List<Guid> TargetTypeUids => new List<Guid>
	{
		StringDescriptor.UID,
		HtmlStringDescriptor.UID,
		TextDescriptor.UID
	};

	public override object DoConvert(object obj)
	{
		//Discarded unreachable code: IL_0092, IL_00a1
		int num = 2;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			default:
				return string.Empty;
			case 1:
				if (obj is DateTime)
				{
					num2 = 4;
					break;
				}
				return obj.ToString();
			case 4:
				dateTime = (DateTime)obj;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (obj != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				return dateTime.ToString((string)dAsL5ioj3JZDfmnLnFpd(--1333735954 ^ 0x4F7FC592));
			}
		}
	}

	public ToStringConvertor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fgKxhIojpcMeDN3U7DA3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object dAsL5ioj3JZDfmnLnFpd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool NwP50xoj1hftL8H5XamC()
	{
		return Oy2mvZojPO51hG4Xew4E == null;
	}

	internal static ToStringConvertor bbGc4nojNFPxmCMQsKve()
	{
		return Oy2mvZojPO51hG4Xew4E;
	}

	internal static void fgKxhIojpcMeDN3U7DA3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
