using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component]
public class Int32TypeEncrypter : BaseTypeEncrypter
{
	private static Int32TypeEncrypter G177WkoLVHTslEvMa6mH;

	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return propertyMetadata2.TypeUid == Int32Descriptor.UID;
			case 1:
				propertyMetadata2 = propertyMetadata as PropertyMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (propertyMetadata2 == null)
			{
				return false;
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
			{
				num2 = 2;
			}
		}
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_007b, IL_008a
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (Q4gGBQoLRq4mh1U9Cbfk((PropertyMetadata)propertyMetadata))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return base.ObjectToString(obj, propertyMetadata);
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return string.Empty;
			default:
				return base.ObjectToString(EXKCVUoLqqde80h8w7NL(obj), propertyMetadata);
			}
		}
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0031
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!ibSCQvoLKxHOMn0W0Zd6(obj))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 2:
				if (Q4gGBQoLRq4mh1U9Cbfk((PropertyMetadata)propertyMetadata))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 3:
				return null;
			}
			break;
		}
		return O4tJKvoLXKCfwx3AlwqT(obj);
	}

	public Int32TypeEncrypter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool a9jMVBoLS9crwgCuSe2P()
	{
		return G177WkoLVHTslEvMa6mH == null;
	}

	internal static Int32TypeEncrypter ncqGDcoLiA2Eirjd8srQ()
	{
		return G177WkoLVHTslEvMa6mH;
	}

	internal static bool Q4gGBQoLRq4mh1U9Cbfk(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static int EXKCVUoLqqde80h8w7NL(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static bool ibSCQvoLKxHOMn0W0Zd6(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static int O4tJKvoLXKCfwx3AlwqT(object P_0)
	{
		return Convert.ToInt32((string)P_0);
	}
}
