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

internal class InternalProcessesServiceStandart : LicensedUnitBase, IInternalProcessesService, ILicensedUnit, IActivationTokenContainer
{
	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private LicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	internal static InternalProcessesServiceStandart egukghxN3326DC3NkQ9;

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string)sGVUyWxUerHP1lbSRXo(0xFA4957C ^ 0xFA4A534));

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
			case 1:
				throw new LicenseException();
			case 2:
				if (!sy4uobxkScr5bQUU0Uv(YVcF6OxSNweVikO0IU4(this), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-478552651 ^ -478548725)))
				{
					nEuoIWxbUqmXNQnlVWN(this, __ModuleInfo.UID, new DecodeActivationKeyAction(DecodeLastActivationKey));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
					{
						num2 = 1;
					}
				}
				break;
			case 0:
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
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void ILicensedUnit.ApplyActivationKey(string key)
	{
		//Discarded unreachable code: IL_0093, IL_00ed, IL_00fc, IL_0150, IL_019b, IL_01ae, IL_01bd, IL_0279, IL_02a9, IL_02eb, IL_02fa
		int num = 18;
		byte licType = default(byte);
		ushort licCount2 = default(ushort);
		byte licType2 = default(byte);
		DateTime? expirationDate2 = default(DateTime?);
		DateTime? expirationDate = default(DateTime?);
		LicenseStatus status = default(LicenseStatus);
		ushort licCount = default(ushort);
		byte b = default(byte);
		byte b2 = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 11:
					num3 = licType;
					goto IL_0336;
				case 18:
					InitLicense();
					num2 = 17;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
					{
						num2 = 17;
					}
					continue;
				case 6:
					return;
				case 15:
				{
					DecodeActivationKey(lastAppliedActKey, out var _, out licCount2, out licType2, out expirationDate2);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				case 27:
					if (!UUogfVxmwMoGjlNNWJM(expirationDate.Value, expirationDate2.Value))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 4:
					return;
				case 14:
					if (licType != 1)
					{
						num2 = 16;
						continue;
					}
					goto case 23;
				case 12:
					return;
				case 23:
					if (!expirationDate.HasValue)
					{
						num2 = 2;
						continue;
					}
					goto case 26;
				case 13:
					return;
				case 3:
				case 10:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 25;
					continue;
				case 1:
					if (b >= b2)
					{
						num2 = 9;
						continue;
					}
					goto case 7;
				case 25:
					return;
				default:
					if (licCount <= licCount2)
					{
						num2 = 13;
						continue;
					}
					goto case 20;
				case 16:
					if (licType == 2)
					{
						num2 = 23;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto default;
				case 20:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 8;
					continue;
				case 22:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 6;
					continue;
				case 24:
					return;
				case 9:
					if (b > b2)
					{
						return;
					}
					goto end_IL_0012;
				case 8:
					return;
				case 7:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 24;
					continue;
				case 19:
					num4 = licType2;
					break;
				case 21:
					if (licType2 != 2)
					{
						num2 = 17;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
						{
							num2 = 19;
						}
						continue;
					}
					num4 = 1;
					break;
				case 26:
					if (!expirationDate2.HasValue)
					{
						num2 = 10;
						continue;
					}
					goto case 27;
				case 5:
					if (licType != 2)
					{
						num2 = 11;
						continue;
					}
					num3 = 1;
					goto IL_0336;
				case 17:
					{
						if (DecodeActivationKey(key, out status, out licCount, out licType, out expirationDate))
						{
							if (lastAppliedActKey != null)
							{
								num2 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
								{
									num2 = 15;
								}
								continue;
							}
							goto case 22;
						}
						num2 = 12;
						continue;
					}
					IL_0336:
					b = (byte)num3;
					num2 = 21;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c == 0)
					{
						num2 = 17;
					}
					continue;
				}
				b2 = (byte)num4;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 14;
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
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				licensingInitialized = true;
				num2 = 3;
				break;
			case 3:
				UpdateTrialExpiration();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
				{
					num2 = 0;
				}
				break;
			default:
				initializedStatus = mxtDawxAghqKURYfWeB(licenseInfo);
				num2 = 4;
				break;
			case 4:
				return;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		//Discarded unreachable code: IL_010b
		int num = 5;
		int num2 = num;
		WorkplaceLicenseInfo workplaceLicenseInfo = default(WorkplaceLicenseInfo);
		ushort num3 = default(ushort);
		uint? workplaceCount = default(uint?);
		while (true)
		{
			switch (num2)
			{
			default:
				if (workplaceLicenseInfo != null)
				{
					num2 = 8;
					break;
				}
				goto case 3;
			case 4:
				workplaceLicenseInfo = licenseInfo as WorkplaceLicenseInfo;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				InitLicense();
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			{
				ushort num4 = num3;
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				if (num4 >= workplaceCount.Value)
				{
					num2 = 9;
					break;
				}
				goto case 10;
			}
			case 7:
				if (workplaceCount.HasValue)
				{
					num2 = 2;
					break;
				}
				goto case 10;
			case 10:
				workplaceLicenseInfo.WorkplaceCount = num3;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
			case 9:
				return licenseInfo;
			case 8:
				num3 = CpbUlexpQxphqNKuxfg(this);
				num2 = 6;
				break;
			case 6:
				if (num3 > 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 1:
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				num2 = 7;
				break;
			}
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
				return;
			case 4:
				bE4ZYcxGXjuv0ObhfUy(licenseInfo, status);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				InitLicense();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				UpdateTrialExpiration();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _);
				num2 = 4;
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
		//Discarded unreachable code: IL_011e, IL_0156, IL_0165, IL_0175, IL_0184
		int num = 1;
		InternalProcessesServiceStandart internalProcessesServiceStandart = default(InternalProcessesServiceStandart);
		bool lockTaken = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 5:
					try
					{
						Monitor.Enter(internalProcessesServiceStandart, ref lockTaken);
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 2:
								if (initialized)
								{
									return;
								}
								num4 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 == 0)
								{
									num4 = 1;
								}
								break;
							case 3:
								licenseInfo = new LicenseInfo(this)
								{
									Status = LicenseStatus.NotActivated
								};
								num4 = 4;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_48279d3d45e2437b9907d478ce5a47b1 != 0)
								{
									num4 = 4;
								}
								break;
							case 1:
								registrationKey = (string)cKtvo6xnFQAYnH3xbnh(1);
								num4 = 3;
								break;
							case 4:
								initialized = true;
								num4 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num5 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff != 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									BbXXnPxy7XaJkOrf63T(internalProcessesServiceStandart);
									num5 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e != 0)
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
				case 3:
					return;
				case 1:
					if (initialized)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					lockTaken = false;
					num2 = 5;
					continue;
				}
				break;
			}
			internalProcessesServiceStandart = this;
			num = 4;
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_005c, IL_010d, IL_014f
		int num = 8;
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
				case 6:
					return (string)lTw72nxRo2ZThhmDL7d(xHr3MAxOgoDiiWP7BGg(text, text2));
				case 8:
					LicensedUnitBase.GHN(out hnH, out hnL);
					num2 = 7;
					continue;
				case 2:
				case 3:
					text2 = (string)xHr3MAxOgoDiiWP7BGg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-79921577 ^ -79933745), text2);
					num2 = 5;
					continue;
				case 7:
					text = hnH.ToString();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
				case 10:
					if (acA4nZx6BIYcUfSfSAn(text2) < 10)
					{
						num2 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 9:
					text = (string)xHr3MAxOgoDiiWP7BGg(sGVUyWxUerHP1lbSRXo(-2144947971 ^ -2144960411), text);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
				case 4:
					if (acA4nZx6BIYcUfSfSAn(text) >= 10)
					{
						num2 = 4;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2e79a6d6eb444d33993dd78f88b64832 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 9;
				}
				break;
			}
			text2 = hnL.ToString();
			num = 4;
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_00a2, IL_00c3, IL_00ed, IL_00fc, IL_0133, IL_0142
		int num = 4;
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
				case 10:
					num3 = 0;
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
					{
						num2 = 7;
					}
					continue;
				case 2:
					return stringBuilder.ToString();
				case 5:
					num3++;
					num2 = 12;
					continue;
				case 4:
					if (key == null)
					{
						num2 = 3;
						continue;
					}
					stringBuilder = new StringBuilder();
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					array = (char[])hGYAcrx0lCL0SReyaZI(key);
					num2 = 10;
					continue;
				default:
					goto end_IL_0012;
				case 3:
					return string.Empty;
				case 7:
				case 12:
					if (num3 < array.Length)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 13:
					if (num3 % 5 != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 1:
				case 6:
					if (num3 <= 0)
					{
						num2 = 14;
						continue;
					}
					goto case 13;
				case 9:
					break;
				}
				DHpE8axBand7uZ1NTkx(stringBuilder, '-');
				num2 = 11;
				continue;
				end_IL_0012:
				break;
			}
			DHpE8axBand7uZ1NTkx(stringBuilder, array[num3]);
			num = 5;
		}
	}

	private bool DecodeLastActivationKey(out LicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate)
	{
		return DecodeActivationKey(lastAppliedActKey, out status, out licCount, out licType, out expirationDate);
	}

	private bool DecodeActivationKey(string key, out LicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate)
	{
		//Discarded unreachable code: IL_011e, IL_01b4
		int num = 13;
		ushort num3 = default(ushort);
		IWorkplaceLicenseInfo workplaceLicenseInfo = default(IWorkplaceLicenseInfo);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					if (num3 <= 0)
					{
						num2 = 19;
						continue;
					}
					goto case 2;
				case 20:
					licType = 0;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					if (workplaceLicenseInfo != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 10;
				case 3:
					licensedUnit = ((IModuleManager)LOlGcXxHe6lxpLmb2vt(q6HDZNxWVVFoxPQwsSQ())).MainApplication as ILicensedUnit;
					num2 = 16;
					continue;
				case 12:
					expirationDate = null;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f == 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					if (PnaexmxiCB7kpy7Gqrw(workplaceLicenseInfo) == LicenseStatus.Activated)
					{
						num2 = 6;
						continue;
					}
					goto case 10;
				case 16:
					if (licensedUnit == null)
					{
						num2 = 8;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 7;
				default:
					return false;
				case 8:
					status = LicenseStatus.Activated;
					num = 4;
					break;
				case 2:
					if (num3 < licCount)
					{
						num2 = 14;
						continue;
					}
					goto case 11;
				case 10:
					status = LicenseStatus.NotActivated;
					num2 = 18;
					continue;
				case 17:
					licType = byte.MaxValue;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					licCount = 65000;
					num2 = 17;
					continue;
				case 11:
				case 19:
					return true;
				case 6:
					if (workplaceLicenseInfo.LicenseType != byte.MaxValue)
					{
						num2 = 10;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 8;
				case 14:
					licCount = num3;
					num2 = 11;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 == 0)
					{
						num2 = 6;
					}
					continue;
				case 18:
					licCount = 0;
					num = 20;
					break;
				case 7:
					workplaceLicenseInfo = ie0pLXxegkmOw1PTFK5(licensedUnit) as IWorkplaceLicenseInfo;
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 != 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					num3 = CpbUlexpQxphqNKuxfg(this);
					num2 = 15;
					continue;
				case 13:
					InitLicense();
					num = 12;
					break;
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
		int num = 8;
		int num2 = num;
		LicenseStatus status = default(LicenseStatus);
		DateTime? trialExpiration = default(DateTime?);
		DateTime? trialExpiration2 = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				status = mxtDawxAghqKURYfWeB(licenseInfo);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f2221527565f4c919b1fed8e8c54e4f7 != 0)
				{
					num2 = 1;
				}
				continue;
			case 6:
				trialExpiration = licenseInfo.TrialExpiration;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 != 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				UpdateTrialExpiration(ref trialExpiration, ref status);
				num2 = 5;
				continue;
			case 3:
				return;
			case 7:
				trialExpiration2 = licenseInfo.TrialExpiration;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 == 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				if (licenseInfo == null)
				{
					return;
				}
				num2 = 7;
				continue;
			case 5:
				licenseInfo.TrialExpiration = trialExpiration;
				num2 = 4;
				continue;
			case 4:
				bE4ZYcxGXjuv0ObhfUy(licenseInfo, status);
				num2 = 3;
				continue;
			}
			if (!trialExpiration2.HasValue)
			{
				return;
			}
			num2 = 6;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e307e1455f8c4779adb085e36b40526a == 0)
			{
				num2 = 0;
			}
		}
	}

	private static void UpdateTrialExpiration(ref DateTime? trialExpiration, ref LicenseStatus status)
	{
		//Discarded unreachable code: IL_005d, IL_01a8
		int num = 7;
		int num2 = num;
		DateTime? trialExpiration2 = default(DateTime?);
		ITrialLicenseInfo trialLicenseInfo = default(ITrialLicenseInfo);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				trialExpiration2 = trialLicenseInfo.TrialExpiration;
				num2 = 2;
				break;
			case 7:
				if (trialExpiration.HasValue)
				{
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
					{
						num2 = 6;
					}
					break;
				}
				return;
			case 5:
				if (status == LicenseStatus.DateExpired)
				{
					num2 = 11;
					break;
				}
				return;
			case 4:
				if (licensedUnit != null)
				{
					num2 = 13;
					break;
				}
				goto case 10;
			case 6:
				licensedUnit = GW8TTAxu8n0KGqD98Ym(ComponentManager.Current.ModuleManager) as ILicensedUnit;
				num2 = 4;
				break;
			case 13:
				trialLicenseInfo = licensedUnit.GetLicenseInfo() as ITrialLicenseInfo;
				num2 = 14;
				break;
			case 9:
				return;
			case 12:
				trialExpiration = trialLicenseInfo.TrialExpiration;
				num2 = 10;
				break;
			case 3:
				if (status == LicenseStatus.Activated)
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 5;
			case 2:
				if (trialExpiration2.HasValue)
				{
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 10;
			case 14:
				if (trialLicenseInfo != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 10;
			case 10:
				if (!trialExpiration.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 8:
			case 11:
				status = (UUogfVxmwMoGjlNNWJM(DateTime.Now.Date, trialExpiration.Value) ? LicenseStatus.DateExpired : LicenseStatus.Activated);
				num2 = 9;
				break;
			}
		}
	}

	public InternalProcessesServiceStandart()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vmJjI8xlahUcHvLJoVY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object YVcF6OxSNweVikO0IU4(object P_0)
	{
		return ((LicensedUnitBase)P_0).MainProviderType;
	}

	internal static bool sy4uobxkScr5bQUU0Uv(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void nEuoIWxbUqmXNQnlVWN(object P_0, Guid P_1, object P_2)
	{
		((LicensedUnitBase)P_0).Check(P_1, (DecodeActivationKeyAction)P_2);
	}

	internal static bool hpMJJrxdePu7UUHipGn()
	{
		return egukghxN3326DC3NkQ9 == null;
	}

	internal static InternalProcessesServiceStandart zbcUbJxjbZWEjXcV7nS()
	{
		return egukghxN3326DC3NkQ9;
	}

	internal static object sGVUyWxUerHP1lbSRXo(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool UUogfVxmwMoGjlNNWJM(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static LicenseStatus mxtDawxAghqKURYfWeB(object P_0)
	{
		return ((LicenseInfo)P_0).Status;
	}

	internal static ushort CpbUlexpQxphqNKuxfg(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetDbLicenseCount();
	}

	internal static void bE4ZYcxGXjuv0ObhfUy(object P_0, LicenseStatus P_1)
	{
		((LicenseInfo)P_0).Status = P_1;
	}

	internal static object cKtvo6xnFQAYnH3xbnh(ushort algorithm)
	{
		return GenerateRegistrationKey(algorithm);
	}

	internal static void BbXXnPxy7XaJkOrf63T(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object xHr3MAxOgoDiiWP7BGg(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int acA4nZx6BIYcUfSfSAn(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object lTw72nxRo2ZThhmDL7d(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object hGYAcrx0lCL0SReyaZI(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object DHpE8axBand7uZ1NTkx(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object q6HDZNxWVVFoxPQwsSQ()
	{
		return ComponentManager.Current;
	}

	internal static object LOlGcXxHe6lxpLmb2vt(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object ie0pLXxegkmOw1PTFK5(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static LicenseStatus PnaexmxiCB7kpy7Gqrw(object P_0)
	{
		return ((ILicenseInfo)P_0).Status;
	}

	internal static object GW8TTAxu8n0KGqD98Ym(object P_0)
	{
		return ((IModuleManager)P_0).MainApplication;
	}

	internal static void vmJjI8xlahUcHvLJoVY()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
