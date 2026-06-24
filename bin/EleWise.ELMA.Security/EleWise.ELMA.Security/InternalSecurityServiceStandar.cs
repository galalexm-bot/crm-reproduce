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

internal class InternalSecurityServiceStandart : InternalSecurityServiceBase, IInternalSecurityService, ILicensedUnit, IWorkplaceLicenseInfoOwner, IConcurrentLicenseInfoOwner, IActivationTokenContainer
{
	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private ConcurrentLicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	internal static InternalSecurityServiceStandart FNaAjVnjIHPTfG1BkTD;

	uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => mlVSFOnR2RiLAwVTfa0(this);

	uint IConcurrentLicenseInfoOwner.UsedPrivilegeCount => xESgYZnwLICUuLRxh7e(this);

	protected override uint UsedLicenseCount
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
					if (Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType().Name != (string)HT5Ep3nPmlw0Cron8OD(0x2CFDCC80 ^ 0x2CFDE9D6))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return base.UsedLicenseCount;
				default:
					throw new LicenseException();
				}
			}
		}
	}

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string)HT5Ep3nPmlw0Cron8OD(0x4B68CDFB ^ 0x4B68E951));

	void IInternalSecurityService.CheckUserToAuthenticate([NotNull] EleWise.ELMA.Security.Models.IUser user, Func<bool> isAlreadyLoggedFunc, Func<int, bool> isCurrentPrivilegeFunc, Func<int> otherUsersCountFunc)
	{
		CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
	}

	bool IInternalSecurityService.CanCreateNewUser()
	{
		return V8Z1Xjn21m6FE49RmvX(this);
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
			case 0:
				return;
			case 1:
				Check(__ModuleInfo.UID, DecodeLastActivationKey, out licSubType, out licCount, out privilegeCount);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void CheckUserToAuthenticate([NotNull] EleWise.ELMA.Security.Models.IUser user, Func<bool> isAlreadyLoggedFunc, Func<int, bool> isCurrentPrivilegeFunc, Func<int> otherUsersCountFunc)
	{
		if (Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType().Name != SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A799728 ^ 0x4A79B27E))
		{
			throw new LicenseException();
		}
		base.CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
	}

	protected override bool CanCreateNewUser()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!Xf2C2pnCbolXBBY82o1(oNfNovnvUpftdTcJRp9(Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType()), HT5Ep3nPmlw0Cron8OD(0xD946FDB ^ 0xD944A8D)))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new LicenseException();
			default:
				return base.CanCreateNewUser();
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
			case 1:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return registrationKey;
			}
		}
	}

	void ILicensedUnit.ApplyActivationKey(string key)
	{
		//Discarded unreachable code: IL_0113, IL_014a, IL_0156, IL_01a0, IL_01af, IL_025c, IL_02a0, IL_02d4, IL_035e
		int num = 9;
		byte licType2 = default(byte);
		ushort licCount2 = default(ushort);
		ushort privilegeLicCount2 = default(ushort);
		byte licType = default(byte);
		byte licSubType2 = default(byte);
		DateTime? expirationDate2 = default(DateTime?);
		byte licSubType = default(byte);
		DateTime? expirationDate = default(DateTime?);
		byte b2 = default(byte);
		byte b = default(byte);
		LicenseStatus status = default(LicenseStatus);
		ushort licCount = default(ushort);
		ushort privilegeLicCount = default(ushort);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				int num3;
				switch (num2)
				{
				case 20:
					if (licType2 != 2)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
						{
							num2 = 19;
						}
						continue;
					}
					num4 = 1;
					goto IL_03da;
				case 1:
					return;
				default:
				{
					if (lastAppliedActKey == null)
					{
						num2 = 25;
						continue;
					}
					DecodeActivationKey(lastAppliedActKey, out var _, out licCount2, out privilegeLicCount2, out licType, out licSubType2, out expirationDate2);
					num = 20;
					break;
				}
				case 5:
					return;
				case 12:
					if (licSubType <= licSubType2)
					{
						num2 = 28;
						continue;
					}
					goto case 24;
				case 29:
					return;
				case 28:
					if (licSubType < licSubType2)
					{
						num2 = 17;
						continue;
					}
					if (licType2 != 1)
					{
						num2 = 30;
						continue;
					}
					goto case 21;
				case 30:
					if (licType2 == 2)
					{
						num2 = 21;
						continue;
					}
					goto case 6;
				case 21:
					if (expirationDate.HasValue)
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 6;
				case 7:
					num3 = licType;
					goto IL_03e7;
				case 14:
					return;
				case 17:
					return;
				case 13:
					return;
				case 16:
					if (b2 < b)
					{
						num2 = 31;
						continue;
					}
					if (b2 > b)
					{
						return;
					}
					num2 = 12;
					continue;
				case 18:
				case 23:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType2, licSubType);
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
					if (!expirationDate2.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 27;
				case 4:
					if (privilegeLicCount <= privilegeLicCount2)
					{
						return;
					}
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
					{
						num2 = 18;
					}
					continue;
				case 3:
					return;
				case 6:
					if (licCount > licCount2)
					{
						num2 = 23;
						continue;
					}
					goto case 22;
				case 25:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType2, licSubType);
					num = 13;
					break;
				case 26:
					return;
				case 22:
					if (licCount != licCount2)
					{
						return;
					}
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
					{
						num2 = 4;
					}
					continue;
				case 19:
					num4 = licType2;
					goto IL_03da;
				case 2:
				case 10:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType2, licSubType);
					num = 3;
					break;
				case 9:
					InitLicense();
					num2 = 8;
					continue;
				case 27:
					if (!l1S2UdnUWxeFnXt08Ha(expirationDate.Value, expirationDate2.Value))
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 2;
				case 31:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType2, licSubType);
					num2 = 26;
					continue;
				case 8:
					if (!DecodeActivationKey(key, out status, out licCount, out privilegeLicCount, out licType2, out licSubType, out expirationDate))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 != 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					if (licType != 2)
					{
						num2 = 7;
						continue;
					}
					num3 = 1;
					goto IL_03e7;
				case 24:
					{
						SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType2, licSubType);
						num2 = 29;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
						{
							num2 = 14;
						}
						continue;
					}
					IL_03e7:
					b = (byte)num3;
					num2 = 16;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
					{
						num2 = 15;
					}
					continue;
					IL_03da:
					b2 = (byte)num4;
					num2 = 15;
					continue;
				}
				break;
			}
		}
	}

	void ILicensedUnit.CompleteLicensingInitialize()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				licensingInitialized = true;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
				{
					num2 = 0;
				}
				break;
			default:
				initializedStatus = licenseInfo.Status;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 3:
				InitLicense();
				num2 = 2;
				break;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		//Discarded unreachable code: IL_00d3, IL_00e2, IL_0130
		int num = 10;
		uint? workplaceCount = default(uint?);
		ushort num3 = default(ushort);
		WorkplaceLicenseInfo workplaceLicenseInfo = default(WorkplaceLicenseInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					InitLicense();
					num2 = 9;
					continue;
				case 5:
					if (!workplaceCount.HasValue)
					{
						num2 = 3;
						continue;
					}
					goto case 8;
				case 11:
					num3 = OekXs1no1w3wul9tEHR(this);
					num2 = 4;
					continue;
				default:
					return licenseInfo;
				case 4:
					if (num3 <= 0)
					{
						num2 = 6;
						continue;
					}
					break;
				case 8:
				{
					ushort num4 = num3;
					workplaceCount = workplaceLicenseInfo.WorkplaceCount;
					if (num4 < workplaceCount.Value)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				}
				case 1:
				case 3:
					workplaceLicenseInfo.WorkplaceCount = num3;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					goto end_IL_0012;
				case 7:
					if (workplaceLicenseInfo != null)
					{
						num2 = 11;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 2:
					break;
				}
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			workplaceLicenseInfo = licenseInfo;
			num = 7;
		}
	}

	void ILicensedUnit.UpdateLicenseInfo()
	{
		int num = 2;
		int num2 = num;
		LicenseStatus status = default(LicenseStatus);
		while (true)
		{
			switch (num2)
			{
			default:
				mbQufbnJpLXYFvwFjt3(licenseInfo, status);
				num2 = 3;
				break;
			case 2:
				InitLicense();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _, out var _, out var _);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
				return;
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
		//Discarded unreachable code: IL_0084, IL_0093, IL_0121, IL_0161, IL_0170, IL_017c, IL_018b, IL_01b6, IL_01c5
		int num = 1;
		int num2 = num;
		InternalSecurityServiceStandart obj = default(InternalSecurityServiceStandart);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 4:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 4:
							return;
						default:
							registrationKey = (string)CwxF5bnKCofJFZgJpw7(1);
							num3 = 5;
							break;
						case 3:
							initialized = true;
							num3 = 2;
							break;
						case 5:
						{
							ConcurrentLicenseInfo concurrentLicenseInfo = new ConcurrentLicenseInfo(this);
							mbQufbnJpLXYFvwFjt3(concurrentLicenseInfo, LicenseStatus.NotActivated);
							licenseInfo = concurrentLicenseInfo;
							int num4 = 3;
							num3 = num4;
							break;
						}
						case 1:
							if (initialized)
							{
								num3 = 4;
								break;
							}
							goto default;
						}
					}
				}
				finally
				{
					int num5;
					if (!lockTaken)
					{
						num5 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
						{
							num5 = 0;
						}
						goto IL_0125;
					}
					goto IL_013b;
					IL_013b:
					Monitor.Exit(obj);
					num5 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
					{
						num5 = 1;
					}
					goto IL_0125;
					IL_0125:
					switch (num5)
					{
					default:
						goto end_IL_0100;
					case 2:
						break;
					case 0:
						goto end_IL_0100;
					case 1:
						goto end_IL_0100;
					}
					goto IL_013b;
					end_IL_0100:;
				}
			case 5:
				return;
			default:
				obj = this;
				num2 = 3;
				break;
			case 3:
				lockTaken = false;
				num2 = 4;
				break;
			case 1:
				if (initialized)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_00ab, IL_0176, IL_0185, IL_0195
		int num = 8;
		int num2 = num;
		uint hnH = default(uint);
		uint hnL = default(uint);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 8:
				LicensedUnitBase.GHN(out hnH, out hnL);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
				{
					num2 = 7;
				}
				break;
			case 4:
				text2 = hnL.ToString();
				num2 = 2;
				break;
			case 2:
			case 3:
				if (text.Length < 10)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 6;
			case 5:
			case 9:
				text = (string)dpn8k6nt8YDqVfXLaIl(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-163225536 ^ -163221522), text);
				num2 = 3;
				break;
			case 6:
			case 10:
				if (w5L6x6nhXn8oHoOG3lP(text2) >= 10)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				text2 = (string)dpn8k6nt8YDqVfXLaIl(HT5Ep3nPmlw0Cron8OD(0x6A336151 ^ 0x6A336EFF), text2);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
				{
					num2 = 10;
				}
				break;
			case 7:
				text = hnH.ToString();
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return (string)gX28dgnOhicaYgVpMTI(dpn8k6nt8YDqVfXLaIl(text, text2));
			}
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_00a4, IL_00fd, IL_010c, IL_011b, IL_01b0
		int num = 15;
		int num2 = num;
		int num3 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		char[] array = default(char[]);
		while (true)
		{
			switch (num2)
			{
			case 15:
				if (key != null)
				{
					num2 = 14;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 4;
			case 6:
				if (num3 % 5 != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 10;
			case 13:
				return stringBuilder.ToString();
			case 2:
			case 5:
				if (num3 < array.Length)
				{
					num2 = 7;
					break;
				}
				goto case 13;
			case 12:
				num3++;
				num2 = 2;
				break;
			case 9:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c != 0)
				{
					num2 = 5;
				}
				break;
			default:
				Sj7eHJncFN0nYZATMlW(stringBuilder, array[num3]);
				num2 = 12;
				break;
			case 4:
				return string.Empty;
			case 14:
				stringBuilder = new StringBuilder();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 != 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				Sj7eHJncFN0nYZATMlW(stringBuilder, '-');
				num2 = 11;
				break;
			case 1:
				array = (char[])cKXuunnqsjd5q8Ixnbe(key);
				num2 = 9;
				break;
			case 7:
			case 8:
				if (num3 <= 0)
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	private bool DecodeLastActivationKey(out LicenseStatus status, out ushort licCount, out ushort privilegeLicCount, out byte licType, out byte licSubType, out DateTime? expirationDate)
	{
		return DecodeActivationKey(lastAppliedActKey, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate);
	}

	private bool DecodeActivationKey(string key, out LicenseStatus status, out ushort licCount, out ushort privilegeLicCount, out byte licType, out byte licSubType, out DateTime? expirationDate)
	{
		//Discarded unreachable code: IL_0230, IL_027e, IL_02ae, IL_02bd, IL_0332, IL_0383, IL_0392
		int num = 1;
		uint hnH = default(uint);
		uint hnL = default(uint);
		bool result = default(bool);
		ushort dbLicenseCount = default(ushort);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (w5L6x6nhXn8oHoOG3lP(key) == 20)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 5:
					licSubType = 0;
					num2 = 4;
					continue;
				case 11:
					if (key == null)
					{
						break;
					}
					goto end_IL_0012;
				case 1:
					InitLicense();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					licType = 0;
					num2 = 7;
					continue;
				case 7:
					return false;
				case 2:
					LicensedUnitBase.GHN(out hnH, out hnL);
					num2 = 9;
					continue;
				case 8:
					key = (string)QfdGO4nGbUKyqPmvQBb(QfdGO4nGbUKyqPmvQBb(QfdGO4nGbUKyqPmvQBb(((string)QfdGO4nGbUKyqPmvQBb(key, HT5Ep3nPmlw0Cron8OD(-726732645 ^ -726730493), "")).Replace((string)HT5Ep3nPmlw0Cron8OD(0xC66FB14 ^ 0xC66DFEE), ""), HT5Ep3nPmlw0Cron8OD(-426925384 ^ -426932296), ""), HT5Ep3nPmlw0Cron8OD(-225736894 ^ -225729980), ""), HT5Ep3nPmlw0Cron8OD(0x46F7DF98 ^ 0x46F7FA94), "");
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					licCount = 0;
					num2 = 12;
					continue;
				case 9:
					try
					{
						uint num3 = wjCs2in0qZd6L6G9arV(QQfoMZnFYNl7oxM3kFP(key, 0, 10));
						uint num4 = uint.Parse(key.Substring(10, 10));
						if (num3 != ~hnH)
						{
							break;
						}
						int num5 = 2;
						while (true)
						{
							switch (num5)
							{
							case 9:
								return result;
							case 1:
								licCount = 65000;
								num5 = 8;
								continue;
							case 2:
								if (num4 == ~hnL)
								{
									num5 = 7;
									continue;
								}
								break;
							case 6:
								dbLicenseCount = GetDbLicenseCount();
								num5 = 10;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
								{
									num5 = 10;
								}
								continue;
							case 3:
							case 4:
							case 5:
								result = true;
								num5 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f != 0)
								{
									num5 = 9;
								}
								continue;
							case 7:
								status = LicenseStatus.Activated;
								num5 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
								{
									num5 = 1;
								}
								continue;
							case 11:
								licCount = dbLicenseCount;
								num5 = 4;
								continue;
							default:
								if (dbLicenseCount >= licCount)
								{
									num5 = 5;
									continue;
								}
								goto case 11;
							case 10:
								if (dbLicenseCount <= 0)
								{
									int num6 = 3;
									num5 = num6;
									continue;
								}
								goto default;
							case 8:
								licType = byte.MaxValue;
								num5 = 6;
								continue;
							case 12:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						int num7 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								ABSLZEnDY2HulJejEpL(LWWXXXnERnWhDIqiybi(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-784481839 ^ -784472893), ex);
								num7 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
								{
									num7 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					break;
				default:
					expirationDate = null;
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					privilegeLicCount = 0;
					num2 = 11;
					continue;
				case 10:
					break;
				}
				status = LicenseStatus.NotActivated;
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
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

	public InternalSecurityServiceStandart()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cU0wUmnMaxn1A5MYhAQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static uint mlVSFOnR2RiLAwVTfa0(object P_0)
	{
		return ((InternalSecurityServiceBase)P_0).UsedLicenseCount;
	}

	internal static uint xESgYZnwLICUuLRxh7e(object P_0)
	{
		return ((InternalSecurityServiceBase)P_0).UsedPrivilegeCount;
	}

	internal static bool V8Z1Xjn21m6FE49RmvX(object P_0)
	{
		return ((InternalSecurityServiceBase)P_0).CanCreateNewUser();
	}

	internal static bool OAJaahnHlJiJ1XEaSeE()
	{
		return FNaAjVnjIHPTfG1BkTD == null;
	}

	internal static InternalSecurityServiceStandart g0mUCInaTGWlpTl5l1m()
	{
		return FNaAjVnjIHPTfG1BkTD;
	}

	internal static object HT5Ep3nPmlw0Cron8OD(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oNfNovnvUpftdTcJRp9(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool Xf2C2pnCbolXBBY82o1(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool l1S2UdnUWxeFnXt08Ha(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static ushort OekXs1no1w3wul9tEHR(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetDbLicenseCount();
	}

	internal static void mbQufbnJpLXYFvwFjt3(object P_0, LicenseStatus P_1)
	{
		((LicenseInfo)P_0).Status = P_1;
	}

	internal static object CwxF5bnKCofJFZgJpw7(ushort algorithm)
	{
		return GenerateRegistrationKey(algorithm);
	}

	internal static object dpn8k6nt8YDqVfXLaIl(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int w5L6x6nhXn8oHoOG3lP(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object gX28dgnOhicaYgVpMTI(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object cKXuunnqsjd5q8Ixnbe(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object Sj7eHJncFN0nYZATMlW(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object QfdGO4nGbUKyqPmvQBb(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object QQfoMZnFYNl7oxM3kFP(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static uint wjCs2in0qZd6L6G9arV(object P_0)
	{
		return uint.Parse((string)P_0);
	}

	internal static object LWWXXXnERnWhDIqiybi()
	{
		return Logger.Log;
	}

	internal static void ABSLZEnDY2HulJejEpL(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void cU0wUmnMaxn1A5MYhAQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
