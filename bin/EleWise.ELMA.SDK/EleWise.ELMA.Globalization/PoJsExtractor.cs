using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Memory;
using Gettext.Cs;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

public class PoJsExtractor
{
	internal static PoJsExtractor rgLXCPGEIj7kKVgkTisi;

	public static Dictionary<string, string> Extract(IEnumerable<string> localeFileNames, IEnumerable<string> baseFileNames)
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(localeFileNames, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70223423));
		List<int> list = new List<int>();
		if (baseFileNames != null && baseFileNames.Any())
		{
			foreach (string baseFileName in baseFileNames)
			{
				BlockManager blockManager = new BlockManager();
				blockManager.ReadFromFile(baseFileName);
				IEnumerator<Block> enumerator2 = blockManager.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Block current2 = enumerator2.Current;
					if (current2.IsJsBlock && !list.Contains(current2.MsgIdHash))
					{
						list.Add(current2.MsgIdHash);
					}
				}
			}
		}
		List<Block> list2 = new List<Block>();
		foreach (string localeFileName in localeFileNames)
		{
			BlockManager blockManager2 = new BlockManager();
			blockManager2.ReadFromFile(localeFileName);
			IEnumerator<Block> enumerator3 = blockManager2.GetEnumerator();
			while (enumerator3.MoveNext())
			{
				Block current4 = enumerator3.Current;
				if (current4.IsJsBlock || list.Contains(current4.MsgIdHash))
				{
					list2.Add(current4);
				}
			}
		}
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using StreamWriter streamWriter = new StreamWriter(memoryStream);
		WriteHeader(streamWriter);
		foreach (Block item in list2)
		{
			WriteBlock(streamWriter, item);
		}
		streamWriter.Flush();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		using StreamReader streamReader = new StreamReader(memoryStream);
		return new PoParser().ParseIntoDictionary((TextReader)streamReader);
	}

	private static void WriteHeader(object writer)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				AMjJibGEqZZo7V9sP1ID(writer, fYFcBLGERA4e1o8cf5jp(Umvs09GEipkVWDH4Y3jW(--1867379187 ^ 0x6F4E4A8D), Umvs09GEipkVWDH4Y3jW(0xE1229CF ^ 0xE124AF1), Umvs09GEipkVWDH4Y3jW(0x1DE3DD89 ^ 0x1DE3C22D)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static void WriteBlock(object writer, object b)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0054, IL_0114, IL_0127, IL_0136, IL_01a6, IL_01b0, IL_026a, IL_027d
		int num = 1;
		int num2 = num;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current2 = default(string);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					while (true)
					{
						IL_00c2:
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
							{
								num5 = 0;
							}
							goto IL_0058;
						}
						goto IL_00af;
						IL_00af:
						current2 = enumerator.Current;
						num5 = 2;
						goto IL_0058;
						IL_0058:
						while (true)
						{
							switch (num5)
							{
							case 2:
								AMjJibGEqZZo7V9sP1ID(writer, FfV9dQGEKZtcFMtmvupN(current2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A6CD94)));
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								goto IL_00c2;
							case 3:
								goto end_IL_00c2;
							}
							break;
						}
						goto IL_00af;
						continue;
						end_IL_00c2:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			case 4:
				return;
			case 5:
				((TextWriter)writer).Write((string)Umvs09GEipkVWDH4Y3jW(0x463A0F3C ^ 0x463A1098));
				num2 = 4;
				break;
			case 2:
				enumerator = ((Block)b).MsgStr.GetEnumerator();
				num2 = 3;
				break;
			case 1:
				enumerator = ((Block)b).MsgId.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num3 = 1;
							}
							goto IL_01b4;
						}
						goto IL_021b;
						IL_021b:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num3 = 0;
						}
						goto IL_01b4;
						IL_01b4:
						while (true)
						{
							switch (num3)
							{
							default:
								AMjJibGEqZZo7V9sP1ID(writer, FfV9dQGEKZtcFMtmvupN(current, Umvs09GEipkVWDH4Y3jW(0x463A0F3C ^ 0x463A1098)));
								num3 = 3;
								continue;
							case 3:
								break;
							case 2:
								goto IL_021b;
							case 1:
								goto end_IL_01f5;
							}
							break;
						}
						continue;
						end_IL_01f5:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			}
		}
	}

	public PoJsExtractor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kVemddGEXdIWWh3qsCbc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Umvs09GEipkVWDH4Y3jW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object fYFcBLGERA4e1o8cf5jp(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void AMjJibGEqZZo7V9sP1ID(object P_0, object P_1)
	{
		((TextWriter)P_0).Write((string)P_1);
	}

	internal static bool t1ZPLIGEV9dv7UiO2R56()
	{
		return rgLXCPGEIj7kKVgkTisi == null;
	}

	internal static PoJsExtractor wQfIOdGESRmFdasRlDHp()
	{
		return rgLXCPGEIj7kKVgkTisi;
	}

	internal static object FfV9dQGEKZtcFMtmvupN(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void kVemddGEXdIWWh3qsCbc()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
