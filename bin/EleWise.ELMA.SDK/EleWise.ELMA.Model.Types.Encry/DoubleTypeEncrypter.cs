using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class DoubleTypeEncrypter : BaseTypeEncrypter
{
	internal static DoubleTypeEncrypter UD84cKoYRl9FZdqJJSlm;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return ygnJmloYTYvXrnOy0BVW(QC6TVwoYXrVMbS6nXEJ8(propertyMetadata2), DoubleDescriptor.UID);
			case 1:
				if (propertyMetadata2 == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0063, IL_0072
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return string.Empty;
			case 3:
				return base.ObjectToString(Convert.ToDouble(obj), propertyMetadata);
			case 1:
				if (obj != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 2:
				if (!OS9G7doYklWwc5FI7l6N((PropertyMetadata)propertyMetadata))
				{
					return base.ObjectToString(obj, propertyMetadata);
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_0080, IL_008f
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (!OS9G7doYklWwc5FI7l6N((PropertyMetadata)propertyMetadata))
					{
						break;
					}
					goto case 4;
				default:
					return null;
				case 1:
				case 2:
					return KfFjLuoYOFbtxtBFqZwC(obj);
				case 4:
					if (!ck6GGWoYnD7dZbPsLt6R(obj))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				}
				break;
			}
			num = 2;
		}
	}

	public DoubleTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid QC6TVwoYXrVMbS6nXEJ8(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool ygnJmloYTYvXrnOy0BVW(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool wp2oyjoYqWForfdEq0Qi()
	{
		return UD84cKoYRl9FZdqJJSlm == null;
	}

	internal static DoubleTypeEncrypter ydHN8JoYKpmiL4uiUnlN()
	{
		return UD84cKoYRl9FZdqJJSlm;
	}

	internal static bool OS9G7doYklWwc5FI7l6N(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static bool ck6GGWoYnD7dZbPsLt6R(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static double KfFjLuoYOFbtxtBFqZwC(object P_0)
	{
		return Convert.ToDouble((string)P_0);
	}
}
