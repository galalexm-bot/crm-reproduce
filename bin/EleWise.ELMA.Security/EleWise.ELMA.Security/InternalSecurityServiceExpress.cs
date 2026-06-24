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

internal class InternalSecurityServiceExpress : InternalSecurityServiceBase, IInternalSecurityService, ILicensedUnit, IWorkplaceLicenseInfoOwner, IConcurrentLicenseInfoOwner, IActivationTokenContainer
{
	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private ConcurrentLicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	internal static InternalSecurityServiceExpress IriWZLXOhcCnOeg0ed0;

	uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => PFPcZJXGukf1g0vsAma(this);

	uint IConcurrentLicenseInfoOwner.UsedPrivilegeCount => hBf08vXFPtHerDiTrHL(this);

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
					if (k1RverXDDCF3F6DusjA(QSV6GPXEs7KT1SQAdqi(Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType()), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x715714F9 ^ 0x7157307B)))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
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

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string)Bi4755XMeiNStU2D9SY(-764392425 ^ -764385091));

	void IInternalSecurityService.CheckUserToAuthenticate([NotNull] EleWise.ELMA.Security.Models.IUser user, Func<bool> isAlreadyLoggedFunc, Func<int, bool> isCurrentPrivilegeFunc, Func<int> otherUsersCountFunc)
	{
		CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
	}

	bool IInternalSecurityService.CanCreateNewUser()
	{
		return Uack3dX0iA9Zd0QFsYx(this);
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
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void CheckUserToAuthenticate([NotNull] EleWise.ELMA.Security.Models.IUser user, Func<bool> isAlreadyLoggedFunc, Func<int, bool> isCurrentPrivilegeFunc, Func<int> otherUsersCountFunc)
	{
		if (Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType().Name != SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40096392 ^ 0x40094710))
		{
			throw new LicenseException();
		}
		base.CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
	}

	protected override bool CanCreateNewUser()
	{
		//Discarded unreachable code: IL_0083, IL_0092
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!k1RverXDDCF3F6DusjA(Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType().Name, Bi4755XMeiNStU2D9SY(0x4D3A45F ^ 0x4D380DD)))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				throw new LicenseException();
			case 1:
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
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
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
		//Discarded unreachable code: IL_0099, IL_00e4, IL_00f5, IL_017f, IL_018e, IL_036e, IL_0378
		int num = 21;
		byte licType = default(byte);
		ushort licCount2 = default(ushort);
		ushort privilegeLicCount2 = default(ushort);
		byte licType2 = default(byte);
		byte licSubType2 = default(byte);
		DateTime? expirationDate = default(DateTime?);
		LicenseStatus status = default(LicenseStatus);
		ushort licCount = default(ushort);
		ushort privilegeLicCount = default(ushort);
		DateTime? expirationDate2 = default(DateTime?);
		byte licSubType = default(byte);
		byte b = default(byte);
		byte b2 = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				int num3;
				switch (num2)
				{
				case 17:
					return;
				case 9:
					return;
				case 22:
					num4 = licType;
					goto IL_03bc;
				case 3:
					return;
				case 2:
				{
					DecodeActivationKey(lastAppliedActKey, out var _, out licCount2, out privilegeLicCount2, out licType2, out licSubType2, out expirationDate);
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 11:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate2, licType, licSubType);
					num = 3;
					break;
				case 1:
					return;
				case 10:
					if (b >= b2)
					{
						if (b > b2)
						{
							num2 = 23;
						}
						else if (licSubType <= licSubType2)
						{
							if (licSubType < licSubType2)
							{
								return;
							}
							num2 = 14;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
							{
								num2 = 18;
							}
						}
						else
						{
							num2 = 26;
						}
					}
					else
					{
						num2 = 12;
					}
					continue;
				case 4:
					if (expirationDate2.HasValue)
					{
						num2 = 16;
						continue;
					}
					goto case 27;
				case 25:
					if (licType2 != 2)
					{
						num = 15;
						break;
					}
					num3 = 1;
					goto IL_03cd;
				default:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate2, licType, licSubType);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 != 0)
					{
						num2 = 6;
					}
					continue;
				case 20:
					if (!DecodeActivationKey(key, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate2))
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					if (lastAppliedActKey != null)
					{
						num2 = 2;
						continue;
					}
					goto case 11;
				case 23:
					return;
				case 21:
					InitLicense();
					num2 = 15;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
					{
						num2 = 20;
					}
					continue;
				case 12:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate2, licType, licSubType);
					num2 = 9;
					continue;
				case 13:
					if (licType == 2)
					{
						num2 = 4;
						continue;
					}
					goto case 27;
				case 14:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate2, licType, licSubType);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					return;
				case 7:
					if (licType != 2)
					{
						num = 22;
						break;
					}
					num4 = 1;
					goto IL_03bc;
				case 6:
					return;
				case 27:
					if (licCount <= licCount2)
					{
						num2 = 17;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 14;
				case 26:
					SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate2, licType, licSubType);
					num2 = 17;
					continue;
				case 24:
					if (licCount != licCount2)
					{
						return;
					}
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 != 0)
					{
						num2 = 2;
					}
					continue;
				case 19:
					if (!uU3800XsUZ2qf5B5k8U(expirationDate2.Value, expirationDate.Value))
					{
						num = 27;
						break;
					}
					goto default;
				case 28:
					return;
				case 18:
					if (licType != 1)
					{
						num2 = 13;
						continue;
					}
					goto case 4;
				case 15:
					num3 = licType2;
					goto IL_03cd;
				case 5:
					if (privilegeLicCount <= privilegeLicCount2)
					{
						return;
					}
					num2 = 14;
					continue;
				case 16:
					{
						if (!expirationDate.HasValue)
						{
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 19;
					}
					IL_03bc:
					b = (byte)num4;
					num = 25;
					break;
					IL_03cd:
					b2 = (byte)num3;
					num = 10;
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
			case 1:
				licensingInitialized = true;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				InitLicense();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				initializedStatus = H47F6gXYPruxNloHLXq(licenseInfo);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		//Discarded unreachable code: IL_0103, IL_0112
		int num = 4;
		WorkplaceLicenseInfo workplaceLicenseInfo = default(WorkplaceLicenseInfo);
		ushort dbLicenseCount = default(ushort);
		uint? workplaceCount = default(uint?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					workplaceLicenseInfo = licenseInfo;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c != 0)
					{
						num2 = 0;
					}
					break;
				case 9:
				{
					ushort num3 = dbLicenseCount;
					workplaceCount = workplaceLicenseInfo.WorkplaceCount;
					if (num3 >= workplaceCount.Value)
					{
						num2 = 5;
						break;
					}
					goto case 10;
				}
				case 4:
					InitLicense();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c != 0)
					{
						num2 = 3;
					}
					break;
				case 5:
				case 6:
					return licenseInfo;
				case 7:
					dbLicenseCount = GetDbLicenseCount();
					num2 = 8;
					break;
				case 8:
					if (dbLicenseCount > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 5;
				case 10:
					workplaceLicenseInfo.WorkplaceCount = dbLicenseCount;
					num2 = 6;
					break;
				case 2:
					if (workplaceCount.HasValue)
					{
						num2 = 9;
						break;
					}
					goto case 10;
				default:
					if (workplaceLicenseInfo != null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 1:
					workplaceCount = workplaceLicenseInfo.WorkplaceCount;
					num2 = 2;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
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
			case 2:
			{
				DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _, out var _, out var _);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				TiV0oIXIXdKLQhWVpkX(licenseInfo, status);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
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
		//Discarded unreachable code: IL_012e, IL_0166, IL_0175, IL_01a3, IL_01b2
		int num = 4;
		int num2 = num;
		bool lockTaken = default(bool);
		InternalSecurityServiceExpress obj = default(InternalSecurityServiceExpress);
		while (true)
		{
			switch (num2)
			{
			default:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 3;
					while (true)
					{
						int num4;
						switch (num3)
						{
						case 2:
							initialized = true;
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
							{
								num3 = 1;
							}
							break;
						case 4:
						{
							ConcurrentLicenseInfo concurrentLicenseInfo = new ConcurrentLicenseInfo(this);
							TiV0oIXIXdKLQhWVpkX(concurrentLicenseInfo, LicenseStatus.NotActivated);
							licenseInfo = concurrentLicenseInfo;
							num4 = 2;
							goto IL_0065;
						}
						case 3:
							if (!initialized)
							{
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
								{
									num3 = 0;
								}
								break;
							}
							return;
						default:
							registrationKey = (string)rUleXFX4TpwYtyPgbJ1(1);
							num4 = 4;
							goto IL_0065;
						case 1:
							return;
							IL_0065:
							num3 = num4;
							break;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num5 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								Monitor.Exit(obj);
								num5 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				return;
			case 3:
				obj = this;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (initialized)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				return;
			}
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_00d6, IL_00e5, IL_00f4, IL_0113, IL_019a, IL_01a9
		int num = 8;
		string text2 = default(string);
		string text = default(string);
		uint hnH = default(uint);
		uint hnL = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 11:
					text2 = (string)Bi4755XMeiNStU2D9SY(-2068904634 ^ -2068903192) + text2;
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
					{
						num2 = 10;
					}
					continue;
				case 2:
				case 3:
					if (AtDlYSXQoF1s3VmTrEB(text) < 10)
					{
						num2 = 4;
						continue;
					}
					goto case 5;
				case 8:
					LicensedUnitBase.GHN(out hnH, out hnL);
					num = 7;
					break;
				default:
					text2 = hnL.ToString();
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					return (string)Xa5IcHXdvRsRQZP4uEY(A03Xh0XVakHl7RNeenQ(text, text2));
				case 4:
				case 6:
					text = (string)A03Xh0XVakHl7RNeenQ(Bi4755XMeiNStU2D9SY(0x1C48C9C4 ^ 0x1C48C66A), text);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a != 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
				case 10:
					if (AtDlYSXQoF1s3VmTrEB(text2) < 10)
					{
						num = 11;
						break;
					}
					goto case 9;
				case 7:
					text = hnH.ToString();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_00e2, IL_0114, IL_0123, IL_018e, IL_019d, IL_01bf, IL_01ce
		int num = 13;
		StringBuilder stringBuilder = default(StringBuilder);
		char[] array = default(char[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					return string.Empty;
				case 12:
					stringBuilder = new StringBuilder();
					num2 = 15;
					continue;
				case 1:
					stringBuilder.Append('-');
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
					{
						num2 = 5;
					}
					continue;
				case 5:
				case 8:
				case 11:
					N5NvXWXgowk9yTJeX5p(stringBuilder, array[num3]);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					if (key != null)
					{
						num2 = 12;
						continue;
					}
					goto case 14;
				default:
					if (num3 % 5 != 0)
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				case 4:
					num3++;
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
					{
						num2 = 9;
					}
					continue;
				case 10:
					break;
				case 3:
					return stringBuilder.ToString();
				case 6:
				case 7:
					if (num3 <= 0)
					{
						num2 = 11;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto default;
				case 15:
					array = (char[])T2HYjIXTjB0QlWCM0C8(key);
					num2 = 10;
					continue;
				case 2:
				case 9:
					if (num3 < array.Length)
					{
						num2 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 3;
				}
				break;
			}
			num3 = 0;
			num = 2;
		}
	}

	private bool DecodeLastActivationKey(out LicenseStatus status, out ushort licCount, out ushort privilegeLicCount, out byte licType, out byte licSubType, out DateTime? expirationDate)
	{
		return DecodeActivationKey(lastAppliedActKey, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate);
	}

	private bool DecodeActivationKey(string key, out LicenseStatus status, out ushort licCount, out ushort privilegeLicCount, out byte licType, out byte licSubType, out DateTime? expirationDate)
	{
		//Discarded unreachable code: IL_01ba, IL_0273, IL_02b8, IL_037e, IL_03cf, IL_03de
		int num = 9;
		uint hnH = default(uint);
		uint hnL = default(uint);
		ushort dbLicenseCount = default(ushort);
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					break;
				case 9:
					InitLicense();
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					key = (string)rjGwNNX8IoN2HNuMlye(rjGwNNX8IoN2HNuMlye(((string)rjGwNNX8IoN2HNuMlye(rjGwNNX8IoN2HNuMlye(key, Bi4755XMeiNStU2D9SY(-736288531 ^ -736286347), ""), Bi4755XMeiNStU2D9SY(0x38328F00 ^ 0x3832ABFA), "")).Replace((string)Bi4755XMeiNStU2D9SY(0x4A799728 ^ 0x4A79B228), ""), Bi4755XMeiNStU2D9SY(-1801396866 ^ -1801389960), ""), Bi4755XMeiNStU2D9SY(-724676315 ^ -724667351), "");
					num2 = 13;
					continue;
				case 4:
					licSubType = 0;
					num2 = 11;
					continue;
				case 7:
					if (key == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 6:
					LicensedUnitBase.GHN(out hnH, out hnL);
					num2 = 12;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
					{
						num2 = 6;
					}
					continue;
				default:
					status = LicenseStatus.NotActivated;
					num2 = 2;
					continue;
				case 8:
					expirationDate = null;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					licType = 0;
					num2 = 5;
					continue;
				case 2:
					licCount = 0;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					try
					{
						uint num3 = uint.Parse(key.Substring(0, 10));
						uint num4 = qy1WveX3GOdMXbDJTHw(KLELxqXr76tZBS1bB7Y(key, 10, 10));
						if (num3 == ~hnH)
						{
							int num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
							{
								num5 = 5;
							}
							while (true)
							{
								int num6;
								switch (num5)
								{
								case 11:
									status = LicenseStatus.Activated;
									num5 = 7;
									continue;
								default:
									dbLicenseCount = GetDbLicenseCount();
									num5 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
									{
										num5 = 0;
									}
									continue;
								case 5:
									if (num4 == ~hnL)
									{
										num5 = 11;
										continue;
									}
									break;
								case 3:
									licCount = dbLicenseCount;
									num5 = 10;
									continue;
								case 7:
									licCount = 65000;
									num6 = 8;
									goto IL_0223;
								case 1:
									if (dbLicenseCount <= 0)
									{
										num5 = 5;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
										{
											num5 = 6;
										}
										continue;
									}
									goto case 4;
								case 8:
									licType = byte.MaxValue;
									num5 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
									{
										num5 = 0;
									}
									continue;
								case 6:
								case 10:
									result = true;
									num6 = 9;
									goto IL_0223;
								case 4:
									if (dbLicenseCount < licCount)
									{
										num5 = 3;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
										{
											num5 = 1;
										}
										continue;
									}
									goto case 6;
								case 2:
									break;
								case 9:
									{
										return result;
									}
									IL_0223:
									num5 = num6;
									continue;
								}
								break;
							}
						}
					}
					catch (Exception ex)
					{
						int num7 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								exwV25Xb5XSHS57YCNl(p2Id44XyoFee4R36Sxr(), Bi4755XMeiNStU2D9SY(-1580392499 ^ -1580385569), ex);
								num7 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
								{
									num7 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto default;
				case 13:
					if (AtDlYSXQoF1s3VmTrEB(key) == 20)
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 5:
					return false;
				}
				break;
			}
			privilegeLicCount = 0;
			num = 7;
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

	public InternalSecurityServiceExpress()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gBgvNiXS9ULwaRqRFin();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static uint PFPcZJXGukf1g0vsAma(object P_0)
	{
		return ((InternalSecurityServiceBase)P_0).UsedLicenseCount;
	}

	internal static uint hBf08vXFPtHerDiTrHL(object P_0)
	{
		return ((InternalSecurityServiceBase)P_0).UsedPrivilegeCount;
	}

	internal static bool Uack3dX0iA9Zd0QFsYx(object P_0)
	{
		return ((InternalSecurityServiceBase)P_0).CanCreateNewUser();
	}

	internal static bool cjUlCrXqyINPAnGRi8W()
	{
		return IriWZLXOhcCnOeg0ed0 == null;
	}

	internal static InternalSecurityServiceExpress YfiCBuXcOhfQZ1uEG9q()
	{
		return IriWZLXOhcCnOeg0ed0;
	}

	internal static object QSV6GPXEs7KT1SQAdqi(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool k1RverXDDCF3F6DusjA(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object Bi4755XMeiNStU2D9SY(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool uU3800XsUZ2qf5B5k8U(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static LicenseStatus H47F6gXYPruxNloHLXq(object P_0)
	{
		return ((LicenseInfo)P_0).Status;
	}

	internal static void TiV0oIXIXdKLQhWVpkX(object P_0, LicenseStatus P_1)
	{
		((LicenseInfo)P_0).Status = P_1;
	}

	internal static object rUleXFX4TpwYtyPgbJ1(ushort algorithm)
	{
		return GenerateRegistrationKey(algorithm);
	}

	internal static object A03Xh0XVakHl7RNeenQ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int AtDlYSXQoF1s3VmTrEB(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object Xa5IcHXdvRsRQZP4uEY(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object T2HYjIXTjB0QlWCM0C8(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object N5NvXWXgowk9yTJeX5p(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object rjGwNNX8IoN2HNuMlye(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object KLELxqXr76tZBS1bB7Y(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static uint qy1WveX3GOdMXbDJTHw(object P_0)
	{
		return uint.Parse((string)P_0);
	}

	internal static object p2Id44XyoFee4R36Sxr()
	{
		return Logger.Log;
	}

	internal static void exwV25Xb5XSHS57YCNl(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void gBgvNiXS9ULwaRqRFin()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
