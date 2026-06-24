using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class Int16TypeEncrypter : BaseTypeEncrypter
{
	internal static Int16TypeEncrypter JUF9LloLTt6p2H5IYYgb;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return ljJoMBoLOOZrwBSKF6kP(propertyMetadata2) == Int16Descriptor.UID;
			}
			if (propertyMetadata2 != null)
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return false;
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!((PropertyMetadata)propertyMetadata).Nullable)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return base.ObjectToString(Convert.ToInt16(obj), propertyMetadata);
			default:
				return string.Empty;
			case 1:
				return base.ObjectToString(obj, propertyMetadata);
			}
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_0079
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!string.IsNullOrEmpty(obj))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			default:
				return Convert.ToInt16(obj);
			case 4:
				if (!c1tI81oL29lB4tHwjk3D((PropertyMetadata)propertyMetadata))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public Int16TypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IJSLYnoLeor5JU6eE963();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid ljJoMBoLOOZrwBSKF6kP(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool rE2J4roLkuGwCoI890NW()
	{
		return JUF9LloLTt6p2H5IYYgb == null;
	}

	internal static Int16TypeEncrypter Gg2j0WoLnMjEI62PWutv()
	{
		return JUF9LloLTt6p2H5IYYgb;
	}

	internal static bool c1tI81oL29lB4tHwjk3D(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static void IJSLYnoLeor5JU6eE963()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
