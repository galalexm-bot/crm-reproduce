using System;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Cfg;
using NHibernate.Cfg.Loquacious;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.MSSQL;

internal class MSSQLProviderImpl : LicensedUnitBase, IWorkplaceLicenseInfoOwner, ILicensedUnit, IActivationTokenContainer
{
	private static readonly Guid securityAssemblyUid;

	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private ConcurrentLicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	internal static MSSQLProviderImpl xETXv5YWaXm7A1oyG6k;

	uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => RsYtbrtMfHfGjew4kNK((IWorkplaceLicenseInfoOwner)sCCiY6tKK36bLFosMnA((ILicensedModuleAssembly)((IModuleManager)rfpkcwYzJukeGciBGg6(bhsekBY3fWZe7fRYQG9())).FindUnitByUid(securityAssemblyUid)));

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string)hgg4b7tYFo5LbwIy3yi(-1661472630 ^ -1661479394));

	internal void Configure(Configuration cfg, IDataBaseSettingsSection sqlSettings)
	{
		//Discarded unreachable code: IL_00f4, IL_0103, IL_01e8, IL_0228
		int num = 7;
		LicenseStatus status = default(LicenseStatus);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		MSSQLTransformationProvider mSSQLTransformationProvider = default(MSSQLTransformationProvider);
		DateTime? expirationDate = default(DateTime?);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
					if (status == LicenseStatus.Activated)
					{
						num2 = 3;
						break;
					}
					goto case 15;
				case 15:
					if (status != LicenseStatus.DateExpired)
					{
						num2 = 16;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3af97e9a57d2492f8793e39a552f0f48 == 0)
						{
							num2 = 15;
						}
						break;
					}
					goto case 3;
				case 5:
					_003C_003Ec__DisplayClass3_.version = (Version)ahHRyptulUm9f9Cx9Pm(mSSQLTransformationProvider);
					num2 = 9;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0e8b96b511f849c7b3cd2b1ffcea4179 == 0)
					{
						num2 = 14;
					}
					break;
				case 2:
					return;
				case 4:
					return;
				case 1:
					throw new LicenseExpiredException(__ModuleInfo.UID);
				default:
					if (sqlSettings == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_443e20b770184f91ab3dcde8e39895cc == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 9;
				case 16:
					throw new LicenseActivationRequiredException(__ModuleInfo.UID);
				case 3:
					if (status != LicenseStatus.DateExpired)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 8:
					ConfigurationExtensions.DataBaseIntegration(cfg, (Action<IDbIntegrationConfigurationProperties>)_003C_003Ec__DisplayClass3_._003CConfigure_003Eb__0);
					num2 = 4;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d1a34b21803e45aa91fae87c4eb8443a == 0)
					{
						num2 = 10;
					}
					break;
				case 6:
				{
					DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _, out var _, out expirationDate);
					num2 = 17;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0d427f376f09408b923d32447c167eeb != 0)
					{
						num2 = 15;
					}
					break;
				}
				case 13:
					if (!expirationDate.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_443e20b770184f91ab3dcde8e39895cc == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 18;
				case 18:
					dateTime = DateTime.Now;
					num2 = 11;
					break;
				case 14:
					_003C_003Ec__DisplayClass3_.connectionString = (string)wPujIZtI0lfAUjnZFWW(ufiC8wt8mgJsKll4ONK(sqlSettings));
					num2 = 8;
					break;
				case 10:
					maAX4MtEBPNlwEHZ3K9(cfg, hgg4b7tYFo5LbwIy3yi(-1424977163 ^ -1424968543), hgg4b7tYFo5LbwIy3yi(0x44957A45 ^ 0x44955CCD));
					num2 = 4;
					break;
				case 9:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 12;
					break;
				case 11:
				{
					DateTime date = dateTime.Date;
					dateTime = expirationDate.Value;
					if (Q3bdnEtZ91SamruNPwt(date, dateTime.Date))
					{
						num2 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_74c50b4541604f879acc41487ba8662e == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
				case 7:
					sQBvrJttUx7Zrhonk4J(sqlSettings, hgg4b7tYFo5LbwIy3yi(-1218069071 ^ -1218075137));
					num2 = 6;
					break;
				case 12:
					mSSQLTransformationProvider = new MSSQLTransformationProvider((string)ufiC8wt8mgJsKll4ONK(sqlSettings));
					num2 = 5;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_53c81d4dd9814619a62ac7ac8ba96c27 != 0)
					{
						num2 = 3;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
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
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ad871fba51dd42b7aa862ab51c3e4a86 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void ILicensedUnit.ApplyActivationKey(string key)
	{
		//Discarded unreachable code: IL_009d, IL_0143, IL_0152, IL_01aa, IL_023b, IL_0273, IL_0309, IL_033c
		int num = 21;
		int num2 = num;
		LicenseStatus status = default(LicenseStatus);
		ushort licCount = default(ushort);
		ushort privilegeLicCount = default(ushort);
		DateTime? expirationDate = default(DateTime?);
		byte licType = default(byte);
		byte licSubType = default(byte);
		byte licSubType2 = default(byte);
		byte licType2 = default(byte);
		byte b = default(byte);
		byte b2 = default(byte);
		DateTime? expirationDate2 = default(DateTime?);
		ushort licCount2 = default(ushort);
		ushort privilegeLicCount2 = default(ushort);
		while (true)
		{
			int num3;
			int num4;
			switch (num2)
			{
			default:
				return;
			case 22:
				SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
				num2 = 10;
				continue;
			case 28:
				return;
			case 2:
				if (licType != 1)
				{
					num2 = 13;
					continue;
				}
				goto case 19;
			case 13:
				if (licType == 2)
				{
					num2 = 19;
					continue;
				}
				goto IL_0180;
			case 7:
				return;
			case 4:
				return;
			case 24:
				return;
			case 16:
				if (licSubType > licSubType2)
				{
					num2 = 22;
					continue;
				}
				if (licSubType < licSubType2)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_992aa32d3a3449929072ecd77a2ed007 == 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
			case 23:
				SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
				num2 = 26;
				continue;
			case 11:
				if (licType != 2)
				{
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bbc137d911274e6c8ec7374800482ba2 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				num3 = 1;
				goto IL_03cf;
			case 30:
				if (licType2 != 2)
				{
					num2 = 18;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_81833be823b44351b330d2171723abb3 != 0)
					{
						num2 = 15;
					}
					continue;
				}
				num4 = 1;
				break;
			case 26:
				return;
			case 1:
				num3 = licType;
				goto IL_03cf;
			case 8:
				return;
			case 21:
				InitLicense();
				num2 = 20;
				continue;
			case 3:
				return;
			case 25:
				SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
				num2 = 3;
				continue;
			case 17:
				if (b < b2)
				{
					num2 = 2;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7937bb5aeb374034837b9426eced6cfc == 0)
					{
						num2 = 15;
					}
				}
				else
				{
					if (b > b2)
					{
						return;
					}
					num2 = 16;
				}
				continue;
			case 18:
				num4 = licType2;
				break;
			case 0:
				return;
			case 27:
				if (!expirationDate2.HasValue)
				{
					num2 = 23;
					continue;
				}
				goto case 6;
			case 12:
			case 14:
				SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
				num2 = 7;
				continue;
			case 20:
				if (DecodeActivationKey(key, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate))
				{
					if (lastAppliedActKey == null)
					{
						num2 = 25;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ca63e6162aaa4aaeaa1385bd9f3ad6e0 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					DecodeActivationKey(lastAppliedActKey, out var _, out licCount2, out privilegeLicCount2, out licType2, out licSubType2, out expirationDate2);
					num2 = 11;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adcdf8abe8194ee7810e832bda7e08e7 == 0)
					{
						num2 = 8;
					}
				}
				else
				{
					num2 = 8;
				}
				continue;
			case 5:
				if (privilegeLicCount <= privilegeLicCount2)
				{
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_937e86e483374781b74ae1d5b232cdfa != 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 12;
			case 10:
				return;
			case 15:
				SetLastAppliedKey(key, status, licCount, privilegeLicCount, expirationDate, licType, licSubType);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_762cf717254743a4a1d5f3fcfeb2849f == 0)
				{
					num2 = 0;
				}
				continue;
			case 29:
				if (licCount != licCount2)
				{
					return;
				}
				num2 = 4;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c4f350cb93ad41c2a93de4e094bd3eae == 0)
				{
					num2 = 5;
				}
				continue;
			case 6:
				if (expirationDate.Value > expirationDate2.Value)
				{
					num2 = 9;
					continue;
				}
				goto IL_0180;
			case 19:
				{
					if (expirationDate.HasValue)
					{
						num2 = 27;
						continue;
					}
					goto IL_0180;
				}
				IL_0180:
				if (licCount > licCount2)
				{
					num2 = 12;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_473ad8036e884220a80a5543064a2d98 != 0)
					{
						num2 = 11;
					}
					continue;
				}
				goto case 29;
				IL_03cf:
				b = (byte)num3;
				num2 = 30;
				continue;
			}
			b2 = (byte)num4;
			num2 = 17;
		}
	}

	void ILicensedUnit.CompleteLicensingInitialize()
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
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_2580d923b4ce4bd0b5bb01b45f02c594 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				initializedStatus = ijljI9t9jQZMMtRlfiY(licenseInfo);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4599535ffcb34731ae493be59317478a != 0)
				{
					num2 = 2;
				}
				break;
			default:
				licensingInitialized = true;
				num2 = 3;
				break;
			case 2:
				return;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		//Discarded unreachable code: IL_006f, IL_0137
		int num = 2;
		uint? workplaceCount = default(uint?);
		WorkplaceLicenseInfo workplaceLicenseInfo = default(WorkplaceLicenseInfo);
		ushort num3 = default(ushort);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
				case 8:
				case 10:
					return licenseInfo;
				case 7:
					workplaceCount = workplaceLicenseInfo.WorkplaceCount;
					num = 5;
					break;
				case 3:
					workplaceLicenseInfo.WorkplaceCount = num3;
					num2 = 6;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c66a81b3385f4e6fa960aa83b221484b == 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					if (workplaceLicenseInfo == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ee3b4c6a3b0041bfaa9b5ce28a8e6629 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 4;
				default:
					if (num3 <= 0)
					{
						num2 = 8;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_fd530154b89d4815aee35b4d6e45073c != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 7;
				case 5:
					if (workplaceCount.HasValue)
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				case 4:
					num3 = HuTYdStybDX6e1rZQFY(this);
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_11b18682a5a544c7bb53148fce1a13cb != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					workplaceLicenseInfo = licenseInfo;
					num = 11;
					break;
				case 2:
					InitLicense();
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a1374360d15f4247b418e6f0fa5eef4e != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
				{
					ushort num4 = num3;
					workplaceCount = workplaceLicenseInfo.WorkplaceCount;
					if (num4 < workplaceCount.Value)
					{
						num = 3;
						break;
					}
					goto case 6;
				}
				}
				break;
			}
		}
	}

	void ILicensedUnit.UpdateLicenseInfo()
	{
		int num = 1;
		int num2 = num;
		LicenseStatus status = default(LicenseStatus);
		while (true)
		{
			switch (num2)
			{
			case 1:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_30d379f142a04774b5dae7c74c918bb8 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
			{
				DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _, out var _, out var _);
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d77c90c2b1934f16bf9cfe858d8dba6d != 0)
				{
					num2 = 2;
				}
				break;
			}
			case 2:
				O6A5NNtnyp3rpCWbBnT(licenseInfo, status);
				num2 = 3;
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
		//Discarded unreachable code: IL_0047, IL_0056, IL_0085, IL_0156, IL_0196, IL_01a5, IL_01b1, IL_01c0
		int num = 5;
		int num2 = num;
		MSSQLProviderImpl mSSQLProviderImpl = default(MSSQLProviderImpl);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 4:
				mSSQLProviderImpl = this;
				num2 = 3;
				continue;
			case 1:
				return;
			case 3:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ee3b4c6a3b0041bfaa9b5ce28a8e6629 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				if (initialized)
				{
					return;
				}
				num2 = 4;
				continue;
			}
			try
			{
				Monitor.Enter(mSSQLProviderImpl, ref lockTaken);
				int num3 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_25f0dcdb5c5e4e6fbd7fee91aad234f3 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
						registrationKey = (string)jKxrQrtOTGAxvMPV337(1);
						num3 = 4;
						break;
					default:
						initialized = true;
						num3 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a20e3edfdf494639a8a8084ef15a8911 == 0)
						{
							num3 = 0;
						}
						break;
					case 3:
						if (!initialized)
						{
							num3 = 2;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef != 0)
							{
								num3 = 2;
							}
							break;
						}
						return;
					case 4:
					{
						ConcurrentLicenseInfo concurrentLicenseInfo = new ConcurrentLicenseInfo(this);
						O6A5NNtnyp3rpCWbBnT(concurrentLicenseInfo, LicenseStatus.NotActivated);
						licenseInfo = concurrentLicenseInfo;
						num3 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef == 0)
						{
							num3 = 0;
						}
						break;
					}
					case 1:
						return;
					}
				}
			}
			finally
			{
				int num4;
				if (!lockTaken)
				{
					num4 = 2;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 == 0)
					{
						num4 = 2;
					}
					goto IL_015a;
				}
				goto IL_0170;
				IL_0170:
				D8qU1ctAyLA8g16QdAr(mSSQLProviderImpl);
				num4 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_cdc960c8d7b3434c87091f57ea1faa93 != 0)
				{
					num4 = 0;
				}
				goto IL_015a;
				IL_015a:
				switch (num4)
				{
				case 2:
					goto end_IL_0135;
				case 1:
					goto end_IL_0135;
				}
				goto IL_0170;
				end_IL_0135:;
			}
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_0058, IL_00f3, IL_0102
		int num = 6;
		string text = default(string);
		string text2 = default(string);
		uint hnH = default(uint);
		uint hnL = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return (string)Q49lhYtxgHXT6AV03RJ(AANW21tj2iYmMBe0FnL(text, text2));
				case 8:
					text = (string)AANW21tj2iYmMBe0FnL(hgg4b7tYFo5LbwIy3yi(-1505501660 ^ -1505494848), text);
					num2 = 2;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_aa8cb810f1524b20abd541fee0197a14 == 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					LicensedUnitBase.GHN(out hnH, out hnL);
					num2 = 3;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_aa8cb810f1524b20abd541fee0197a14 == 0)
					{
						num2 = 5;
					}
					continue;
				case 9:
					text2 = hnL.ToString();
					num2 = 3;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_762cf717254743a4a1d5f3fcfeb2849f != 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					text = hnH.ToString();
					num2 = 9;
					continue;
				default:
					if (text2.Length < 10)
					{
						break;
					}
					goto end_IL_0012;
				case 3:
				case 4:
					if (text.Length >= 10)
					{
						num2 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bbc137d911274e6c8ec7374800482ba2 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 2:
					break;
				}
				text2 = (string)AANW21tj2iYmMBe0FnL(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1374979190 ^ -1374986898), text2);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7d9c3f1bd5704dffa8a30fba06b99cdf == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_0096, IL_00a5, IL_00dc, IL_00eb, IL_00fb
		int num = 12;
		int num3 = default(int);
		char[] array = default(char[]);
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b191e4df737c4fbb97b7fbe68dd7816d != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					num3 = 0;
					num2 = 13;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_2580d923b4ce4bd0b5bb01b45f02c594 == 0)
					{
						num2 = 13;
					}
					continue;
				case 11:
					return string.Empty;
				case 8:
					if (num3 <= 0)
					{
						num2 = 10;
						continue;
					}
					goto case 3;
				default:
					if (num3 >= array.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ec5f92fd6ddb449a9afc09c18f0a77db != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 8;
				case 4:
					return stringBuilder.ToString();
				case 12:
					if (key != null)
					{
						stringBuilder = new StringBuilder();
						num2 = 2;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_7b9eb7c7ce494b779c3d495b11db0ee8 != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 11;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_65ce79c871be4e148c284823cf722edd == 0)
						{
							num2 = 7;
						}
					}
					continue;
				case 7:
					break;
				case 3:
					if (num3 % 5 != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c07718730a1849a8a092e51c2522f212 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
				case 5:
				case 10:
					M0ERyAtNswh8ohmHM4E(stringBuilder, array[num3]);
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_24d54149ebc348d09713294df311806b == 0)
					{
						num2 = 9;
					}
					continue;
				case 2:
					array = (char[])uAgBUHtQfEZvBaNxxSg(key);
					num2 = 6;
					continue;
				}
				break;
			}
			M0ERyAtNswh8ohmHM4E(stringBuilder, '-');
			num = 5;
		}
	}

	private bool DecodeLastActivationKey(out LicenseStatus status, out ushort licCount, out ushort privilegeLicCount, out byte licType, out byte licSubType, out DateTime? expirationDate)
	{
		return DecodeActivationKey(lastAppliedActKey, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate);
	}

	private bool DecodeActivationKey(string key, out LicenseStatus status, out ushort licCount, out ushort privilegeLicCount, out byte licType, out byte licSubType, out DateTime? expirationDate)
	{
		//Discarded unreachable code: IL_00fb, IL_013e, IL_014d, IL_015c, IL_024e, IL_02a5
		int num = 10;
		int num2 = num;
		uint hnH = default(uint);
		ushort num6 = default(ushort);
		uint hnL = default(uint);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 10:
				InitLicense();
				num2 = 6;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_595bc6899ac747d989e6cbc941c80562 == 0)
				{
					num2 = 9;
				}
				break;
			case 12:
				status = LicenseStatus.NotActivated;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4d5fabaf870f450c93de24e9225e7993 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				licSubType = 0;
				num2 = 4;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_5bd098bed6154f4ea8b455a24c427093 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				privilegeLicCount = 0;
				num2 = 5;
				break;
			case 2:
				try
				{
					uint num3 = iPLZ4stCbeIKU6NOTup(whKfErt6jUbC2a8o8k9(key, 0, 10));
					uint num4 = uint.Parse((string)whKfErt6jUbC2a8o8k9(key, 10, 10));
					if (num3 == ~hnH)
					{
						int num5 = 7;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_24d54149ebc348d09713294df311806b == 0)
						{
							num5 = 9;
						}
						while (true)
						{
							switch (num5)
							{
							case 6:
								if (num6 >= licCount)
								{
									num5 = 2;
									continue;
								}
								goto case 7;
							case 4:
								licType = byte.MaxValue;
								num5 = 10;
								continue;
							case 9:
								if (num4 == ~hnL)
								{
									num5 = 8;
									continue;
								}
								break;
							case 10:
								num6 = HuTYdStybDX6e1rZQFY(this);
								num5 = 5;
								continue;
							case 8:
								status = LicenseStatus.Activated;
								num5 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_30d379f142a04774b5dae7c74c918bb8 != 0)
								{
									num5 = 3;
								}
								continue;
							case 5:
								if (num6 > 0)
								{
									num5 = 6;
									continue;
								}
								goto default;
							default:
								result = true;
								num5 = 11;
								continue;
							case 3:
								licCount = 65000;
								num5 = 4;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_610637caa58f480dbbd64235291b457a == 0)
								{
									num5 = 4;
								}
								continue;
							case 7:
								licCount = num6;
								num5 = 0;
								if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c2cab395bbae4d16ab33c46363a0e09f == 0)
								{
									num5 = 0;
								}
								continue;
							case 1:
								break;
							case 11:
								return result;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num7 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b191e4df737c4fbb97b7fbe68dd7816d == 0)
					{
						num7 = 1;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							X4GAkctoevGIeDDbywT(y7KuQ3tJP8mNgdqVGIU(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x28823350 ^ 0x28821458), ex);
							num7 = 0;
							if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_15400f29239a48f5a6f7d131d55cff1f == 0)
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
				goto case 12;
			case 3:
				return false;
			case 1:
				key = (string)BFgaQftLydHXdUZlpuK(BFgaQftLydHXdUZlpuK(BFgaQftLydHXdUZlpuK(BFgaQftLydHXdUZlpuK(BFgaQftLydHXdUZlpuK(key, hgg4b7tYFo5LbwIy3yi(0x142041AF ^ 0x14206745), ""), hgg4b7tYFo5LbwIy3yi(0x7E7071FB ^ 0x7E70570B), ""), hgg4b7tYFo5LbwIy3yi(-318240169 ^ -318231391), ""), hgg4b7tYFo5LbwIy3yi(0x6FC42799 ^ 0x6FC40165), ""), hgg4b7tYFo5LbwIy3yi(-969579703 ^ -969587637), "");
				num2 = 3;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_88b018be80f64052a4b6364462094eef == 0)
				{
					num2 = 6;
				}
				break;
			case 9:
				expirationDate = null;
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f5427a24f2948678f15f0286379c485 == 0)
				{
					num2 = 7;
				}
				break;
			case 11:
				LicensedUnitBase.GHN(out hnH, out hnL);
				num2 = 2;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				if (KmkkQFtke4WB0c0ItRp(key) == 20)
				{
					num2 = 11;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_611f69e7a7a34a4fbeb0099afc53aecd == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 12;
			case 8:
				licType = 0;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3af97e9a57d2492f8793e39a552f0f48 != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				if (key != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a2b331cfbee74083865b99663c080fcb == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 12;
			default:
				licCount = 0;
				num2 = 8;
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

	public MSSQLProviderImpl()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Vc4dy6tdFXJNoTX5qVS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b13d731cb79641de887177267153d656 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MSSQLProviderImpl()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0e8b96b511f849c7b3cd2b1ffcea4179 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				securityAssemblyUid = new Guid((string)hgg4b7tYFo5LbwIy3yi(-862174492 ^ -862165560));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_c76ae84e13cb4972824810f3a682325a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object bhsekBY3fWZe7fRYQG9()
	{
		return ComponentManager.Current;
	}

	internal static object rfpkcwYzJukeGciBGg6(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object sCCiY6tKK36bLFosMnA(object P_0)
	{
		return ((ILicensedModuleAssembly)P_0).LicenseUnit;
	}

	internal static uint RsYtbrtMfHfGjew4kNK(object P_0)
	{
		return ((IWorkplaceLicenseInfoOwner)P_0).UsedLicenseCount;
	}

	internal static bool sjJU0YY2iADVZ2SJrys()
	{
		return xETXv5YWaXm7A1oyG6k == null;
	}

	internal static MSSQLProviderImpl AilUJOY7bNoc3htMukU()
	{
		return xETXv5YWaXm7A1oyG6k;
	}

	internal static object hgg4b7tYFo5LbwIy3yi(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void sQBvrJttUx7Zrhonk4J(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static bool Q3bdnEtZ91SamruNPwt(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static object ufiC8wt8mgJsKll4ONK(object P_0)
	{
		return ((IDataBaseSettingsSection)P_0).ConnectionString;
	}

	internal static object ahHRyptulUm9f9Cx9Pm(object P_0)
	{
		return ((TransformationProvider)P_0).GetEngineVersion();
	}

	internal static object wPujIZtI0lfAUjnZFWW(object P_0)
	{
		return MSSQLProvider.UpdateConnectionString((string)P_0);
	}

	internal static object maAX4MtEBPNlwEHZ3K9(object P_0, object P_1, object P_2)
	{
		return ((Configuration)P_0).SetProperty((string)P_1, (string)P_2);
	}

	internal static LicenseStatus ijljI9t9jQZMMtRlfiY(object P_0)
	{
		return ((LicenseInfo)P_0).Status;
	}

	internal static ushort HuTYdStybDX6e1rZQFY(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetDbLicenseCount();
	}

	internal static void O6A5NNtnyp3rpCWbBnT(object P_0, LicenseStatus P_1)
	{
		((LicenseInfo)P_0).Status = P_1;
	}

	internal static object jKxrQrtOTGAxvMPV337(ushort algorithm)
	{
		return GenerateRegistrationKey(algorithm);
	}

	internal static void D8qU1ctAyLA8g16QdAr(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object AANW21tj2iYmMBe0FnL(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object Q49lhYtxgHXT6AV03RJ(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object uAgBUHtQfEZvBaNxxSg(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object M0ERyAtNswh8ohmHM4E(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object BFgaQftLydHXdUZlpuK(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static int KmkkQFtke4WB0c0ItRp(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object whKfErt6jUbC2a8o8k9(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static uint iPLZ4stCbeIKU6NOTup(object P_0)
	{
		return uint.Parse((string)P_0);
	}

	internal static object y7KuQ3tJP8mNgdqVGIU()
	{
		return Logger.Log;
	}

	internal static void X4GAkctoevGIeDDbywT(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void Vc4dy6tdFXJNoTX5qVS()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}
}
