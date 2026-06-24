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

internal class InternalProcessesServiceOracle : LicensedUnitBase, IInternalProcessesService, ILicensedUnit, IActivationTokenContainer
{
	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private LicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	internal static InternalProcessesServiceOracle SV80lCx8DJm47rE0S6w;

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string)x0EOhqxqnCKYLsfMD92(-478552651 ^ -478548483));

	public void Check()
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
				if (lh7ecLxsng2G1MtWf9m(MainProviderType, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x713816B4 ^ 0x7138262A)))
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 == 0)
					{
						num2 = 1;
					}
					break;
				}
				J8hhWPx2pLSwjjoNFRt(this, __ModuleInfo.UID, new DecodeActivationKeyAction(DecodeLastActivationKey));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
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
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void ILicensedUnit.ApplyActivationKey(string key)
	{
		//Discarded unreachable code: IL_00d6, IL_00e5, IL_0109, IL_0197, IL_01a6, IL_01e1, IL_02bc, IL_02ee, IL_02fd
		int num = 19;
		byte licType2 = default(byte);
		byte licType = default(byte);
		DateTime? expirationDate = default(DateTime?);
		ushort licCount = default(ushort);
		DateTime? expirationDate2 = default(DateTime?);
		LicenseStatus status2 = default(LicenseStatus);
		ushort licCount2 = default(ushort);
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
				default:
					return;
				case 10:
					if (licType2 == 2)
					{
						num2 = 15;
						continue;
					}
					goto IL_016b;
				case 0:
					return;
				case 9:
					if (licType2 != 1)
					{
						num2 = 10;
						continue;
					}
					goto case 15;
				case 4:
					if (licType2 != 2)
					{
						num2 = 16;
						continue;
					}
					num4 = 1;
					goto IL_0309;
				case 20:
					return;
				case 8:
					if (lastAppliedActKey != null)
					{
						num = 6;
						break;
					}
					goto case 23;
				case 19:
					InitLicense();
					num2 = 18;
					continue;
				case 21:
					return;
				case 1:
					num3 = licType;
					goto IL_0326;
				case 15:
					if (expirationDate.HasValue)
					{
						num2 = 12;
						continue;
					}
					goto IL_016b;
				case 17:
					return;
				case 6:
				{
					DecodeActivationKey(lastAppliedActKey, out var _, out licCount, out licType, out expirationDate2);
					num = 4;
					break;
				}
				case 11:
					if (licType != 2)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					num3 = 1;
					goto IL_0326;
				case 3:
					return;
				case 7:
					return;
				case 13:
				case 24:
					SetLastAppliedKey(key, status2, licCount2, expirationDate, licType2);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 == 0)
					{
						num2 = 3;
					}
					continue;
				case 16:
					num4 = licType2;
					goto IL_0309;
				case 23:
					SetLastAppliedKey(key, status2, licCount2, expirationDate, licType2);
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
					{
						num2 = 17;
					}
					continue;
				case 14:
					SetLastAppliedKey(key, status2, licCount2, expirationDate, licType2);
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
					{
						num2 = 21;
					}
					continue;
				case 5:
					if (dwDqOsxQRvUU4uX4mdJ(expirationDate.Value, expirationDate2.Value))
					{
						num2 = 24;
						continue;
					}
					goto IL_016b;
				case 12:
					if (!expirationDate2.HasValue)
					{
						num2 = 13;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 5;
				case 18:
					if (!DecodeActivationKey(key, out status2, out licCount2, out licType2, out expirationDate))
					{
						return;
					}
					num2 = 8;
					continue;
				case 2:
					SetLastAppliedKey(key, status2, licCount2, expirationDate, licType2);
					num2 = 7;
					continue;
				case 22:
					{
						if (b >= b2)
						{
							if (b > b2)
							{
								return;
							}
							num2 = 9;
						}
						else
						{
							num2 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 == 0)
							{
								num2 = 2;
							}
						}
						continue;
					}
					IL_0326:
					b2 = (byte)num3;
					num2 = 22;
					continue;
					IL_016b:
					if (licCount2 <= licCount)
					{
						return;
					}
					num2 = 14;
					continue;
					IL_0309:
					b = (byte)num4;
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	void ILicensedUnit.CompleteLicensingInitialize()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				default:
					licensingInitialized = true;
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					initializedStatus = TfUlU4xVJ5xkXXFN9rj(licenseInfo);
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					InitLicense();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				break;
			}
			UpdateTrialExpiration();
			num = 3;
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		//Discarded unreachable code: IL_0128
		int num = 7;
		int num2 = num;
		ushort dbLicenseCount = default(ushort);
		uint? workplaceCount = default(uint?);
		WorkplaceLicenseInfo workplaceLicenseInfo = default(WorkplaceLicenseInfo);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (dbLicenseCount > 0)
				{
					num2 = 3;
					continue;
				}
				break;
			case 8:
				if (workplaceCount.HasValue)
				{
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 10;
			case 7:
				InitLicense();
				num2 = 6;
				continue;
			case 6:
				workplaceLicenseInfo = licenseInfo as WorkplaceLicenseInfo;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c != 0)
				{
					num2 = 2;
				}
				continue;
			case 3:
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				num2 = 8;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
				{
					num2 = 4;
				}
				continue;
			case 2:
				if (workplaceLicenseInfo != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 10:
				workplaceLicenseInfo.WorkplaceCount = dbLicenseCount;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
			{
				ushort num3 = dbLicenseCount;
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				if (num3 >= workplaceCount.Value)
				{
					num2 = 9;
					continue;
				}
				goto case 10;
			}
			case 1:
				dbLicenseCount = GetDbLicenseCount();
				num2 = 4;
				continue;
			}
			break;
		}
		return licenseInfo;
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
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				UpdateTrialExpiration();
				num2 = 3;
				break;
			case 3:
				return;
			case 2:
				rka03VxDXR3h4HJWNjk(licenseInfo, status);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c41b9b25e0a04be1b1ded81427c555dd != 0)
				{
					num2 = 4;
				}
				break;
			default:
			{
				DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c == 0)
				{
					num2 = 2;
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
		//Discarded unreachable code: IL_0054, IL_0125, IL_0165, IL_0174, IL_0180, IL_018f
		int num = 2;
		int num2 = num;
		InternalProcessesServiceOracle obj = default(InternalProcessesServiceOracle);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 4:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
					{
						num3 = 2;
					}
					while (true)
					{
						switch (num3)
						{
						case 4:
							initialized = true;
							num3 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 == 0)
							{
								num3 = 1;
							}
							break;
						case 3:
						{
							LicenseInfo obj2 = new LicenseInfo(this);
							rka03VxDXR3h4HJWNjk(obj2, LicenseStatus.NotActivated);
							licenseInfo = obj2;
							num3 = 4;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
							{
								num3 = 1;
							}
							break;
						}
						case 2:
							if (!initialized)
							{
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9f9823be58b94730af510f3472045ea6 != 0)
								{
									num3 = 0;
								}
								break;
							}
							return;
						default:
							registrationKey = (string)HYom00xKxeXH3qCQXjQ(1);
							num3 = 3;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
							{
								num3 = 3;
							}
							break;
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
						goto IL_0129;
					}
					goto IL_013f;
					IL_0129:
					switch (num4)
					{
					case 2:
						goto end_IL_0114;
					case 1:
						goto end_IL_0114;
					}
					goto IL_013f;
					IL_013f:
					Monitor.Exit(obj);
					num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
					{
						num4 = 1;
					}
					goto IL_0129;
					end_IL_0114:;
				}
			case 3:
				return;
			case 1:
				return;
			default:
				lockTaken = false;
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				if (!initialized)
				{
					obj = this;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_00d0, IL_011a, IL_013c, IL_014b, IL_015b, IL_016a
		int num = 11;
		int num2 = num;
		string text = default(string);
		uint hnH = default(uint);
		string text2 = default(string);
		uint hnL = default(uint);
		while (true)
		{
			switch (num2)
			{
			default:
				text = (string)JPjIyKxMgZW5jjKvXaV(x0EOhqxqnCKYLsfMD92(-79921577 ^ -79933745), text);
				num2 = 4;
				break;
			case 10:
				text = hnH.ToString();
				num2 = 2;
				break;
			case 7:
				return (string)u39U8BxYom0s7hPf2af(JPjIyKxMgZW5jjKvXaV(text, text2));
			case 5:
			case 6:
				text2 = (string)x0EOhqxqnCKYLsfMD92(0x5A5DBA54 ^ 0x5A5D8ACC) + text2;
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			case 3:
				if (PnY1rUxa6x0fvnAWFh4(text2) < 10)
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 7;
			case 2:
				text2 = hnL.ToString();
				num2 = 9;
				break;
			case 11:
				LicensedUnitBase.GHN(out hnH, out hnL);
				num2 = 10;
				break;
			case 4:
			case 9:
				if (PnY1rUxa6x0fvnAWFh4(text) >= 10)
				{
					goto case 1;
				}
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e != 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_00c0, IL_011a, IL_014e, IL_015d, IL_0175, IL_0184
		int num = 3;
		int num3 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		char[] array = default(char[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					if (num3 % 5 != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 13;
				case 1:
				case 8:
				case 12:
					HHMteixv9cgbF6GuXi8(stringBuilder, array[num3]);
					num2 = 4;
					continue;
				case 7:
					if (num3 <= 0)
					{
						num2 = 12;
						continue;
					}
					goto case 14;
				case 11:
					return string.Empty;
				case 2:
					stringBuilder = new StringBuilder();
					num2 = 10;
					continue;
				case 10:
					array = ((string)key).ToCharArray();
					num2 = 6;
					continue;
				case 13:
					HHMteixv9cgbF6GuXi8(stringBuilder, '-');
					num = 8;
					break;
				case 6:
					num3 = 0;
					num = 5;
					break;
				case 3:
					if (key != null)
					{
						num2 = 2;
						continue;
					}
					goto case 11;
				default:
					if (num3 >= array.Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 7;
				case 9:
					return stringBuilder.ToString();
				case 4:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private bool DecodeLastActivationKey(out LicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate)
	{
		return DecodeActivationKey(lastAppliedActKey, out status, out licCount, out licType, out expirationDate);
	}

	private bool DecodeActivationKey(string key, out LicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate)
	{
		//Discarded unreachable code: IL_008a, IL_0099, IL_010e, IL_011d, IL_01ee, IL_01fd, IL_024e
		int num = 10;
		IWorkplaceLicenseInfo workplaceLicenseInfo = default(IWorkplaceLicenseInfo);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		ushort num3 = default(ushort);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					licCount = 0;
					num2 = 12;
					continue;
				case 3:
					workplaceLicenseInfo = licensedUnit.GetLicenseInfo() as IWorkplaceLicenseInfo;
					num = 18;
					break;
				case 14:
					if (licensedUnit == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2e79a6d6eb444d33993dd78f88b64832 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 3;
				case 8:
					licCount = 65000;
					num2 = 22;
					continue;
				case 15:
				case 16:
					return true;
				case 18:
					if (workplaceLicenseInfo == null)
					{
						num = 2;
						break;
					}
					goto case 5;
				case 1:
				case 2:
				case 21:
					status = LicenseStatus.NotActivated;
					num2 = 11;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
					{
						num2 = 20;
					}
					continue;
				case 4:
					return false;
				case 7:
					status = LicenseStatus.Activated;
					num2 = 8;
					continue;
				case 9:
					expirationDate = null;
					num2 = 17;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa == 0)
					{
						num2 = 14;
					}
					continue;
				default:
					licCount = num3;
					num2 = 16;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 == 0)
					{
						num2 = 10;
					}
					continue;
				case 6:
					num3 = KpfEFEx9Xcf2FH5IMWg(this);
					num2 = 13;
					continue;
				case 17:
					licensedUnit = ((ComponentManager)d0yaInxPMPjJgmtvGb7()).ModuleManager.MainApplication as ILicensedUnit;
					num2 = 14;
					continue;
				case 19:
					if (num3 >= licCount)
					{
						num2 = 15;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto default;
				case 11:
					if (wxhwLKx4Pt0Qw7i8LQU(workplaceLicenseInfo) != byte.MaxValue)
					{
						num2 = 21;
						continue;
					}
					goto case 7;
				case 5:
					if (workplaceLicenseInfo.Status != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 10:
					InitLicense();
					num2 = 9;
					continue;
				case 12:
					licType = 0;
					num = 4;
					break;
				case 13:
					if (num3 > 0)
					{
						num2 = 19;
						continue;
					}
					goto case 15;
				case 22:
					licType = byte.MaxValue;
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
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
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 4;
		LicenseStatus status = default(LicenseStatus);
		DateTime? trialExpiration2 = default(DateTime?);
		DateTime? trialExpiration = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					rka03VxDXR3h4HJWNjk(licenseInfo, status);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_cc6425824e2145d58580462376bc9992 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					return;
				case 4:
					if (licenseInfo != null)
					{
						num = 3;
						break;
					}
					return;
				case 7:
					trialExpiration2 = licenseInfo.TrialExpiration;
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					licenseInfo.TrialExpiration = trialExpiration2;
					num2 = 6;
					continue;
				case 2:
					status = TfUlU4xVJ5xkXXFN9rj(licenseInfo);
					num2 = 9;
					continue;
				case 1:
					return;
				case 3:
					trialExpiration = licenseInfo.TrialExpiration;
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 != 0)
					{
						num2 = 2;
					}
					continue;
				case 9:
					UpdateTrialExpiration(ref trialExpiration2, ref status);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (!trialExpiration.HasValue)
					{
						num = 5;
						break;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	private static void UpdateTrialExpiration(ref DateTime? trialExpiration, ref LicenseStatus status)
	{
		//Discarded unreachable code: IL_00b9, IL_0123, IL_014c, IL_015b, IL_01a4, IL_01b3, IL_01c2, IL_0234, IL_0243
		int num = 15;
		int num2 = num;
		ITrialLicenseInfo trialLicenseInfo = default(ITrialLicenseInfo);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		DateTime? trialExpiration2 = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 13:
				trialExpiration = trialLicenseInfo.TrialExpiration;
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f != 0)
				{
					num2 = 4;
				}
				break;
			case 15:
				if (!trialExpiration.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 != 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 3;
			case 14:
				return;
			case 9:
				trialLicenseInfo = licensedUnit.GetLicenseInfo() as ITrialLicenseInfo;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5158ff5e06d54ab9b6f7b04c47b15f73 != 0)
				{
					num2 = 12;
				}
				break;
			case 6:
				if (status == LicenseStatus.DateExpired)
				{
					num2 = 17;
					break;
				}
				return;
			case 7:
				if (status == LicenseStatus.Activated)
				{
					num2 = 11;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 6;
			default:
				if (!trialExpiration.HasValue)
				{
					num2 = 16;
					break;
				}
				goto case 7;
			case 2:
				return;
			case 16:
				return;
			case 18:
				trialExpiration2 = trialLicenseInfo.TrialExpiration;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				if (!trialExpiration2.HasValue)
				{
					num2 = 8;
					break;
				}
				goto case 13;
			case 3:
				licensedUnit = ((IModuleManager)HOdFhHxTiWku4bx6idS(d0yaInxPMPjJgmtvGb7())).MainApplication as ILicensedUnit;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 != 0)
				{
					num2 = 1;
				}
				break;
			case 12:
				if (trialLicenseInfo == null)
				{
					num2 = 10;
					break;
				}
				goto case 18;
			case 1:
				if (licensedUnit == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 11:
			case 17:
				status = (dwDqOsxQRvUU4uX4mdJ(DateTime.Now.Date, trialExpiration.Value) ? LicenseStatus.DateExpired : LicenseStatus.Activated);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public InternalProcessesServiceOracle()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		opt1KnxcXhkBVHLp6kC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lh7ecLxsng2G1MtWf9m(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void J8hhWPx2pLSwjjoNFRt(object P_0, Guid P_1, object P_2)
	{
		((LicensedUnitBase)P_0).Check(P_1, (DecodeActivationKeyAction)P_2);
	}

	internal static bool TYumbVxwMFAAG9X77lm()
	{
		return SV80lCx8DJm47rE0S6w == null;
	}

	internal static InternalProcessesServiceOracle COqGjyxt1NdKkZXnA3x()
	{
		return SV80lCx8DJm47rE0S6w;
	}

	internal static object x0EOhqxqnCKYLsfMD92(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool dwDqOsxQRvUU4uX4mdJ(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static LicenseStatus TfUlU4xVJ5xkXXFN9rj(object P_0)
	{
		return ((LicenseInfo)P_0).Status;
	}

	internal static void rka03VxDXR3h4HJWNjk(object P_0, LicenseStatus P_1)
	{
		((LicenseInfo)P_0).Status = P_1;
	}

	internal static object HYom00xKxeXH3qCQXjQ(ushort algorithm)
	{
		return GenerateRegistrationKey(algorithm);
	}

	internal static object JPjIyKxMgZW5jjKvXaV(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int PnY1rUxa6x0fvnAWFh4(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object u39U8BxYom0s7hPf2af(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object HHMteixv9cgbF6GuXi8(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object d0yaInxPMPjJgmtvGb7()
	{
		return ComponentManager.Current;
	}

	internal static byte wxhwLKx4Pt0Qw7i8LQU(object P_0)
	{
		return ((ILicenseInfo)P_0).LicenseType;
	}

	internal static ushort KpfEFEx9Xcf2FH5IMWg(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetDbLicenseCount();
	}

	internal static object HOdFhHxTiWku4bx6idS(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static void opt1KnxcXhkBVHLp6kC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
