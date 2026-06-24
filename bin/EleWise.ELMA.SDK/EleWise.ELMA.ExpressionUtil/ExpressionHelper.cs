using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ExpressionUtil;

public static class ExpressionHelper
{
	private static ExpressionHelper AmocPSGrAICHbAF9kUVq;

	public static RouteValueDictionary GetRouteValuesFromExpression<TController>(Expression<Action<TController>> action) where TController : Controller
	{
		if (action == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123573366));
		}
		if (!(action.Body is MethodCallExpression methodCallExpression))
		{
			throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CF5499), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629912362));
		}
		string name = typeof(TController).Name;
		if (!name.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A619EC6), StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7E80627), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398591832));
		}
		string text = name.Substring(0, name.Length - z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979207863).Length);
		if (text.Length == 0)
		{
			throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606920084), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637F306F));
		}
		string targetActionName = GetTargetActionName(methodCallExpression.Method);
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
		routeValueDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61ECA7C0), text);
		routeValueDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411230503), targetActionName);
		object obj = typeof(TController).GetCustomAttributes(typeof(RouteAreaAttribute), inherit: true).FirstOrDefault();
		RouteAreaAttribute val = (RouteAreaAttribute)((obj is RouteAreaAttribute) ? obj : null);
		if (val != null)
		{
			string areaName = val.get_AreaName();
			routeValueDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3590178), areaName);
		}
		AddParameterValuesFromExpressionToDictionary(routeValueDictionary, methodCallExpression);
		return routeValueDictionary;
	}

	public static string GetInputName<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression)
	{
		if (expression.Body.NodeType == ExpressionType.Call)
		{
			return GetInputName((MethodCallExpression)expression.Body).Substring(expression.Parameters[0].Name.Length + 1);
		}
		return expression.Body.ToString().Substring(expression.Parameters[0].Name.Length + 1);
	}

	private static string GetInputName(object expression)
	{
		//Discarded unreachable code: IL_0058, IL_0067
		int num = 1;
		int num2 = num;
		MethodCallExpression methodCallExpression = default(MethodCallExpression);
		while (true)
		{
			switch (num2)
			{
			case 1:
				methodCallExpression = OJBarQGr0gxlBgvTRMPS(expression) as MethodCallExpression;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return (string)gDhLPnGrmTnauXUQb3Aa(methodCallExpression);
			case 2:
				return OJBarQGr0gxlBgvTRMPS(expression).ToString();
			default:
				if (methodCallExpression == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private static string GetTargetActionName(object methodInfo)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_0123, IL_0132
		int num = 1;
		string text = default(string);
		ActionNameAttribute val = default(ActionNameAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					text = (string)OuaV72GryrrInlqsrLhc(methodInfo);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (val == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 5;
				case 5:
					return (string)E2IvxEGrgQXeBH0kTDjI(val);
				case 4:
					if (BYhTKPGr5iWONiOUtU2t(methodInfo).IsSubclassOf(l9no7iGrMvYPwU0hjIWO(typeof(AsyncController).TypeHandle)))
					{
						num2 = 8;
						continue;
					}
					goto IL_00f4;
				case 3:
					throw new InvalidOperationException(string.Format((IFormatProvider)zw7SYWGr92HIBeK0f5X2(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE163D87), text));
				case 8:
					if (cc3b0HGrjNtWqfyIbKbL(text, BOF0uEGrdgFrUU4ewhD5(-218496594 ^ -218229366), StringComparison.OrdinalIgnoreCase))
					{
						num2 = 9;
						continue;
					}
					if (cc3b0HGrjNtWqfyIbKbL(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538784732), StringComparison.OrdinalIgnoreCase))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto IL_00f4;
				case 9:
					return (string)cXTQSGGrLYPuvlKyp4Ml(text, 0, text.Length - hqMI2WGrYnK18HNbsOuP(BOF0uEGrdgFrUU4ewhD5(0x4EA5403C ^ 0x4EA15418)));
				default:
					if (!Ec9gbiGrJPvLkmerwx4d(methodInfo, l9no7iGrMvYPwU0hjIWO(typeof(NonActionAttribute).TypeHandle), true))
					{
						num = 7;
						break;
					}
					goto case 2;
				case 2:
					throw new InvalidOperationException((string)cLNJmpGrl9Z1cap7B9St(zw7SYWGr92HIBeK0f5X2(), BOF0uEGrdgFrUU4ewhD5(0x66F566B6 ^ 0x66F17566), text));
				case 7:
					{
						val = ((IEnumerable)Jb0VmbGrr87xJvuIN9Y5(methodInfo, l9no7iGrMvYPwU0hjIWO(typeof(ActionNameAttribute).TypeHandle), true)).OfType<ActionNameAttribute>().FirstOrDefault();
						num = 6;
						break;
					}
					IL_00f4:
					return text;
				}
				break;
			}
		}
	}

	private static void AddParameterValuesFromExpressionToDictionary(object rvd, object call)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_00dd, IL_00ec, IL_00fb, IL_014e
		int num = 5;
		int num2 = num;
		int num3 = default(int);
		ConstantExpression constantExpression = default(ConstantExpression);
		Expression expression = default(Expression);
		ParameterInfo[] array = default(ParameterInfo[]);
		object obj2 = default(object);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 13:
				return;
			case 11:
				return;
			case 9:
				num3 = 0;
				num2 = 8;
				continue;
			case 6:
				constantExpression = expression as ConstantExpression;
				num2 = 2;
				continue;
			case 7:
				num3++;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				if (constantExpression == null)
				{
					num2 = 10;
					continue;
				}
				goto default;
			case 4:
				if (array.Length == 0)
				{
					return;
				}
				num2 = 9;
				continue;
			case 3:
			case 8:
				if (num3 >= array.Length)
				{
					num2 = 13;
					continue;
				}
				goto case 12;
			case 5:
				array = (ParameterInfo[])ic3nJsGrUBp3Zxu6Zh10(((MethodCallExpression)call).Method);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 1;
				}
				continue;
			default:
				obj = Yo4NrqGrs10VGQdkHODc(constantExpression);
				break;
			case 1:
				NIAZ1JGrzT9NC8oiVPDN(rvd, lJP0ykGrcxpb7h6o6JEP(array[num3]), obj2);
				num2 = 7;
				continue;
			case 12:
				expression = ((MethodCallExpression)call).Arguments[num3];
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 6;
				}
				continue;
			case 10:
				obj = CachedExpressionCompiler.Evaluate(expression);
				break;
			}
			obj2 = obj;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
			{
				num2 = 1;
			}
		}
	}

	internal static object OJBarQGr0gxlBgvTRMPS(object P_0)
	{
		return ((MethodCallExpression)P_0).Object;
	}

	internal static object gDhLPnGrmTnauXUQb3Aa(object P_0)
	{
		return GetInputName(P_0);
	}

	internal static bool HWRh3cGr7fUqQ6lJ59Wn()
	{
		return AmocPSGrAICHbAF9kUVq == null;
	}

	internal static ExpressionHelper bCN23qGrxpjcXrGh2vPC()
	{
		return AmocPSGrAICHbAF9kUVq;
	}

	internal static object OuaV72GryrrInlqsrLhc(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static Type l9no7iGrMvYPwU0hjIWO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool Ec9gbiGrJPvLkmerwx4d(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).IsDefined(P_1, P_2);
	}

	internal static object zw7SYWGr92HIBeK0f5X2()
	{
		return CultureInfo.CurrentCulture;
	}

	internal static object BOF0uEGrdgFrUU4ewhD5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cLNJmpGrl9Z1cap7B9St(object P_0, object P_1, object P_2)
	{
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2);
	}

	internal static object Jb0VmbGrr87xJvuIN9Y5(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static object E2IvxEGrgQXeBH0kTDjI(object P_0)
	{
		return ((ActionNameAttribute)P_0).get_Name();
	}

	internal static Type BYhTKPGr5iWONiOUtU2t(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static bool cc3b0HGrjNtWqfyIbKbL(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	internal static int hqMI2WGrYnK18HNbsOuP(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object cXTQSGGrLYPuvlKyp4Ml(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object ic3nJsGrUBp3Zxu6Zh10(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static object Yo4NrqGrs10VGQdkHODc(object P_0)
	{
		return ((ConstantExpression)P_0).Value;
	}

	internal static object lJP0ykGrcxpb7h6o6JEP(object P_0)
	{
		return ((ParameterInfo)P_0).Name;
	}

	internal static void NIAZ1JGrzT9NC8oiVPDN(object P_0, object P_1, object P_2)
	{
		((RouteValueDictionary)P_0).Add((string)P_1, P_2);
	}
}
