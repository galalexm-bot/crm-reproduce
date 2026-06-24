using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public class NotificationRecipientSet
{
	private static NotificationRecipientSet UcdOxUwWt70ximRriB8;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool Clear
	{
		[CompilerGenerated]
		get
		{
			return _003CClear_003Ek__BackingField;
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
					_003CClear_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
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

	public bool SendToAuthorOnly
	{
		[CompilerGenerated]
		get
		{
			return _003CSendToAuthorOnly_003Ek__BackingField;
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
					_003CSendToAuthorOnly_003Ek__BackingField = value;
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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

	public List<NotificationRecipientItem> Items { get; set; }

	public virtual IEnumerable<object> GetRecipients(INotification notification)
	{
		List<object> list = new List<object>();
		if (Condition == null || Condition.Evaluate(notification))
		{
			foreach (NotificationRecipientItem item in Items)
			{
				IEnumerable<object> recipients = item.GetRecipients(notification);
				if (recipients != null)
				{
					list.AddRange(recipients);
				}
			}
			return list;
		}
		return list;
	}

	public NotificationRecipientSet Clone()
	{
		NotificationRecipientSet notificationRecipientSet = new NotificationRecipientSet();
		GL0BHDwhBkUrGK2HoF7(notificationRecipientSet, Clear);
		dxemyTwGDnV5FUFtyw0(notificationRecipientSet, Condition);
		notificationRecipientSet.Items = Items.ToList();
		NlQYoGwEXPWXNLqE6Rr(notificationRecipientSet, Name);
		ovaKq9wfJu0ujhIYV0j(notificationRecipientSet, SendToAuthorOnly);
		return notificationRecipientSet;
	}

	protected NotificationRecipientSet()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VNmuEZwQtVInjUijBgQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public NotificationRecipientSet(XmlElement node)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_0097, IL_00aa, IL_00b9, IL_00da, IL_00e9, IL_00f9, IL_0160, IL_016f, IL_017f
		SingletonReader.PushGlobal();
		base._002Ector();
		int num = 14;
		XmlElement xmlElement = default(XmlElement);
		XmlNode xmlNode = default(XmlNode);
		NotificationRecipientItem item = default(NotificationRecipientItem);
		while (true)
		{
			switch (num)
			{
			case 20:
				return;
			case 13:
				if (xmlElement != null)
				{
					num = 5;
					break;
				}
				goto case 15;
			case 24:
				if (r9phBWw8hKAXT0OlGbW(FaAXUUwC9pi1gmbiUMq(node), kYnNNhwvtyTUP9PUiIL(0x1FFEF86A ^ 0x1FFE8BAA)) != null)
				{
					num = 16;
					break;
				}
				goto case 11;
			case 14:
				Name = string.Empty;
				num = 24;
				break;
			case 2:
			case 4:
				xmlElement = xmlNode as XmlElement;
				num = 13;
				break;
			case 9:
				Items = new List<NotificationRecipientItem>();
				num = 22;
				break;
			case 1:
			case 10:
				item = new NotificationRecipientItem(xmlElement);
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num = 5;
				}
				break;
			case 6:
				if (r9phBWw8hKAXT0OlGbW(FaAXUUwC9pi1gmbiUMq(node), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335028089)) != null)
				{
					num = 12;
					break;
				}
				goto case 9;
			case 18:
				xmlNode = (XmlNode)SvBFC8wIsQe6qWLb9pc(xmlNode);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num = 0;
				}
				break;
			case 12:
				SendToAuthorOnly = ((string)b0obbQwZV3ochBY2adi(r9phBWw8hKAXT0OlGbW(FaAXUUwC9pi1gmbiUMq(node), kYnNNhwvtyTUP9PUiIL(-2107978722 ^ -2108012906)))).Equals((string)kYnNNhwvtyTUP9PUiIL(0x269E5FCA ^ 0x269E45C4), StringComparison.CurrentCultureIgnoreCase);
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num = 9;
				}
				break;
			case 8:
				Items.Add(item);
				num = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num = 11;
				}
				break;
			case 15:
				xmlNode = (XmlNode)SvBFC8wIsQe6qWLb9pc(xmlNode);
				num = 3;
				break;
			case 5:
			case 17:
				if (!fB1eBAwSDR9GL77GRsq(X50AvuwV3uMq6GssSsy(xmlElement), kYnNNhwvtyTUP9PUiIL(-1487388570 ^ -1487353142)))
				{
					num = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num = 4;
					}
					break;
				}
				goto case 23;
			case 16:
				Name = (string)b0obbQwZV3ochBY2adi(r9phBWw8hKAXT0OlGbW(FaAXUUwC9pi1gmbiUMq(node), kYnNNhwvtyTUP9PUiIL(0x10E41EDB ^ 0x10E46D1B)));
				num = 11;
				break;
			case 23:
				Condition = new NotificationTemplateFilterCondition(xmlElement);
				num = 7;
				break;
			case 19:
				Clear = ((XmlNode)r9phBWw8hKAXT0OlGbW(FaAXUUwC9pi1gmbiUMq(node), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921233479))).Value.Equals((string)kYnNNhwvtyTUP9PUiIL(0x3A5D5EF ^ 0x3A5CFE1), StringComparison.CurrentCultureIgnoreCase);
				num = 6;
				break;
			case 11:
				if (((XmlAttributeCollection)FaAXUUwC9pi1gmbiUMq(node))[(string)kYnNNhwvtyTUP9PUiIL(0x571EA399 ^ 0x571E29E3)] != null)
				{
					num = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num = 19;
					}
					break;
				}
				goto case 6;
			default:
				if (xmlNode == null)
				{
					return;
				}
				num = 4;
				break;
			case 22:
				xmlNode = (XmlNode)gFxdSewuAxJMmLVt9iy(node);
				num = 21;
				break;
			}
		}
	}

	internal static bool pktgbwwoS4WNGXAEyjN()
	{
		return UcdOxUwWt70ximRriB8 == null;
	}

	internal static NotificationRecipientSet ye6J69wbwO6oUPYB7Vr()
	{
		return UcdOxUwWt70ximRriB8;
	}

	internal static void GL0BHDwhBkUrGK2HoF7(object P_0, bool value)
	{
		((NotificationRecipientSet)P_0).Clear = value;
	}

	internal static void dxemyTwGDnV5FUFtyw0(object P_0, object P_1)
	{
		((NotificationRecipientSet)P_0).Condition = (NotificationTemplateFilterCondition)P_1;
	}

	internal static void NlQYoGwEXPWXNLqE6Rr(object P_0, object P_1)
	{
		((NotificationRecipientSet)P_0).Name = (string)P_1;
	}

	internal static void ovaKq9wfJu0ujhIYV0j(object P_0, bool value)
	{
		((NotificationRecipientSet)P_0).SendToAuthorOnly = value;
	}

	internal static void VNmuEZwQtVInjUijBgQ()
	{
		SingletonReader.PushGlobal();
	}

	internal static object FaAXUUwC9pi1gmbiUMq(object P_0)
	{
		return ((XmlNode)P_0).Attributes;
	}

	internal static object kYnNNhwvtyTUP9PUiIL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object r9phBWw8hKAXT0OlGbW(object P_0, object P_1)
	{
		return ((XmlAttributeCollection)P_0)[(string)P_1];
	}

	internal static object b0obbQwZV3ochBY2adi(object P_0)
	{
		return ((XmlNode)P_0).Value;
	}

	internal static object gFxdSewuAxJMmLVt9iy(object P_0)
	{
		return ((XmlNode)P_0).FirstChild;
	}

	internal static object SvBFC8wIsQe6qWLb9pc(object P_0)
	{
		return ((XmlNode)P_0).NextSibling;
	}

	internal static object X50AvuwV3uMq6GssSsy(object P_0)
	{
		return ((XmlNode)P_0).Name;
	}

	internal static bool fB1eBAwSDR9GL77GRsq(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
