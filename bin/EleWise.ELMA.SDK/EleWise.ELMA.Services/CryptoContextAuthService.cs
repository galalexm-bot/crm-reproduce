using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service(Type = ComponentType.WebServer, InjectProperties = true, Scope = ServiceScope.Shell, EnableInterceptors = false)]
public class CryptoContextAuthService : ICryptoContextAuthService
{
	internal static CryptoContextAuthService qDEAlQBHqKOGFFXss0XZ;

	protected ICryptoContextAuthServiceImpl GetImpl(IEntity entity)
	{
		//Discarded unreachable code: IL_00e7, IL_00f6
		int num = 3;
		int num2 = num;
		ICryptoContextAuthServiceImpl cryptoContextAuthServiceImpl = default(ICryptoContextAuthServiceImpl);
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				cryptoContextAuthServiceImpl = ((ComponentManager)gAmdgqBHT5JqrNQb2VwY()).GetExtensionPoints<ICryptoContextAuthServiceImpl>().FirstOrDefault(_003C_003Ec__DisplayClass0_._003CGetImpl_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass0_.entity = entity;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				throw new Exception(SR.T((string)spTj7MBHkNMVxw1NYsve(-97972138 ^ -98023382), _003C_003Ec__DisplayClass0_.entity.GetType()));
			case 5:
				return cryptoContextAuthServiceImpl;
			default:
				if (cryptoContextAuthServiceImpl != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 4;
			case 3:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public bool SignInForEntity(IEntity entity, string password)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 2;
		int num2 = num;
		ICryptoContextAuthServiceImpl impl = default(ICryptoContextAuthServiceImpl);
		while (true)
		{
			switch (num2)
			{
			default:
				return kj5riaBHnJNTEwpg5HNi(impl, entity, password);
			case 3:
				return false;
			case 2:
				impl = GetImpl(entity);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (impl == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	public bool IsSignForEntity(IEntity entity)
	{
		//Discarded unreachable code: IL_0080, IL_008f
		int num = 3;
		int num2 = num;
		ICryptoContextAuthServiceImpl impl = default(ICryptoContextAuthServiceImpl);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (impl == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				impl = GetImpl(entity);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return J0nLBHBHOKbKQI6aGTtJ(impl, entity);
			default:
				return false;
			}
		}
	}

	public void SignOutForEntity(IEntity entity)
	{
		//Discarded unreachable code: IL_004a, IL_0059
		int num = 4;
		ICryptoContextAuthServiceImpl impl = default(ICryptoContextAuthServiceImpl);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (impl == null)
					{
						num = 2;
						break;
					}
					goto default;
				case 2:
					return;
				case 4:
					impl = GetImpl(entity);
					num = 3;
					break;
				default:
					f45WMgBH2IW2xaVEyMY3(impl, entity);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	public IEntity DecryptFromContext(IEntity entity)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 3;
		int num2 = num;
		ICryptoContextAuthServiceImpl impl = default(ICryptoContextAuthServiceImpl);
		while (true)
		{
			switch (num2)
			{
			case 3:
				impl = GetImpl(entity);
				num2 = 2;
				break;
			default:
				return (IEntity)crG5X0BHe22dsPJyn7qe(impl, entity);
			case 1:
				return null;
			case 2:
				if (impl == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public string GetPasswordFromContext(IEntity entity)
	{
		//Discarded unreachable code: IL_0054, IL_0063
		int num = 2;
		int num2 = num;
		ICryptoContextAuthServiceImpl impl = default(ICryptoContextAuthServiceImpl);
		while (true)
		{
			switch (num2)
			{
			case 2:
				impl = GetImpl(entity);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return (string)iPQ9vqBHPed7PmgZRXnU(impl, entity);
			case 3:
				return null;
			case 1:
				if (impl == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	public CryptoContextAuthService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BhhtR0BH1VXBK6QbDoB4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object gAmdgqBHT5JqrNQb2VwY()
	{
		return ComponentManager.Current;
	}

	internal static object spTj7MBHkNMVxw1NYsve(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool e8tebLBHKcI0DBpIbQdm()
	{
		return qDEAlQBHqKOGFFXss0XZ == null;
	}

	internal static CryptoContextAuthService PIFMrTBHXEA8MuQRoeTh()
	{
		return qDEAlQBHqKOGFFXss0XZ;
	}

	internal static bool kj5riaBHnJNTEwpg5HNi(object P_0, object P_1, object P_2)
	{
		return ((ICryptoContextAuthServiceImpl)P_0).SignInForEntity((IEntity)P_1, (string)P_2);
	}

	internal static bool J0nLBHBHOKbKQI6aGTtJ(object P_0, object P_1)
	{
		return ((ICryptoContextAuthServiceImpl)P_0).IsSignForEntity((IEntity)P_1);
	}

	internal static void f45WMgBH2IW2xaVEyMY3(object P_0, object P_1)
	{
		((ICryptoContextAuthServiceImpl)P_0).SignOutForEntity((IEntity)P_1);
	}

	internal static object crG5X0BHe22dsPJyn7qe(object P_0, object P_1)
	{
		return ((ICryptoContextAuthServiceImpl)P_0).DecryptFromContext((IEntity)P_1);
	}

	internal static object iPQ9vqBHPed7PmgZRXnU(object P_0, object P_1)
	{
		return ((ICryptoContextAuthServiceImpl)P_0).GetPasswordFromContext((IEntity)P_1);
	}

	internal static void BhhtR0BH1VXBK6QbDoB4()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
