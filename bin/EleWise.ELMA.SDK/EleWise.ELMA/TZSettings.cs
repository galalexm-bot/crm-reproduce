using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA;

[Serializable]
public sealed class TZSettings : ISerializable, IXmlSerializable
{
	public enum TZType
	{
		Client = 0,
		Runtime = 1,
		Server = 2,
		Custom = -1,
		WithoutOffset = -2
	}

	private static TZSettings c7PWgnCKJjQQedmMcdy;

	public TZType Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public int Offset
	{
		[CompilerGenerated]
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003COffset_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public TZSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aBk3piCkYNXCyTplKJy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TZSettings(TZType type, int offset)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aBk3piCkYNXCyTplKJy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Offset = offset;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				Type = type;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public TZSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_0083, IL_00ef, IL_011c, IL_012b
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 1;
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			try
			{
				Type = (TZType)Vr3C5xCOyU9xE3TJW5R(info, EqMiVQCn5lCURYZYeZR(0x1DE3DD89 ^ 0x1DE3E56F));
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					}
					Offset = Vr3C5xCOyU9xE3TJW5R(info, EqMiVQCn5lCURYZYeZR(-951514650 ^ -951504620));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
				}
			}
			catch (Exception)
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					throw new InvalidOperationException((string)oMh1BiC2PZhjq9IcQ8a(EqMiVQCn5lCURYZYeZR(0x5F3078B6 ^ 0x5F3041B4)));
				}
			}
		}
	}

	private bool Equals(TZSettings other)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Type == KvG6lNCejSv788ePRRo(other))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return Offset == VDMcnYCP9H15ekToASp(other);
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0058, IL_0067, IL_009a
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (obj != null)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			case 5:
				return Equals((TZSettings)obj);
			default:
				return false;
			case 4:
				return false;
			case 2:
				if (this == obj)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!(obj is TZSettings))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 1:
				return true;
			}
		}
	}

	public override int GetHashCode()
	{
		return ((int)Type * 397) ^ Offset.GetHashCode();
	}

	public static bool operator ==(TZSettings left, TZSettings right)
	{
		return NZ18kNC1dctm4u19D1F(left, right);
	}

	public static bool operator !=(TZSettings left, TZSettings right)
	{
		return !NZ18kNC1dctm4u19D1F(left, right);
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_005b, IL_00cd, IL_0100, IL_010f
		switch (1)
		{
		case 1:
			try
			{
				xAp5SvCN5QarlTB6F2L(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A7DBAC), (int)Type);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					}
					xAp5SvCN5QarlTB6F2L(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870902587), Offset);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num = 1;
					}
				}
			}
			catch (Exception)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108643508)));
				}
			}
		case 0:
			break;
		}
	}

	public XmlSchema GetSchema()
	{
		return null;
	}

	public void ReadXml(XmlReader reader)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_00bb, IL_012d, IL_015b
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 5:
				return;
			case 2:
				if (reader.IsEmptyElement)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 4;
			default:
				try
				{
					Type = (TZType)fI4pd0Ca1PewOQPEaVv(DroV9JCpJWteN4r9e0t(reader, EqMiVQCn5lCURYZYeZR(0x10E41EDB ^ 0x10E4263D)));
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							Offset = Convert.ToInt32((string)DroV9JCpJWteN4r9e0t(reader, EqMiVQCn5lCURYZYeZR(-2138160520 ^ -2138146166)));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new InvalidOperationException((string)oMh1BiC2PZhjq9IcQ8a(EqMiVQCn5lCURYZYeZR(--1418440330 ^ 0x548B9788)));
					}
				}
				break;
			case 4:
				klTrcvC3gfcbBSWYYBv(reader);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				break;
			}
			hIk6aPCDtQ53rpRs1w0(reader);
			num2 = 5;
		}
	}

	public void WriteXml(XmlWriter writer)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				xybpCfCtH6UjkQbSA4H(writer, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77AF45), Offset.ToString());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				xybpCfCtH6UjkQbSA4H(writer, EqMiVQCn5lCURYZYeZR(0x6DC147B0 ^ 0x6DC17F56), ((int)Type).ToString());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void aBk3piCkYNXCyTplKJy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool kRZWZcCXrI86mg71t4h()
	{
		return (object)c7PWgnCKJjQQedmMcdy == null;
	}

	internal static TZSettings HsBqC1CTdScvbUkGUoE()
	{
		return c7PWgnCKJjQQedmMcdy;
	}

	internal static object EqMiVQCn5lCURYZYeZR(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int Vr3C5xCOyU9xE3TJW5R(object P_0, object P_1)
	{
		return ((SerializationInfo)P_0).GetInt32((string)P_1);
	}

	internal static object oMh1BiC2PZhjq9IcQ8a(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static TZType KvG6lNCejSv788ePRRo(object P_0)
	{
		return ((TZSettings)P_0).Type;
	}

	internal static int VDMcnYCP9H15ekToASp(object P_0)
	{
		return ((TZSettings)P_0).Offset;
	}

	internal static bool NZ18kNC1dctm4u19D1F(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void xAp5SvCN5QarlTB6F2L(object P_0, object P_1, int P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static void klTrcvC3gfcbBSWYYBv(object P_0)
	{
		((XmlReader)P_0).ReadStartElement();
	}

	internal static object DroV9JCpJWteN4r9e0t(object P_0, object P_1)
	{
		return ((XmlReader)P_0).ReadElementString((string)P_1);
	}

	internal static int fI4pd0Ca1PewOQPEaVv(object P_0)
	{
		return int.Parse((string)P_0);
	}

	internal static void hIk6aPCDtQ53rpRs1w0(object P_0)
	{
		((XmlReader)P_0).ReadEndElement();
	}

	internal static void xybpCfCtH6UjkQbSA4H(object P_0, object P_1, object P_2)
	{
		((XmlWriter)P_0).WriteElementString((string)P_1, (string)P_2);
	}
}
