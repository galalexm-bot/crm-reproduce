using System;
using System.Reflection;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

internal class InternalSecurityServiceOracle : InternalSecurityServiceBase, IInternalSecurityService, ILicensedUnit, IWorkplaceLicenseInfoOwner, IConcurrentLicenseInfoOwner, IActivationTokenContainer
{
	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private ConcurrentLicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	internal static InternalSecurityServiceOracle QTbIq8X9JgIqZ478yPS;

	uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => TZAsRsXzESg1TWj9ur4(this);

	uint IConcurrentLicenseInfoOwner.UsedPrivilegeCount => p6eUAgnkPsHwrFwKBdi(this);

	protected override uint UsedLicenseCount
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					throw new LicenseException();
				case 1:
					return base.UsedLicenseCount;
				case 2:
					if (!A86QPTnAA0kon0TUFmd(ss0wTXn5mNkJu7lix3X(Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType()), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1983795824 ^ 0x763E7746)))
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string)atarHTnW1nnsKZYFEL4(0x4BBFF2C6 ^ 0x4BBFD66C));

	void IInternalSecurityService.CheckUserToAuthenticate([NotNull] EleWise.ELMA.Security.Models.IUser user, Func<bool> isAlreadyLoggedFunc, Func<int, bool> isCurrentPrivilegeFunc, Func<int> otherUsersCountFunc)
	{
		CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
	}

	bool IInternalSecurityService.CanCreateNewUser()
	{
		return o6etxTnpyKl9NIR4C8T(this);
	}

	protected override void Check(out byte licSubType, out ushort licCount, out ushort privilegeCount)
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
				Check(__ModuleInfo.UID, DecodeLastActivationKey, out licSubType, out licCount, out privilegeCount);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void CheckUserToAuthenticate([NotNull] EleWise.ELMA.Security.Models.IUser user, Func<bool> isAlreadyLoggedFunc, Func<int, bool> isCurrentPrivilegeFunc, Func<int> otherUsersCountFunc)
	{
		if (Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType().Name != SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x45F3B9A1 ^ 0x45F39C97))
		{
			throw new LicenseException();
		}
		base.CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
	}

	protected override bool CanCreateNewUser()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if ((string)ss0wTXn5mNkJu7lix3X(Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType()) != SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71CDF2F ^ 0x71CFA19))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return base.CanCreateNewUser();
			default:
				throw new LicenseException();
			}
		}
	}

	string ILicensedUnit.GetRegistrationKey()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return registrationKey;
			case 1:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void ILicensedUnit.ApplyActivationKey(string key)
	{
		//Discarded unreachable code: IL_00d5, IL_00e6, IL_0131, IL_0140, IL_014f, IL_018e, IL_0359, IL_036a
		int num = 7;
		DateTime? expirationDate = default(DateTime?);
		byte licType = default(byte);
		byte licType2 = default(byte);
		byte b2 = default(byte);
		byte b = default(byte);
		byte licSubType = default(byte);
		byte licSubType2 = default(byte);
		ushort privilegeLicCount = default(ushort);
		ushort privilegeLicCount2 = default(ushort);
		LicenseStatus status = default(LicenseStatus);
		ushort licCount = default(ushort);
		DateTime? expirationDate2 = default(DateTime?);
		ushort licCount2 = default(ushort);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				int num3;
				switch (num2)
				{
				default:
					return;
				case 12:
					if (expirationDate.HasValue)
					{
						num2 = 18;
						continue;
					}
					goto case 2;
				case 1:
					if (licType != 2)
					{
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
						{
							num2 = 25;
						}
						continue;
					}
					num4 = 1;
					goto IL_03bb;
				case 13:
					num3 = licType2;
					goto IL_03cc;
				case 24:
					return;
				case 4:
					if (b2 > b)
					{
						num2 = 26;
						continue;
					}
					if (licSubType > licSubType2)
					{
						num2 = 14;
						continue;
					}
					if (licSubType < licSubType2)
					{
						return;
					}
					num2 = 28;
					continue;
				case 27:
					if (privilegeLicCount > privilegeLicCount2)
					{
						num = 15;
						break;
					}
					return;
				case 21:
					return;
				case 20:
					return;
				case 19:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					if (!nOu9RonXglOT3e7WkL2(expirationDate.Value, expirationDate2.Value))
					{
						num2 = 2;
						continue;
					}
					goto case 29;
				case 0:
					return;
				case 16:
				{
					DecodeActivationKey(lastAppliedActKey, out var _, out licCount2, out privilegeLicCount2, out licType2, out licSubType2, out expirationDate2);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 10:
					return;
				case 2:
					if (licCount <= licCount2)
					{
						num2 = 23;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 15;
				case 3:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
					num2 = 24;
					continue;
				case 11:
					if (b2 >= b)
					{
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 6:
					if (DecodeActivationKey(key, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate))
					{
						if (lastAppliedActKey != null)
						{
							num2 = 16;
							continue;
						}
						goto case 19;
					}
					num2 = 21;
					continue;
				case 8:
					return;
				case 28:
					if (licType != 1)
					{
						num = 17;
						break;
					}
					goto case 12;
				case 15:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
					num2 = 20;
					continue;
				case 18:
					if (!expirationDate2.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 9;
				case 7:
					InitLicense();
					num = 6;
					break;
				case 26:
					return;
				case 29:
				case 30:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
					{
						num2 = 1;
					}
					continue;
				case 25:
					num4 = licType;
					goto IL_03bb;
				case 5:
					return;
				case 23:
					if (licCount != licCount2)
					{
						return;
					}
					num2 = 27;
					continue;
				case 22:
					if (licType2 != 2)
					{
						num2 = 13;
						continue;
					}
					num3 = 1;
					goto IL_03cc;
				case 17:
					{
						if (licType == 2)
						{
							num2 = 12;
							continue;
						}
						goto case 2;
					}
					IL_03cc:
					b = (byte)num3;
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
					{
						num2 = 10;
					}
					continue;
					IL_03bb:
					b2 = (byte)num4;
					num = 22;
					break;
				}
				break;
			}
		}
	}

	void ILicensedUnit.CompleteLicensingInitialize()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				licensingInitialized = true;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				InitLicense();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				initializedStatus = nZuDcfnn7A8kHG8fksn(licenseInfo);
				num2 = 3;
				break;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		int num = 1;
		int num2 = num;
		ushort num3 = default(ushort);
		uint? workplaceCount = default(uint?);
		WorkplaceLicenseInfo workplaceLicenseInfo = default(WorkplaceLicenseInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = pm3cnOniZeKFauLTru8(this);
				num2 = 7;
				break;
			case 1:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return licenseInfo;
			case 8:
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				num2 = 5;
				break;
			case 9:
			{
				ushort num4 = num3;
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				if (num4 < workplaceCount.Value)
				{
					num2 = 6;
					break;
				}
				goto case 4;
			}
			case 7:
				if (num3 > 0)
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 3:
				if (workplaceLicenseInfo != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			default:
				workplaceLicenseInfo = licenseInfo;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				workplaceLicenseInfo.WorkplaceCount = num3;
				num2 = 4;
				break;
			case 5:
				if (workplaceCount.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	void ILicensedUnit.UpdateLicenseInfo()
	{
		int num = 3;
		int num2 = num;
		LicenseStatus status = default(LicenseStatus);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Ya0nJJn7jyLZbjD6FQd(licenseInfo, status);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				InitLicense();
				num2 = 2;
				break;
			case 0:
				return;
			case 2:
			{
				DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _, out var _, out var _);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	byte[] ILicensedUnit.GetActivationToken()
	{
		return null;
	}

	ActivationToken IActivationTokenContainer.GetActivationToken()
	{
		return null;
	}

	private void InitLicense()
	{
		//Discarded unreachable code: IL_0083, IL_0137, IL_0146, IL_0177, IL_0196, IL_01c2, IL_01d1, IL_01f6, IL_0205
		int num = 3;
		int num2 = num;
		bool lockTaken = default(bool);
		InternalSecurityServiceOracle internalSecurityServiceOracle = default(InternalSecurityServiceOracle);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				lockTaken = false;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				return;
			case 2:
				internalSecurityServiceOracle = this;
				num2 = 5;
				break;
			case 4:
				try
				{
					Monitor.Enter(internalSecurityServiceOracle, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
					{
						num3 = 3;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							registrationKey = GenerateRegistrationKey(1);
							num3 = 5;
							break;
						case 3:
							if (initialized)
							{
								num3 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto case 1;
						case 5:
						{
							ConcurrentLicenseInfo concurrentLicenseInfo = new ConcurrentLicenseInfo(this);
							Ya0nJJn7jyLZbjD6FQd(concurrentLicenseInfo, LicenseStatus.NotActivated);
							licenseInfo = concurrentLicenseInfo;
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
							{
								num3 = 0;
							}
							break;
						}
						default:
							initialized = true;
							num3 = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
							{
								num3 = 2;
							}
							break;
						case 2:
							return;
						case 4:
							return;
						}
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
						{
							num4 = 0;
						}
						goto IL_017b;
					}
					goto IL_01a0;
					IL_01a0:
					AYoXIGn6BxZEvJkJPAx(internalSecurityServiceOracle);
					num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
					{
						num4 = 1;
					}
					goto IL_017b;
					IL_017b:
					switch (num4)
					{
					default:
						goto end_IL_0156;
					case 0:
						goto end_IL_0156;
					case 2:
						break;
					case 1:
						goto end_IL_0156;
					}
					goto IL_01a0;
					end_IL_0156:;
				}
			case 3:
				if (initialized)
				{
					return;
				}
				num2 = 2;
				break;
			case 0:
				return;
			}
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_008f, IL_009e, IL_00d2, IL_0104
		int num = 8;
		int num2 = num;
		string text = default(string);
		string text2 = default(string);
		uint hnL = default(uint);
		uint hnH = default(uint);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 4:
				text = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B47B00F) + text;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				return (string)LQ5doZnZ9JDMYjlkGPL(aVUtx2nlOedHxsDw99R(text, text2));
			case 5:
				text2 = (string)aVUtx2nlOedHxsDw99R(atarHTnW1nnsKZYFEL4(-1718905545 ^ -1718904167), text2);
				num2 = 10;
				break;
			case 3:
				text2 = hnL.ToString();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (text.Length >= 10)
				{
					goto case 9;
				}
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
				{
					num2 = 2;
				}
				break;
			case 9:
			case 10:
				if (wZRKOAnNGCZ2TPYZoLU(text2) >= 10)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 7:
				text = hnH.ToString();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				LicensedUnitBase.GHN(out hnH, out hnL);
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_0094, IL_00ef, IL_0137, IL_0181, IL_0190
		int num = 14;
		int num2 = num;
		int num3 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		char[] array = default(char[]);
		while (true)
		{
			switch (num2)
			{
			case 11:
				if (num3 % 5 == 0)
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 4:
				G5wlHqnBBkcnYeDtYZL(stringBuilder, '-');
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db != 0)
				{
					num2 = 6;
				}
				break;
			default:
				if (num3 < array.Length)
				{
					num2 = 2;
					break;
				}
				goto case 8;
			case 12:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				array = (char[])D5B6t2nxTFb9XYj9viC(key);
				num2 = 12;
				break;
			case 8:
				return stringBuilder.ToString();
			case 1:
			case 7:
				G5wlHqnBBkcnYeDtYZL(stringBuilder, array[num3]);
				num2 = 5;
				break;
			case 2:
			case 6:
				if (num3 <= 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 11;
			case 5:
				num3++;
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
				{
					num2 = 10;
				}
				break;
			case 3:
				return string.Empty;
			case 13:
				stringBuilder = new StringBuilder();
				num2 = 9;
				break;
			case 14:
				if (key != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private bool DecodeLastActivationKey(out LicenseStatus status, out ushort licCount, out ushort privilegeLicCount, out byte licType, out byte licSubType, out DateTime? expirationDate)
	{
		return DecodeActivationKey(lastAppliedActKey, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate);
	}

	private bool DecodeActivationKey(string key, out LicenseStatus status, out ushort licCount, out ushort privilegeLicCount, out byte licType, out byte licSubType, out DateTime? expirationDate)
	{
		//Discarded unreachable code: IL_024e, IL_025d, IL_030f, IL_0360, IL_036f
		int num = 7;
		int num2 = num;
		uint hnH = default(uint);
		bool result = default(bool);
		uint hnL = default(uint);
		ushort num6 = default(ushort);
		while (true)
		{
			switch (num2)
			{
			default:
				privilegeLicCount = 0;
				num2 = 10;
				break;
			case 12:
				return false;
			case 2:
				licSubType = 0;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				licType = 0;
				num2 = 11;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
				{
					num2 = 12;
				}
				break;
			case 4:
				key = (string)pmt8HAnuBk5KbMNnMin(((string)pmt8HAnuBk5KbMNnMin(pmt8HAnuBk5KbMNnMin(key, atarHTnW1nnsKZYFEL4(--553267277 ^ 0x20FA39D5), ""), atarHTnW1nnsKZYFEL4(0x71CDF2F ^ 0x71CFBD5), "")).Replace((string)atarHTnW1nnsKZYFEL4(-1957236745 ^ -1957246217), "").Replace((string)atarHTnW1nnsKZYFEL4(0x71CDF2F ^ 0x71CFA29), ""), atarHTnW1nnsKZYFEL4(0x7CAA49C6 ^ 0x7CAA6CCA), "");
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (wZRKOAnNGCZ2TPYZoLU(key) == 20)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 9;
			case 9:
				status = LicenseStatus.NotActivated;
				num2 = 11;
				break;
			case 10:
				if (key != null)
				{
					num2 = 4;
					break;
				}
				goto case 9;
			case 5:
				try
				{
					uint num3 = XYmOUynebnZ6UwLJ0om(JXvgXenmcfHKHFtZJlG(key, 0, 10));
					uint num4 = XYmOUynebnZ6UwLJ0om(key.Substring(10, 10));
					if (num3 == ~hnH)
					{
						int num5 = 7;
						while (true)
						{
							switch (num5)
							{
							case 9:
								return result;
							case 7:
								if (num4 == ~hnL)
								{
									num5 = 4;
									continue;
								}
								break;
							case 10:
								num6 = pm3cnOniZeKFauLTru8(this);
								num5 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
								{
									num5 = 1;
								}
								continue;
							default:
								licCount = num6;
								num5 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
								{
									num5 = 3;
								}
								continue;
							case 5:
								licType = byte.MaxValue;
								num5 = 10;
								continue;
							case 6:
								if (num6 < licCount)
								{
									num5 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
									{
										num5 = 0;
									}
									continue;
								}
								goto case 3;
							case 4:
							{
								status = LicenseStatus.Activated;
								int num7 = 8;
								num5 = num7;
								continue;
							}
							case 3:
								result = true;
								num5 = 9;
								continue;
							case 8:
								licCount = 65000;
								num5 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
								{
									num5 = 5;
								}
								continue;
							case 2:
								if (num6 > 0)
								{
									num5 = 6;
									continue;
								}
								goto case 3;
							case 1:
								break;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num8 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
					{
						num8 = 0;
					}
					while (true)
					{
						switch (num8)
						{
						default:
							bmw6MvnLKmAoC2cmVRe(Logger.Log, atarHTnW1nnsKZYFEL4(0x6AA79E0 ^ 0x6AA5CF2), ex);
							num8 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
							{
								num8 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				goto case 9;
			case 11:
				licCount = 0;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
				{
					num2 = 8;
				}
				break;
			case 1:
				LicensedUnitBase.GHN(out hnH, out hnL);
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				expirationDate = null;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				InitLicense();
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private void SetLastAppliedKey(string key, LicenseStatus newStatus, ushort newLicCount, ushort newPrivilegeCount, DateTime? newExpirationDate, byte newLicType, byte newSubType)
	{
		lastAppliedActKey = key;
		if (licensingInitialized && newStatus == LicenseStatus.Activated && initializedStatus != 0)
		{
			licenseInfo.Status = LicenseStatus.NeedRestart;
		}
		else
		{
			licenseInfo.Status = newStatus;
		}
		licenseInfo.LicenseType = newLicType;
		licenseInfo.IsConcurrent = newSubType == 1;
		licenseInfo.WorkplaceCount = ((newLicCount >= 65000) ? null : new uint?(newLicCount));
		licenseInfo.PrivilegeCount = ((newPrivilegeCount >= 65000) ? null : new uint?(newPrivilegeCount));
		licenseInfo.TrialExpiration = newExpirationDate;
	}

	public InternalSecurityServiceOracle()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static uint TZAsRsXzESg1TWj9ur4(object P_0)
	{
		return ((InternalSecurityServiceBase)P_0).UsedLicenseCount;
	}

	internal static uint p6eUAgnkPsHwrFwKBdi(object P_0)
	{
		return ((InternalSecurityServiceBase)P_0).UsedPrivilegeCount;
	}

	internal static bool o6etxTnpyKl9NIR4C8T(object P_0)
	{
		return ((InternalSecurityServiceBase)P_0).CanCreateNewUser();
	}

	internal static bool K35TdqXfCncEjMb8xH1()
	{
		return QTbIq8X9JgIqZ478yPS == null;
	}

	internal static InternalSecurityServiceOracle CNYGBmX1QofI69GVQr3()
	{
		return QTbIq8X9JgIqZ478yPS;
	}

	internal static object ss0wTXn5mNkJu7lix3X(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool A86QPTnAA0kon0TUFmd(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object atarHTnW1nnsKZYFEL4(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool nOu9RonXglOT3e7WkL2(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static LicenseStatus nZuDcfnn7A8kHG8fksn(object P_0)
	{
		return ((LicenseInfo)P_0).Status;
	}

	internal static ushort pm3cnOniZeKFauLTru8(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetDbLicenseCount();
	}

	internal static void Ya0nJJn7jyLZbjD6FQd(object P_0, LicenseStatus P_1)
	{
		((LicenseInfo)P_0).Status = P_1;
	}

	internal static void AYoXIGn6BxZEvJkJPAx(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object aVUtx2nlOedHxsDw99R(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int wZRKOAnNGCZ2TPYZoLU(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object LQ5doZnZ9JDMYjlkGPL(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object D5B6t2nxTFb9XYj9viC(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object G5wlHqnBBkcnYeDtYZL(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object pmt8HAnuBk5KbMNnMin(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object JXvgXenmcfHKHFtZJlG(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static uint XYmOUynebnZ6UwLJ0om(object P_0)
	{
		return uint.Parse((string)P_0);
	}

	internal static void bmw6MvnLKmAoC2cmVRe(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
