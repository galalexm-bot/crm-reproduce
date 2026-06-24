using System;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Modules.Impl;

public abstract class LicensedUnitBase : ILicensedUnitComponentInfo
{
	protected delegate bool DecodeActivationKeyAction(out LicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate);

	protected delegate bool DecodeConcurrentActivationKeyAction(out LicenseStatus status, out ushort licCount, out ushort privilegeCount, out byte licType, out byte licSubType, out DateTime? expirationDate);

	public static class Providers
	{
		[Obsolete("Провайдер Firebird больше не поддерживается", true)]
		public const string Firebird = "FirebirdProvider";

		public const string MSSQL = "MSSQLProvider";

		public const string Oracle = "OracleProvider";

		public const string PostgreSQL = "PostgreSQLProvider";

		internal static Providers fcZGQSfMxjCIeBOYkwt4;

		public static string GetVersionName(string providerName)
		{
			return GetVersionName(gBr9GpfMyUqQrYa7hjBL(providerName));
		}

		public static string GetVersionName(ElmaEdition edition, string providerType)
		{
			//Discarded unreachable code: IL_006b, IL_0075, IL_009a, IL_0122, IL_012c, IL_01b9, IL_01c8
			int num = 3;
			int num2 = num;
			string text2 = default(string);
			string text = default(string);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 12:
					obj = XSmNJQfMMRJ6EekZZqwN(-889460160 ^ -889287330);
					break;
				case 6:
					obj = XSmNJQfMMRJ6EekZZqwN(-629844702 ^ -630181356);
					break;
				case 4:
					if (text2 == null)
					{
						num2 = 5;
						continue;
					}
					goto case 9;
				case 9:
					text = (string)PiJrAkfM9AURjQoUVppx(text, XSmNJQfMMRJ6EekZZqwN(0x53CACA3 ^ 0x53CCB89), text2, XSmNJQfMMRJ6EekZZqwN(0x3630F361 ^ 0x3630ECDD));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (edition != ElmaEdition.Standart)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 7;
				default:
					obj = null;
					break;
				case 10:
					if (IinN0afMJJTytAsKY1gZ(providerType, XSmNJQfMMRJ6EekZZqwN(-35995181 ^ -35998889)))
					{
						num2 = 12;
						continue;
					}
					goto default;
				case 7:
					if (!IinN0afMJJTytAsKY1gZ(providerType, XSmNJQfMMRJ6EekZZqwN(0x68BBB53E ^ 0x68BBC792)))
					{
						num2 = 11;
						continue;
					}
					obj = XSmNJQfMMRJ6EekZZqwN(0x103FE975 ^ 0x103A8E33);
					break;
				case 1:
				case 5:
					return text;
				case 11:
					if (IinN0afMJJTytAsKY1gZ(providerType, XSmNJQfMMRJ6EekZZqwN(0x8317432 ^ 0x835E5CE)))
					{
						num2 = 6;
						continue;
					}
					goto case 10;
				case 8:
					if (edition == ElmaEdition.Enterprise)
					{
						num2 = 7;
						continue;
					}
					goto case 1;
				case 3:
					text = GetVersionName(edition);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 1;
					}
					continue;
				}
				text2 = (string)obj;
				num2 = 4;
			}
		}

		public static string GetVersionName(ElmaEdition edition)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (string)kfEkWufMd3MnyCHTGd2s(XSmNJQfMMRJ6EekZZqwN(-70007027 ^ -69820311));
				case 1:
					return string.Empty;
				case 2:
					{
						switch (edition)
						{
						case ElmaEdition.Express:
							break;
						case ElmaEdition.Standart:
							return (string)kfEkWufMd3MnyCHTGd2s(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939728908));
						case ElmaEdition.Enterprise:
							return (string)kfEkWufMd3MnyCHTGd2s(XSmNJQfMMRJ6EekZZqwN(0x2ACE37D ^ 0x2A984F1));
						case ElmaEdition.CE:
							return (string)kfEkWufMd3MnyCHTGd2s(XSmNJQfMMRJ6EekZZqwN(-16752921 ^ -16434867));
						default:
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num2 = 1;
							}
							goto end_IL_0012;
						}
						goto default;
					}
					end_IL_0012:
					break;
				}
			}
		}

		public static ElmaEdition GetEdition(string providerName)
		{
			return ElmaEdition.CE;
		}

		internal static ElmaEdition gBr9GpfMyUqQrYa7hjBL(object P_0)
		{
			return GetEdition((string)P_0);
		}

		internal static bool oyS9bJfM0bCWkdcB1Kj0()
		{
			return fcZGQSfMxjCIeBOYkwt4 == null;
		}

		internal static Providers xVrfGWfMmB20lc0fdRP6()
		{
			return fcZGQSfMxjCIeBOYkwt4;
		}

		internal static object XSmNJQfMMRJ6EekZZqwN(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool IinN0afMJJTytAsKY1gZ(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static object PiJrAkfM9AURjQoUVppx(object P_0, object P_1, object P_2, object P_3)
		{
			return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
		}

		internal static object kfEkWufMd3MnyCHTGd2s(object P_0)
		{
			return SR.T((string)P_0);
		}
	}

	protected static bool _hnLoaded;

	protected static uint _hnH;

	protected static uint _hnL;

	private static LicensedUnitBase WuoIfyN3CtpRVE9K6dw;

	protected virtual string MainProviderType
	{
		get
		{
			//Discarded unreachable code: IL_0056, IL_0065, IL_00bf, IL_00d3
			int num = 2;
			int num2 = num;
			IRuntimeApplication runtimeApplication2 = default(IRuntimeApplication);
			while (true)
			{
				IRuntimeApplication runtimeApplication;
				switch (num2)
				{
				default:
					if (ATnyavN4yWoXbo1doZB(orDWfdNwxu3Yguyniv1()) != 0)
					{
						num2 = 3;
						break;
					}
					goto case 4;
				case 2:
					if (((ComponentManager)orDWfdNwxu3Yguyniv1()).Stage == ComponentManager.LifetimeStage.BeforeInit)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 5;
				case 6:
					if (runtimeApplication2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return (string)tLtYOINH7HrZybWrMGQ((runtimeApplication2.MainProvider ?? throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487391910))).GetType());
				case 5:
					runtimeApplication = Locator.GetServiceNotNull<IRuntimeApplication>();
					goto IL_00e7;
				case 1:
					runtimeApplication = ((ComponentManager)orDWfdNwxu3Yguyniv1()).GetComponentsForRegister<IRuntimeApplication>().FirstOrDefault();
					goto IL_00e7;
				case 4:
					return string.Empty;
				case 3:
					{
						throw new InvalidOperationException((string)L9kpquN6KmV92DQ2EXV(-138018305 ^ -137989381));
					}
					IL_00e7:
					runtimeApplication2 = runtimeApplication;
					num2 = 6;
					break;
				}
			}
		}
	}

	protected void Check(Guid moduleUid, DecodeConcurrentActivationKeyAction decodeAction)
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
			{
				Check(moduleUid, decodeAction, out var _, out var _, out var _);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	protected void Check(Guid moduleUid, DecodeConcurrentActivationKeyAction decodeAction, out byte licSubType, out ushort licCount, out ushort privilegeCount)
	{
		//Discarded unreachable code: IL_0072, IL_0081, IL_0091
		int num = 7;
		LicenseStatus status = default(LicenseStatus);
		DateTime dateTime = default(DateTime);
		DateTime? expirationDate = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					throw new LicenseActivationRequiredException(moduleUid);
				case 3:
					if (status != LicenseStatus.DateExpired)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 9:
					if (status != LicenseStatus.DateExpired)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				case 2:
					throw new LicenseExpiredException(moduleUid);
				case 5:
				{
					DateTime date = dateTime.Date;
					dateTime = expirationDate.Value;
					if (!XUMJtSNtCHdHT3rD6Vn(date, dateTime.Date))
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 2;
					}
					break;
				}
				case 8:
					dateTime = q7jo73NDHrgcA0B2qFf();
					num2 = 5;
					break;
				default:
					if (!expirationDate.HasValue)
					{
						return;
					}
					num2 = 8;
					break;
				case 4:
					throw new LicenseActivationRequiredException(moduleUid);
				case 6:
					if (status == LicenseStatus.Activated)
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 7:
				{
					if (decodeAction(out status, out licCount, out privilegeCount, out var _, out licSubType, out expirationDate))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 4;
				}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	protected void Check(Guid moduleUid, DecodeActivationKeyAction decodeAction)
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
			{
				Check(moduleUid, decodeAction, out var _);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	protected void Check(Guid moduleUid, DecodeActivationKeyAction decodeAction, out ushort licCount)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_00ef, IL_00fe, IL_0120
		int num = 5;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		LicenseStatus status = default(LicenseStatus);
		DateTime? expirationDate = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			default:
				throw new LicenseExpiredException(moduleUid);
			case 3:
				return;
			case 8:
				return;
			case 10:
				dateTime = DateTime.Now;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 6;
				}
				break;
			case 5:
			{
				if (!decodeAction(out status, out licCount, out var _, out expirationDate))
				{
					num2 = 4;
					break;
				}
				if (status == LicenseStatus.Activated)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 9;
			}
			case 2:
				if (!expirationDate.HasValue)
				{
					num2 = 8;
					break;
				}
				goto case 10;
			case 4:
				throw new LicenseActivationRequiredException(moduleUid);
			case 9:
				if (status != LicenseStatus.DateExpired)
				{
					num2 = 7;
					break;
				}
				goto case 1;
			case 6:
			{
				DateTime date = dateTime.Date;
				dateTime = expirationDate.Value;
				if (!XUMJtSNtCHdHT3rD6Vn(date, dateTime.Date))
				{
					num2 = 3;
					break;
				}
				goto default;
			}
			case 7:
				throw new LicenseActivationRequiredException(moduleUid);
			case 1:
				if (status != LicenseStatus.DateExpired)
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	protected virtual ushort GetDbLicenseCount()
	{
		return 0;
	}

	protected static void GHN(out uint hnH, out uint hnL)
	{
		//Discarded unreachable code: IL_009c, IL_01a8, IL_029b
		int num = 14;
		int num2 = num;
		ManagementObjectCollection.ManagementObjectEnumerator enumerator = default(ManagementObjectCollection.ManagementObjectEnumerator);
		object obj = default(object);
		object obj2 = default(object);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 16:
				return;
			case 7:
				try
				{
					ManagementObjectCollection managementObjectCollection = (ManagementObjectCollection)bbmRZdNARTtOqxRp8wR(new ManagementObjectSearcher((string)L9kpquN6KmV92DQ2EXV(-1822890472 ^ -1822911120)));
					int num3 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							if (g68FiUNxu1OvvG4m6Rx(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						case 2:
							enumerator = managementObjectCollection.GetEnumerator();
							num3 = 5;
							continue;
						case 3:
							obj = T18eavNmwfwgM15r3Cr(oFhTfPN0DeTmsCLPUXx(enumerator), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3D9CBE));
							num3 = 4;
							continue;
						case 6:
							if (managementObjectCollection != null)
							{
								num3 = 2;
								continue;
							}
							break;
						case 5:
							whkQ3qN7yXlE0XHiJXK(enumerator);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num3 = 1;
							}
							continue;
						default:
							obj2 = T18eavNmwfwgM15r3Cr(oFhTfPN0DeTmsCLPUXx(enumerator), L9kpquN6KmV92DQ2EXV(-1108654032 ^ -1108657258));
							num3 = 3;
							continue;
						case 4:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new InvalidOperationException((string)UxWtiFNy9FomjGd560K(L9kpquN6KmV92DQ2EXV(-1146510045 ^ -1146497297)) + (string)((!TiKLvjNJ70BChdlMgcR(vDqiUoNMmpa65C3YW5R(ex))) ? O3Z24aNdiKGEvr3IF4n(XMvcDxN9Le0HRhNH4pu(), SR.T((string)L9kpquN6KmV92DQ2EXV(-1146510045 ^ -1146498613), ex.Message)) : string.Empty) + ((ex is COMException) ? (Environment.NewLine + SR.T((string)L9kpquN6KmV92DQ2EXV(-1108654032 ^ -1108656864), string.Format((string)L9kpquN6KmV92DQ2EXV(-576149596 ^ -576138608), cwJ0KtNlhFIGW55beEY((COMException)ex)))) : string.Empty), ex);
					}
				}
				goto case 11;
			case 13:
				hnH = _hnH;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				hnL = _hnL;
				num2 = 6;
				break;
			case 1:
				_hnH = hnH;
				num2 = 4;
				break;
			case 11:
				hnL = 2345106789u;
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 17;
				}
				break;
			case 4:
				_hnL = hnL;
				num2 = 10;
				break;
			case 12:
				hnH = 1234098765u;
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 9;
				}
				break;
			default:
				hnL = iF6aEWN5ncwZL2hPQhk(array, 0);
				num2 = 12;
				break;
			case 5:
				hnH = iF6aEWN5ncwZL2hPQhk(array2, 0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 15:
				if (obj != null)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 14:
				if (_hnLoaded)
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 10;
					}
					break;
				}
				obj2 = null;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 8;
				}
				break;
			case 9:
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider2 = new MD5CryptoServiceProvider();
				byte[] array3 = (byte[])jEsnCONrt1CLBnF6sYj(Encoding.UTF8, obj2.ToString());
				array = (byte[])bQP8B3Ngt5TrdbdWcIH(mD5CryptoServiceProvider2, array3);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 6:
				return;
			case 3:
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				byte[] buffer = (byte[])jEsnCONrt1CLBnF6sYj(TBE1EBNjchdxMEiMOgc(), obj.ToString());
				array2 = mD5CryptoServiceProvider.ComputeHash(buffer);
				num2 = 5;
				break;
			}
			case 17:
				if (obj2 != null)
				{
					num2 = 9;
					break;
				}
				goto case 12;
			case 8:
				obj = null;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 7;
				}
				break;
			case 10:
				_hnLoaded = true;
				num2 = 16;
				break;
			}
		}
	}

	string ILicensedUnitComponentInfo.GetComponentId()
	{
		return (string)yFALilNYrhJ61i3BxUi(this);
	}

	string ILicensedUnitComponentInfo.GetComponentVersion()
	{
		return (string)rQxHsANLATW3vYMhHVk(this);
	}

	protected virtual string GetComponentId()
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		int num2 = num;
		ModuleAttribute attribute = default(ModuleAttribute);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 3:
				return (string)wTt8krNUDdTDP5AUrIZ(attribute);
			default:
				if (attribute != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 1:
				attribute = AttributeHelper<ModuleAttribute>.GetAttribute(GetType().Assembly);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual string GetComponentVersion()
	{
		//Discarded unreachable code: IL_003b, IL_004a
		int num = 1;
		int num2 = num;
		Version version = default(Version);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 3:
				return version.ToString();
			case 1:
				version = VersionInfo.GetVersion(WR5hV2NsmEM9dhgJYfP(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (qKUIU5NcMN4OIN1g5a3(version, null))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	protected LicensedUnitBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MvZf4UNz5ct352fkwLZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Ag1StaNpJsLpOYTpVE9()
	{
		return WuoIfyN3CtpRVE9K6dw == null;
	}

	internal static LicensedUnitBase WjPu5FNa4f0Jcd8yuwP()
	{
		return WuoIfyN3CtpRVE9K6dw;
	}

	internal static DateTime q7jo73NDHrgcA0B2qFf()
	{
		return DateTime.Now;
	}

	internal static bool XUMJtSNtCHdHT3rD6Vn(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static object orDWfdNwxu3Yguyniv1()
	{
		return ComponentManager.Current;
	}

	internal static ComponentType ATnyavN4yWoXbo1doZB(object P_0)
	{
		return ((ComponentManager)P_0).ComponentType;
	}

	internal static object L9kpquN6KmV92DQ2EXV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object tLtYOINH7HrZybWrMGQ(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object bbmRZdNARTtOqxRp8wR(object P_0)
	{
		return ((ManagementObjectSearcher)P_0).Get();
	}

	internal static void whkQ3qN7yXlE0XHiJXK(object P_0)
	{
		((ManagementObjectCollection.ManagementObjectEnumerator)P_0).Reset();
	}

	internal static bool g68FiUNxu1OvvG4m6Rx(object P_0)
	{
		return ((ManagementObjectCollection.ManagementObjectEnumerator)P_0).MoveNext();
	}

	internal static object oFhTfPN0DeTmsCLPUXx(object P_0)
	{
		return ((ManagementObjectCollection.ManagementObjectEnumerator)P_0).Current;
	}

	internal static object T18eavNmwfwgM15r3Cr(object P_0, object P_1)
	{
		return ((ManagementBaseObject)P_0).GetPropertyValue((string)P_1);
	}

	internal static object UxWtiFNy9FomjGd560K(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object vDqiUoNMmpa65C3YW5R(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static bool TiKLvjNJ70BChdlMgcR(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object XMvcDxN9Le0HRhNH4pu()
	{
		return Environment.NewLine;
	}

	internal static object O3Z24aNdiKGEvr3IF4n(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int cwJ0KtNlhFIGW55beEY(object P_0)
	{
		return ((ExternalException)P_0).ErrorCode;
	}

	internal static object jEsnCONrt1CLBnF6sYj(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object bQP8B3Ngt5TrdbdWcIH(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static uint iF6aEWN5ncwZL2hPQhk(object P_0, int P_1)
	{
		return BitConverter.ToUInt32((byte[])P_0, P_1);
	}

	internal static object TBE1EBNjchdxMEiMOgc()
	{
		return Encoding.UTF8;
	}

	internal static object yFALilNYrhJ61i3BxUi(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetComponentId();
	}

	internal static object rQxHsANLATW3vYMhHVk(object P_0)
	{
		return ((LicensedUnitBase)P_0).GetComponentVersion();
	}

	internal static object wTt8krNUDdTDP5AUrIZ(object P_0)
	{
		return ((ModuleAttribute)P_0).Id;
	}

	internal static Type WR5hV2NsmEM9dhgJYfP(object P_0)
	{
		return P_0.GetType();
	}

	internal static bool qKUIU5NcMN4OIN1g5a3(object P_0, object P_1)
	{
		return (Version)P_0 != (Version)P_1;
	}

	internal static void MvZf4UNz5ct352fkwLZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
