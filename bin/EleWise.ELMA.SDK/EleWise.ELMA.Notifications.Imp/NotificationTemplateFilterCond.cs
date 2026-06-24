using System;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public class NotificationTemplateFilterCondition
{
	private readonly ExpressionTemplateEvaluator expressionEvaluator;

	private static NotificationTemplateFilterCondition nKPJ19th44Nr9SHEVM9;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool Evaluate(object notificationDataSource)
	{
		int num = 1;
		int num2 = num;
		FormatedValue formatedValue = default(FormatedValue);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (formatedValue != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto IL_0093;
			default:
				return false;
			case 2:
				if (UdAcYjtQFA4jAyFTQoo(formatedValue) is bool)
				{
					num2 = 4;
					break;
				}
				goto IL_0093;
			case 4:
				return (bool)UdAcYjtQFA4jAyFTQoo(formatedValue);
			case 1:
				{
					if (expressionEvaluator != null)
					{
						formatedValue = (FormatedValue)jGJ1Xwtfjks98G6CuTc(expressionEvaluator, notificationDataSource);
						num2 = 3;
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
				IL_0093:
				return false;
			}
		}
	}

	public NotificationTemplateFilterCondition(string expressionText)
	{
		//Discarded unreachable code: IL_001e, IL_008a, IL_00ed, IL_0123, IL_0132
		FeTyN0tCdWdGCIXZTRL();
		base._002Ector();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				ExpressionText = expressionText;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return;
			}
			try
			{
				if (string.IsNullOrEmpty(ExpressionText))
				{
					return;
				}
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						expressionEvaluator = new ExpressionTemplateEvaluator(ExpressionText);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			}
			catch (Exception innerException)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				default:
					throw new Exception((string)Hofl91t8loCutPp5kZ5(AW2EQjtvsBb7WmBQWql(--1333735954 ^ 0x4F7FB5A2), ExpressionText), innerException);
				}
			}
		}
	}

	public NotificationTemplateFilterCondition(XmlElement node)
	{
		//Discarded unreachable code: IL_0050, IL_0055
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(((string)AnkpTHtZjMU8WYXlGlq(node)).Trim((char[])viYODStubxZ72lNCLfJ(AW2EQjtvsBb7WmBQWql(-195614443 ^ -195592359))));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qaGa1OtGvNeBmmtE5Z7()
	{
		return nKPJ19th44Nr9SHEVM9 == null;
	}

	internal static NotificationTemplateFilterCondition VS0LRFtEROKZihbqr4O()
	{
		return nKPJ19th44Nr9SHEVM9;
	}

	internal static object jGJ1Xwtfjks98G6CuTc(object P_0, object P_1)
	{
		return ((ExpressionEvaluator)P_0).Evaluate(P_1);
	}

	internal static object UdAcYjtQFA4jAyFTQoo(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static void FeTyN0tCdWdGCIXZTRL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object AW2EQjtvsBb7WmBQWql(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Hofl91t8loCutPp5kZ5(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object AnkpTHtZjMU8WYXlGlq(object P_0)
	{
		return ((XmlNode)P_0).InnerXml;
	}

	internal static object viYODStubxZ72lNCLfJ(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}
}
