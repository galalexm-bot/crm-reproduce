using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class GuidTypeEncrypter : BaseTypeEncrypter
{
	private static GuidTypeEncrypter jUiq95oYLgHenxmV3BnP;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0088, IL_0097
		int num = 1;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				if (propertyMetadata2 == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 1:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return pQsyAIoYzjX1rXyG9gtq(xenl8poYcR5nqQU0DLu7(propertyMetadata2), GuidDescriptor.UID);
			case 3:
				return false;
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return string.Empty;
			case 2:
				if (!NLvYhkoLF6RYrIoms7fS((PropertyMetadata)propertyMetadata))
				{
					return base.ObjectToString(obj, propertyMetadata);
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (obj != null)
				{
					return base.ObjectToString((Guid)obj, propertyMetadata);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_009f, IL_00ae, IL_00e5
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				return Guid.Empty;
			case 1:
				return new Guid(obj);
			case 3:
				if (((PropertyMetadata)propertyMetadata).Nullable)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 2:
				if (!c9D8YOoLBiZT8vD6DbXR(obj))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				return null;
			default:
				if (!c9D8YOoLBiZT8vD6DbXR(obj))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public GuidTypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid xenl8poYcR5nqQU0DLu7(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool pQsyAIoYzjX1rXyG9gtq(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool zVDgeHoYUNQpF962XcyK()
	{
		return jUiq95oYLgHenxmV3BnP == null;
	}

	internal static GuidTypeEncrypter u9EWUKoYsAmvCFfWeUH9()
	{
		return jUiq95oYLgHenxmV3BnP;
	}

	internal static bool NLvYhkoLF6RYrIoms7fS(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static bool c9D8YOoLBiZT8vD6DbXR(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
