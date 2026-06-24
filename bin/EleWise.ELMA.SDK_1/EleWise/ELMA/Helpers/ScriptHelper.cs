// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.ScriptHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Помощник скриптов</summary>
  public static class ScriptHelper
  {
    private static ScriptHelper LFQkhyhj8ZDAlWEIiyI1;

    /// <summary>Получить информацию о методе</summary>
    /// <param name="type">Тип</param>
    /// <param name="scriptName">Имя скрипта</param>
    /// <returns>Информация о методе</returns>
    public static MethodInfo GetMethodInfo(Type type, string scriptName)
    {
      int num1 = 2;
      MethodInfo methodInfo1;
      while (true)
      {
        int index;
        MethodInfo[] methodInfoArray;
        MethodInfo methodInfo2;
        string name;
        IEnumerable<string> values;
        MethodInfo method1;
        string scriptNameLower;
        string scriptShortName;
        switch (num1)
        {
          case 1:
            name = (string) ScriptHelper.VeyrwJhjVE7vxNGXcUty((object) scriptName, (object) new string[1]
            {
              (string) ScriptHelper.dKysH3hjIcAPCtKiaXeQ(1470440286 ^ 1470488824)
            }, StringSplitOptions.None)[0];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          case 2:
            methodInfo1 = (MethodInfo) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
            continue;
          case 3:
            ParameterInfo[] parameters = methodInfo2.GetParameters();
            // ISSUE: reference to a compiler-generated field
            Func<ParameterInfo, string> func = ScriptHelper.\u003C\u003Ec.\u003C\u003E9__0_2;
            Func<ParameterInfo, string> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              ScriptHelper.\u003C\u003Ec.\u003C\u003E9__0_2 = selector = (Func<ParameterInfo, string>) (q =>
              {
                int num2 = 1;
                string typeInfo;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      typeInfo = ScriptHelper.GetTypeInfo(ScriptHelper.\u003C\u003Ec.FuUH7dvmkRAQBfINHS2E((object) q));
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_3:
                // ISSUE: reference to a compiler-generated method
                return typeInfo.Substring(1, ScriptHelper.\u003C\u003Ec.anSEIEvmnF7i9yrDwJhl((object) typeInfo) - 2);
              });
            }
            else
              goto label_27;
label_26:
            values = ((IEnumerable<ParameterInfo>) parameters).Select<ParameterInfo, string>(selector);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 15 : 12;
            continue;
label_27:
            selector = func;
            goto label_26;
          case 4:
          case 12:
          case 19:
            goto label_5;
          case 5:
          case 11:
            if (index < methodInfoArray.Length)
            {
              num1 = 8;
              continue;
            }
            goto label_5;
          case 6:
            scriptNameLower = (string) ScriptHelper.IXSelwhjSuuWcceXLq36((object) scriptName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 16 : 8;
            continue;
          case 7:
            index = 0;
            num1 = 5;
            continue;
          case 8:
          case 21:
            methodInfo2 = methodInfoArray[index];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 3 : 3;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            MethodInfo[] all = Array.FindAll<MethodInfo>(type.GetMethods(), (Predicate<MethodInfo>) (method => ScriptHelper.\u003C\u003Ec__DisplayClass0_1.TBCiyEvmRxW7YBUbwnI5(ScriptHelper.\u003C\u003Ec__DisplayClass0_1.YtN2glvmigodaSnLkW98((object) method), (object) scriptShortName)));
            name = (string) ScriptHelper.Ur7LgDhjKmgn1ogQKyKS(ScriptHelper.b5illXhjqQmVbQfO83SP((object) name, '+', '.'), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672211914), (object) "");
            methodInfoArray = all;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 5 : 7;
            continue;
          case 10:
            num1 = 6;
            continue;
          case 13:
            methodInfo1 = methodInfo2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 19 : 11;
            continue;
          case 14:
            scriptShortName = (string) ScriptHelper.QeaCUNhjR1aPcCioamBY((object) name, 0, ScriptHelper.EpAtVehjihRS3luTnh4g((object) name, '('));
            num1 = 9;
            continue;
          case 15:
            if (!((string) ScriptHelper.eo3RcehjXaaaEb85eXqx((object) methodInfo2) + (string) ScriptHelper.dKysH3hjIcAPCtKiaXeQ(-2107978722 ^ -2107976792) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858866351), values) + (string) ScriptHelper.dKysH3hjIcAPCtKiaXeQ(~538519529 ^ -538523734) != name))
            {
              num1 = 13;
              continue;
            }
            goto case 17;
          case 16:
            method1 = type.GetMethod(name);
            if ((object) method1 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 20 : 7;
              continue;
            }
            break;
          case 17:
            ++index;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 11 : 3;
            continue;
          case 18:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 14 : 4;
            continue;
          case 20:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            method1 = Array.Find<MethodInfo>(type.GetMethods(), (Predicate<MethodInfo>) (method => ScriptHelper.\u003C\u003Ec__DisplayClass0_0.POfsBqvmZY93FDHlWkwb(ScriptHelper.\u003C\u003Ec__DisplayClass0_0.PrO6SQvm8dgUoxbiHZWD(ScriptHelper.\u003C\u003Ec__DisplayClass0_0.vxm8Zvvmvpb1FViTqZg0((object) method)), (object) scriptNameLower)));
            break;
          default:
            if (!name.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710575748)))
            {
              num1 = 10;
              continue;
            }
            goto case 18;
        }
        methodInfo1 = method1;
        num1 = 12;
      }
