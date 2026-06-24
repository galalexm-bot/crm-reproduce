// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExpressionUtil.ExpressionHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.ExpressionUtil
{
  public static class ExpressionHelper
  {
    private static ExpressionHelper AmocPSGrAICHbAF9kUVq;

    public static RouteValueDictionary GetRouteValuesFromExpression<TController>(
      Expression<Action<TController>> action)
      where TController : Controller
    {
      if (action == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123573366));
      if (!(action.Body is MethodCallExpression body))
        throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406096537), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629912362));
      string name = typeof (TController).Name;
      string str = name.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979476166), StringComparison.OrdinalIgnoreCase) ? name.Substring(0, name.Length - z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979207863).Length) : throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132646439), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398591832));
      if (str.Length == 0)
        throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606920084), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669279855));
      string targetActionName = ExpressionHelper.GetTargetActionName((object) body.Method);
      RouteValueDictionary rvd = new RouteValueDictionary();
      rvd.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642899392), (object) str);
      rvd.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411230503), (object) targetActionName);
      if (((IEnumerable<object>) typeof (TController).GetCustomAttributes(typeof (RouteAreaAttribute), true)).FirstOrDefault<object>() is RouteAreaAttribute routeAreaAttribute)
      {
        string areaName = routeAreaAttribute.AreaName;
        rvd.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3590178), (object) areaName);
      }
      ExpressionHelper.AddParameterValuesFromExpressionToDictionary((object) rvd, (object) body);
      return rvd;
    }

    public static string GetInputName<TModel, TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      return expression.Body.NodeType == ExpressionType.Call ? ExpressionHelper.GetInputName((object) (MethodCallExpression) expression.Body).Substring(expression.Parameters[0].Name.Length + 1) : expression.Body.ToString().Substring(expression.Parameters[0].Name.Length + 1);
    }

    private static string GetInputName(object expression)
    {
      int num = 1;
      MethodCallExpression methodCallExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            methodCallExpression = ExpressionHelper.OJBarQGr0gxlBgvTRMPS(expression) as MethodCallExpression;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_3;
          default:
            if (methodCallExpression == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_3:
      return (string) ExpressionHelper.gDhLPnGrmTnauXUQb3Aa((object) methodCallExpression);
label_4:
      return ExpressionHelper.OJBarQGr0gxlBgvTRMPS(expression).ToString();
    }

    private static string GetTargetActionName(object methodInfo)
    {
      int num1 = 1;
      string targetActionName;
      ActionNameAttribute actionNameAttribute;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              targetActionName = (string) ExpressionHelper.OuaV72GryrrInlqsrLhc(methodInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_18;
            case 3:
              goto label_9;
            case 4:
              // ISSUE: type reference
              if (ExpressionHelper.BYhTKPGr5iWONiOUtU2t(methodInfo).IsSubclassOf(ExpressionHelper.l9no7iGrMvYPwU0hjIWO(__typeref (AsyncController))))
              {
                num2 = 8;
                continue;
              }
              goto label_10;
            case 5:
              goto label_6;
            case 6:
              if (actionNameAttribute == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 4 : 2;
                continue;
              }
              goto label_6;
            case 7:
              goto label_19;
            case 8:
              if (ExpressionHelper.cc3b0HGrjNtWqfyIbKbL((object) targetActionName, ExpressionHelper.BOF0uEGrdgFrUU4ewhD5(-218496594 ^ -218229366), StringComparison.OrdinalIgnoreCase))
              {
                num2 = 9;
                continue;
              }
              if (ExpressionHelper.cc3b0HGrjNtWqfyIbKbL((object) targetActionName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538784732), StringComparison.OrdinalIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 3 : 3;
                continue;
              }
              goto label_10;
            case 9:
              goto label_13;
            default:
              goto label_16;
          }
        }
label_16:
        // ISSUE: type reference
        if (!ExpressionHelper.Ec9gbiGrJPvLkmerwx4d(methodInfo, ExpressionHelper.l9no7iGrMvYPwU0hjIWO(__typeref (NonActionAttribute)), true))
        {
          num1 = 7;
          continue;
        }
        goto label_18;
label_19:
        // ISSUE: type reference
        actionNameAttribute = ((IEnumerable) ExpressionHelper.Jb0VmbGrr87xJvuIN9Y5(methodInfo, ExpressionHelper.l9no7iGrMvYPwU0hjIWO(__typeref (ActionNameAttribute)), true)).OfType<ActionNameAttribute>().FirstOrDefault<ActionNameAttribute>();
        num1 = 6;
      }
label_6:
      return (string) ExpressionHelper.E2IvxEGrgQXeBH0kTDjI((object) actionNameAttribute);
label_9:
      throw new InvalidOperationException(string.Format((IFormatProvider) ExpressionHelper.zw7SYWGr92HIBeK0f5X2(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236338567), (object) targetActionName));
label_10:
      return targetActionName;
