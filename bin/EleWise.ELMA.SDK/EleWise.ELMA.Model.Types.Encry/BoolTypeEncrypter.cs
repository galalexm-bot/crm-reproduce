using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class BoolTypeEncrypter : BaseTypeEncrypter
{
	internal static BoolTypeEncrypter HgaT7YoYocd5fejBvvak;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0042, IL_0051
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (propertyMetadata2 == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				return bwNSK5oYEb9XdVhsQvCW(Mj6YF9oYGwwVFX19S2fD(propertyMetadata2), BoolDescriptor.UID);
			case 3:
				return false;
			case 2:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_009d, IL_00ac
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (nvVuBEoYfWRFQEgfjlHU((PropertyMetadata)propertyMetadata))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 2;
					}
					break;
				}
				return base.ObjectToString(obj, propertyMetadata);
			case 2:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return string.Empty;
			default:
				return base.ObjectToString(FPUT68oYQslsDpV2VmQC(obj), propertyMetadata);
			}
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (((PropertyMetadata)propertyMetadata).Nullable)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				if (!MIyUxDoYCDDq5VnfHAwW(obj))
				{
					num2 = 3;
					continue;
				}
				goto case 2;
			case 2:
				return null;
			case 3:
				break;
			}
			break;
		}
		return bAjA1roYvdYTIrSI9JOE(obj);
	}

	public BoolTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oetLlpoY8jycmxcjoYli();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid Mj6YF9oYGwwVFX19S2fD(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool bwNSK5oYEb9XdVhsQvCW(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool K2AbTkoYbpSXeiaA1306()
	{
		return HgaT7YoYocd5fejBvvak == null;
	}

	internal static BoolTypeEncrypter K19ffEoYhg5uIm4yCM2N()
	{
		return HgaT7YoYocd5fejBvvak;
	}

	internal static bool nvVuBEoYfWRFQEgfjlHU(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static bool FPUT68oYQslsDpV2VmQC(object P_0)
	{
		return Convert.ToBoolean(P_0);
	}

	internal static bool MIyUxDoYCDDq5VnfHAwW(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool bAjA1roYvdYTIrSI9JOE(object P_0)
	{
		return Convert.ToBoolean((string)P_0);
	}

	internal static void oetLlpoY8jycmxcjoYli()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
