using System;
using System.IO;
using System.Xml;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class XmlObjectSerializableType : XmlSerializableType<object>
{
	private static XmlObjectSerializableType gXhekFWyuJblupI0GHiW;

	protected override void SaveObjectToStream(Stream stream, object obj)
	{
		//Discarded unreachable code: IL_0055, IL_00b2, IL_00ea, IL_0109, IL_0118, IL_0166, IL_019e, IL_01ad
		int num = 2;
		int num2 = num;
		StreamWriter streamWriter = default(StreamWriter);
		XmlWriter xmlWriter = default(XmlWriter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					HpKNQUWySHT4W8ZgPbZs(streamWriter, obj.GetType().AssemblyQualifiedName);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							xmlWriter = (XmlWriter)trJ80ZWyikEjhIMyf86S(streamWriter);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
							{
								num3 = 1;
							}
							break;
						case 1:
							try
							{
								ClassSerializationHelper.SerializeObjectByXml(obj, xmlWriter);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
								return;
							}
							finally
							{
								int num5;
								if (xmlWriter == null)
								{
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
									{
										num5 = 0;
									}
									goto IL_00ee;
								}
								goto IL_0123;
								IL_0123:
								IodpApWyRFoH6AE7E3r4(xmlWriter);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
								{
									num5 = 0;
								}
								goto IL_00ee;
								IL_00ee:
								switch (num5)
								{
								default:
									goto end_IL_00c9;
								case 2:
									goto end_IL_00c9;
								case 1:
									break;
								case 0:
									goto end_IL_00c9;
								}
								goto IL_0123;
								end_IL_00c9:;
							}
						}
					}
				}
				finally
				{
					if (streamWriter != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								((IDisposable)streamWriter).Dispose();
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				streamWriter = new StreamWriter(stream);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override object LoadObjectFromStream(Stream stream)
	{
		//Discarded unreachable code: IL_0041, IL_00c6, IL_00fe, IL_013e, IL_014d, IL_017a, IL_01b2, IL_01c1
		int num = 2;
		int num2 = num;
		StreamReader streamReader = default(StreamReader);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					Type tp = j413faWyKfI0GGiE1pFN(FuwnqHWyqICsguRbl2en(streamReader));
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 1:
							xmlTextReader = new XmlTextReader(streamReader);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							EcNq8AWyXlATYfdl1KfB(streamReader);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num3 = 1;
							}
							continue;
						}
						try
						{
							obj = ClassSerializationHelper.DeserializeObjectByXml(tp, xmlTextReader);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num4 = 0;
							}
							return num4 switch
							{
								0 => obj, 
								_ => obj, 
							};
						}
						finally
						{
							int num5;
							if (xmlTextReader == null)
							{
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
								{
									num5 = 2;
								}
								goto IL_0102;
							}
							goto IL_0118;
							IL_0118:
							IodpApWyRFoH6AE7E3r4(xmlTextReader);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num5 = 0;
							}
							goto IL_0102;
							IL_0102:
							switch (num5)
							{
							case 2:
								goto end_IL_00dd;
							case 1:
								goto end_IL_00dd;
							}
							goto IL_0118;
							end_IL_00dd:;
						}
					}
				}
				finally
				{
					if (streamReader != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								((IDisposable)streamReader).Dispose();
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			default:
				return obj;
			case 2:
				streamReader = new StreamReader(stream);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public XmlObjectSerializableType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void HpKNQUWySHT4W8ZgPbZs(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static object trJ80ZWyikEjhIMyf86S(object P_0)
	{
		return XmlWriter.Create((TextWriter)P_0);
	}

	internal static void IodpApWyRFoH6AE7E3r4(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool Em3nNqWyIVZAuhHYfchW()
	{
		return gXhekFWyuJblupI0GHiW == null;
	}

	internal static XmlObjectSerializableType m57LhsWyVvLsyAK0XFyW()
	{
		return gXhekFWyuJblupI0GHiW;
	}

	internal static object FuwnqHWyqICsguRbl2en(object P_0)
	{
		return ((TextReader)P_0).ReadLine();
	}

	internal static Type j413faWyKfI0GGiE1pFN(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static void EcNq8AWyXlATYfdl1KfB(object P_0)
	{
		((StreamReader)P_0).CheckAndCorrectInternalBOMSymbols();
	}
}
