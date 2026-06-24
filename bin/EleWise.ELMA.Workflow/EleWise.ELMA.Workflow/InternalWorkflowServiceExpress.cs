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

internal class InternalWorkflowServiceExpress : LicensedUnitBase, IInternalWorkflowService, ILicensedUnit, IActivationTokenContainer
{
	private bool initialized;

	private bool licensingInitialized;

	private string lastAppliedActKey;

	private string registrationKey;

	private LicenseInfo licenseInfo;

	private LicenseStatus initializedStatus;

	internal static InternalWorkflowServiceExpress UckaMNZvd0MvbuU16uQ;

	Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string)w8blSIZsPo1Qcn69nEE(-539998957 ^ -539996681));

	public void Run(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_00a3
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				if (!JDnTDoZJxQahGByjlNo(MainProviderType, w8blSIZsPo1Qcn69nEE(0x6871CA ^ 0x687976)))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				throw new LicenseException();
			default:
				Check(__ModuleInfo.UID, DecodeLastActivationKey);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
				{
					num2 = 2;
				}
				break;
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
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
		//Discarded unreachable code: IL_00d3, IL_0102, IL_01f9, IL_0208, IL_025a, IL_0280, IL_02a5, IL_02ed
		int num = 2;
		byte licType = default(byte);
		byte licType2 = default(byte);
		LicenseStatus status = default(LicenseStatus);
		ushort licCount = default(ushort);
		DateTime? expirationDate = default(DateTime?);
		DateTime? expirationDate2 = default(DateTime?);
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
				case 14:
					if (licType != 2)
					{
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
						{
							num2 = 8;
						}
						continue;
					}
					num4 = 1;
					goto IL_030c;
				case 7:
					return;
				case 6:
					return;
				case 20:
					if (licType2 != 2)
					{
						num2 = 10;
						continue;
					}
					num3 = 1;
					goto IL_0319;
				case 2:
					InitLicense();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (DecodeActivationKey(key, out status, out licCount, out licType, out expirationDate))
					{
						num2 = 9;
						continue;
					}
					return;
				case 25:
					if (!expirationDate2.HasValue)
					{
						num = 3;
						break;
					}
					goto default;
				case 3:
				case 23:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 12;
					}
					continue;
				case 24:
					return;
				case 12:
					if (licType != 1)
					{
						num2 = 19;
						continue;
					}
					goto case 4;
				default:
					if (!(expirationDate.Value > expirationDate2.Value))
					{
						num2 = 13;
						continue;
					}
					goto case 3;
				case 11:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
					{
						num2 = 5;
					}
					continue;
				case 15:
					SetLastAppliedKey(key, status, licCount, expirationDate, licType);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					return;
				case 16:
				{
					DecodeActivationKey(lastAppliedActKey, out var _, out licCount2, out licType2, out expirationDate2);
					num2 = 14;
					continue;
				}
				case 19:
					if (licType == 2)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 13;
				case 22:
					if (b >= b2)
					{
						if (b <= b2)
						{
							num2 = 12;
							continue;
						}
						return;
					}
					num = 15;
					break;
				case 21:
					return;
				case 13:
					if (licCount <= licCount2)
					{
						return;
					}
					num2 = 8;
					continue;
				case 17:
					num4 = licType;
					goto IL_030c;
				case 4:
					if (expirationDate.HasValue)
					{
						num2 = 25;
						continue;
					}
					goto case 13;
				case 18:
					return;
				case 9:
					if (lastAppliedActKey != null)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 11;
				case 10:
					num3 = licType2;
					goto IL_0319;
				case 8:
					{
						SetLastAppliedKey(key, status, licCount, expirationDate, licType);
						num2 = 7;
						continue;
					}
					IL_0319:
					b2 = (byte)num3;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
					{
						num2 = 22;
					}
					continue;
					IL_030c:
					b = (byte)num4;
					num2 = 20;
					continue;
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				UpdateTrialExpiration();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				initializedStatus = yG9p7PZl5OZgSWNtAb9(licenseInfo);
				num2 = 4;
				break;
			case 4:
				return;
			}
		}
	}

	ILicenseInfo ILicensedUnit.GetLicenseInfo()
	{
		//Discarded unreachable code: IL_0071, IL_0163, IL_0172
		int num = 8;
		int num2 = num;
		uint? workplaceCount = default(uint?);
		WorkplaceLicenseInfo workplaceLicenseInfo = default(WorkplaceLicenseInfo);
		ushort num3 = default(ushort);
		while (true)
		{
			switch (num2)
			{
			case 8:
				InitLicense();
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				if (!workplaceCount.HasValue)
				{
					num2 = 2;
					break;
				}
				goto case 3;
			case 7:
				workplaceLicenseInfo = licenseInfo as WorkplaceLicenseInfo;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
			case 11:
				workplaceLicenseInfo.WorkplaceCount = num3;
				num2 = 6;
				break;
			default:
				return licenseInfo;
			case 1:
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				if (workplaceLicenseInfo == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 10;
			case 3:
			{
				ushort num4 = num3;
				workplaceCount = workplaceLicenseInfo.WorkplaceCount;
				if (num4 < workplaceCount.Value)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto default;
			}
			case 10:
				num3 = wdkKSyZ0lEZayTyDuZn(this);
				num2 = 9;
				break;
			case 9:
				if (num3 > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
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
			default:
			{
				DecodeActivationKey(lastAppliedActKey, out status, out var _, out var _, out var _);
				num2 = 4;
				break;
			}
			case 3:
				UpdateTrialExpiration();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				InitLicense();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				jbihUCZy90fpwFugNGa(licenseInfo, status);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 3;
				}
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
		//Discarded unreachable code: IL_007b, IL_008a, IL_00d8, IL_0189, IL_01b9, IL_01c8, IL_01d4
		int num = 5;
		int num2 = num;
		bool lockTaken = default(bool);
		InternalWorkflowServiceExpress obj = default(InternalWorkflowServiceExpress);
		while (true)
		{
			switch (num2)
			{
			default:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (!initialized)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				return;
			case 4:
				obj = this;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 1:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 4:
							return;
						case 3:
							registrationKey = (string)FXsiFMZmna6NyA8XymK(1);
							num3 = 2;
							break;
						case 1:
							if (initialized)
							{
								return;
							}
							num3 = 3;
							break;
						case 2:
							licenseInfo = new LicenseInfo(this)
							{
								Status = LicenseStatus.NotActivated
							};
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
							{
								num3 = 0;
							}
							break;
						default:
							initialized = true;
							num3 = 4;
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
						{
							num4 = 0;
						}
						goto IL_018d;
					}
					goto IL_01a3;
					IL_01a3:
					Monitor.Exit(obj);
					num4 = 2;
					goto IL_018d;
					IL_018d:
					switch (num4)
					{
					default:
						goto end_IL_0168;
					case 1:
						break;
					case 0:
						goto end_IL_0168;
					case 2:
						goto end_IL_0168;
					}
					goto IL_01a3;
					end_IL_0168:;
				}
			}
		}
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		//Discarded unreachable code: IL_0087, IL_0096, IL_00b5, IL_00c4, IL_0165
		int num = 6;
		uint hnH = default(uint);
		uint hnL = default(uint);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					LicensedUnitBase.GHN(out hnH, out hnL);
					num2 = 5;
					continue;
				case 1:
					return (string)h9yiAMZ5SQK3daMjeLN(WIXQFiZbdYV5BiUB6DS(text, text2));
				case 5:
					text = hnH.ToString();
					num2 = 8;
					continue;
				case 8:
					text2 = hnL.ToString();
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					text = (string)w8blSIZsPo1Qcn69nEE(0x361628FF ^ 0x361621CB) + text;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
					{
						num2 = 2;
					}
					continue;
				case 9:
				case 10:
					if (F9hKI7ZtOGrsA40JY9f(text2) < 10)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 2:
				case 4:
					if (F9hKI7ZtOGrsA40JY9f(text) >= 10)
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				}
				break;
			}
			text2 = (string)WIXQFiZbdYV5BiUB6DS(w8blSIZsPo1Qcn69nEE(-947937941 ^ -947940257), text2);
			num = 10;
		}
	}

	private static string FormatKey(object key)
	{
		//Discarded unreachable code: IL_00bf, IL_00ce
		int num = 10;
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
				case 10:
					if (key == null)
					{
						num2 = 9;
						continue;
					}
					stringBuilder = new StringBuilder();
					num2 = 7;
					continue;
				case 9:
					return string.Empty;
				case 3:
					stringBuilder.Append(array[num3]);
					num2 = 4;
					continue;
				case 5:
					return stringBuilder.ToString();
				case 1:
					if (num3 % 5 == 0)
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 6:
				case 8:
					if (num3 >= array.Length)
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 4:
					num3++;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num2 = 8;
					}
					continue;
				case 2:
					HEeSZrZBc9mrvU3CFSi(stringBuilder, '-');
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					break;
				case 11:
					num3 = 0;
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 3;
					}
					continue;
				default:
					if (num3 > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				}
				break;
			}
			array = (char[])TgkqqMZgasvHWGgTxZN(key);
			num = 11;
		}
	}

	private bool DecodeLastActivationKey(out LicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate)
	{
		return DecodeActivationKey(lastAppliedActKey, out status, out licCount, out licType, out expirationDate);
	}

	private bool DecodeActivationKey(string key, out LicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate)
	{
		//Discarded unreachable code: IL_00a0, IL_00af, IL_01bc, IL_022b, IL_023a, IL_0260
		int num = 12;
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
				case 6:
					if (num3 >= licCount)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 18;
				case 9:
					goto end_IL_0012;
				case 17:
					if (workplaceLicenseInfo != null)
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 11:
					expirationDate = null;
					num2 = 9;
					continue;
				case 1:
					licCount = 0;
					num2 = 14;
					continue;
				case 18:
					licCount = num3;
					num2 = 19;
					continue;
				case 3:
					if (licensedUnit == null)
					{
						num2 = 8;
						continue;
					}
					break;
				case 2:
					return false;
				case 8:
					status = LicenseStatus.Activated;
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
					{
						num2 = 18;
					}
					continue;
				case 21:
					num3 = wdkKSyZ0lEZayTyDuZn(this);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 4;
					}
					continue;
				case 14:
					licType = 0;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num2 = 2;
					}
					continue;
				case 13:
					if (g9iXdVZDpU8764fPWng(workplaceLicenseInfo) != byte.MaxValue)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 7:
					if (num3 <= 0)
					{
						num2 = 10;
						continue;
					}
					goto case 6;
				case 12:
					InitLicense();
					num2 = 11;
					continue;
				default:
					status = LicenseStatus.NotActivated;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 1;
					}
					continue;
				case 22:
					licCount = 65000;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					if (njwmefZujyWRVfW4mjf(workplaceLicenseInfo) != 0)
					{
						num2 = 20;
						continue;
					}
					goto case 13;
				case 4:
					licType = byte.MaxValue;
					num2 = 21;
					continue;
				case 10:
				case 16:
				case 19:
					return true;
				case 15:
					break;
				}
				workplaceLicenseInfo = gyTRw4ZdL28EdPrADY0(licensedUnit) as IWorkplaceLicenseInfo;
				num2 = 17;
				continue;
				end_IL_0012:
				break;
			}
			licensedUnit = djikVeZXOqsbmRXKERf(PdNnyhZPayIn2gUY9xD(billunZcv8ypDwWcfQe())) as ILicensedUnit;
			num = 3;
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
		int num = 7;
		DateTime? trialExpiration2 = default(DateTime?);
		LicenseStatus status = default(LicenseStatus);
		DateTime? trialExpiration = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					licenseInfo.TrialExpiration = trialExpiration2;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					licenseInfo.Status = status;
					num = 4;
					break;
				case 8:
					if (trialExpiration.HasValue)
					{
						num2 = 2;
						continue;
					}
					return;
				case 3:
					UpdateTrialExpiration(ref trialExpiration2, ref status);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					trialExpiration2 = licenseInfo.TrialExpiration;
					num2 = 5;
					continue;
				case 7:
					if (licenseInfo != null)
					{
						num = 6;
						break;
					}
					return;
				case 5:
					status = yG9p7PZl5OZgSWNtAb9(licenseInfo);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					return;
				case 6:
					trialExpiration = licenseInfo.TrialExpiration;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	private static void UpdateTrialExpiration(ref DateTime? trialExpiration, ref LicenseStatus status)
	{
		//Discarded unreachable code: IL_00cf, IL_0129, IL_0138, IL_015e
		int num = 10;
		DateTime? trialExpiration2 = default(DateTime?);
		ITrialLicenseInfo trialLicenseInfo = default(ITrialLicenseInfo);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					trialExpiration2 = trialLicenseInfo.TrialExpiration;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (status == LicenseStatus.DateExpired)
					{
						num = 14;
						break;
					}
					return;
				case 16:
					licensedUnit = djikVeZXOqsbmRXKERf(PdNnyhZPayIn2gUY9xD(billunZcv8ypDwWcfQe())) as ILicensedUnit;
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 6;
					}
					continue;
				case 9:
					return;
				case 15:
					return;
				case 1:
				case 5:
				case 7:
					if (!trialExpiration.HasValue)
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (!trialExpiration2.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 4:
					trialExpiration = trialLicenseInfo.TrialExpiration;
					num2 = 7;
					continue;
				case 2:
					if (trialLicenseInfo == null)
					{
						num = 5;
						break;
					}
					goto case 13;
				case 10:
					if (!trialExpiration.HasValue)
					{
						num2 = 9;
						continue;
					}
					goto case 16;
				case 8:
					trialLicenseInfo = gyTRw4ZdL28EdPrADY0(licensedUnit) as ITrialLicenseInfo;
					num2 = 2;
					continue;
				case 6:
					if (licensedUnit != null)
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				case 3:
					if (status == LicenseStatus.Activated)
					{
						num2 = 12;
						continue;
					}
					goto case 11;
				case 12:
				case 14:
					status = (MjXKZpZH768FN52i94f(NvH6XeZnZjh1qlb8F63().Date, trialExpiration.Value) ? LicenseStatus.DateExpired : LicenseStatus.Activated);
					num = 15;
					break;
				}
				break;
			}
		}
	}

	public InternalWorkflowServiceExpress()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AhZ8TsZLTUTdwC9OMNo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object w8blSIZsPo1Qcn69nEE(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool JDnTDoZJxQahGByjlNo(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool bTT63KZYjUAOJijDufH()
	{
		return UckaMNZvd0MvbuU16uQ == null;
	}

	internal static InternalWorkflowServiceExpress YwATtsZ8vBWL2eXaW3y()
	{
		return UckaMNZvd0MvbuU16uQ;
	}

	internal static LicenseStatus yG9p7PZl5OZgSWNtAb9(object P_0)
	{
		return ((LicenseInfo)P_0).Status;
	}

	internal static ushort wdkKSyZ0lEZayTyDuZn(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetDbLicenseCount();
	}

	internal static void jbihUCZy90fpwFugNGa(object P_0, LicenseStatus P_1)
	{
		((LicenseInfo)P_0).Status = P_1;
	}

	internal static object FXsiFMZmna6NyA8XymK(ushort algorithm)
	{
		return GenerateRegistrationKey(algorithm);
	}

	internal static int F9hKI7ZtOGrsA40JY9f(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object WIXQFiZbdYV5BiUB6DS(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object h9yiAMZ5SQK3daMjeLN(object P_0)
	{
		return FormatKey(P_0);
	}

	internal static object TgkqqMZgasvHWGgTxZN(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object HEeSZrZBc9mrvU3CFSi(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object billunZcv8ypDwWcfQe()
	{
		return ComponentManager.Current;
	}

	internal static object PdNnyhZPayIn2gUY9xD(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object djikVeZXOqsbmRXKERf(object P_0)
	{
		return ((IModuleManager)P_0).MainApplication;
	}

	internal static object gyTRw4ZdL28EdPrADY0(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static LicenseStatus njwmefZujyWRVfW4mjf(object P_0)
	{
		return ((ILicenseInfo)P_0).Status;
	}

	internal static byte g9iXdVZDpU8764fPWng(object P_0)
	{
		return ((ILicenseInfo)P_0).LicenseType;
	}

	internal static DateTime NvH6XeZnZjh1qlb8F63()
	{
		return DateTime.Now;
	}

	internal static bool MjXKZpZH768FN52i94f(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static void AhZ8TsZLTUTdwC9OMNo()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
