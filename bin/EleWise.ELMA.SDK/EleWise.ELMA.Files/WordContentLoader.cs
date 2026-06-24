using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Words;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files;

[Component(Order = 20)]
public class WordContentLoader : BaseFileContentLoader
{
	internal static WordContentLoader cb70R1GTe6gwWT9EXWya;

	public override List<string> Extensions => new List<string>
	{
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088386180),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7246423A),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1FA3C0)
	};

	public override string GetText(string fileName)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				Document val = new Document(fileName);
				text = string.Format(arg0: stcO0FGTNgVg6M5LytRY(), format: (string)MDXiwGGT39KfntoAjaU8(-561074844 ^ -561164856));
				gh2Rs1GTpCYqFkNtlgii((object)val, text, (SaveFormat)50);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				return base.GetText(text);
			}
		}
	}

	public override string GetText(Stream stream)
	{
		//Discarded unreachable code: IL_0057, IL_00de, IL_010e, IL_011d, IL_0129, IL_0138, IL_0166, IL_019e, IL_01de, IL_01e9
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		Document val = default(Document);
		MemoryStream memoryStream = default(MemoryStream);
		string text = default(string);
		Stream stream2 = default(Stream);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					gC80OtGTDiaZ1t0Rs68K(val, memoryStream, (SaveFormat)50);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							text = base.GetText(memoryStream);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
							{
								num3 = 2;
							}
							break;
						default:
							cvTvTLGTt5LlqyKkPuxV(memoryStream, 0L);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num3 = 1;
							}
							break;
						case 2:
							return text;
						}
					}
				}
				finally
				{
					int num4;
					if (memoryStream == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num4 = 1;
						}
						goto IL_00e2;
					}
					goto IL_00f8;
					IL_00f8:
					mXMRlYGTaXtro4HLogJ2(memoryStream);
					num4 = 2;
					goto IL_00e2;
					IL_00e2:
					switch (num4)
					{
					case 1:
						goto end_IL_00bd;
					case 2:
						goto end_IL_00bd;
					}
					goto IL_00f8;
					end_IL_00bd:;
				}
			case 1:
				try
				{
					val = new Document(stream);
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				finally
				{
					int num6;
					if (stream2 == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num6 = 0;
						}
						goto IL_01a2;
					}
					goto IL_01b8;
					IL_01b8:
					mXMRlYGTaXtro4HLogJ2(stream2);
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num6 = 1;
					}
					goto IL_01a2;
					IL_01a2:
					switch (num6)
					{
					default:
						goto end_IL_017d;
					case 2:
						break;
					case 0:
						goto end_IL_017d;
					case 1:
						goto end_IL_017d;
					}
					goto IL_01b8;
					end_IL_017d:;
				}
				goto case 4;
			default:
				return text;
			case 4:
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				stream2 = stream;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public WordContentLoader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qQw4n0GTw1M1pCn1ZiuO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object stcO0FGTNgVg6M5LytRY()
	{
		return IOExtensions.GetTempFileName();
	}

	internal static object MDXiwGGT39KfntoAjaU8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object gh2Rs1GTpCYqFkNtlgii(object P_0, object P_1, SaveFormat P_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return ((Document)P_0).Save((string)P_1, P_2);
	}

	internal static bool u7pVBoGTP6QskggiflLQ()
	{
		return cb70R1GTe6gwWT9EXWya == null;
	}

	internal static WordContentLoader lJZIuJGT16JYbPQ7ljZD()
	{
		return cb70R1GTe6gwWT9EXWya;
	}

	internal static void mXMRlYGTaXtro4HLogJ2(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object gC80OtGTDiaZ1t0Rs68K(object P_0, object P_1, SaveFormat P_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return ((Document)P_0).Save((Stream)P_1, P_2);
	}

	internal static void cvTvTLGTt5LlqyKkPuxV(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static void qQw4n0GTw1M1pCn1ZiuO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
