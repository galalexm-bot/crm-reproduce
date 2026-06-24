using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public class NotificationRecipientItem
{
	private readonly ExpressionTemplateEvaluator expressionEvaluator;

	internal static NotificationRecipientItem HHZvCutdnbvHbVti8eL;

	public string TypeName
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeName_003Ek__BackingField;
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
					_003CTypeName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
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

	public string ExpressionText
	{
		[CompilerGenerated]
		get
		{
			return _003CExpressionText_003Ek__BackingField;
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
					_003CExpressionText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
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
				case 0:
					return;
				case 1:
					_003CCondition_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<object> GetRecipients(INotification notification)
	{
		if (expressionEvaluator == null)
		{
			return null;
		}
		if (Condition == null || Condition.Evaluate(notification))
		{
			INotificationRecipientTypeHandler notificationRecipientTypeHandler = ComponentManager.Current.GetExtensionPoints<INotificationRecipientTypeHandler>().FirstOrDefault((INotificationRecipientTypeHandler rth) => MsZ7AWwBIwuhdGrl8aI(HhtYPOwFLQ1liaGKL5e(rth), TypeName));
			if (notificationRecipientTypeHandler == null)
			{
				Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858918321), TypeName));
				return null;
			}
			object value = expressionEvaluator.Evaluate(notification)?.Value;
			return notificationRecipientTypeHandler.GetRecipients(value);
		}
		return null;
	}

	public NotificationRecipientItem(XmlElement node)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_0157, IL_0166, IL_01c2, IL_020d, IL_021c, IL_0248, IL_027d, IL_028c, IL_02d9
		PEWfyBtgavkwew23aZ8();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		XmlAttribute xmlAttribute = default(XmlAttribute);
		while (true)
		{
			switch (num)
			{
			case 8:
				return;
			case 3:
				if (node == null)
				{
					num = 7;
					continue;
				}
				TypeName = (string)u4Dw1TtjThF7MaYwBdC(node);
				num = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num = 11;
				}
				continue;
			case 7:
				throw new ArgumentNullException((string)ViB08Lt5l0M6XCvChoW(0x463A0F3C ^ 0x463A8564));
			case 11:
				ExpressionText = ((string)Xn9C6etYZuNxEug8u4B(node)).Trim((char[])gca7mbtLUxokMAsKwiL(ViB08Lt5l0M6XCvChoW(0x5F3078B6 ^ 0x5F302EFA)));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num = 1;
				}
				continue;
			case 1:
				xmlAttribute = ((XmlAttributeCollection)n0QqJJtUDq7SHOjk5E4(node))[(string)ViB08Lt5l0M6XCvChoW(0x66F566B6 ^ 0x66F5ECD2)];
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 4;
				}
				continue;
			case 2:
			case 9:
			case 10:
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 0;
				}
				continue;
			case 5:
				if (xmlAttribute.Value == null)
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 6;
			case 6:
				Condition = new NotificationTemplateFilterCondition((string)M07qwptsl8ViZd3Cw7D(xmlAttribute));
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num = 9;
				}
				continue;
			case 4:
				if (xmlAttribute == null)
				{
					num = 10;
					continue;
				}
				goto case 5;
			}
			try
			{
				int num2;
				if (vPrh0ktc0L6XAgislry(ExpressionText))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 2;
					}
					goto IL_01c6;
				}
				goto IL_01dc;
				IL_01dc:
				expressionEvaluator = new ExpressionTemplateEvaluator(ExpressionText);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 1;
				}
				goto IL_01c6;
				IL_01c6:
				switch (num2)
				{
				case 1:
					return;
				case 2:
					return;
				}
				goto IL_01dc;
			}
			catch (Exception innerException)
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					throw new Exception((string)CW8GnntzYEiuPTSawKg(ViB08Lt5l0M6XCvChoW(0x3C5338FF ^ 0x3C53BF4F), ExpressionText), innerException);
				}
			}
		}
	}

	internal static bool zPgdXutl9wDG9a7HbSq()
	{
		return HHZvCutdnbvHbVti8eL == null;
	}

	internal static NotificationRecipientItem amxTqNtrGmtwh0h3FYW()
	{
		return HHZvCutdnbvHbVti8eL;
	}

	internal static void PEWfyBtgavkwew23aZ8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object ViB08Lt5l0M6XCvChoW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object u4Dw1TtjThF7MaYwBdC(object P_0)
	{
		return ((XmlNode)P_0).Name;
	}

	internal static object Xn9C6etYZuNxEug8u4B(object P_0)
	{
		return ((XmlNode)P_0).InnerXml;
	}

	internal static object gca7mbtLUxokMAsKwiL(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object n0QqJJtUDq7SHOjk5E4(object P_0)
	{
		return ((XmlNode)P_0).Attributes;
	}

	internal static object M07qwptsl8ViZd3Cw7D(object P_0)
	{
		return ((XmlNode)P_0).Value;
	}

	internal static bool vPrh0ktc0L6XAgislry(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object CW8GnntzYEiuPTSawKg(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object HhtYPOwFLQ1liaGKL5e(object P_0)
	{
		return ((INotificationRecipientTypeHandler)P_0).Name;
	}

	internal static bool MsZ7AWwBIwuhdGrl8aI(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
