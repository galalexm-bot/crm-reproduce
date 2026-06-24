using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

public class PoParser
{
	internal static PoParser BfAjtuGEJInu5nSfk5lD;

	public static Tuple<List<string>, List<PoLineDescriptor>> Parse(TextReader reader)
	{
		List<string> list = new List<string>();
		List<PoLineDescriptor> list2 = new List<PoLineDescriptor>();
		int num = 1;
		StringBuilder stringBuilder = null;
		StringBuilder stringBuilder2 = null;
		bool isFuzzy = false;
		bool isLow = false;
		List<string> list3 = new List<string>();
		string text = reader.ReadLine()?.Trim();
		if (text != null && text.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97865956)))
		{
			do
			{
				list.Add(text);
				text = reader.ReadLine()?.Trim();
			}
			while (!string.IsNullOrEmpty(text) && !text.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDF056C)) && !text.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675303787)));
		}
		while (true)
		{
			text = reader.ReadLine()?.Trim();
			if (string.IsNullOrEmpty(text))
			{
				if (num == 3 && stringBuilder != null && stringBuilder2 != null)
				{
					PoLineDescriptor poLineDescriptor = new PoLineDescriptor
					{
						Key = stringBuilder.ToString().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957817578), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A5CA4B)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E264EC), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411201529))
							.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138035567), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EBEC1))
							.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A81A69A), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4785A37B)),
						Value = stringBuilder2.ToString().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477138292), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341841F1)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76DCBE8), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x202605E5))
							.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1FA18A), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218489610))
							.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345419030), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882127340)),
						IsFuzzy = isFuzzy,
						IsLow = isLow
					};
					poLineDescriptor.Comments.AddRange(list3);
					list2.Add(poLineDescriptor);
					stringBuilder = null;
					stringBuilder2 = null;
					isFuzzy = false;
					isLow = false;
					list3 = new List<string>();
				}
				if (text == null)
				{
					break;
				}
				num = 1;
				continue;
			}
			if (text.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B35147F)))
			{
				if (text.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A45DCC)))
				{
					isFuzzy = true;
				}
				else if (text.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146480035)))
				{
					isLow = true;
				}
			}
			else if (text[0] == '#')
			{
				list3.Add(text);
				continue;
			}
			bool flag = text.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289869516));
			bool flag2 = !flag && text.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088261040));
			if (flag || flag2)
			{
				num = (flag ? 2 : 3);
				int num2 = text.IndexOf('"');
				if (num2 == -1)
				{
					continue;
				}
				int num3 = text.IndexOf('"', num2 + 1);
				while (num3 != -1 && text[num3 - 1] == '\\')
				{
					num3 = text.IndexOf('"', num3 + 1);
				}
				if (num3 != -1)
				{
					string value = text.Substring(num2 + 1, num3 - num2 - 1);
					if (flag)
					{
						stringBuilder = new StringBuilder();
						stringBuilder.Append(value);
					}
					else
					{
						stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(value);
					}
				}
			}
			else if (text[0] == '"' && text.Length != 1)
			{
				text = ((text[text.Length - 1] == '"') ? text.Substring(1, text.Length - 2) : text.Substring(1, text.Length - 1));
				switch (num)
				{
				case 2:
					stringBuilder?.Append(text);
					break;
				case 3:
					stringBuilder2?.Append(text);
					break;
				}
			}
		}
		return new Tuple<List<string>, List<PoLineDescriptor>>(list, list2);
	}

	public static Tuple<List<string>, List<PoLineDescriptor>> Parse(string text)
	{
		return Parse(new StringReader(text));
	}

	public PoParser()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XZNZ7FGEl4NZOfbPhvBe();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void XZNZ7FGEl4NZOfbPhvBe()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool jqYhJcGE9sHT9HEqaewC()
	{
		return BfAjtuGEJInu5nSfk5lD == null;
	}

	internal static PoParser zsAfynGEdQKIZXd5gExq()
	{
		return BfAjtuGEJInu5nSfk5lD;
	}
}
