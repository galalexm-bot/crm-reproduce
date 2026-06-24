using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.Crypto;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

public class SecuritySettings : GlobalSettingsBase
{
	private int passwordMinLength;

	private int periodicityOfForcedChangePassword;

	private int countLogonAttempts;

	private int blockingPeriod;

	private int periodResetCountLogonAttempt;

	internal static SecuritySettings Nq6gcfzBjHMw25ot6Y8;

	[DisplayName(typeof(SecuritySettings_SR), "DefaultAuthCryptoProviderSettings")]
	[IgnoreDataMember]
	public DefaultCryptoProviderSettings DefaultAuthCryptoProviderSettings
	{
		get
		{
			//Discarded unreachable code: IL_0057, IL_0066
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (mAfWwozw0N1i9TJnPZ6(SerializeDefaultAuthCryptoProviderSettings))
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return ClassSerializationHelper.DeserializeObjectByJson<DefaultCryptoProviderSettings>(SerializeDefaultAuthCryptoProviderSettings);
				case 1:
					return new DefaultCryptoProviderSettings(new Guid((string)XCHE43zR41NahF7hEhr(0x6AA79E0 ^ 0x6AB7196)), new Guid((string)XCHE43zR41NahF7hEhr(-930147978 ^ -930210796)));
				}
			}
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					SerializeDefaultAuthCryptoProviderSettings = (string)bcaKnaz2mSrddu456N7(value);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string SerializeDefaultAuthCryptoProviderSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CSerializeDefaultAuthCryptoProviderSettings_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CSerializeDefaultAuthCryptoProviderSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[DisplayName(typeof(SecuritySettings_SR), "AllowLoginByCertificate")]
	public bool AllowLoginByCertificate
	{
		[CompilerGenerated]
		get
		{
			return _003CAllowLoginByCertificate_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CAllowLoginByCertificate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[DisplayName(typeof(SecuritySettings_SR), "AllowLoginByToken")]
	public bool AllowLoginByToken
	{
		[CompilerGenerated]
		get
		{
			return _003CAllowLoginByToken_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CAllowLoginByToken_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(SecuritySettings_SR), "AllowLoginOnlyByDefaultCertificate")]
	public bool AllowLoginOnlyByDefaultCertificate
	{
		[CompilerGenerated]
		get
		{
			return _003CAllowLoginOnlyByDefaultCertificate_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CAllowLoginOnlyByDefaultCertificate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long FreezeAuthenticationOnPingTimeoutTicks
	{
		[CompilerGenerated]
		get
		{
			return _003CFreezeAuthenticationOnPingTimeoutTicks_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CFreezeAuthenticationOnPingTimeoutTicks_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public TimeSpan FreezeAuthenticationOnPingTimeoutTime
	{
		get
		{
			return new TimeSpan(FreezeAuthenticationOnPingTimeoutTicks);
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					FreezeAuthenticationOnPingTimeoutTicks = ((value > OA5baRzLaCgw9oug1cR(3.0)) ? value : OA5baRzLaCgw9oug1cR(3.0)).Ticks;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long SignOutOnPingTimeoutTicks
	{
		[CompilerGenerated]
		get
		{
			return _003CSignOutOnPingTimeoutTicks_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CSignOutOnPingTimeoutTicks_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public TimeSpan SignOutOnPingTimeoutTime
	{
		get
		{
			return new TimeSpan(SignOutOnPingTimeoutTicks);
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					SignOutOnPingTimeoutTicks = ((value > OA5baRzLaCgw9oug1cR(3.0)) ? value : OA5baRzLaCgw9oug1cR(3.0)).Ticks;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool SignOutOnActionTimeout
	{
		[CompilerGenerated]
		get
		{
			return _003CSignOutOnActionTimeout_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CSignOutOnActionTimeout_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long SignOutOnActionTimeoutTicks
	{
		[CompilerGenerated]
		get
		{
			return _003CSignOutOnActionTimeoutTicks_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CSignOutOnActionTimeoutTicks_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TimeSpan SignOutOnActionTimeoutTime
	{
		get
		{
			return new TimeSpan(SignOutOnActionTimeoutTicks);
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					SignOutOnActionTimeoutTicks = (t8RUAQzPmGl54BtQqxS(value, OA5baRzLaCgw9oug1cR(3.0)) ? value : OA5baRzLaCgw9oug1cR(3.0)).Ticks;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool SignOutPrivilegedUsers
	{
		[CompilerGenerated]
		get
		{
			return _003CSignOutPrivilegedUsers_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CSignOutPrivilegedUsers_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool IsPrivilegedLicense
	{
		get
		{
			//Discarded unreachable code: IL_003a, IL_0044
			int num = 3;
			int num2 = num;
			IConcurrentLicenseInfo concurrentLicenseInfo = default(IConcurrentLicenseInfo);
			ILicensedUnit mainLicensedUnit = default(ILicensedUnit);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					obj = null;
					break;
				case 5:
					return PxEgXPzUPAcUxjxjCwQ(concurrentLicenseInfo);
				default:
					return false;
				case 2:
					if (mainLicensedUnit == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = QUSO4LzCPnobuK7rslH(mainLicensedUnit) as IConcurrentLicenseInfo;
					break;
				case 3:
					mainLicensedUnit = ((ComponentManager)WfWoYIzvCPKqyXPdTsm()).ModuleManager.MainLicensedUnit;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 != 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					if (concurrentLicenseInfo == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				}
				concurrentLicenseInfo = (IConcurrentLicenseInfo)obj;
				num2 = 4;
			}
		}
	}

	public long SignOutPrivilegedUsersTimeoutTicks
	{
		[CompilerGenerated]
		get
		{
			return _003CSignOutPrivilegedUsersTimeoutTicks_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CSignOutPrivilegedUsersTimeoutTicks_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TimeSpan SignOutPrivilegedUsersTimeoutTime
	{
		get
		{
			return new TimeSpan(SignOutPrivilegedUsersTimeoutTicks);
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					SignOutPrivilegedUsersTimeoutTicks = (t8RUAQzPmGl54BtQqxS(value, TimeSpan.FromMinutes(10.0)) ? value : TimeSpan.FromMinutes(10.0)).Ticks;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(SecuritySettings_SR), "DenyEditSecurityUserProfile")]
	public bool DenyEditSecurityUserProfile
	{
		[CompilerGenerated]
		get
		{
			return _003CDenyEditSecurityUserProfile_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CDenyEditSecurityUserProfile_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Description(typeof(SecuritySettings_SR), "CountLogonAttempts_Description")]
	[DisplayName(typeof(SecuritySettings_SR), "CountLogonAttempts")]
	public int CountLogonAttempts
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return 0;
				case 1:
					if (countLogonAttempts > 0)
					{
						return countLogonAttempts;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_003a, IL_0049
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 5:
					return;
				case 1:
					MUsvXHzhTyKD02RBUCy(qcLQ2nztZbSeDoxrMPR());
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
					{
						num2 = 3;
					}
					break;
				default:
					countLogonAttempts = value;
					num2 = 5;
					break;
				case 4:
					countLogonAttempts = 0;
					num2 = 3;
					break;
				case 2:
					if (value <= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	[DisplayName(typeof(SecuritySettings_SR), "BlockingPeriod")]
	[Description(typeof(SecuritySettings_SR), "BlockingPeriod_Description")]
	public int BlockingPeriod
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return 0;
				case 1:
					if (blockingPeriod > 0)
					{
						return blockingPeriod;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					blockingPeriod = ((value > 0) ? value : 0);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Description(typeof(SecuritySettings_SR), "ResetCountLoginAttempts_Description")]
	[DisplayName(typeof(SecuritySettings_SR), "ResetCountLoginAttempts")]
	public int PeriodResetCountLogonAttempts
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (periodResetCountLogonAttempt <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
						{
							num2 = 0;
						}
						break;
					}
					return periodResetCountLogonAttempt;
				default:
					return 0;
				}
			}
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					periodResetCountLogonAttempt = ((value > 0) ? value : 0);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Description(typeof(SecuritySettings_SR), "NotifyBlocking_Description")]
	[DisplayName(typeof(SecuritySettings_SR), "NotifyBlocking")]
	public bool NotifyBlocking
	{
		[CompilerGenerated]
		get
		{
			return _003CNotifyBlocking_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CNotifyBlocking_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string NotifyUsersId
	{
		[CompilerGenerated]
		get
		{
			return _003CNotifyUsersId_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CNotifyUsersId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Description(typeof(SecuritySettings_SR), "NotifyUsers_Description")]
	[DisplayName(typeof(SecuritySettings_SR), "NotifyUsers")]
	[IgnoreDataMember]
	public List<EleWise.ELMA.Security.Models.IUser> NotifyUsers
	{
		get
		{
			List<EleWise.ELMA.Security.Models.IUser> list = new List<EleWise.ELMA.Security.Models.IUser>();
			if (!string.IsNullOrEmpty(NotifyUsersId))
			{
				string[] array = NotifyUsersId.Split(',');
				for (int i = 0; i < array.Length; i++)
				{
					if (long.TryParse(array[i], out var result))
					{
						list.Add(UserManager.Instance.LoadOrNull(result));
					}
				}
			}
			return list;
		}
		set
		{
			string notifyUsersId = null;
			if (value != null)
			{
				List<long> list = new List<long>();
				foreach (EleWise.ELMA.Security.Models.IUser item in value)
				{
					list.Add(item.Id);
				}
				notifyUsersId = list.ToSeparatedString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4CD4C8A0 ^ 0x4CD4D26E));
			}
			NotifyUsersId = notifyUsersId;
		}
	}

	[DisplayName(typeof(SecuritySettings_SR), "PasswordMinLength")]
	public int PasswordMinLength
	{
		get
		{
			//Discarded unreachable code: IL_005c, IL_006b
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (passwordMinLength > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return 0;
				default:
					return passwordMinLength;
				}
			}
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					passwordMinLength = ((value > 0) ? value : 0);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(SecuritySettings_SR), "IsComplexPassword")]
	[Description(typeof(SecuritySettings_SR), "IsComplexPassword_Description")]
	public bool IsComplexPassword
	{
		[CompilerGenerated]
		get
		{
			return _003CIsComplexPassword_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CIsComplexPassword_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[Description(typeof(SecuritySettings_SR), "PeriodicityOfForcedChangePassword_Description")]
	[DisplayName(typeof(SecuritySettings_SR), "PeriodicityOfForcedChangePassword")]
	public int PeriodicityOfForcedChangePassword
	{
		get
		{
			//Discarded unreachable code: IL_005c, IL_006b
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return 0;
				case 1:
					return periodicityOfForcedChangePassword;
				case 2:
					if (periodicityOfForcedChangePassword > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					periodicityOfForcedChangePassword = ((value > 0) ? value : 0);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(SecuritySettings_SR), "ForcedChangePasswordOnFirstLogon")]
	public bool ForcedChangePasswordOnFirstLogon
	{
		[CompilerGenerated]
		get
		{
			return _003CForcedChangePasswordOnFirstLogon_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CForcedChangePasswordOnFirstLogon_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public long ExclusionGroupId
	{
		[CompilerGenerated]
		get
		{
			return _003CExclusionGroupId_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CExclusionGroupId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Description(typeof(SecuritySettings_SR), "ExclusionGroup_Description")]
	[IgnoreDataMember]
	[DisplayName(typeof(SecuritySettings_SR), "ExclusionGroup")]
	public IUserGroup ExclusionGroup
	{
		get
		{
			return ((AbstractNHEntityManager<IUserGroup, long>)YnbWxHzOiQBJfEePCh1()).LoadOrNull(ExclusionGroupId);
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					ExclusionGroupId = value?.Id ?? 0;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SecuritySettings()
	{
		//Discarded unreachable code: IL_001a
		TpwE4hze5rsgRS2IDLT();
		base._002Ector();
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 5:
				FreezeAuthenticationOnPingTimeoutTime = OA5baRzLaCgw9oug1cR(3.0);
				num = 2;
				break;
			case 4:
				NotifyUsers = new List<EleWise.ELMA.Security.Models.IUser> { ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)cBNNyPzaBCXuCYslOK6()).Load(SecurityConstants.AdminUserUid) };
				num = 3;
				break;
			case 1:
				SignOutPrivilegedUsersTimeoutTime = sLIV93zj7adrZS3mvhO(1.0);
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
				{
					num = 0;
				}
				break;
			default:
				ExclusionGroup = UserGroupManager.Instance.Load(SecurityConstants.AdminGroupUid);
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
				{
					num = 4;
				}
				break;
			case 7:
				SignOutOnActionTimeoutTime = IfIS1MzHMA2M1xOSdaB(1.0);
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				SignOutOnPingTimeoutTime = sLIV93zj7adrZS3mvhO(1.0);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
				{
					num = 7;
				}
				break;
			case 6:
				return;
			case 3:
			{
				DefaultAuthCryptoProviderSettings = new DefaultCryptoProviderSettings(new Guid((string)XCHE43zR41NahF7hEhr(0x8875F5C ^ 0x886572A)), new Guid((string)XCHE43zR41NahF7hEhr(0xFD0849E ^ 0xFD189FC)));
				int num2 = 6;
				num = num2;
				break;
			}
			}
		}
	}

	protected override bool SkipProperty(PropertyInfo property)
	{
		//Discarded unreachable code: IL_0041, IL_009e, IL_00d7, IL_00e6
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				return sp0GwQzJZcg30y2GST2(CnMwFIzKZNQkVkjFfiX(property), XCHE43zR41NahF7hEhr(0x28EBA022 ^ 0x28EAB4C0));
			case 4:
			case 5:
			case 7:
				return true;
			case 3:
				if (sp0GwQzJZcg30y2GST2(property.Name, XCHE43zR41NahF7hEhr(-1195916818 ^ -1195977404)))
				{
					num2 = 5;
					break;
				}
				goto case 6;
			case 1:
				if (sp0GwQzJZcg30y2GST2(property.Name, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-426925384 ^ -426985840)))
				{
					num2 = 7;
					break;
				}
				goto default;
			case 2:
				if (!ToUqZdzoSH7FPiIMqvt(this, property))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			default:
				if (sp0GwQzJZcg30y2GST2(CnMwFIzKZNQkVkjFfiX(property), XCHE43zR41NahF7hEhr(0x5FD42272 ^ 0x5FD53604)))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			}
		}
	}

	internal static void TpwE4hze5rsgRS2IDLT()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static TimeSpan OA5baRzLaCgw9oug1cR(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static TimeSpan sLIV93zj7adrZS3mvhO(double P_0)
	{
		return TimeSpan.FromDays(P_0);
	}

	internal static TimeSpan IfIS1MzHMA2M1xOSdaB(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static object cBNNyPzaBCXuCYslOK6()
	{
		return UserManager.Instance;
	}

	internal static object XCHE43zR41NahF7hEhr(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool nanbSQzuqCxElAsPpkA()
	{
		return Nq6gcfzBjHMw25ot6Y8 == null;
	}

	internal static SecuritySettings jleKPPzmyaajpngSMCS()
	{
		return Nq6gcfzBjHMw25ot6Y8;
	}

	internal static bool mAfWwozw0N1i9TJnPZ6(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object bcaKnaz2mSrddu456N7(object P_0)
	{
		return ClassSerializationHelper.SerializeObjectByJson(P_0);
	}

	internal static bool t8RUAQzPmGl54BtQqxS(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 > P_1;
	}

	internal static object WfWoYIzvCPKqyXPdTsm()
	{
		return ComponentManager.Current;
	}

	internal static object QUSO4LzCPnobuK7rslH(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static bool PxEgXPzUPAcUxjxjCwQ(object P_0)
	{
		return ((IConcurrentLicenseInfo)P_0).IsConcurrent;
	}

	internal static bool ToUqZdzoSH7FPiIMqvt(object P_0, object P_1)
	{
		return ((GlobalSettingsBase)P_0).SkipProperty((PropertyInfo)P_1);
	}

	internal static bool sp0GwQzJZcg30y2GST2(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object CnMwFIzKZNQkVkjFfiX(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object qcLQ2nztZbSeDoxrMPR()
	{
		return UserSecurityProfileManager.Instance;
	}

	internal static void MUsvXHzhTyKD02RBUCy(object P_0)
	{
		((UserSecurityProfileManager)P_0).ResetCountFailedLogonAllUsers();
	}

	internal static object YnbWxHzOiQBJfEePCh1()
	{
		return UserGroupManager.Instance;
	}
}
