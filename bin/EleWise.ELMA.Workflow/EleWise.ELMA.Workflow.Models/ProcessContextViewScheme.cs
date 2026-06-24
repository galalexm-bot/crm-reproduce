using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
[XmlExport]
[Component]
public class ProcessContextViewScheme : ISerializable, IXsiRoot
{
	private static ProcessContextViewScheme wliLxaOHgsPb9AsQ9udI;

	public SwimlaneContextViewScheme Default
	{
		[CompilerGenerated]
		get
		{
			return _003CDefault_003Ek__BackingField;
		}
		[CompilerGenerated]
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
					_003CDefault_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<SwimlaneContextViewScheme> Swimlanes { get; set; }

	public ProcessContextViewScheme()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Default = new SwimlaneContextViewScheme();
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				Swimlanes = new List<SwimlaneContextViewScheme>();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	protected ProcessContextViewScheme(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_00a1, IL_00b0, IL_00bb, IL_0155, IL_018d, IL_019c, IL_01ac, IL_01bb
		mGZRbkOHPFWfAKN4q8Pf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
		{
			num = 0;
		}
		string xml = default(string);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			case 1:
				xml = (string)oWdMSvOHdQsyqDYpS1HM(info, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1001989756), HgbHeZOHXmTDNoFGl90S(typeof(string).TypeHandle));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
				{
					num = 3;
				}
				continue;
			case 4:
				try
				{
					while (true)
					{
						int num2;
						if (!UPHcdMOHnYvpPodxBKk7(enumerator))
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
							{
								num2 = 0;
							}
							goto IL_00bf;
						}
						goto IL_011c;
						IL_011c:
						current = enumerator.Current;
						num2 = 3;
						goto IL_00bf;
						IL_00bf:
						while (true)
						{
							switch (num2)
							{
							default:
								return;
							case 3:
								xqUHffOHD7SfgSYvMSW5(current, this, current.GetValue(obj, null), null);
								num2 = 2;
								continue;
							case 2:
								break;
							case 1:
								goto IL_011c;
							case 0:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								jhRlZFOHHUkArWVgZB6j(enumerator);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 5:
				return;
			case 3:
				obj = ClassSerializationHelper.DeserializeObjectByXml(WTq80VOHur0n7Pr6Svpn(this), xml);
				num = 6;
				continue;
			case 2:
				return;
			case 6:
				if (obj == null)
				{
					num = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num = 3;
					}
					continue;
				}
				break;
			}
			enumerator = obj.GetType().GetProperties().Where(delegate(PropertyInfo p)
			{
				//Discarded unreachable code: IL_0031
				int num4 = 1;
				int num5 = num4;
				while (true)
				{
					switch (num5)
					{
					case 1:
						if (!_003C_003Ec.p2tBDLvYeWks1AZd37uY(p))
						{
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
							{
								num5 = 0;
							}
							continue;
						}
						goto case 3;
					case 3:
						if (_003C_003Ec.vSypbPvYNmwaYqGw2MkX(p))
						{
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
							{
								num5 = 2;
							}
							continue;
						}
						break;
					case 2:
						return AttributeHelper<XmlIgnoreAttribute>.GetAttribute(p, inherited: true) == null;
					}
					break;
				}
				return false;
			})
				.GetEnumerator();
			num = 4;
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
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
				VNSTSfOH9OHA19RU9Ht9(info, h9Ldb7OHLvv4yyuPef5V(0x628167BE ^ 0x6280915A), wsVotpOHf5aqSoDYfkjO(this, true));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool UXnvONOHBZdGlFXWduvq()
	{
		return wliLxaOHgsPb9AsQ9udI == null;
	}

	internal static ProcessContextViewScheme S5kvLcOHcKg3akApUYSG()
	{
		return wliLxaOHgsPb9AsQ9udI;
	}

	internal static void mGZRbkOHPFWfAKN4q8Pf()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Type HgbHeZOHXmTDNoFGl90S(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object oWdMSvOHdQsyqDYpS1HM(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static Type WTq80VOHur0n7Pr6Svpn(object P_0)
	{
		return P_0.GetType();
	}

	internal static void xqUHffOHD7SfgSYvMSW5(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool UPHcdMOHnYvpPodxBKk7(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void jhRlZFOHHUkArWVgZB6j(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object h9Ldb7OHLvv4yyuPef5V(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object wsVotpOHf5aqSoDYfkjO(object P_0, bool P_1)
	{
		return ClassSerializationHelper.SerializeObjectByXml(P_0, P_1);
	}

	internal static void VNSTSfOH9OHA19RU9Ht9(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
