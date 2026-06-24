using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public class ElmaRestrictions
{
	private static IRuntimeApplication runtimeApplication;

	internal static ElmaRestrictions lv00dAW3Mg4sPZx6QYtJ;

	private static bool CaseSensitivity => SR.GetSetting((string)rV87EBW3d3VPdmxKLyEZ(-541731959 ^ -541602887), defaultValue: true);

	private static string LikeValue(object value)
	{
		int num = 1;
		int num2 = num;
		IRuntimeApplication obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = runtimeApplication;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				obj = (runtimeApplication = Locator.GetServiceNotNull<IRuntimeApplication>());
				break;
			}
			break;
		}
		return (string)ME3XCPW3rFcZYEdhM7r0(((ITransformationProvider)WFAg6yW3ltt7uiVFfN5f(obj)).Dialect, value ?? string.Empty);
	}

	private static string LikeValue(object value)
	{
		//Discarded unreachable code: IL_002a
		int num = 1;
		int num2 = num;
		object value2;
		while (true)
		{
			switch (num2)
			{
			default:
				value2 = null;
				break;
			case 1:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					continue;
				}
				value2 = value.ToString();
				break;
			}
			break;
		}
		return ElmaRestrictions.LikeValue(value2);
	}

	public static AbstractCriterion InsensitiveLike(string propertyName, object value)
	{
		//Discarded unreachable code: IL_0047, IL_0056
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (AbstractCriterion)S7XiR0W3jaSHGmqti5rL(propertyName, oWBkVxW35JIFYshYi2KY(value));
			case 1:
				return (AbstractCriterion)C3vgHZW3YW2w2899YOM7(propertyName, oWBkVxW35JIFYshYi2KY(value));
			case 2:
				if (MD9CJkW3gAfpS27aDfd0())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static AbstractCriterion InsensitiveLike(IProjection projection, object value)
	{
		//Discarded unreachable code: IL_006b, IL_007a
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (MD9CJkW3gAfpS27aDfd0())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return (AbstractCriterion)gGkZQbW3LqigyYH95hcH(projection, oWBkVxW35JIFYshYi2KY(value));
			case 1:
				return (AbstractCriterion)hYXSKgW3UWKUgI03rsZ6(projection, oWBkVxW35JIFYshYi2KY(value));
			}
		}
	}

	public static AbstractCriterion InsensitiveLike(IProjection projection, string value, MatchMode matchMode)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (CaseSensitivity)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return (AbstractCriterion)TCr3T1W3cl0FPrJt9HZT(projection, iHSn2rW3s7VFsxc20sKS(value), matchMode);
			default:
				return (AbstractCriterion)obgHv2W3zNQWe3ZA1U1e(projection, iHSn2rW3s7VFsxc20sKS(value), matchMode);
			}
		}
	}

	public static AbstractCriterion InsensitiveLike(string propertyName, string value, MatchMode matchMode)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (MD9CJkW3gAfpS27aDfd0())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return (AbstractCriterion)T1UT0oWpFgLousgIMwOL(propertyName, iHSn2rW3s7VFsxc20sKS(value), matchMode);
			case 1:
				return (AbstractCriterion)Y9HBJYWpBQlSQMCkQfDZ(propertyName, ElmaRestrictions.LikeValue((object)value), matchMode);
			}
		}
	}

	public static AbstractCriterion Like(string propertyName, object value)
	{
		return (AbstractCriterion)S7XiR0W3jaSHGmqti5rL(propertyName, ElmaRestrictions.LikeValue(value));
	}

	public static AbstractCriterion Like(IProjection projection, object value)
	{
		return (AbstractCriterion)gGkZQbW3LqigyYH95hcH(projection, ElmaRestrictions.LikeValue(value));
	}

	public static AbstractCriterion Like(IProjection projection, string value, MatchMode matchMode)
	{
		return (AbstractCriterion)TCr3T1W3cl0FPrJt9HZT(projection, iHSn2rW3s7VFsxc20sKS(value), matchMode);
	}

	public static AbstractCriterion Like(string propertyName, string value, MatchMode matchMode)
	{
		return (AbstractCriterion)(object)Restrictions.Like(propertyName, ElmaRestrictions.LikeValue((object)value), matchMode);
	}

	public ElmaRestrictions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WRwQm9WpWR2coHMELqIl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object rV87EBW3d3VPdmxKLyEZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool nHlKIIW3JoNoktd9R7jv()
	{
		return lv00dAW3Mg4sPZx6QYtJ == null;
	}

	internal static ElmaRestrictions DNsGRiW39M9eofghWPf3()
	{
		return lv00dAW3Mg4sPZx6QYtJ;
	}

	internal static object WFAg6yW3ltt7uiVFfN5f(object P_0)
	{
		return ((IRuntimeApplication)P_0).TransformationProvider;
	}

	internal static object ME3XCPW3rFcZYEdhM7r0(object P_0, object P_1)
	{
		return ((Dialect)P_0).LikeValue((string)P_1);
	}

	internal static bool MD9CJkW3gAfpS27aDfd0()
	{
		return CaseSensitivity;
	}

	internal static object oWBkVxW35JIFYshYi2KY(object P_0)
	{
		return ElmaRestrictions.LikeValue(P_0);
	}

	internal static object S7XiR0W3jaSHGmqti5rL(object P_0, object P_1)
	{
		return Restrictions.Like((string)P_0, P_1);
	}

	internal static object C3vgHZW3YW2w2899YOM7(object P_0, object P_1)
	{
		return Restrictions.InsensitiveLike((string)P_0, P_1);
	}

	internal static object gGkZQbW3LqigyYH95hcH(object P_0, object P_1)
	{
		return Restrictions.Like((IProjection)P_0, P_1);
	}

	internal static object hYXSKgW3UWKUgI03rsZ6(object P_0, object P_1)
	{
		return Restrictions.InsensitiveLike((IProjection)P_0, P_1);
	}

	internal static object iHSn2rW3s7VFsxc20sKS(object P_0)
	{
		return ElmaRestrictions.LikeValue(P_0);
	}

	internal static object TCr3T1W3cl0FPrJt9HZT(object P_0, object P_1, object P_2)
	{
		return Restrictions.Like((IProjection)P_0, (string)P_1, (MatchMode)P_2);
	}

	internal static object obgHv2W3zNQWe3ZA1U1e(object P_0, object P_1, object P_2)
	{
		return Restrictions.InsensitiveLike((IProjection)P_0, (string)P_1, (MatchMode)P_2);
	}

	internal static object T1UT0oWpFgLousgIMwOL(object P_0, object P_1, object P_2)
	{
		return Restrictions.Like((string)P_0, (string)P_1, (MatchMode)P_2);
	}

	internal static object Y9HBJYWpBQlSQMCkQfDZ(object P_0, object P_1, object P_2)
	{
		return Restrictions.InsensitiveLike((string)P_0, (string)P_1, (MatchMode)P_2);
	}

	internal static void WRwQm9WpWR2coHMELqIl()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
