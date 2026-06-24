using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Cryptography;

[Service]
public class HmacService : IHmacService
{
	private static HmacService CRRgbxBLK4Ujc9UJRNvZ;

	public string GetNormalizedMessage(string verb, string resourceUri, string queryUri, Dictionary<string, string> headers, string contentType, byte[] requestBody)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string value = ((verb != null) ? verb.Trim().ToUpper() : string.Empty);
		string value2 = ((resourceUri != null) ? resourceUri : string.Empty);
		string value3 = ((queryUri != null) ? queryUri : string.Empty);
		string normalizedHeaders = GetNormalizedHeaders(headers);
		string contentHash = GetContentHash(requestBody);
		string value4 = ((!string.IsNullOrEmpty(contentType)) ? contentType.Trim().ToLower() : string.Empty);
		stringBuilder.Append(value).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672126305)).Append(value2)
			.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3C22D))
			.Append(value3)
			.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7F2DB6))
			.Append(normalizedHeaders)
			.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123637286))
			.Append(contentHash)
			.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51151DB9))
			.Append(value4)
			.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837669921));
		return stringBuilder.ToString();
	}

	public string Sign(string message, byte[] secret)
	{
		return MemoryHelper.ActionWithMemoryBuffer<byte, (string, byte[]), string>(((Encoding)mhOwGFBLkfmTyraKA1R3()).GetByteCount(message), (message, secret), SignAction);
	}

	private string SignAction(byte[] buffer, int offset, int length, (string, byte[]) param)
	{
		var (text, key) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, buffer, offset);
		using HMACSHA256 hMACSHA = new HMACSHA256(key);
		return Convert.ToBase64String(hMACSHA.ComputeHash(buffer, offset, length));
	}

	public byte[] Sign(byte[] message, byte[] secret)
	{
		//Discarded unreachable code: IL_0072, IL_00aa, IL_00c9, IL_00d8, IL_0105, IL_0114
		int num = 1;
		int num2 = num;
		HMACSHA256 hMACSHA = default(HMACSHA256);
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				hMACSHA = new HMACSHA256(secret);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = (byte[])W4HEc6BLnQOVZ5ghei8i(hMACSHA, message);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				int num4;
				if (hMACSHA == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num4 = 1;
					}
					goto IL_00ae;
				}
				goto IL_00e3;
				IL_00e3:
				((IDisposable)hMACSHA).Dispose();
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num4 = 0;
				}
				goto IL_00ae;
				IL_00ae:
				switch (num4)
				{
				default:
					goto end_IL_0089;
				case 1:
					goto end_IL_0089;
				case 2:
					break;
				case 0:
					goto end_IL_0089;
				}
				goto IL_00e3;
				end_IL_0089:;
			}
		}
	}

	public bool CheckSignature(string message, byte[] secret, string base64Signature)
	{
		int num = 2;
		int num2 = num;
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				array2 = Sign((byte[])NVqxZmBLOeDILKftXCTe(mhOwGFBLkfmTyraKA1R3(), message), secret);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				array = Convert.FromBase64String(base64Signature);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return OUOgDcBL25o2Lr4dLXLB(StructuralComparisons.StructuralEqualityComparer, array, array2);
			}
		}
	}

	private string GetNormalizedHeaders(Dictionary<string, string> headers)
	{
		IOrderedEnumerable<KeyValuePair<string, string>> orderedEnumerable = from h in headers
			select new KeyValuePair<string, string>(h.Key.ToLower(), h.Value.Trim().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867198415), "").Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x54889E9C), "")) into e
			orderby e.Key
			select e;
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, string> item in orderedEnumerable)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FFD4FD));
			}
			stringBuilder.AppendFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309722794), item.Key, item.Value);
		}
		return stringBuilder.ToString();
	}

	private string GetContentHash(byte[] body)
	{
		//Discarded unreachable code: IL_005c, IL_006b, IL_00e7, IL_011f, IL_015f, IL_016e, IL_017a
		int num = 3;
		int num2 = num;
		SHA256 sHA = default(SHA256);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return string.Empty;
			case 2:
				sHA = SHA256.Create();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return result;
			case 3:
				if (body != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 1;
			}
			try
			{
				result = (string)uE09gHBLPwUIsRvgedsL(VqASKxBL1lXUpNWgx26N(uE09gHBLPwUIsRvgedsL(aIktNYBLenOpmOo7JETU(W4HEc6BLnQOVZ5ghei8i(sHA, body))), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088305740), ""));
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				int num4;
				if (sHA == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num4 = 0;
					}
					goto IL_0123;
				}
				goto IL_0139;
				IL_0139:
				uHEwIoBLNhYF1yQ1d5n0(sHA);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num4 = 2;
				}
				goto IL_0123;
				IL_0123:
				switch (num4)
				{
				default:
					goto end_IL_00fe;
				case 1:
					break;
				case 0:
					goto end_IL_00fe;
				case 2:
					goto end_IL_00fe;
				}
				goto IL_0139;
				end_IL_00fe:;
			}
		}
	}

	public HmacService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HqrkVrBL30CbKROS8TeB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object mhOwGFBLkfmTyraKA1R3()
	{
		return Encoding.UTF8;
	}

	internal static bool B8DdVEBLX4NW8q8nNoOd()
	{
		return CRRgbxBLK4Ujc9UJRNvZ == null;
	}

	internal static HmacService PEr1HmBLT1x9fo8gKdge()
	{
		return CRRgbxBLK4Ujc9UJRNvZ;
	}

	internal static object W4HEc6BLnQOVZ5ghei8i(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static object NVqxZmBLOeDILKftXCTe(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static bool OUOgDcBL25o2Lr4dLXLB(object P_0, object P_1, object P_2)
	{
		return ((IEqualityComparer)P_0).Equals(P_1, P_2);
	}

	internal static object aIktNYBLenOpmOo7JETU(object P_0)
	{
		return BitConverter.ToString((byte[])P_0);
	}

	internal static object uE09gHBLPwUIsRvgedsL(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object VqASKxBL1lXUpNWgx26N(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void uHEwIoBLNhYF1yQ1d5n0(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void HqrkVrBL30CbKROS8TeB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
