using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy;

internal sealed class XNodeWrapper : IDisposable
{
	private XNode xnode;

	private string nodeContext;

	private List<StringReader> stringReaderList;

	private List<XmlReader> xmlReaderList;

	private static XNodeWrapper OgqHBfE26PLwlBI7x5ls;

	internal XNodeWrapper(XmlReader reader)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_006a, IL_0079, IL_0146, IL_0155
		BwD8oZE27YJ7WhUuMpLV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				stringReaderList = new List<StringReader>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 0;
				}
				break;
			case 7:
				xnode = (XNode)qfqiOOE2JZckHYS6dnwA(reader);
				num = 8;
				break;
			default:
				xmlReaderList = new List<XmlReader>();
				num = 9;
				break;
			case 9:
				return;
			case 3:
			case 5:
				throw new ArgumentException((string)E34kksE2mQc5unKe0BvO(--1360331293 ^ 0x51115C01));
			case 6:
				if (!xF5thBE2yA6aOubSANeu(qVr6FhE20ruFGeEIpvvx(reader), E34kksE2mQc5unKe0BvO(0x92F12D5 ^ 0x92B4CD9)))
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num = 5;
					}
					break;
				}
				goto case 4;
			case 4:
				if (!ecjFrFE2Mx3gLXCEpxiQ(reader))
				{
					num = 7;
					break;
				}
				goto case 3;
			case 8:
				nodeContext = xnode.ToString();
				num = 2;
				break;
			case 1:
				if (!YQwEgoE2xJr47mPlFwU5(reader))
				{
					num = 3;
					break;
				}
				goto case 6;
			}
		}
	}

	public void Dispose()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				stringReaderList.Clear();
				num2 = 4;
				continue;
			case 4:
				return;
			case 2:
				i3fvaUE29a4u4tG9qYb0(xmlReaderList);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				xmlReaderList.ForEach(delegate(XmlReader x)
				{
					_003C_003Ec.PPMtUW8Xz26yJmk8oMyy(x);
				});
				num2 = 2;
				continue;
			}
			stringReaderList.ForEach(delegate(StringReader x)
			{
				_003C_003Ec.R2Ut5v8TFoPsAli9Xo5Z(x);
			});
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
			{
				num2 = 1;
			}
		}
	}

	internal Guid GetTypeUid()
	{
		int num = 1;
		int num2 = num;
		Guid result = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				XmlReader xmlReader = GetXmlReader();
				SxxLPXE2dLgCfgFFj8pI(xmlReader, E34kksE2mQc5unKe0BvO(0x1A33FE36 ^ 0x1A33BC54));
				Guid.TryParse(xmlReader.GetAttribute((string)E34kksE2mQc5unKe0BvO(-889460160 ^ -889477086)), out result);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				return result;
			}
		}
	}

	internal XmlReader GetXmlReader()
	{
		XmlReader xmlReader = CreateXmlReader();
		xmlReader.ReadToFollowing((string)E34kksE2mQc5unKe0BvO(-541731959 ^ -542012027));
		return xmlReader;
	}

	private XmlReader CreateXmlReader()
	{
		int num = 2;
		int num2 = num;
		XmlTextReader xmlTextReader = default(XmlTextReader);
		while (true)
		{
			switch (num2)
			{
			case 1:
				xmlReaderList.Add(xmlTextReader);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return xmlTextReader;
			case 2:
				xmlTextReader = new XmlTextReader(CreateStringReader());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private StringReader CreateStringReader()
	{
		int num = 1;
		int num2 = num;
		StringReader stringReader = default(StringReader);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return stringReader;
			case 1:
				stringReader = new StringReader(nodeContext);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				stringReaderList.Add(stringReader);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void BwD8oZE27YJ7WhUuMpLV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool YQwEgoE2xJr47mPlFwU5(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object qVr6FhE20ruFGeEIpvvx(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static object E34kksE2mQc5unKe0BvO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool xF5thBE2yA6aOubSANeu(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool ecjFrFE2Mx3gLXCEpxiQ(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object qfqiOOE2JZckHYS6dnwA(object P_0)
	{
		return XNode.ReadFrom((XmlReader)P_0);
	}

	internal static bool dSTPiJE2HWGdDgMiicah()
	{
		return OgqHBfE26PLwlBI7x5ls == null;
	}

	internal static XNodeWrapper JORCqFE2AjsT8gMuKf19()
	{
		return OgqHBfE26PLwlBI7x5ls;
	}

	internal static void i3fvaUE29a4u4tG9qYb0(object P_0)
	{
		((List<XmlReader>)P_0).Clear();
	}

	internal static bool SxxLPXE2dLgCfgFFj8pI(object P_0, object P_1)
	{
		return ((XmlReader)P_0).MoveToAttribute((string)P_1);
	}
}
