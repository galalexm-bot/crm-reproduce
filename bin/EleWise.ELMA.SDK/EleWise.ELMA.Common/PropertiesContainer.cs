using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common;

[Serializable]
public class PropertiesContainer : IPropertiesContainer, IXmlSerializable
{
	private readonly Dictionary<string, object> container;

	protected const string KeyName = "key";

	protected const string ItemName = "item";

	internal static PropertiesContainer RJwN8JfVuKGXP2GvKwNs;

	public object this[string key]
	{
		get
		{
			return container[key];
		}
		set
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
					container[key] = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<string> GetProperties()
	{
		return container.Keys;
	}

	public object GetPropertyValue(string propertyName, object[] index)
	{
		int num = 1;
		int num2 = num;
		object value = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				container.TryGetValue(propertyName, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return value;
			}
		}
	}

	public void SetPropertyValue(string propertyName, object[] index, object value)
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
				container[propertyName] = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RemoveProperty(string propertyName)
	{
		//Discarded unreachable code: IL_0084, IL_0093
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				container.Remove(propertyName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (!container.ContainsKey(propertyName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 1:
				return;
			case 2:
				return;
			}
		}
	}

	public bool IsEmpty()
	{
		return Chi0tNfVSNLCYngyYH7U(container) == 0;
	}

	public XmlSchema GetSchema()
	{
		return null;
	}

	public void ReadXml(XmlReader reader)
	{
		//Discarded unreachable code: IL_0076, IL_0085, IL_00f7, IL_0106
		int num = 8;
		object value = default(object);
		XmlSerializer xmlSerializer = default(XmlSerializer);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					value = lpcXIafVnmm1VehGucvM(xmlSerializer, reader);
					num2 = 14;
					continue;
				case 5:
					return;
				case 6:
					reader.ReadEndElement();
					num2 = 15;
					continue;
				case 3:
					return;
				case 13:
					iNNRbvfVKWA8OXsYaqYu(reader);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 11;
					}
					continue;
				case 4:
					break;
				default:
					if (reader.NodeType == XmlNodeType.EndElement)
					{
						num2 = 4;
						continue;
					}
					goto case 13;
				case 12:
					nkRlfCfVTs9YBtvTho8S(reader);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					text = (string)VbvPo4fVXdKqiclJMOQx(reader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76CA32E));
					num2 = 2;
					continue;
				case 2:
					if (!text.IsNullOrWhiteSpace())
					{
						reader.ReadStartElement((string)amISotfVkYcdI3Dxslqf(0x4785BC0D ^ 0x47851473));
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 8;
						}
					}
					else
					{
						num2 = 12;
					}
					continue;
				case 10:
					qc9v0XfVqimW2IPgTdBB(reader);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					return;
				case 7:
					xmlSerializer = new XmlSerializer(iE4fZWfVRmwc12dp2CtP(typeof(object).TypeHandle));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (LEKk13fVidnRZejeEoPe(reader))
					{
						return;
					}
					num2 = 7;
					continue;
				case 14:
					container.Add(text, value);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			nkRlfCfVTs9YBtvTho8S(reader);
			num = 5;
		}
	}

	public void WriteXml(XmlWriter writer)
	{
		//Discarded unreachable code: IL_0032, IL_0040, IL_0192, IL_01a5, IL_01b4
		int num = 1;
		int num2 = num;
		Dictionary<string, object>.KeyCollection.Enumerator enumerator = default(Dictionary<string, object>.KeyCollection.Enumerator);
		string current = default(string);
		object obj = default(object);
		XmlSerializer xmlSerializer = default(XmlSerializer);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
							{
								num3 = 1;
							}
							goto IL_0044;
						}
						goto IL_00fd;
						IL_00fd:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num3 = 0;
						}
						goto IL_0044;
						IL_0044:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							default:
								nV5sQ3fVOj6t1Bcbbr6N(writer, amISotfVkYcdI3Dxslqf(0x463A0F3C ^ 0x463AA742));
								num3 = 2;
								continue;
							case 7:
								obj = container[current];
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								LC5K1jfVPUCYu1P0Q8yU(writer);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
								{
									num3 = 4;
								}
								continue;
							case 5:
								goto IL_00fd;
							case 6:
								FYfqVMfVeKt3sHDLpmWL(xmlSerializer, writer, obj);
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num3 = 3;
								}
								continue;
							case 2:
								gCtncafV2ArcoWHtk5Rp(writer, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE135E6F), current);
								num3 = 7;
								continue;
							case 1:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			default:
				enumerator = container.Keys.GetEnumerator();
				num2 = 3;
				break;
			case 1:
				xmlSerializer = new XmlSerializer(iE4fZWfVRmwc12dp2CtP(typeof(object).TypeHandle));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public bool TryGetValue<T>(string key, out T value)
	{
		if (container.TryGetValue(key, out var value2) && ((value2 == null && default(T) == null) || value2 is T))
		{
			value = (T)value2;
			return true;
		}
		value = default(T);
		return false;
	}

	public PropertiesContainer()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		container = new Dictionary<string, object>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool P5JomNfVIrCdFwIirfgO()
	{
		return RJwN8JfVuKGXP2GvKwNs == null;
	}

	internal static PropertiesContainer u0DguWfVVbjEonBcoIrK()
	{
		return RJwN8JfVuKGXP2GvKwNs;
	}

	internal static int Chi0tNfVSNLCYngyYH7U(object P_0)
	{
		return ((Dictionary<string, object>)P_0).Count;
	}

	internal static bool LEKk13fVidnRZejeEoPe(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static Type iE4fZWfVRmwc12dp2CtP(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void qc9v0XfVqimW2IPgTdBB(object P_0)
	{
		((XmlReader)P_0).ReadStartElement();
	}

	internal static XmlNodeType iNNRbvfVKWA8OXsYaqYu(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static object VbvPo4fVXdKqiclJMOQx(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static void nkRlfCfVTs9YBtvTho8S(object P_0)
	{
		((XmlReader)P_0).ReadEndElement();
	}

	internal static object amISotfVkYcdI3Dxslqf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object lpcXIafVnmm1VehGucvM(object P_0, object P_1)
	{
		return ((XmlSerializer)P_0).Deserialize((XmlReader)P_1);
	}

	internal static void nV5sQ3fVOj6t1Bcbbr6N(object P_0, object P_1)
	{
		((XmlWriter)P_0).WriteStartElement((string)P_1);
	}

	internal static void gCtncafV2ArcoWHtk5Rp(object P_0, object P_1, object P_2)
	{
		((XmlWriter)P_0).WriteAttributeString((string)P_1, (string)P_2);
	}

	internal static void FYfqVMfVeKt3sHDLpmWL(object P_0, object P_1, object P_2)
	{
		((XmlSerializer)P_0).Serialize((XmlWriter)P_1, P_2);
	}

	internal static void LC5K1jfVPUCYu1P0Q8yU(object P_0)
	{
		((XmlWriter)P_0).WriteEndElement();
	}
}