label_5:
      return methodInfo1;
    }

    /// <summary>Получить информацию о типе</summary>
    /// <param name="type">Тип</param>
    /// <returns>Информация о типе</returns>
    private static string GetTypeInfo(Type type)
    {
      int num = 1;
      string typeInfo;
      string str1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!type.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 2:
            typeInfo = (string) ScriptHelper.dKysH3hjIcAPCtKiaXeQ(-1886646897 ^ -1886586003) + type.Namespace + (string) ScriptHelper.dKysH3hjIcAPCtKiaXeQ(-2099751081 ^ -2099753581) + type.Name + (string) ScriptHelper.dKysH3hjIcAPCtKiaXeQ(-542721635 ^ -542748801) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576171784);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 3 : 3;
            continue;
          case 3:
          case 4:
            goto label_2;
          case 6:
            str1 = string.Join((string) ScriptHelper.dKysH3hjIcAPCtKiaXeQ(-1824388195 ^ -1824368275), ((IEnumerable<Type>) type.GetGenericArguments()).Select<Type, string>(new Func<Type, string>(ScriptHelper.GetTypeInfo)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 2;
            continue;
          default:
            object obj1 = ScriptHelper.dKysH3hjIcAPCtKiaXeQ(-218496594 ^ -218433716);
            string fullName = type.FullName;
            object obj2 = fullName != null ? ScriptHelper.aqUVMMhjT4i9XIBPW7X8((object) fullName, '+', '.') : (object) null;
            string str2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218909602);
            typeInfo = (string) ScriptHelper.HO8diehjk0aaIJfRf63p(obj1, obj2, (object) str2);
            num = 4;
            continue;
        }
      }
label_2:
      return typeInfo;
    }

    /// <summary>
    /// Сформировать корректный namespace для использования в генерируемом коде ссылки на службу
    /// </summary>
    /// <param name="nameSpace">Пространство имен</param>
    internal static string ServiceNamespace(string nameSpace)
    {
      int num1 = 3;
      string pattern;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              pattern = string.Format((string) ScriptHelper.dKysH3hjIcAPCtKiaXeQ(-441065788 ^ -2092910478 ^ 1727380532), (object) pattern);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            case 2:
              pattern = (string) ScriptHelper.CcDPvdhjOc55yiyX2qow((object) pattern);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_5;
            default:
              goto label_6;
          }
        }
label_5:
        pattern = new string((char[]) ScriptHelper.FI2inehjnE9l8hbmU5VL());
        num1 = 2;
      }
label_6:
      return (string) ScriptHelper.Ur7LgDhjKmgn1ogQKyKS(ScriptHelper.Ur7LgDhjKmgn1ogQKyKS(ScriptHelper.Ur7LgDhjKmgn1ogQKyKS(ScriptHelper.Ur7LgDhjKmgn1ogQKyKS(ScriptHelper.Ur7LgDhjKmgn1ogQKyKS((object) Regex.Replace(nameSpace, pattern, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669211617)), ScriptHelper.dKysH3hjIcAPCtKiaXeQ(-643786247 ^ -643760697), (object) ""), ScriptHelper.dKysH3hjIcAPCtKiaXeQ(-867826612 ^ -867850946), (object) ""), ScriptHelper.dKysH3hjIcAPCtKiaXeQ(1242972401 >> 4 ^ 77692619), ScriptHelper.dKysH3hjIcAPCtKiaXeQ(825385222 ^ 825388412)), ScriptHelper.dKysH3hjIcAPCtKiaXeQ(-1858887263 ^ -1858883635), ScriptHelper.dKysH3hjIcAPCtKiaXeQ(322893104 - -1992822529 ^ -1979250613)), ScriptHelper.dKysH3hjIcAPCtKiaXeQ(44884861 ^ 44861229), (object) "");
    }

    internal static object dKysH3hjIcAPCtKiaXeQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VeyrwJhjVE7vxNGXcUty([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static object IXSelwhjSuuWcceXLq36([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static int EpAtVehjihRS3luTnh4g([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object QeaCUNhjR1aPcCioamBY([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object b5illXhjqQmVbQfO83SP([In] object obj0, [In] char obj1, [In] char obj2) => (object) ((string) obj0).Replace(obj1, obj2);

    internal static object Ur7LgDhjKmgn1ogQKyKS([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object eo3RcehjXaaaEb85eXqx([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool HGquUghjZqlNQmuQlrxw() => ScriptHelper.LFQkhyhj8ZDAlWEIiyI1 == null;

    internal static ScriptHelper qC2cPjhju5Q7DU3wcTZ9() => ScriptHelper.LFQkhyhj8ZDAlWEIiyI1;

    internal static object aqUVMMhjT4i9XIBPW7X8([In] object obj0, [In] char obj1, [In] char obj2) => (object) ((string) obj0).Replace(obj1, obj2);

    internal static object HO8diehjk0aaIJfRf63p([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object FI2inehjnE9l8hbmU5VL() => (object) Path.GetInvalidFileNameChars();

    internal static object CcDPvdhjOc55yiyX2qow([In] object obj0) => (object) Regex.Escape((string) obj0);
  }
}