label_13:
      return (string) ExpressionHelper.cXTQSGGrLYPuvlKyp4Ml((object) targetActionName, 0, targetActionName.Length - ExpressionHelper.hqMI2WGrYnK18HNbsOuP(ExpressionHelper.BOF0uEGrdgFrUU4ewhD5(1319452732 ^ 1319195672)));
label_18:
      throw new InvalidOperationException((string) ExpressionHelper.cLNJmpGrl9Z1cap7B9St(ExpressionHelper.zw7SYWGr92HIBeK0f5X2(), ExpressionHelper.BOF0uEGrdgFrUU4ewhD5(-441065788 ^ -2092910478 ^ 1727100262), (object) targetActionName));
    }

    private static void AddParameterValuesFromExpressionToDictionary(object rvd, object call)
    {
      int num = 5;
      while (true)
      {
        int index;
        Expression expression;
        ConstantExpression constantExpression;
        ParameterInfo[] parameterInfoArray;
        object obj1;
        object obj2;
        switch (num)
        {
          case 1:
            ExpressionHelper.NIAZ1JGrzT9NC8oiVPDN(rvd, ExpressionHelper.lJP0ykGrcxpb7h6o6JEP((object) parameterInfoArray[index]), obj1);
            num = 7;
            continue;
          case 2:
            if (constantExpression == null)
            {
              num = 10;
              continue;
            }
            goto default;
          case 3:
          case 8:
            if (index >= parameterInfoArray.Length)
            {
              num = 13;
              continue;
            }
            goto case 12;
          case 4:
            if (parameterInfoArray.Length != 0)
            {
              num = 9;
              continue;
            }
            goto label_10;
          case 5:
            parameterInfoArray = (ParameterInfo[]) ExpressionHelper.ic3nJsGrUBp3Zxu6Zh10((object) ((MethodCallExpression) call).Method);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 4 : 1;
            continue;
          case 6:
            constantExpression = expression as ConstantExpression;
            num = 2;
            continue;
          case 7:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 3 : 3;
            continue;
          case 9:
            index = 0;
            num = 8;
            continue;
          case 10:
            obj2 = CachedExpressionCompiler.Evaluate(expression);
            break;
          case 11:
            goto label_2;
          case 12:
            expression = ((MethodCallExpression) call).Arguments[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 4 : 6;
            continue;
          case 13:
            goto label_11;
          default:
            obj2 = ExpressionHelper.Yo4NrqGrs10VGQdkHODc((object) constantExpression);
            break;
        }
        obj1 = obj2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
      }
label_2:
      return;
label_11:
      return;
label_10:;
    }

    internal static object OJBarQGr0gxlBgvTRMPS([In] object obj0) => (object) ((MethodCallExpression) obj0).Object;

    internal static object gDhLPnGrmTnauXUQb3Aa([In] object obj0) => (object) ExpressionHelper.GetInputName(obj0);

    internal static bool HWRh3cGr7fUqQ6lJ59Wn() => ExpressionHelper.AmocPSGrAICHbAF9kUVq == null;

    internal static ExpressionHelper bCN23qGrxpjcXrGh2vPC() => ExpressionHelper.AmocPSGrAICHbAF9kUVq;

    internal static object OuaV72GryrrInlqsrLhc([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static Type l9no7iGrMvYPwU0hjIWO([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool Ec9gbiGrJPvLkmerwx4d([In] object obj0, [In] Type obj1, [In] bool obj2) => ((MemberInfo) obj0).IsDefined(obj1, obj2);

    internal static object zw7SYWGr92HIBeK0f5X2() => (object) CultureInfo.CurrentCulture;

    internal static object BOF0uEGrdgFrUU4ewhD5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cLNJmpGrl9Z1cap7B9St([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((IFormatProvider) obj0, (string) obj1, obj2);

    internal static object Jb0VmbGrr87xJvuIN9Y5([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    internal static object E2IvxEGrgQXeBH0kTDjI([In] object obj0) => (object) ((ActionNameAttribute) obj0).Name;

    internal static Type BYhTKPGr5iWONiOUtU2t([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static bool cc3b0HGrjNtWqfyIbKbL([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).EndsWith((string) obj1, obj2);

    internal static int hqMI2WGrYnK18HNbsOuP([In] object obj0) => ((string) obj0).Length;

    internal static object cXTQSGGrLYPuvlKyp4Ml([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object ic3nJsGrUBp3Zxu6Zh10([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static object Yo4NrqGrs10VGQdkHODc([In] object obj0) => ((ConstantExpression) obj0).Value;

    internal static object lJP0ykGrcxpb7h6o6JEP([In] object obj0) => (object) ((ParameterInfo) obj0).Name;

    internal static void NIAZ1JGrzT9NC8oiVPDN([In] object obj0, [In] object obj1, [In] object obj2) => ((RouteValueDictionary) obj0).Add((string) obj1, obj2);
  }
}
