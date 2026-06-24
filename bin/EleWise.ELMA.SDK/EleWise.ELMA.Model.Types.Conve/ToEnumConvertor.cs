using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Convertors;

public class ToEnumConvertor : TypeConvertor
{
	private static ToEnumConvertor cXoPL8o55BLrF4UYmSVD;

	public override List<Guid> SourceTypeUids => new List<Guid> { EnumDescriptor.UID };

	public override List<Guid> TargetTypeUids => new List<Guid> { EnumDescriptor.UID };

	public override object DoConvert(object obj)
	{
		//Discarded unreachable code: IL_008e, IL_00c0, IL_00d7, IL_00e6
		int num = 3;
		int num2 = num;
		int? num3 = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return num3;
			case 3:
				num3 = null;
				num2 = 2;
				break;
			case 2:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			default:
				try
				{
					num3 = (int)obj;
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				catch (Exception)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			}
		}
	}

	public ToEnumConvertor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qx8fTJo5L0LtrcxVPNqL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool HhNXWFo5jG1pINHXLNLs()
	{
		return cXoPL8o55BLrF4UYmSVD == null;
	}

	internal static ToEnumConvertor OtEEPso5YVmys60UTsWN()
	{
		return cXoPL8o55BLrF4UYmSVD;
	}

	internal static void qx8fTJo5L0LtrcxVPNqL()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
