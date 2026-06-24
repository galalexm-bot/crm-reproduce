using System;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Processes;

internal class InternalProcessesServiceExpress : LicensedUnitBase, IInternalProcessesService, ILicensedUnit, IActivationTokenContainer
{
	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private LicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	internal static InternalProcessesServiceExpress HJ1ja5hetFN5jkUKBBs;

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string)o7LNwVhf8W4a05cF3Yf(-2038019883 ^ -2038007651));

	public void Check()
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!((string)LrTI0FhlqpKD0GYMHM1(this) != (string)o7LNwVhf8W4a05cF3Yf(-193507406 ^ -193495150)))
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			default:
				throw new LicenseException();
			case 2:
				dcEOPFhLnXGsegEdhHj(this, __ModuleInfo.UID, new DecodeActivationKeyAction(DecodeLastActivationKey));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
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
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void ILicensedUnit.ApplyActivationKey(string key)
	{
		//Discarded unreachable code: IL_0123, IL_01c8, IL_01d7, IL_01f8, IL_0236, IL_0245, IL_02ea
		int num = 23;
		ushort licCount2 = default(ushort);
		byte licType2 = default(byte);
		DateTime? expirationDate2 = default(DateTime?);
		LicenseStatus status = default(LicenseStatus);
		ushort licCount = default(ushort);
		DateTime? expirationDate = default(DateTime?);
		byte licType = default(byte);
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
				case 10:
					return;
				case 16:
				{
					DecodeActivationKey(lastAppliedActKey, out var _, out licCount2, out licType2, out expirationDate2);
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 21:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 6;
					continue;
				case 18:
					return;
				case 19:
					if (licCount > licCount2)
					{
						num2 = 21;
						continue;
					}
					return;
				case 17:
					return;
				case 4:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 18;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					num4 = licType2;
					break;
				case 12:
					return;
				case 13:
					if (licType != 1)
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 11:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 10;
					continue;
				case 9:
					if (expirationDate2.HasValue)
					{
						num2 = 20;
						continue;
					}
					goto case 4;
				case 3:
					return;
				case 14:
					if (b > b2)
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 != 0)
					{
						num2 = 13;
					}
					continue;
				case 8:
					if (expirationDate.HasValue)
					{
						num2 = 9;
						continue;
					}
					goto case 19;
				case 6:
					return;
				case 15:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 3;
					continue;
				case 23:
					InitLicense();
					num2 = 22;
					continue;
				default:
					num3 = licType;
					goto IL_02f5;
				case 7:
					if (licType2 != 2)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					num4 = 1;
					break;
				case 5:
					if (licType == 2)
					{
						num2 = 8;
						continue;
					}
					goto case 19;
				case 22:
					if (DecodeActivationKey(key, out status, out licCount, out licType, out expirationDate))
					{
						if (lastAppliedActKey != null)
						{
							num2 = 16;
							continue;
						}
						goto case 11;
					}
					num2 = 17;
					continue;
				case 2:
					if (licType != 2)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					num3 = 1;
					goto IL_02f5;
				case 20:
					if (!ovib6MhJ8PiFXDQZ8wc(expirationDate.Value, expirationDate2.Value))
					{
						num2 = 19;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 4;
				case 24:
					{
						if (b >= b2)
						{
							num2 = 14;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 != 0)
							{
								num2 = 11;
							}
							continue;
						}
						goto case 15;
					}
					IL_02f5:
					b = (byte)num3;
					num2 = 7;
					continue;
				}
				b2 = (byte)num4;
				num2 = 24;
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
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
			case 2:
				InitLicense();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				UpdateTrialExpiration();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				licensingInitialized = true;
				num2 = 4;
				break;
			default:
				initializedStatus = licenseInfo.Status;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		//Discarded unreachable code: IL_0072, IL_0081, IL_0091, IL_00a0
		int num = 9;
		WorkplaceLicenseInfo workplaceLicenseInfo = default(WorkplaceLicenseInfo);
		uint? workplaceCount = default(uint?);
		ushort dbLicenseCount = default(ushort);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					InitLicense();
					num2 = 8;
					continue;
				case 3:
					if (workplaceLicenseInfo == null)
					{
						num2 = 5;
						continue;
					}
					break;
				case 7:
					if (workplaceCount.HasValue)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 2:
					workplaceLicenseInfo.WorkplaceCount = dbLicenseCount;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
				{
					ushort num3 = dbLicenseCount;
					workplaceCount = workplaceLicenseInfo.WorkplaceCount;
					if (num3 >= workplaceCount.Value)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				}
				case 8:
					workplaceLicenseInfo = licenseInfo as WorkplaceLicenseInfo;
					num2 = 3;
					continue;
				case 11:
					workplaceCount = workplaceLicenseInfo.WorkplaceCount;
					num2 = 7;
					continue;
				default:
					return licenseInfo;
				case 4:
					if (dbLicenseCount > 0)
					{
						goto end_IL_0012;
					}
					goto default;
				case 10:
					break;
				}
				dbLicenseCount = GetDbLicenseCount();
				num2 = 4;
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	void ILicensedUnit.UpdateLicenseInfo()
	{
		int num = 2;
		LicenseStatus status = default(LicenseStatus);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					UpdateTrialExpiration();
					num2 = 3;
					continue;
				case 2:
					InitLicense();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				case 3:
					return;
				case 4:
					Fj7YPfhrEbyUVyICwfm(licenseInfo, status);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _);
			num = 4;
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
		//Discarded unreachable code: IL_0099, IL_014a, IL_0182, IL_0191
		int num = 3;
		bool lockTaken = default(bool);
		InternalProcessesServiceExpress internalProcessesServiceExpress = default(InternalProcessesServiceExpress);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					return;
				case 4:
					lockTaken = false;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					if (!initialized)
					{
						internalProcessesServiceExpress = this;
						num2 = 4;
						continue;
					}
					break;
				case 1:
					try
					{
						Monitor.Enter(internalProcessesServiceExpress, ref lockTaken);
						int num3 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 4:
								registrationKey = (string)aEsXl9h7UnsArXgqsUu(1);
								num3 = 2;
								break;
							case 1:
								initialized = true;
								num3 = 3;
								break;
							case 2:
								licenseInfo = new LicenseInfo(this)
								{
									Status = LicenseStatus.NotActivated
								};
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 == 0)
								{
									num3 = 1;
								}
								break;
							default:
								if (initialized)
								{
									return;
								}
								num3 = 4;
								break;
							}
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num4 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									tFbYOBh5Cax5xsh85xG(internalProcessesServiceExpress);
									num4 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				}
				break;
			}
			num = 2;
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_005c, IL_006b, IL_007b, IL_015c
		int num = 6;
		int num2 = num;
		string text2 = default(string);
		string text = default(string);
		uint hnH = default(uint);
		uint hnL = default(uint);
		while (true)
		{
			switch (num2)
			{
			case 10:
				return (string)THvs89h1EEKLvTfrijH(text2 + text);
			case 5:
				text2 = hnH.ToString();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
			case 9:
				text = (string)fCKHe5hge6FD8LqugkE(o7LNwVhf8W4a05cF3Yf(0x77CE159B ^ 0x77CE2503), text);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
			case 7:
				if (text2.Length >= 10)
				{
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			default:
				text = hnL.ToString();
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
			case 8:
				if (text.Length < 10)
				{
					num2 = 9;
					continue;
				}
				goto case 10;
			case 6:
				LicensedUnitBase.GHN(out hnH, out hnL);
				num2 = 5;
				continue;
			case 2:
				break;
			}
			text2 = (string)fCKHe5hge6FD8LqugkE(o7LNwVhf8W4a05cF3Yf(0x51F798FE ^ 0x51F7A866), text2);
			num2 = 7;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bce36a95fd341dfb7b4178ccc0544f2 != 0)
			{
				num2 = 0;
			}
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_00b3, IL_0135, IL_0144, IL_0154
		int num = 10;
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
				case 13:
					num3 = 0;
					num2 = 6;
					continue;
				case 10:
					if (key != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 2;
				case 6:
				case 7:
					if (num3 < array.Length)
					{
						num2 = 11;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 12;
				case 12:
					return stringBuilder.ToString();
				case 5:
					num3++;
					num2 = 7;
					continue;
				case 1:
					ParDZGhZ03T8BtKJroX(stringBuilder, '-');
					num2 = 3;
					continue;
				case 4:
				case 11:
					if (num3 > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 8:
					array = (char[])psM57rhI755f5HZAqVq(key);
					num2 = 13;
					continue;
				case 3:
					break;
				default:
					if (num3 % 5 == 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					return string.Empty;
				case 9:
					stringBuilder = new StringBuilder();
					num2 = 8;
					continue;
				}
				break;
			}
			ParDZGhZ03T8BtKJroX(stringBuilder, array[num3]);
			num = 5;
		}
	}

	private bool DecodeLastActivationKey(out LicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate)
	{
		return DecodeActivationKey(lastAppliedActKey, out status, out licCount, out licType, out expirationDate);
	}

	private bool DecodeActivationKey(string key, out LicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate)
	{
		//Discarded unreachable code: IL_0145, IL_0215, IL_0224
		int num = 15;
		IWorkplaceLicenseInfo workplaceLicenseInfo = default(IWorkplaceLicenseInfo);
		ushort num3 = default(ushort);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					if (QxhfFHxXwG2fRtqYXZl(workplaceLicenseInfo) != byte.MaxValue)
					{
						num2 = 17;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 == 0)
						{
							num2 = 17;
						}
						break;
					}
					goto IL_00bf;
				case 9:
					licType = byte.MaxValue;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 != 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					return false;
				case 15:
					InitLicense();
					num2 = 14;
					break;
				case 7:
					licCount = num3;
					num2 = 11;
					break;
				case 16:
					if (workplaceLicenseInfo != null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 4:
					licType = 0;
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 == 0)
					{
						num2 = 0;
					}
					break;
				case 12:
					if (num3 < licCount)
					{
						num2 = 7;
						break;
					}
					goto case 2;
				case 14:
					expirationDate = null;
					num2 = 10;
					break;
				case 6:
					workplaceLicenseInfo = tGnYLZxCfSRlcCRuV41(licensedUnit) as IWorkplaceLicenseInfo;
					num2 = 16;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
					{
						num2 = 10;
					}
					break;
				case 2:
				case 11:
					return true;
				case 5:
				case 17:
					status = LicenseStatus.NotActivated;
					num2 = 18;
					break;
				case 13:
					if (workplaceLicenseInfo.Status != 0)
					{
						num2 = 5;
						break;
					}
					goto case 19;
				case 18:
					licCount = 0;
					num2 = 4;
					break;
				case 1:
					licCount = 65000;
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					num3 = VcUVK6xoCCKqMTF3uvC(this);
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 != 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					if (num3 <= 0)
					{
						num2 = 2;
						break;
					}
					goto case 12;
				case 10:
					licensedUnit = bSYZRNxElcyYGKORUEB(((ComponentManager)BT4lmphzcYuOk3ZoH0j()).ModuleManager) as ILicensedUnit;
					num2 = 20;
					break;
				case 20:
					{
						if (licensedUnit != null)
						{
							num2 = 3;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 == 0)
							{
								num2 = 6;
							}
							break;
						}
						goto IL_00bf;
					}
					IL_00bf:
					status = LicenseStatus.Activated;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
					{
						num2 = 1;
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

	private void SetLastAppliedKey(string key, LicenseStatus newStatus, ushort newLicCount, DateTime? newExpirationDate, byte newLicType)
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
		if (licenseInfo is WorkplaceLicenseInfo)
		{
			((WorkplaceLicenseInfo)licenseInfo).WorkplaceCount = ((newLicCount >= 65000) ? null : new uint?(newLicCount));
		}
		licenseInfo.TrialExpiration = newExpirationDate;
		if (licensingInitialized)
		{
			UpdateTrialExpiration();
		}
	}

	private void UpdateTrialExpiration()
	{
		//Discarded unreachable code: IL_0049, IL_0058
		int num = 8;
		int num2 = num;
		DateTime? trialExpiration = default(DateTime?);
		LicenseStatus status = default(LicenseStatus);
		DateTime? trialExpiration2 = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 1:
				licenseInfo.TrialExpiration = trialExpiration;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
				{
					num2 = 3;
				}
				break;
			case 8:
				if (licenseInfo == null)
				{
					num2 = 7;
					break;
				}
				goto default;
			case 4:
				status = clUGEsx37OcoMLb8ciJ(licenseInfo);
				num2 = 9;
				break;
			default:
				trialExpiration2 = licenseInfo.TrialExpiration;
				num2 = 2;
				break;
			case 3:
				Fj7YPfhrEbyUVyICwfm(licenseInfo, status);
				num2 = 6;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return;
			case 2:
				if (!trialExpiration2.HasValue)
				{
					return;
				}
				num2 = 5;
				break;
			case 5:
				trialExpiration = licenseInfo.TrialExpiration;
				num2 = 4;
				break;
			case 9:
				UpdateTrialExpiration(ref trialExpiration, ref status);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static void UpdateTrialExpiration(ref DateTime? trialExpiration, ref LicenseStatus status)
	{
		//Discarded unreachable code: IL_0085, IL_0094, IL_01a8, IL_01b7
		int num = 1;
		ITrialLicenseInfo trialLicenseInfo = default(ITrialLicenseInfo);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		DateTime? trialExpiration2 = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					trialLicenseInfo = licensedUnit.GetLicenseInfo() as ITrialLicenseInfo;
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 == 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					if (status == LicenseStatus.DateExpired)
					{
						num2 = 14;
						continue;
					}
					return;
				case 10:
					trialExpiration2 = trialLicenseInfo.TrialExpiration;
					num2 = 3;
					continue;
				case 11:
					trialExpiration = trialLicenseInfo.TrialExpiration;
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea != 0)
					{
						num2 = 10;
					}
					continue;
				case 3:
					if (trialExpiration2.HasValue)
					{
						num2 = 11;
						continue;
					}
					goto case 9;
				case 9:
				case 12:
				case 13:
					if (trialExpiration.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 1:
					if (trialExpiration.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 4:
					if (licensedUnit == null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				default:
					licensedUnit = bSYZRNxElcyYGKORUEB(WKXnDfxhDe4gwbS91lq(BT4lmphzcYuOk3ZoH0j())) as ILicensedUnit;
					num2 = 4;
					continue;
				case 2:
					if (status != 0)
					{
						num2 = 8;
						continue;
					}
					break;
				case 7:
					if (trialLicenseInfo == null)
					{
						num2 = 13;
						continue;
					}
					goto case 10;
				case 6:
					return;
				case 14:
					break;
				}
				status = (ovib6MhJ8PiFXDQZ8wc(fpvql0xxREHSiRS4ufv().Date, trialExpiration.Value) ? LicenseStatus.DateExpired : LicenseStatus.Activated);
				num2 = 6;
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public InternalProcessesServiceExpress()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		eei6NrxFyLWs7w26ET3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object LrTI0FhlqpKD0GYMHM1(object P_0)
	{
		return ((LicensedUnitBase)P_0).MainProviderType;
	}

	internal static object o7LNwVhf8W4a05cF3Yf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void dcEOPFhLnXGsegEdhHj(object P_0, Guid P_1, object P_2)
	{
		((LicensedUnitBase)P_0).Check(P_1, (DecodeActivationKeyAction)P_2);
	}

	internal static bool wPt9myhic67YgojTfg8()
	{
		return HJ1ja5hetFN5jkUKBBs == null;
	}

	internal static InternalProcessesServiceExpress MKp555huH1nqfn0AZqx()
	{
		return HJ1ja5hetFN5jkUKBBs;
	}

	internal static bool ovib6MhJ8PiFXDQZ8wc(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static void Fj7YPfhrEbyUVyICwfm(object P_0, LicenseStatus P_1)
	{
		((LicenseInfo)P_0).Status = P_1;
	}

	internal static object aEsXl9h7UnsArXgqsUu(ushort algorithm)
	{
		return GenerateRegistrationKey(algorithm);
	}

	internal static void tFbYOBh5Cax5xsh85xG(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object fCKHe5hge6FD8LqugkE(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object THvs89h1EEKLvTfrijH(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object psM57rhI755f5HZAqVq(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object ParDZGhZ03T8BtKJroX(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object BT4lmphzcYuOk3ZoH0j()
	{
		return ComponentManager.Current;
	}

	internal static object bSYZRNxElcyYGKORUEB(object P_0)
	{
		return ((IModuleManager)P_0).MainApplication;
	}

	internal static object tGnYLZxCfSRlcCRuV41(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static byte QxhfFHxXwG2fRtqYXZl(object P_0)
	{
		return ((ILicenseInfo)P_0).LicenseType;
	}

	internal static ushort VcUVK6xoCCKqMTF3uvC(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetDbLicenseCount();
	}

	internal static LicenseStatus clUGEsx37OcoMLb8ciJ(object P_0)
	{
		return ((LicenseInfo)P_0).Status;
	}

	internal static object WKXnDfxhDe4gwbS91lq(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static DateTime fpvql0xxREHSiRS4ufv()
	{
		return DateTime.Now;
	}

	internal static void eei6NrxFyLWs7w26ET3()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
