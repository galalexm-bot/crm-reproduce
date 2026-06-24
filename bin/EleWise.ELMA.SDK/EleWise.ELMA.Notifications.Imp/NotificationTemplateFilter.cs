using System;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public class NotificationTemplateFilter
{
	internal static NotificationTemplateFilter RdmUjZwmSCCxhUEkMHP;

	public string Event
	{
		[CompilerGenerated]
		get
		{
			return _003CEvent_003Ek__BackingField;
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
					_003CEvent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ObjectName
	{
		[CompilerGenerated]
		get
		{
			return _003CObjectName_003Ek__BackingField;
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
					_003CObjectName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
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

	public bool ObjectInherit
	{
		[CompilerGenerated]
		get
		{
			return _003CObjectInherit_003Ek__BackingField;
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
					_003CObjectInherit_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ActionName
	{
		[CompilerGenerated]
		get
		{
			return _003CActionName_003Ek__BackingField;
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
					_003CActionName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
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

	public NotificationTemplateFilterCondition Condition
	{
		[CompilerGenerated]
		get
		{
			return _003CCondition_003Ek__BackingField;
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
					_003CCondition_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
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

	public virtual bool Check(INotification notification)
	{
		//Discarded unreachable code: IL_0098, IL_0125, IL_0134, IL_016f, IL_01a5, IL_023f, IL_024e, IL_025e, IL_026d, IL_029f
		int num = 17;
		IEventNotification eventNotification = default(IEventNotification);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					if (QRdOyowgLFS7pkc7XUW(hshaPtwrQreJLHt5LwP(eventNotification)) != null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 9:
					if (hshaPtwrQreJLHt5LwP(eventNotification) != null)
					{
						num2 = 15;
						break;
					}
					goto case 2;
				case 1:
					if (eventNotification != null)
					{
						num2 = 12;
						break;
					}
					goto case 7;
				case 12:
					if (Event != null)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 8;
						}
						break;
					}
					goto default;
				case 14:
					if (oMvV9Wwd4Dy2mXFv1O0(v63NQBw9bkndBXGlYrd(eventNotification), Event, StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 21:
					if (ngM3tJw558gCcTk7PQd(Condition, notification))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 13;
						}
						break;
					}
					goto case 20;
				case 11:
					if (oMvV9Wwd4Dy2mXFv1O0(QRdOyowgLFS7pkc7XUW(hshaPtwrQreJLHt5LwP(eventNotification)), ActionName, StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 4;
						break;
					}
					goto case 2;
				case 2:
					return false;
				case 4:
				case 5:
					if (Condition == null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 21;
				case 17:
					Contract.ArgumentNotNull(notification, (string)e3uU8qwJSDVsXs3TI4w(0x42643203 ^ 0x4264B40D));
					num2 = 16;
					break;
				case 10:
					return false;
				case 8:
					if (ActionName == null)
					{
						num2 = 5;
						break;
					}
					goto case 9;
				case 18:
					if (v63NQBw9bkndBXGlYrd(eventNotification) == null)
					{
						num2 = 19;
						break;
					}
					goto case 14;
				case 3:
				case 19:
					return false;
				default:
					if (ObjectName != null)
					{
						num2 = 6;
						break;
					}
					goto case 8;
				case 16:
					eventNotification = notification as IEventNotification;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 1;
					}
					break;
				case 20:
					return false;
				case 7:
				case 13:
					return true;
				case 6:
					if (IsChildOf((IAuditObject)MKLD6ywlKSSR1QtndGt(eventNotification), ObjectName))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 8;
						}
						break;
					}
					goto case 10;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	public NotificationTemplateFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bv6DP0wj3rXbfk6tBf3();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ObjectInherit = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public NotificationTemplateFilter(XmlElement node)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ObjectInherit = true;
				num = 2;
				break;
			case 0:
				return;
			case 2:
				Parse(node);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Parse(XmlElement node)
	{
		//Discarded unreachable code: IL_008d, IL_009c, IL_013c, IL_014b, IL_01aa, IL_01b9, IL_01c8, IL_02ed, IL_0370, IL_037f, IL_03a5, IL_03b8
		int num = 18;
		XmlNode xmlNode = default(XmlNode);
		XmlElement xmlElement = default(XmlElement);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
					return;
				case 6:
					ObjectInherit = oMvV9Wwd4Dy2mXFv1O0(eO9U0e4WR7gh7pnLduc(UQABG14Ba5ArHgLh0UP(t7QAWX4F2uqisDmXslA(xmlNode), e3uU8qwJSDVsXs3TI4w(-740338220 ^ -740304816))), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767754643), StringComparison.CurrentCultureIgnoreCase);
					num2 = 23;
					continue;
				case 8:
					ActionName = (string)obVNxjwz0G5A0QWZL9F(KgFIKNws7oQsbMPIdBB(xmlNode), mr5Qt7wc8I3T4ore376(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A6847C)));
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 11;
					}
					continue;
				case 13:
					xmlNode = (XmlNode)k2LLTuwYS01Jotau79p(xmlNode);
					num2 = 4;
					continue;
				case 26:
					Condition = new NotificationTemplateFilterCondition(xmlElement);
					num2 = 14;
					continue;
				case 7:
					if (!qAnJnnwUksSEIJF31I2(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53C21D7)))
					{
						num2 = 9;
						continue;
					}
					goto case 8;
				case 21:
					if (!qAnJnnwUksSEIJF31I2(text, e3uU8qwJSDVsXs3TI4w(-1217523399 ^ -1217487761)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 20:
					if (xmlElement != null)
					{
						num2 = 25;
						continue;
					}
					goto case 13;
				case 3:
				case 25:
					text = (string)g8Si4kwLSJRxjLsomde(xmlNode);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 11;
					}
					continue;
				case 15:
					if (((XmlAttributeCollection)t7QAWX4F2uqisDmXslA(xmlNode))[(string)e3uU8qwJSDVsXs3TI4w(0xE1229CF ^ 0xE12A44B)] != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 11;
				case 9:
					if (!qAnJnnwUksSEIJF31I2(text, e3uU8qwJSDVsXs3TI4w(-29254301 ^ -29288497)))
					{
						num2 = 12;
						continue;
					}
					goto case 26;
				case 4:
				case 17:
				case 19:
					if (xmlNode == null)
					{
						return;
					}
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 24;
					}
					continue;
				case 10:
				case 24:
					xmlElement = xmlNode as XmlElement;
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 17;
					}
					continue;
				default:
					if (text == (string)e3uU8qwJSDVsXs3TI4w(-978351861 ^ -978385809))
					{
						num = 2;
						break;
					}
					goto case 7;
				case 11:
				case 12:
				case 14:
				case 22:
				case 23:
					xmlNode = (XmlNode)k2LLTuwYS01Jotau79p(xmlNode);
					num2 = 19;
					continue;
				case 1:
				case 2:
					ObjectName = (string)obVNxjwz0G5A0QWZL9F(xmlNode.InnerXml, mr5Qt7wc8I3T4ore376(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740359272)));
					num2 = 15;
					continue;
				case 18:
					xmlNode = node.FirstChild;
					num = 17;
					break;
				case 5:
					Event = (string)obVNxjwz0G5A0QWZL9F(KgFIKNws7oQsbMPIdBB(xmlNode), mr5Qt7wc8I3T4ore376(e3uU8qwJSDVsXs3TI4w(-787452571 ^ -787465431)));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	private bool IsChildOf(IAuditObject obj, string name)
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_0075, IL_0084
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (Mm86Ss4brdnqNrpucCk(obj) != null)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 7:
					if (obj == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto default;
				case 5:
					return true;
				case 3:
					return IsChildOf((IAuditObject)Mm86Ss4brdnqNrpucCk(obj), name);
				case 2:
					return false;
				default:
					if (obj.Name == null)
					{
						num2 = 4;
						break;
					}
					if (oMvV9Wwd4Dy2mXFv1O0(UXumUx4on14q54FF87Y(obj), name, StringComparison.CurrentCultureIgnoreCase))
					{
						goto end_IL_0012;
					}
					if (!ObjectInherit)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 1;
				case 4:
				case 6:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	internal static bool l413SlwyxxOkbK1v84P()
	{
		return RdmUjZwmSCCxhUEkMHP == null;
	}

	internal static NotificationTemplateFilter zKUoqYwMh9O49iGR0O5()
	{
		return RdmUjZwmSCCxhUEkMHP;
	}

	internal static object e3uU8qwJSDVsXs3TI4w(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object v63NQBw9bkndBXGlYrd(object P_0)
	{
		return ((IEventNotification)P_0).Event;
	}

	internal static bool oMvV9Wwd4Dy2mXFv1O0(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object MKLD6ywlKSSR1QtndGt(object P_0)
	{
		return ((IEventNotification)P_0).Object;
	}

	internal static object hshaPtwrQreJLHt5LwP(object P_0)
	{
		return ((IEventNotification)P_0).Action;
	}

	internal static object QRdOyowgLFS7pkc7XUW(object P_0)
	{
		return ((IAuditAction)P_0).Name;
	}

	internal static bool ngM3tJw558gCcTk7PQd(object P_0, object P_1)
	{
		return ((NotificationTemplateFilterCondition)P_0).Evaluate(P_1);
	}

	internal static void bv6DP0wj3rXbfk6tBf3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object k2LLTuwYS01Jotau79p(object P_0)
	{
		return ((XmlNode)P_0).NextSibling;
	}

	internal static object g8Si4kwLSJRxjLsomde(object P_0)
	{
		return ((XmlNode)P_0).Name;
	}

	internal static bool qAnJnnwUksSEIJF31I2(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object KgFIKNws7oQsbMPIdBB(object P_0)
	{
		return ((XmlNode)P_0).InnerXml;
	}

	internal static object mr5Qt7wc8I3T4ore376(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object obVNxjwz0G5A0QWZL9F(object P_0, object P_1)
	{
		return ((string)P_0).Trim((char[])P_1);
	}

	internal static object t7QAWX4F2uqisDmXslA(object P_0)
	{
		return ((XmlNode)P_0).Attributes;
	}

	internal static object UQABG14Ba5ArHgLh0UP(object P_0, object P_1)
	{
		return ((XmlAttributeCollection)P_0)[(string)P_1];
	}

	internal static object eO9U0e4WR7gh7pnLduc(object P_0)
	{
		return ((XmlNode)P_0).Value;
	}

	internal static object UXumUx4on14q54FF87Y(object P_0)
	{
		return ((IAuditObject)P_0).Name;
	}

	internal static object Mm86Ss4brdnqNrpucCk(object P_0)
	{
		return ((IAuditObject)P_0).Parent;
	}
}
