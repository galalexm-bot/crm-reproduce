using System;
using System.Collections.Generic;
using EleWise.ELMA.Licensing;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Modules.Impl;

public abstract class ComplexLicensedUnit : ComplexLicensedUnit<ILicensedUnit>
{
	private static ComplexLicensedUnit vjEA8K1yQpuP55fQiqV;

	public ComplexLicensedUnit(ILicensedUnit e, ILicensedUnit s, ILicensedUnit o)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(e, s, o);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool eEbWku1M3UNL5PDYA7O()
	{
		return vjEA8K1yQpuP55fQiqV == null;
	}

	internal static ComplexLicensedUnit g9powp1JDsCD9sgrRTe()
	{
		return vjEA8K1yQpuP55fQiqV;
	}
}
public abstract class ComplexLicensedUnit<TIntf> : LicensedUnitBase, ILicensedUnit, IActivationTokenContainer where TIntf : ILicensedUnit
{
	private TIntf e;

	private TIntf s;

	private TIntf o;

	private List<TIntf> all;

	internal static object iwyjrG19uqqwKlGun3B;

	protected virtual bool ApplyKeysToAll => false;

	protected virtual TIntf ActiveUnit
	{
		get
		{
			if (!string.IsNullOrEmpty(MainProviderType) && !(MainProviderType == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812053814)))
			{
				if (!(MainProviderType == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289719098)))
				{
					return o;
				}
				return s;
			}
			return e;
		}
	}

	Guid ILicensedUnit.RegistrationKeyMethodUid
	{
		get
		{
			int num = 1;
			int num2 = num;
			TIntf activeUnit = default(TIntf);
			while (true)
			{
				switch (num2)
				{
				default:
					return activeUnit.RegistrationKeyMethodUid;
				case 1:
					activeUnit = ActiveUnit;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ComplexLicensedUnit(TIntf e, TIntf s, TIntf o)
	{
		SingletonReader.JJCZtPuTvSt();
		all = new List<TIntf>();
		base._002Ector();
		this.e = e;
		this.s = s;
		this.o = o;
		all.Add(e);
		all.Add(s);
		all.Add(o);
	}

	string ILicensedUnit.GetRegistrationKey()
	{
		int num = 1;
		int num2 = num;
		TIntf activeUnit = default(TIntf);
		while (true)
		{
			switch (num2)
			{
			default:
				return activeUnit.GetRegistrationKey();
			case 1:
				activeUnit = ActiveUnit;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void ILicensedUnit.ApplyActivationKey(string key)
	{
		//Discarded unreachable code: IL_0041
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		TIntf activeUnit = default(TIntf);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!ApplyKeysToAll)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 4:
				all.ForEach(_003C_003Ec__DisplayClass8_._003CEleWise_002EELMA_002EModules_002EILicensedUnit_002EApplyActivationKey_003Eb__0);
				num2 = 7;
				break;
			case 2:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass8_.key = key;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				activeUnit.ApplyActivationKey(_003C_003Ec__DisplayClass8_.key);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				return;
			case 7:
				return;
			case 5:
				activeUnit = ActiveUnit;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	void ILicensedUnit.CompleteLicensingInitialize()
	{
		int num = 4;
		int num2 = num;
		TIntf activeUnit = default(TIntf);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 4:
				if (!ApplyKeysToAll)
				{
					activeUnit = ActiveUnit;
					num2 = 2;
					break;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 3;
				}
				break;
			case 0:
				return;
			case 2:
				activeUnit.CompleteLicensingInitialize();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				all.ForEach(delegate(TIntf a)
				{
					a.CompleteLicensingInitialize();
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		int num = 1;
		int num2 = num;
		TIntf activeUnit = default(TIntf);
		while (true)
		{
			switch (num2)
			{
			default:
				return activeUnit.GetLicenseInfo();
			case 1:
				activeUnit = ActiveUnit;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void ILicensedUnit.UpdateLicenseInfo()
	{
		int num = 3;
		int num2 = num;
		TIntf activeUnit = default(TIntf);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (ApplyKeysToAll)
				{
					num2 = 2;
					break;
				}
				activeUnit = ActiveUnit;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				activeUnit.UpdateLicenseInfo();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 2:
				all.ForEach(delegate(TIntf a)
				{
					a.UpdateLicenseInfo();
				});
				num2 = 4;
				break;
			}
		}
	}

	byte[] ILicensedUnit.GetActivationToken()
	{
		int num = 1;
		int num2 = num;
		TIntf activeUnit = default(TIntf);
		while (true)
		{
			switch (num2)
			{
			case 1:
				activeUnit = ActiveUnit;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return activeUnit.GetActivationToken();
			}
		}
	}

	ActivationToken IActivationTokenContainer.GetActivationToken()
	{
		//Discarded unreachable code: IL_003b
		int num = 1;
		int num2 = num;
		IActivationTokenContainer activationTokenContainer = default(IActivationTokenContainer);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			case 2:
				return activationTokenContainer.GetActivationToken();
			case 1:
				activationTokenContainer = ActiveUnit as IActivationTokenContainer;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (activationTokenContainer != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	internal static bool ujO6NZ1dTrxgr6iFehK()
	{
		return iwyjrG19uqqwKlGun3B == null;
	}

	internal static object kKK6X71lOoxZfQ2Laf3()
	{
		return iwyjrG19uqqwKlGun3B;
	}
}
