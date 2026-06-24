using System;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public class NotificationTemplateObject
{
	private readonly ExpressionTemplateEvaluator expressionEvaluator;

	internal static NotificationTemplateObject w27EkJ6BZObj1mcEa1r;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public NotificationTemplateObject()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		l4Fs4K6bM9nCp5YqgqY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public string GetObjectId(object notificationDataSource)
	{
		//Discarded unreachable code: IL_009d, IL_00ac, IL_00bd, IL_00c7, IL_00d6
		int num = 4;
		FormatedValue formatedValue = default(FormatedValue);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					return null;
				case 3:
					goto end_IL_0012;
				case 4:
					if (expressionEvaluator != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 5:
					if (formatedValue != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				default:
					obj = null;
					break;
				case 2:
					obj = formatedValue.Value;
					break;
				}
				return (string)zyiC656GEACMKufYitx(obj);
				continue;
				end_IL_0012:
				break;
			}
			formatedValue = (FormatedValue)cXX34e6huD3NDiC1Ak5(expressionEvaluator, notificationDataSource);
			num = 5;
		}
	}

	public NotificationTemplateObject(XmlElement node)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_00a5, IL_0108, IL_0143, IL_0152
		SingletonReader.JJCZtPuTvSt();
		this._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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
				break;
			case 0:
				return;
			case 2:
				try
				{
					if (string.IsNullOrEmpty(ExpressionText))
					{
						return;
					}
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
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
						expressionEvaluator = new ExpressionTemplateEvaluator(ExpressionText);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 0;
						}
					}
				}
				catch (Exception innerException)
				{
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						throw new Exception((string)WDbcdr6CfuAXus1SkNQ(cYlD7r6fRRnfMsYAMqJ(-576149596 ^ -576184300), ExpressionText), innerException);
					}
				}
			}
			ExpressionText = (string)rsC3PV6QBJOeQ23wEV7(jO8CD86EcUthf62eV2D(node), ((string)cYlD7r6fRRnfMsYAMqJ(-1978478350 ^ -1978497346)).ToCharArray());
			num = 2;
		}
	}

	internal static bool F5SUy66WULLHqAXm2uR()
	{
		return w27EkJ6BZObj1mcEa1r == null;
	}

	internal static NotificationTemplateObject k7kwdM6oL37F5MiuhGh()
	{
		return w27EkJ6BZObj1mcEa1r;
	}

	internal static void l4Fs4K6bM9nCp5YqgqY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object cXX34e6huD3NDiC1Ak5(object P_0, object P_1)
	{
		return ((ExpressionEvaluator)P_0).Evaluate(P_1);
	}

	internal static object zyiC656GEACMKufYitx(object P_0)
	{
		return Convert.ToString(P_0);
	}

	internal static object jO8CD86EcUthf62eV2D(object P_0)
	{
		return ((XmlNode)P_0).InnerXml;
	}

	internal static object cYlD7r6fRRnfMsYAMqJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object rsC3PV6QBJOeQ23wEV7(object P_0, object P_1)
	{
		return ((string)P_0).Trim((char[])P_1);
	}

	internal static object WDbcdr6CfuAXus1SkNQ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
