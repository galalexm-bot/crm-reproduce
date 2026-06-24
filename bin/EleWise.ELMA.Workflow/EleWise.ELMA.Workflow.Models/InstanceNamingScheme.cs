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
public class InstanceNamingScheme : ISerializable, IXsiRoot
{
	public enum SchemeType
	{
		Standart,
		Template
	}

	private static InstanceNamingScheme FVNrNIOnU49jnSVm3RWM;

	public SchemeType Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
				case 1:
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
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

	public string TemplateText
	{
		[CompilerGenerated]
		get
		{
			return _003CTemplateText_003Ek__BackingField;
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
				case 1:
					_003CTemplateText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
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

	public bool AskNameOnStart
	{
		[CompilerGenerated]
		get
		{
			return _003CAskNameOnStart_003Ek__BackingField;
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
				case 1:
					_003CAskNameOnStart_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
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

	public InstanceNamingScheme()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uuBNraOnGIOdL5mfQXKf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				AskNameOnStart = true;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				Type = SchemeType.Standart;
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}

	protected InstanceNamingScheme(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_005f, IL_006e, IL_00a0, IL_00af, IL_00ba, IL_0154, IL_018c, IL_019b
		uuBNraOnGIOdL5mfQXKf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
		{
			num = 0;
		}
		object obj = default(object);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		string xml = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 5:
				if (obj == null)
				{
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						int num2;
						if (!vgx05OOnIqx5FNMseHBr(enumerator))
						{
							num2 = 3;
							goto IL_00be;
						}
						goto IL_011b;
						IL_00be:
						while (true)
						{
							switch (num2)
							{
							case 3:
								return;
							case 2:
								gfBUMbOnixQ24VJPunwZ(current, this, YE4XiAOnFZjTkOxuPtPD(current, obj, null), null);
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
								{
									num2 = 0;
								}
								continue;
							case 1:
								break;
							default:
								goto IL_011b;
							}
							break;
						}
						continue;
						IL_011b:
						current = enumerator.Current;
						num2 = 2;
						goto IL_00be;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								lAli7fOnaLKaaF4hI3sn(enumerator);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
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
				}
			case 4:
				obj = ClassSerializationHelper.DeserializeObjectByXml(GetType(), xml);
				num = 5;
				continue;
			case 1:
				xml = (string)hJvNgnOnoxTIGlDx9VWO(info, Ec9uHNOn7WXOvZyK8FRH(-10408775 ^ -10429859), U9r7ptOn2mUKSCOngur3(typeof(string).TypeHandle));
				num = 4;
				continue;
			case 6:
				break;
			}
			enumerator = obj.GetType().GetProperties().Where(delegate(PropertyInfo p)
			{
				//Discarded unreachable code: IL_003e, IL_004d
				int num4 = 3;
				int num5 = num4;
				while (true)
				{
					switch (num5)
					{
					case 1:
						return AttributeHelper<XmlIgnoreAttribute>.GetAttribute(p, inherited: true) == null;
					default:
						return false;
					case 3:
						if (_003C_003Ec.BA2obpvYiAAKQ9LDuAP7(p))
						{
							num5 = 2;
							break;
						}
						goto default;
					case 2:
						if (!p.CanWrite)
						{
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
							{
								num5 = 0;
							}
							break;
						}
						goto case 1;
					}
				}
			})
				.GetEnumerator();
			num = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
			{
				num = 2;
			}
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
			case 0:
				return;
			case 1:
				VBK641OneOx1mjBTEdKc(info, Ec9uHNOn7WXOvZyK8FRH(0x747FFBE0 ^ 0x747E0D04), EqgdEPOnrdaWVM8AOuGP(this, true));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void uuBNraOnGIOdL5mfQXKf()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool xu2RMvOnVywabpIASVMX()
	{
		return FVNrNIOnU49jnSVm3RWM == null;
	}

	internal static InstanceNamingScheme yZ2gWDOnA2VAHFJu0pa2()
	{
		return FVNrNIOnU49jnSVm3RWM;
	}

	internal static object Ec9uHNOn7WXOvZyK8FRH(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type U9r7ptOn2mUKSCOngur3(RuntimeTypeHandle P_0)
	{
		return System.Type.GetTypeFromHandle(P_0);
	}

	internal static object hJvNgnOnoxTIGlDx9VWO(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static object YE4XiAOnFZjTkOxuPtPD(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void gfBUMbOnixQ24VJPunwZ(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool vgx05OOnIqx5FNMseHBr(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void lAli7fOnaLKaaF4hI3sn(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object EqgdEPOnrdaWVM8AOuGP(object P_0, bool P_1)
	{
		return ClassSerializationHelper.SerializeObjectByXml(P_0, P_1);
	}

	internal static void VBK641OneOx1mjBTEdKc(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
