using System;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

internal sealed class EntityPropertyFilterableBehaviour : IPublicationBehaviourChecker
{
	private static EntityPropertyFilterableBehaviour Vderedb1qZY9l5ImcyyW;

	public PublicationType Check(CheckType action, object oldValue, object newValue)
	{
		//Discarded unreachable code: IL_0062, IL_00ca, IL_011a, IL_0129
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return PublicationType.Soft;
			case 7:
				if (oldValue.Equals(true))
				{
					num2 = 4;
					break;
				}
				goto case 8;
			case 1:
				return PublicationType.Delta;
			case 5:
				if (action == CheckType.Change)
				{
					if (!oldValue.Equals(newValue))
					{
						num2 = 7;
						break;
					}
					goto case 3;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				if (action != 0)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 8:
				return PublicationType.Delta;
			default:
				return PublicationType.Restart;
			case 2:
				throw new ArgumentOutOfRangeException((string)e61MxRb1TeiqclNgBexF(0x4D1C1EE4 ^ 0x4D1D0710), action, SR.T((string)e61MxRb1TeiqclNgBexF(-1870892489 ^ -1870751927)));
			case 4:
				if (newValue.Equals(false))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			}
		}
	}

	public EntityPropertyFilterableBehaviour()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object e61MxRb1TeiqclNgBexF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool CUi2l6b1KVhnPbjAa8Zk()
	{
		return Vderedb1qZY9l5ImcyyW == null;
	}

	internal static EntityPropertyFilterableBehaviour InvVTgb1X0r2Ou0BpcEM()
	{
		return Vderedb1qZY9l5ImcyyW;
	}
}
