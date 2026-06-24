using System;
using System.IO;
using System.Xml.Serialization;

namespace EleWise.ELMA.Serialization;

public static class XmlSerializer<T>
{
	internal static object y37C2dB5VLyDqKhsDIOM;

	public static string Serialize(object obj)
	{
		//Discarded unreachable code: IL_0051, IL_00b0, IL_00f0, IL_00fb, IL_010a
		int num = 2;
		int num2 = num;
		XmlSerializer xmlSerializer = default(XmlSerializer);
		StringWriter stringWriter = default(StringWriter);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					xmlSerializer.Serialize(stringWriter, obj);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						}
						result = stringWriter.ToString();
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num4;
					if (stringWriter == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num4 = 1;
						}
						goto IL_00b4;
					}
					goto IL_00ca;
					IL_00ca:
					((IDisposable)stringWriter).Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num4 = 0;
					}
					goto IL_00b4;
					IL_00b4:
					switch (num4)
					{
					default:
						goto end_IL_008f;
					case 2:
						break;
					case 1:
						goto end_IL_008f;
					case 0:
						goto end_IL_008f;
					}
					goto IL_00ca;
					end_IL_008f:;
				}
			case 2:
				xmlSerializer = new XmlSerializer(typeof(T));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				stringWriter = new StringWriter();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return result;
			}
		}
	}

	public static T Deserialize(string data)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		using StringReader textReader = new StringReader(data);
		return (T)xmlSerializer.Deserialize(textReader);
	}

	public static void SerializeToFile(string fileName, object obj)
	{
		//Discarded unreachable code: IL_0065, IL_009d, IL_00d5, IL_00e4
		int num = 2;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		XmlSerializer xmlSerializer = default(XmlSerializer);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
				num2 = 3;
				break;
			case 3:
				try
				{
					xmlSerializer.Serialize(fileStream, obj);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (fileStream != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								((IDisposable)fileStream).Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			case 2:
				xmlSerializer = new XmlSerializer(typeof(T));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static T DeserializeFromFile(string fileName)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		using FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
		return (T)xmlSerializer.Deserialize(stream);
	}

	internal static bool INo7RNB5SGOU11UxLByT()
	{
		return y37C2dB5VLyDqKhsDIOM == null;
	}

	internal static object M6ObSwB5iG38rFOXb4uy()
	{
		return y37C2dB5VLyDqKhsDIOM;
	}
}
