using System;
using System.Collections.Generic;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Helpers;

public static class GenerateNameHelper
{
	private static int maximumPrefixLength;

	private static int partOfGuidLength;

	private static readonly string foreignKeyPrefix;

	private static readonly string primaryKeyPrefix;

	internal static GenerateNameHelper rWCumdoE3UvA1uGVanEU;

	public static string GenerateForeignKeyName(string prefix, string tableName, string columnName)
	{
		int num = 4;
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return (string)Vr1CYMoEAqK23fsWETOO(prefix, LP5YkGoEHbjNOFbBF7Mj(guid.ToString((string)h0cUYToEDtok2gT8g4ZJ(-2099751081 ^ -2099729121)), 0, partOfGuidLength));
				default:
					Contract.ArgumentNotNullOrEmpty(tableName, (string)h0cUYToEDtok2gT8g4ZJ(0x1ECE530A ^ 0x1ECF9BA8));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					GUL1StoEtdommX8dDAOb(columnName, h0cUYToEDtok2gT8g4ZJ(0x3A5D5EF ^ 0x3A42A9F));
					num2 = 5;
					continue;
				case 3:
					Contract.CheckArgument(WWpBgvoEwWOllIfrY0PV(prefix) <= maximumPrefixLength, (string)h0cUYToEDtok2gT8g4ZJ(-1979251663 ^ -1979265901));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					break;
				case 4:
					GUL1StoEtdommX8dDAOb(prefix, h0cUYToEDtok2gT8g4ZJ(-3333094 ^ -3181598));
					num2 = 3;
					continue;
				}
				break;
			}
			guid = spRCY7oE6NCmVa4hgTUj(yqhWDRoE4iivOfxfQE4a(foreignKeyPrefix, tableName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710497400), columnName));
			num = 2;
		}
	}

	public static string GenerateForeignKeyName(string prefix, string tableName, IEnumerable<string> columnNames)
	{
		Contract.ArgumentNotNullOrEmpty(prefix, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210582469));
		Contract.CheckArgument(prefix.Length <= maximumPrefixLength, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70089086));
		Contract.ArgumentNotNullOrEmpty(tableName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345471642));
		return prefix + (foreignKeyPrefix + tableName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A76C6F5) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606707618), columnNames)).GetDeterministicGuid().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269EA582)).Substring(0, partOfGuidLength);
	}

	public static string GeneratePrimaryKeyName(string prefix, string tableName, string columnName)
	{
		int num = 1;
		int num2 = num;
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				GUL1StoEtdommX8dDAOb(prefix, h0cUYToEDtok2gT8g4ZJ(-1088304168 ^ -1088185312));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				GUL1StoEtdommX8dDAOb(columnName, h0cUYToEDtok2gT8g4ZJ(0x463A0F3C ^ 0x463BF04C));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				GUL1StoEtdommX8dDAOb(tableName, h0cUYToEDtok2gT8g4ZJ(-561074844 ^ -561027642));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 3;
				}
				break;
			default:
				cmIJDLoE7ZqoDJRfh8up(WWpBgvoEwWOllIfrY0PV(prefix) <= maximumPrefixLength, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217406565));
				num2 = 4;
				break;
			case 2:
				guid = spRCY7oE6NCmVa4hgTUj(yqhWDRoE4iivOfxfQE4a(primaryKeyPrefix, tableName, h0cUYToEDtok2gT8g4ZJ(-105199646 ^ -105146720), columnName));
				num2 = 3;
				break;
			case 3:
				return prefix + (string)LP5YkGoEHbjNOFbBF7Mj(guid.ToString((string)h0cUYToEDtok2gT8g4ZJ(-1858887263 ^ -1858905111)), 0, partOfGuidLength);
			}
		}
	}

	static GenerateNameHelper()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				foreignKeyPrefix = (string)h0cUYToEDtok2gT8g4ZJ(-787452571 ^ -787335827);
				num2 = 3;
				break;
			case 4:
				return;
			case 3:
				primaryKeyPrefix = (string)h0cUYToEDtok2gT8g4ZJ(-218496594 ^ -218605124);
				num2 = 4;
				break;
			default:
				maximumPrefixLength = 5;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				partOfGuidLength = 24;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				KwKxBEoEx8Vp2cm2ApkK();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object h0cUYToEDtok2gT8g4ZJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void GUL1StoEtdommX8dDAOb(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static int WWpBgvoEwWOllIfrY0PV(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object yqhWDRoE4iivOfxfQE4a(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static Guid spRCY7oE6NCmVa4hgTUj(object P_0)
	{
		return ((string)P_0).GetDeterministicGuid();
	}

	internal static object LP5YkGoEHbjNOFbBF7Mj(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object Vr1CYMoEAqK23fsWETOO(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool dxV1OboEpYPgJjncdevG()
	{
		return rWCumdoE3UvA1uGVanEU == null;
	}

	internal static GenerateNameHelper b1pAZWoEaN9XqGFudmHE()
	{
		return rWCumdoE3UvA1uGVanEU;
	}

	internal static void cmIJDLoE7ZqoDJRfh8up(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static void KwKxBEoEx8Vp2cm2ApkK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
