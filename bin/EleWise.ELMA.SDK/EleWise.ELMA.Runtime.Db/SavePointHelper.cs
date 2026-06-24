using System;
using System.Data;
using Autofac.Core;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db;

public static class SavePointHelper
{
	private static ITransformationProvider _transformationProvider;

	private static SavePointHelper zmsU1QW8QGVbLNUBVPja;

	private static ITransformationProvider TransformationProvider()
	{
		//Discarded unreachable code: IL_0055, IL_00ac, IL_00c3, IL_00d2, IL_0125, IL_0134
		int num = 2;
		int num2 = num;
		ITransformationProvider transformationProvider = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					_transformationProvider = Locator.GetService<ITransformationProvider>();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return transformationProvider;
						}
						transformationProvider = _transformationProvider;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num3 = 1;
						}
					}
				}
				catch (DependencyResolutionException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			default:
				return null;
			case 4:
				return _transformationProvider;
			case 1:
				if (TD0qnyW88u5P0Hg6qUVj())
				{
					num2 = 3;
					break;
				}
				goto default;
			case 2:
				if (_transformationProvider == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public static bool SavePoint(string key, IDbCommand dBCommand)
	{
		//Discarded unreachable code: IL_0050, IL_005f, IL_0080, IL_008f
		int num = 4;
		ITransformationProvider transformationProvider = default(ITransformationProvider);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 2:
					transformationProvider = (ITransformationProvider)FMohcKW8Z99dJUChZpxB();
					num2 = 6;
					continue;
				case 6:
					if (transformationProvider != null)
					{
						num2 = 5;
						continue;
					}
					return false;
				case 1:
					if (dBCommand.Transaction != null)
					{
						num2 = 2;
						continue;
					}
					goto default;
				case 4:
					if (dBCommand == null)
					{
						break;
					}
					goto case 1;
				case 5:
					return oqphV1W8IUj8oHQ8jf9n(transformationProvider, key, zqqS9VW8uCwYA3HnnSMm(dBCommand));
				}
				break;
			}
			num = 3;
		}
	}

	public static void ReleaseSavePoint(string key, IDbCommand dBCommand)
	{
		//Discarded unreachable code: IL_0065, IL_0074
		int num = 1;
		ITransformationProvider transformationProvider = default(ITransformationProvider);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 5:
					q1oTVCW8VlEFVNq7kCFB(transformationProvider, key, zqqS9VW8uCwYA3HnnSMm(dBCommand));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 6;
					}
					continue;
				case 0:
					return;
				case 1:
					if (dBCommand == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 6:
					return;
				case 3:
					return;
				case 4:
					if (transformationProvider == null)
					{
						return;
					}
					num = 5;
					break;
				case 2:
					if (zqqS9VW8uCwYA3HnnSMm(dBCommand) != null)
					{
						transformationProvider = (ITransformationProvider)FMohcKW8Z99dJUChZpxB();
						num2 = 4;
						continue;
					}
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public static void RollBackSavePoint(string key, IDbCommand dBCommand)
	{
		int num = 1;
		int num2 = num;
		ITransformationProvider transformationProvider = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (transformationProvider != null)
				{
					num2 = 3;
					continue;
				}
				return;
			case 1:
				if (dBCommand != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 3:
				rvTNH6W8SVwDkY4nOHJd(transformationProvider, key, dBCommand.Transaction);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				return;
			case 4:
				return;
			}
			if (zqqS9VW8uCwYA3HnnSMm(dBCommand) == null)
			{
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 3;
				}
				continue;
			}
			transformationProvider = (ITransformationProvider)FMohcKW8Z99dJUChZpxB();
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
			{
				num2 = 2;
			}
		}
	}

	public static string GetSavePointKey()
	{
		return (string)VPEetqW8qiUpsCv3DOuh(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FBAF20), p3FhnXW8iQKFvZ4YBDZ4().ToString((string)TUF00CW8RPdL9OlvNxMi(0xA592A41 ^ 0xA595A4F)));
	}

	internal static bool TD0qnyW88u5P0Hg6qUVj()
	{
		return Locator.Initialized;
	}

	internal static bool wikojfW8C1YGwAQIO0x9()
	{
		return zmsU1QW8QGVbLNUBVPja == null;
	}

	internal static SavePointHelper GcumVAW8vb7bYsKEeJlu()
	{
		return zmsU1QW8QGVbLNUBVPja;
	}

	internal static object FMohcKW8Z99dJUChZpxB()
	{
		return TransformationProvider();
	}

	internal static object zqqS9VW8uCwYA3HnnSMm(object P_0)
	{
		return ((IDbCommand)P_0).Transaction;
	}

	internal static bool oqphV1W8IUj8oHQ8jf9n(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).SavePoint((string)P_1, (IDbTransaction)P_2);
	}

	internal static void q1oTVCW8VlEFVNq7kCFB(object P_0, object P_1, object P_2)
	{
		((ITransformationProvider)P_0).ReleaseSavePoint((string)P_1, (IDbTransaction)P_2);
	}

	internal static void rvTNH6W8SVwDkY4nOHJd(object P_0, object P_1, object P_2)
	{
		((ITransformationProvider)P_0).RollBackSavePoint((string)P_1, (IDbTransaction)P_2);
	}

	internal static Guid p3FhnXW8iQKFvZ4YBDZ4()
	{
		return Guid.NewGuid();
	}

	internal static object TUF00CW8RPdL9OlvNxMi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VPEetqW8qiUpsCv3DOuh(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
