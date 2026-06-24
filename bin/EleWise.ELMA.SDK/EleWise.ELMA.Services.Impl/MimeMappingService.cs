using System;
using System.Collections;
using System.Collections.Concurrent;
using System.IO;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Impl;

[Service]
internal class MimeMappingService : IMimeMappingService
{
	private readonly ConcurrentDictionary<string, string> mimeTypes;

	internal static MimeMappingService hYkk04BMAcPrDSfh1Nnq;

	public MimeMappingService()
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_0085, IL_0094, IL_009f, IL_01bf, IL_01ce, IL_01eb, IL_0219, IL_0251, IL_0270, IL_027f, IL_02ac, IL_02bb
		SingletonReader.JJCZtPuTvSt();
		mimeTypes = new ConcurrentDictionary<string, string>();
		base._002Ector();
		int num = 2;
		XmlNodeList xmlNodeList = default(XmlNodeList);
		IEnumerator enumerator = default(IEnumerator);
		XmlNode xmlNode = default(XmlNode);
		XmlDocument xmlDocument = default(XmlDocument);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 1:
				if (xmlNodeList == null)
				{
					return;
				}
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num = 3;
				}
				break;
			case 7:
				try
				{
					while (true)
					{
						int num2;
						if (!juYxmqBMrkSFq4WivalT(enumerator))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num2 = 1;
							}
							goto IL_00a3;
						}
						goto IL_0137;
						IL_0137:
						xmlNode = (XmlNode)SeDR9hBMJ0DjExOaWarS(enumerator);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						goto IL_00a3;
						IL_00a3:
						while (true)
						{
							switch (num2)
							{
							case 1:
								return;
							default:
								mimeTypes.TryAdd((string)W9WfRoBMlpxTbPViA4cb(RgQlyjBMdoX3UcvIYpCW(xmlNode, LYlhgDBM9rj4yOCmyAZx(0x63ABA4E8 ^ 0x63AACE8A))), (string)W9WfRoBMlpxTbPViA4cb(RgQlyjBMdoX3UcvIYpCW(xmlNode, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710499162))));
								num2 = 3;
								continue;
							case 3:
								break;
							case 2:
								goto IL_0137;
							}
							break;
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num3 = 2;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							goto end_IL_017f;
						case 2:
							if (disposable == null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num4 = 0;
								}
								continue;
							}
							break;
						case 0:
							goto end_IL_017f;
						case 1:
							break;
						case 3:
							goto end_IL_017f;
						}
						M4yXI9BMm8euhTlwXSsn(disposable);
						num4 = 3;
						continue;
						end_IL_017f:
						break;
					}
				}
			case 6:
				try
				{
					xmlDocument.Load(xmlTextReader);
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
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
					if (xmlTextReader == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num6 = 0;
						}
						goto IL_0255;
					}
					goto IL_028a;
					IL_028a:
					M4yXI9BMm8euhTlwXSsn(xmlTextReader);
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num6 = 1;
					}
					goto IL_0255;
					IL_0255:
					switch (num6)
					{
					default:
						goto end_IL_0230;
					case 0:
						goto end_IL_0230;
					case 2:
						break;
					case 1:
						goto end_IL_0230;
					}
					goto IL_028a;
					end_IL_0230:;
				}
				goto case 5;
			default:
				xmlTextReader = new XmlTextReader(new StringReader((string)oypH0OBM0kqKJvbwJaLS()));
				num = 6;
				break;
			case 2:
				xmlDocument = new XmlDocument();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num = 0;
				}
				break;
			case 5:
				xmlNodeList = (XmlNodeList)SWZGnGBMyivRUDEbbS89(xmlDocument, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411140625));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 1;
				}
				break;
			case 3:
				enumerator = (IEnumerator)zTG6L1BMMECsAyyeBqCH(xmlNodeList);
				num = 7;
				break;
			}
		}
	}

	public virtual string GetTypeByExtension(string extension)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!mimeTypes.ContainsKey(extension))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return mimeTypes[extension];
			default:
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92E7855);
			}
		}
	}

	public virtual void RegisterMimeType(string ext, string mimeType)
	{
		//Discarded unreachable code: IL_0031
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
				if (!mimeTypes.TryRemove(ext, out var _))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			case 3:
				break;
			case 2:
				return;
			}
			mimeTypes.TryAdd(ext, mimeType);
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
			{
				num2 = 2;
			}
		}
	}

	internal static object oypH0OBM0kqKJvbwJaLS()
	{
		return Resources.MimeTypes;
	}

	internal static void M4yXI9BMm8euhTlwXSsn(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object SWZGnGBMyivRUDEbbS89(object P_0, object P_1)
	{
		return ((XmlNode)P_0).SelectNodes((string)P_1);
	}

	internal static object zTG6L1BMMECsAyyeBqCH(object P_0)
	{
		return ((XmlNodeList)P_0).GetEnumerator();
	}

	internal static object SeDR9hBMJ0DjExOaWarS(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object LYlhgDBM9rj4yOCmyAZx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RgQlyjBMdoX3UcvIYpCW(object P_0, object P_1)
	{
		return ((XmlNode)P_0).SelectSingleNode((string)P_1);
	}

	internal static object W9WfRoBMlpxTbPViA4cb(object P_0)
	{
		return ((XmlNode)P_0).InnerText;
	}

	internal static bool juYxmqBMrkSFq4WivalT(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool tQGB0oBM7goHWk9EAISc()
	{
		return hYkk04BMAcPrDSfh1Nnq == null;
	}

	internal static MimeMappingService ro1AM3BMxIrpSMZVZmmJ()
	{
		return hYkk04BMAcPrDSfh1Nnq;
	}
}
