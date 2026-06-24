using System;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow;

internal class InternalWorkflowServiceOracle : LicensedUnitBase, IInternalWorkflowService, ILicensedUnit, IActivationTokenContainer
{
	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private LicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	private static InternalWorkflowServiceOracle gEuO9qZf7BY7cCrxwYR;

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF40051C));

	public void Run(IWorkflowInstance instance)
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
				if (!((string)b1C18oZjRb0MDJ9mHxY(this) != (string)iNSq2HZRC0nSqu00yTu(-801808857 ^ -801810659)))
				{
					kGldnBZ6fdQYAWcRbul(this, __ModuleInfo.UID, new DecodeActivationKeyAction(DecodeLastActivationKey));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 0;
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
			case 1:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
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
		//Discarded unreachable code: IL_0165, IL_01d4, IL_026e, IL_029c
		int num = 7;
		int num2 = num;
		LicenseStatus status = default(LicenseStatus);
		ushort licCount = default(ushort);
		DateTime? expirationDate = default(DateTime?);
		byte licType2 = default(byte);
		ushort licCount2 = default(ushort);
		byte licType = default(byte);
		DateTime? expirationDate2 = default(DateTime?);
		byte b = default(byte);
		byte b2 = default(byte);
		while (true)
		{
			int num4;
			int num3;
			switch (num2)
			{
			case 7:
				InitLicense();
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
				{
					num2 = 5;
				}
				continue;
			case 13:
				SetLastAppliedKey(key, status, licCount, expirationDate, licType2);
				num2 = 20;
				continue;
			case 12:
				return;
			case 10:
			{
				if (lastAppliedActKey == null)
				{
					num2 = 17;
					continue;
				}
				DecodeActivationKey(lastAppliedActKey, out var _, out licCount2, out licType, out expirationDate2);
				num2 = 22;
				continue;
			}
			case 19:
				if (Ub5MkWZqvYPEi5xftfN(expirationDate.Value, expirationDate2.Value))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 16;
			case 9:
				if (b < b2)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (b <= b2)
				{
					if (licType2 != 1)
					{
						num2 = 15;
						continue;
					}
					goto case 2;
				}
				num2 = 11;
				continue;
			case 14:
				if (expirationDate2.HasValue)
				{
					num2 = 19;
					continue;
				}
				goto case 3;
			case 6:
				if (!DecodeActivationKey(key, out status, out licCount, out licType2, out expirationDate))
				{
					return;
				}
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				SetLastAppliedKey(key, status, licCount, expirationDate, licType2);
				num2 = 21;
				continue;
			case 11:
				return;
			case 17:
				SetLastAppliedKey(key, status, licCount, expirationDate, licType2);
				num2 = 8;
				continue;
			default:
				SetLastAppliedKey(key, status, licCount, expirationDate, licType2);
				num2 = 5;
				continue;
			case 1:
				num4 = licType2;
				goto IL_02bb;
			case 8:
				return;
			case 5:
				return;
			case 15:
				if (licType2 == 2)
				{
					num2 = 2;
					continue;
				}
				goto case 16;
			case 2:
				if (!expirationDate.HasValue)
				{
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 12;
					}
					continue;
				}
				goto case 14;
			case 22:
				if (licType2 != 2)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				num4 = 1;
				goto IL_02bb;
			case 18:
				num3 = licType;
				break;
			case 21:
				return;
			case 16:
				if (licCount > licCount2)
				{
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				return;
			case 4:
				if (licType != 2)
				{
					num2 = 18;
					continue;
				}
				num3 = 1;
				break;
			case 20:
				return;
				IL_02bb:
				b = (byte)num4;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
				{
					num2 = 4;
				}
				continue;
			}
			b2 = (byte)num3;
			num2 = 9;
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
			default:
				initializedStatus = ldqAPPZ3iun3hsfr5Ix(licenseInfo);
				num2 = 3;
				break;
			case 3:
				return;
			case 4:
				UpdateTrialExpiration();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				licensingInitialized = true;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_00fb, IL_010a, IL_0163
		int num = 4;
		ushort num3 = default(ushort);
		uint? workplaceCount = default(uint?);
		WorkplaceLicenseInfo workplaceLicenseInfo = default(WorkplaceLicenseInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					num3 = zldf59ZT8983fIuHXoo(this);
					num2 = 6;
					continue;
				case 2:
				{
					ushort num4 = num3;
					workplaceCount = workplaceLicenseInfo.WorkplaceCount;
					if (num4 >= workplaceCount.Value)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 1;
				}
				case 8:
					workplaceCount = workplaceLicenseInfo.WorkplaceCount;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 9;
					}
					continue;
				case 7:
					if (workplaceLicenseInfo != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 3:
					workplaceLicenseInfo = licenseInfo as WorkplaceLicenseInfo;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					if (num3 <= 0)
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 8;
				case 5:
				case 11:
				case 12:
					return licenseInfo;
				case 4:
					InitLicense();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					if (!workplaceCount.HasValue)
					{
						num = 10;
						break;
					}
					goto case 2;
				case 1:
				case 10:
					workplaceLicenseInfo.WorkplaceCount = num3;
					num = 5;
					break;
				}
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
			case 2:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				RBeEigZQ3CEvt9MtsPJ(licenseInfo, status);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
				{
					num2 = 0;
				}
				break;
			default:
				UpdateTrialExpiration();
				num2 = 4;
				break;
			case 1:
			{
				DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 4:
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
		//Discarded unreachable code: IL_0058, IL_00c5, IL_013c, IL_015b, IL_016a, IL_0197, IL_01aa, IL_01b9
		int num = 2;
		int num2 = num;
		InternalWorkflowServiceOracle obj = default(InternalWorkflowServiceOracle);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
						{
							LicenseInfo obj2 = new LicenseInfo(this);
							RBeEigZQ3CEvt9MtsPJ(obj2, LicenseStatus.NotActivated);
							licenseInfo = obj2;
							num3 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
							{
								num3 = 5;
							}
							break;
						}
						default:
							if (initialized)
							{
								num3 = 2;
								break;
							}
							goto case 3;
						case 2:
							return;
						case 3:
							registrationKey = GenerateRegistrationKey(1);
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
							{
								num3 = 1;
							}
							break;
						case 5:
							initialized = true;
							num3 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
							{
								num3 = 0;
							}
							break;
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
						num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num4 = 0;
						}
						goto IL_0140;
					}
					goto IL_0175;
					IL_0175:
					Monitor.Exit(obj);
					num4 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num4 = 2;
					}
					goto IL_0140;
					IL_0140:
					switch (num4)
					{
					case 1:
						goto end_IL_011b;
					case 2:
						goto end_IL_011b;
					}
					goto IL_0175;
					end_IL_011b:;
				}
			case 0:
				return;
			case 1:
				obj = this;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				lockTaken = false;
				num2 = 3;
				break;
			case 2:
				if (initialized)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				return;
			}
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_004d, IL_0097, IL_00a6, IL_0190
		int num = 7;
		int num2 = num;
		string text = default(string);
		uint hnH = default(uint);
		string text2 = default(string);
		uint hnL = default(uint);
		while (true)
		{
			switch (num2)
			{
			case 6:
				text = hnH.ToString();
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
			case 4:
				if (mOrmQhZCoBcgMg8eC1G(text) < 10)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 2:
			case 9:
				text = (string)ijvtmeZpNIamfXc7f50(iNSq2HZRC0nSqu00yTu(0xA7339EE ^ 0xA7330DA), text);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 4;
				}
				break;
			case 8:
				text2 = (string)ijvtmeZpNIamfXc7f50(iNSq2HZRC0nSqu00yTu(0x7AC609FE ^ 0x7AC600CA), text2);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
				{
					num2 = 10;
				}
				break;
			case 5:
				text2 = hnL.ToString();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				LicensedUnitBase.GHN(out hnH, out hnL);
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
			case 10:
				if (text2.Length >= 10)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			default:
				return (string)fHrf1CZMA3o5GKJWsw7(ijvtmeZpNIamfXc7f50(text, text2));
			}
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_0083, IL_009a, IL_00f9, IL_011d, IL_0130, IL_013f
		int num = 13;
		int num2 = num;
		char[] array = default(char[]);
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				array = (char[])GTnkRwZkCHQlvgkN0S5(key);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
				{
					num2 = 5;
				}
				break;
			case 8:
				return stringBuilder.ToString();
			case 14:
				if (num3 % 5 != 0)
				{
					num2 = 11;
					break;
				}
				goto case 6;
			case 1:
				num3++;
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num2 = 9;
				}
				break;
			case 5:
				num3 = 0;
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
				{
					num2 = 7;
				}
				break;
			case 7:
			case 10:
				if (num3 < array.Length)
				{
					num2 = 3;
					break;
				}
				goto case 8;
			case 13:
				if (key != null)
				{
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 4;
			case 3:
			case 9:
				if (num3 <= 0)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 14;
			case 2:
			case 11:
			case 15:
				stringBuilder.Append(array[num3]);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				hy9EW9ZUcY2xHNcnH5M(stringBuilder, '-');
				num2 = 15;
				break;
			case 4:
				return string.Empty;
			case 12:
				stringBuilder = new StringBuilder();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num2 = 0;
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
		//Discarded unreachable code: IL_011a, IL_0236, IL_0245
		int num = 17;
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
				case 12:
					if (num3 > 0)
					{
						num2 = 6;
						continue;
					}
					goto case 8;
				case 15:
					licCount = 0;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					if (workplaceLicenseInfo != null)
					{
						num2 = 3;
						continue;
					}
					goto case 18;
				case 16:
					expirationDate = null;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					InitLicense();
					num2 = 16;
					continue;
				default:
					num3 = zldf59ZT8983fIuHXoo(this);
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 2;
					}
					continue;
				case 9:
					if (licensedUnit == null)
					{
						num2 = 11;
						continue;
					}
					break;
				case 8:
					return true;
				case 1:
					licensedUnit = SAaWVgZA8xP1G5Z2EMj(d53BwiZV54Qpb6BAlKr(ComponentManager.Current)) as ILicensedUnit;
					num2 = 9;
					continue;
				case 5:
					if (tjSAptZGo1b8ZJmWgKq(workplaceLicenseInfo) != byte.MaxValue)
					{
						num2 = 20;
						continue;
					}
					goto case 11;
				case 14:
					licCount = num3;
					num2 = 8;
					continue;
				case 3:
					if (workplaceLicenseInfo.Status != 0)
					{
						num2 = 18;
						continue;
					}
					goto case 5;
				case 19:
					licType = byte.MaxValue;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					return false;
				case 11:
					status = LicenseStatus.Activated;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
					{
						num2 = 2;
					}
					continue;
				case 18:
				case 20:
					status = LicenseStatus.NotActivated;
					num2 = 15;
					continue;
				case 6:
					if (num3 < licCount)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 8;
				case 2:
					goto end_IL_0012;
				case 4:
					licType = 0;
					num2 = 13;
					continue;
				case 7:
					break;
				}
				workplaceLicenseInfo = licensedUnit.GetLicenseInfo() as IWorkplaceLicenseInfo;
				num2 = 10;
				continue;
				end_IL_0012:
				break;
			}
			licCount = 65000;
			num = 19;
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
		int num = 4;
		int num2 = num;
		LicenseStatus status = default(LicenseStatus);
		DateTime? trialExpiration = default(DateTime?);
		DateTime? trialExpiration2 = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (licenseInfo != null)
				{
					num2 = 3;
					break;
				}
				return;
			case 8:
				return;
			case 5:
				RBeEigZQ3CEvt9MtsPJ(licenseInfo, status);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 8;
				}
				break;
			default:
				UpdateTrialExpiration(ref trialExpiration, ref status);
				num2 = 6;
				break;
			case 7:
				status = ldqAPPZ3iun3hsfr5Ix(licenseInfo);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				licenseInfo.TrialExpiration = trialExpiration;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				if (!trialExpiration2.HasValue)
				{
					return;
				}
				num2 = 2;
				break;
			case 3:
				trialExpiration2 = licenseInfo.TrialExpiration;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				trialExpiration = licenseInfo.TrialExpiration;
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private static void UpdateTrialExpiration(ref DateTime? trialExpiration, ref LicenseStatus status)
	{
		//Discarded unreachable code: IL_0139, IL_0148
		int num = 5;
		DateTime? trialExpiration2 = default(DateTime?);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		ITrialLicenseInfo trialLicenseInfo = default(ITrialLicenseInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!trialExpiration.HasValue)
					{
						return;
					}
					goto end_IL_0012;
				case 2:
				case 8:
					if (trialExpiration.HasValue)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					return;
				case 9:
					if (trialExpiration2.HasValue)
					{
						num2 = 10;
						continue;
					}
					goto case 2;
				default:
					if (status == LicenseStatus.DateExpired)
					{
						num2 = 7;
						continue;
					}
					return;
				case 4:
					licensedUnit = SAaWVgZA8xP1G5Z2EMj(d53BwiZV54Qpb6BAlKr(EcC7JFZ7U62QCTlE0d8())) as ILicensedUnit;
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					return;
				case 13:
					if (status != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 10:
					trialExpiration = trialLicenseInfo.TrialExpiration;
					num2 = 2;
					continue;
				case 11:
					if (licensedUnit == null)
					{
						num2 = 8;
						continue;
					}
					goto case 3;
				case 6:
					trialExpiration2 = trialLicenseInfo.TrialExpiration;
					num2 = 9;
					continue;
				case 12:
					if (trialLicenseInfo != null)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 3:
					trialLicenseInfo = lbylKAZ2mMU1CgYcNk1(licensedUnit) as ITrialLicenseInfo;
					num2 = 12;
					continue;
				case 7:
					break;
				}
				status = (Ub5MkWZqvYPEi5xftfN(t0VfqaZo9YYst6LcQwj().Date, trialExpiration.Value) ? LicenseStatus.DateExpired : LicenseStatus.Activated);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public InternalWorkflowServiceOracle()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MkGcCpZFXM94l6BJWV7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object b1C18oZjRb0MDJ9mHxY(object P_0)
	{
		return ((LicensedUnitBase)P_0).MainProviderType;
	}

	internal static object iNSq2HZRC0nSqu00yTu(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void kGldnBZ6fdQYAWcRbul(object P_0, Guid P_1, object P_2)
	{
		((LicensedUnitBase)P_0).Check(P_1, (DecodeActivationKeyAction)P_2);
	}

	internal static bool tWZfVTZ9YK6Xa1qyq2r()
	{
		return gEuO9qZf7BY7cCrxwYR == null;
	}

	internal static InternalWorkflowServiceOracle cMCW5nZWVPR0OB1WAUs()
	{
		return gEuO9qZf7BY7cCrxwYR;
	}

	internal static bool Ub5MkWZqvYPEi5xftfN(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static LicenseStatus ldqAPPZ3iun3hsfr5Ix(object P_0)
	{
		return ((LicenseInfo)P_0).Status;
	}

	internal static ushort zldf59ZT8983fIuHXoo(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetDbLicenseCount();
	}

	internal static void RBeEigZQ3CEvt9MtsPJ(object P_0, LicenseStatus P_1)
	{
		((LicenseInfo)P_0).Status = P_1;
	}

	internal static object ijvtmeZpNIamfXc7f50(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int mOrmQhZCoBcgMg8eC1G(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object fHrf1CZMA3o5GKJWsw7(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object GTnkRwZkCHQlvgkN0S5(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object hy9EW9ZUcY2xHNcnH5M(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object d53BwiZV54Qpb6BAlKr(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object SAaWVgZA8xP1G5Z2EMj(object P_0)
	{
		return ((IModuleManager)P_0).MainApplication;
	}

	internal static byte tjSAptZGo1b8ZJmWgKq(object P_0)
	{
		return ((ILicenseInfo)P_0).LicenseType;
	}

	internal static object EcC7JFZ7U62QCTlE0d8()
	{
		return ComponentManager.Current;
	}

	internal static object lbylKAZ2mMU1CgYcNk1(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static DateTime t0VfqaZo9YYst6LcQwj()
	{
		return DateTime.Now;
	}

	internal static void MkGcCpZFXM94l6BJWV7()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
