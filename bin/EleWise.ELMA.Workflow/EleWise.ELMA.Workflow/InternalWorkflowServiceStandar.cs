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

internal class InternalWorkflowServiceStandart : LicensedUnitBase, IInternalWorkflowService, ILicensedUnit, IActivationTokenContainer
{
	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private LicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	internal static InternalWorkflowServiceStandart VH4smWZikIslNDklZpU;

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string)zOWgCVZNNFAFoPFmR2G(0x1145BED7 ^ 0x1145B633));

	public void Run(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_0099, IL_00a8
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				throw new LicenseException();
			default:
				bPA5vVZeC9bLh1IHnbe(this, __ModuleInfo.UID, new DecodeActivationKeyAction(DecodeLastActivationKey));
				num2 = 3;
				break;
			case 1:
				if (!((string)op5xY2Zr68AtmlVYIcK(this) != SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x101D855)))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
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
		//Discarded unreachable code: IL_0085, IL_0094, IL_00c6, IL_00d5, IL_00e5, IL_0128, IL_027e, IL_0288
		int num = 5;
		byte licType = default(byte);
		DateTime? expirationDate = default(DateTime?);
		DateTime? expirationDate2 = default(DateTime?);
		byte licType2 = default(byte);
		LicenseStatus status = default(LicenseStatus);
		ushort licCount = default(ushort);
		byte b = default(byte);
		byte b2 = default(byte);
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
				case 18:
					if (licType == 2)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto IL_0254;
				case 11:
					if (expirationDate.Value > expirationDate2.Value)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_0254;
				default:
					num4 = licType;
					goto IL_02ed;
				case 12:
					if (licType2 != 2)
					{
						num2 = 2;
						continue;
					}
					num3 = 1;
					goto IL_02fa;
				case 6:
				case 20:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 16;
					continue;
				case 14:
					if (b < b2)
					{
						num = 13;
						break;
					}
					if (b <= b2)
					{
						num2 = 8;
						continue;
					}
					return;
				case 22:
					if (licType != 2)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					num4 = 1;
					goto IL_02ed;
				case 10:
					return;
				case 24:
				{
					DecodeActivationKey(lastAppliedActKey, out var _, out licCount2, out licType2, out expirationDate2);
					num2 = 22;
					continue;
				}
				case 19:
					if (!expirationDate2.HasValue)
					{
						num2 = 20;
						continue;
					}
					goto case 11;
				case 21:
					return;
				case 1:
					return;
				case 8:
					if (licType != 1)
					{
						num = 18;
						break;
					}
					goto case 17;
				case 7:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num = 3;
					break;
				case 5:
					InitLicense();
					num2 = 4;
					continue;
				case 4:
					if (DecodeActivationKey(key, out status, out licCount, out licType, out expirationDate))
					{
						num2 = 23;
						continue;
					}
					return;
				case 9:
					return;
				case 23:
					if (lastAppliedActKey != null)
					{
						num2 = 24;
						continue;
					}
					goto case 15;
				case 16:
					return;
				case 2:
					num3 = licType2;
					goto IL_02fa;
				case 13:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 21;
					continue;
				case 3:
					return;
				case 17:
					if (expirationDate.HasValue)
					{
						num2 = 18;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto IL_0254;
				case 15:
					{
						SetLastAppliedKey(key, status, licCount, expirationDate, licType);
						num2 = 10;
						continue;
					}
					IL_0254:
					if (licCount > licCount2)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
					IL_02ed:
					b = (byte)num4;
					num2 = 12;
					continue;
					IL_02fa:
					b2 = (byte)num3;
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
					{
						num2 = 10;
					}
					continue;
				}
				break;
			}
		}
	}

	void ILicensedUnit.CompleteLicensingInitialize()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				initializedStatus = M6wdhNZxLQKgQTtQCwJ(licenseInfo);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				UpdateTrialExpiration();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				InitLicense();
				num2 = 3;
				break;
			case 3:
				licensingInitialized = true;
				num2 = 2;
				break;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		//Discarded unreachable code: IL_0086, IL_0095, IL_0116, IL_0125, IL_018e, IL_019d, IL_01ad
		int num = 13;
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
				case 5:
					if (!workplaceCount.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				case 2:
				case 9:
				case 10:
				case 11:
					return licenseInfo;
				case 8:
					goto end_IL_0012;
				case 12:
					workplaceLicenseInfo = licenseInfo as WorkplaceLicenseInfo;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					if (num3 <= 0)
					{
						num2 = 2;
						continue;
					}
					goto end_IL_0012;
				case 4:
				{
					ushort num4 = num3;
					workplaceCount = workplaceLicenseInfo.WorkplaceCount;
					if (num4 >= workplaceCount.Value)
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				}
				case 3:
				case 6:
					workplaceLicenseInfo.WorkplaceCount = num3;
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
					{
						num2 = 10;
					}
					continue;
				case 13:
					InitLicense();
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 12;
					}
					continue;
				case 1:
					if (workplaceLicenseInfo == null)
					{
						num2 = 10;
						continue;
					}
					break;
				case 7:
					break;
				}
				num3 = Mcyj9ZZS2TjYPtsEWrr(this);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			workplaceCount = workplaceLicenseInfo.WorkplaceCount;
			num = 5;
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
			case 4:
				return;
			case 3:
				UpdateTrialExpiration();
				num2 = 4;
				break;
			case 1:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				mBxcHsZ19qhbApX0TXt(licenseInfo, status);
				num2 = 3;
				break;
			default:
			{
				DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
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
		//Discarded unreachable code: IL_00b5, IL_0166, IL_019e
		int num = 1;
		int num2 = num;
		InternalWorkflowServiceStandart internalWorkflowServiceStandart = default(InternalWorkflowServiceStandart);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (initialized)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 0;
					}
					break;
				}
				internalWorkflowServiceStandart = this;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 4:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			case 2:
				try
				{
					Monitor.Enter(internalWorkflowServiceStandart, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 1:
							if (initialized)
							{
								return;
							}
							num3 = 3;
							break;
						case 3:
							registrationKey = (string)apgRjUZhBUPAxHyEWWo(1);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
							{
								num3 = 0;
							}
							break;
						case 4:
							initialized = true;
							num3 = 2;
							break;
						default:
						{
							LicenseInfo obj = new LicenseInfo(this);
							mBxcHsZ19qhbApX0TXt(obj, LicenseStatus.NotActivated);
							licenseInfo = obj;
							num3 = 4;
							break;
						}
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								LF50hhZEQTsAfgUTgKk(internalWorkflowServiceStandart);
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_0094, IL_0156, IL_0165
		int num = 6;
		int num2 = num;
		string text = default(string);
		uint hnH = default(uint);
		uint hnL = default(uint);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
			case 8:
				if (e8Hvm0Z4EC8N95f2Vdm(text) < 10)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			case 6:
				LicensedUnitBase.GHN(out hnH, out hnL);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 5;
				}
				break;
			case 9:
				text2 = hnL.ToString();
				num2 = 7;
				break;
			case 10:
				text2 = (string)zOWgCVZNNFAFoPFmR2G(0x5BCD23A0 ^ 0x5BCD2A94) + text2;
				num2 = 4;
				break;
			case 5:
				text = hnH.ToString();
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
			case 4:
				if (e8Hvm0Z4EC8N95f2Vdm(text2) >= 10)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 10;
			default:
				return (string)qQ0qOFZzmvIwlsEIwpc(IHC0cmZw8DlMonSFNpE(text, text2));
			case 1:
			case 3:
				text = (string)IHC0cmZw8DlMonSFNpE(zOWgCVZNNFAFoPFmR2G(0x56F860D7 ^ 0x56F869E3), text);
				num2 = 8;
				break;
			}
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_00d9, IL_0165, IL_019e, IL_01ad
		int num = 5;
		int num2 = num;
		int num3 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		char[] array = default(char[]);
		while (true)
		{
			switch (num2)
			{
			default:
				num3++;
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
				{
					num2 = 5;
				}
				break;
			case 12:
				if (num3 % 5 != 0)
				{
					num2 = 3;
					break;
				}
				goto case 8;
			case 2:
			case 3:
			case 7:
				gyA05WvOFpsrOebIyWT(stringBuilder, array[num3]);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				if (num3 <= 0)
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 12;
			case 6:
				return string.Empty;
			case 4:
				stringBuilder = new StringBuilder();
				num2 = 13;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num2 = 13;
				}
				break;
			case 10:
				num3 = 0;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			case 11:
				if (num3 >= array.Length)
				{
					num2 = 14;
					break;
				}
				goto case 9;
			case 8:
				gyA05WvOFpsrOebIyWT(stringBuilder, '-');
				num2 = 2;
				break;
			case 5:
				if (key != null)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 14:
				return stringBuilder.ToString();
			case 13:
				array = (char[])yodPsdvK9fmVDNxrYka(key);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
				{
					num2 = 10;
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
		//Discarded unreachable code: IL_00e6, IL_0130, IL_013f, IL_026c, IL_0289
		int num = 11;
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
				case 9:
				case 16:
					status = LicenseStatus.NotActivated;
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
					{
						num2 = 21;
					}
					continue;
				case 14:
					if (workplaceLicenseInfo != null)
					{
						num2 = 18;
						continue;
					}
					goto case 9;
				case 5:
					licensedUnit = SXp473vvQl0Bl798iuH(YvflUZvZNnZYgwoHeQc(ComponentManager.Current)) as ILicensedUnit;
					num2 = 13;
					continue;
				default:
					if (workplaceLicenseInfo.LicenseType != byte.MaxValue)
					{
						num2 = 9;
						continue;
					}
					goto case 7;
				case 19:
					licCount = num3;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
					{
						num2 = 2;
					}
					continue;
				case 22:
					licCount = 0;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 6;
					}
					continue;
				case 13:
					if (licensedUnit == null)
					{
						num2 = 7;
						continue;
					}
					goto case 8;
				case 3:
					break;
				case 10:
					expirationDate = null;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					num3 = Mcyj9ZZS2TjYPtsEWrr(this);
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					workplaceLicenseInfo = licensedUnit.GetLicenseInfo() as IWorkplaceLicenseInfo;
					num2 = 14;
					continue;
				case 18:
					if (SFg5JmvYZhoCg1Scp3A(workplaceLicenseInfo) != 0)
					{
						num2 = 16;
						continue;
					}
					goto default;
				case 15:
					licType = byte.MaxValue;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return false;
				case 7:
					status = LicenseStatus.Activated;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
				case 12:
				case 17:
					return true;
				case 11:
					InitLicense();
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 2;
					}
					continue;
				case 21:
					if (num3 <= 0)
					{
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 20;
				case 6:
					licType = 0;
					num2 = 4;
					continue;
				case 20:
					if (num3 >= licCount)
					{
						num2 = 12;
						continue;
					}
					goto case 19;
				}
				break;
			}
			licCount = 65000;
			num = 15;
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
		//Discarded unreachable code: IL_004d, IL_00f8, IL_0107
		int num = 9;
		int num2 = num;
		DateTime? trialExpiration = default(DateTime?);
		LicenseStatus status = default(LicenseStatus);
		DateTime? trialExpiration2 = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 4:
				UpdateTrialExpiration(ref trialExpiration, ref status);
				num2 = 7;
				continue;
			case 9:
				if (licenseInfo == null)
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			case 5:
				if (!trialExpiration2.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 10;
			case 10:
				trialExpiration = licenseInfo.TrialExpiration;
				num2 = 2;
				continue;
			case 7:
				licenseInfo.TrialExpiration = trialExpiration;
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
				{
					num2 = 4;
				}
				continue;
			case 8:
				return;
			case 2:
				status = M6wdhNZxLQKgQTtQCwJ(licenseInfo);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 4;
				}
				continue;
			case 6:
				licenseInfo.Status = status;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
				{
					num2 = 3;
				}
				continue;
			case 3:
				return;
			}
			trialExpiration2 = licenseInfo.TrialExpiration;
			num2 = 5;
		}
	}

	private static void UpdateTrialExpiration(ref DateTime? trialExpiration, ref LicenseStatus status)
	{
		//Discarded unreachable code: IL_0087, IL_00c8, IL_01b7
		int num = 9;
		int num2 = num;
		DateTime? trialExpiration2 = default(DateTime?);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		ITrialLicenseInfo trialLicenseInfo = default(ITrialLicenseInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				if (!trialExpiration2.HasValue)
				{
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 12;
			case 3:
				if (licensedUnit != null)
				{
					num2 = 2;
					break;
				}
				goto case 11;
			case 1:
				if (trialLicenseInfo == null)
				{
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 4:
				trialExpiration2 = trialLicenseInfo.TrialExpiration;
				num2 = 7;
				break;
			case 11:
			case 14:
			case 15:
				if (trialExpiration.HasValue)
				{
					num2 = 6;
					break;
				}
				return;
			case 9:
				if (trialExpiration.HasValue)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 6;
					}
					break;
				}
				return;
			case 0:
				return;
			case 10:
				if (status != LicenseStatus.DateExpired)
				{
					return;
				}
				num2 = 13;
				break;
			case 6:
				if (status == LicenseStatus.Activated)
				{
					num2 = 5;
					break;
				}
				goto case 10;
			case 2:
				trialLicenseInfo = oO8xHpvsECvjxt9YjDE(licensedUnit) as ITrialLicenseInfo;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
				{
					num2 = 1;
				}
				break;
			case 12:
				trialExpiration = trialLicenseInfo.TrialExpiration;
				num2 = 11;
				break;
			case 8:
				licensedUnit = SXp473vvQl0Bl798iuH(((ComponentManager)RkL6cuv8keAOZDZWovU()).ModuleManager) as ILicensedUnit;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
			case 13:
				status = (lKtSBvvJ7yID8hRWdj4(DateTime.Now.Date, trialExpiration.Value) ? LicenseStatus.DateExpired : LicenseStatus.Activated);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public InternalWorkflowServiceStandart()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object op5xY2Zr68AtmlVYIcK(object P_0)
	{
		return ((LicensedUnitBase)P_0).MainProviderType;
	}

	internal static void bPA5vVZeC9bLh1IHnbe(object P_0, Guid P_1, object P_2)
	{
		((LicensedUnitBase)P_0).Check(P_1, (DecodeActivationKeyAction)P_2);
	}

	internal static bool Wg2Yw5ZI5BgOtI5HCA9()
	{
		return VH4smWZikIslNDklZpU == null;
	}

	internal static InternalWorkflowServiceStandart ejifcYZa6VBvSEg7f14()
	{
		return VH4smWZikIslNDklZpU;
	}

	internal static object zOWgCVZNNFAFoPFmR2G(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static LicenseStatus M6wdhNZxLQKgQTtQCwJ(object P_0)
	{
		return ((LicenseInfo)P_0).Status;
	}

	internal static ushort Mcyj9ZZS2TjYPtsEWrr(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetDbLicenseCount();
	}

	internal static void mBxcHsZ19qhbApX0TXt(object P_0, LicenseStatus P_1)
	{
		((LicenseInfo)P_0).Status = P_1;
	}

	internal static object apgRjUZhBUPAxHyEWWo(ushort algorithm)
	{
		return GenerateRegistrationKey(algorithm);
	}

	internal static void LF50hhZEQTsAfgUTgKk(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object IHC0cmZw8DlMonSFNpE(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int e8Hvm0Z4EC8N95f2Vdm(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object qQ0qOFZzmvIwlsEIwpc(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object yodPsdvK9fmVDNxrYka(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object gyA05WvOFpsrOebIyWT(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object YvflUZvZNnZYgwoHeQc(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object SXp473vvQl0Bl798iuH(object P_0)
	{
		return ((IModuleManager)P_0).MainApplication;
	}

	internal static LicenseStatus SFg5JmvYZhoCg1Scp3A(object P_0)
	{
		return ((ILicenseInfo)P_0).Status;
	}

	internal static object RkL6cuv8keAOZDZWovU()
	{
		return ComponentManager.Current;
	}

	internal static object oO8xHpvsECvjxt9YjDE(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static bool lKtSBvvJ7yID8hRWdj4(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}
}
