// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.DiagnosticsHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Diagnostics
{
  public static class DiagnosticsHelper
  {
    internal static DiagnosticsHelper QAZoAiEBdMCEWyKCQMHc;

    public static string GetMethodCallName(Type ownerType, MethodInfo method)
    {
      int num = 15;
      StringBuilder builder;
      int index;
      ParameterInfo[] parameterInfoArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            DiagnosticsHelper.nQnJedEBjqkuEQX2jyZO((object) builder, DiagnosticsHelper.fYqmSXEBYmsDEJbaDtm5((object) method));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 3:
            DiagnosticsHelper.nQnJedEBjqkuEQX2jyZO((object) builder, DiagnosticsHelper.yEuWNrEBgpNCAcDlu5Ud(-53329496 >> 4 ^ -3326242));
            num = 2;
            continue;
          case 4:
            builder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420747110));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
            continue;
          case 5:
            goto label_20;
          case 6:
            goto label_2;
          case 7:
            ++index;
            num = 9;
            continue;
          case 8:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 18 : 13;
            continue;
          case 9:
          case 18:
            if (index >= parameterInfoArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 3 : 4;
              continue;
            }
            goto case 10;
          case 10:
            if (index <= 0)
            {
              num = 11;
              continue;
            }
            goto case 12;
          case 11:
          case 17:
            DiagnosticsHelper.iwmNXXEBsYkVpjORDZBU(DiagnosticsHelper.Bs14fREBUIZddkvmyp9t((object) parameterInfoArray[index]), false, (object) builder);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 7 : 7;
            continue;
          case 12:
            DiagnosticsHelper.nQnJedEBjqkuEQX2jyZO((object) builder, DiagnosticsHelper.yEuWNrEBgpNCAcDlu5Ud(277947046 - -1479185048 ^ 1757133116));
            num = 17;
            continue;
          case 13:
            DiagnosticsHelper.AppendTypeName(ownerType, false, builder);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 3 : 3;
            continue;
          case 14:
            if (!DiagnosticsHelper.bdlc6ZEB52OxxAyooorY((object) method, (object) null))
            {
              builder = new StringBuilder();
              num = 13;
              continue;
            }
            num = 6;
            continue;
          case 15:
            if (!(ownerType == (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 7 : 14;
              continue;
            }
            goto label_20;
          case 16:
            parameterInfoArray = (ParameterInfo[]) DiagnosticsHelper.peDnd4EBLNQ1AG3iO7rt((object) method);
            num = 8;
            continue;
          default:
            builder.Append((string) DiagnosticsHelper.yEuWNrEBgpNCAcDlu5Ud(-1290212282 ^ -644262414 ^ 1786881538));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 11 : 16;
            continue;
        }
      }
label_2:
      throw new ArgumentException((string) DiagnosticsHelper.yEuWNrEBgpNCAcDlu5Ud(322893104 - -1992822529 ^ -1979311833));
label_4:
      return builder.ToString();
label_20:
      throw new ArgumentException((string) DiagnosticsHelper.yEuWNrEBgpNCAcDlu5Ud(1470440286 ^ 1470171682));
    }

    public static string GetControllerActionCallName(Type controllerType, string action)
    {
      int num1 = 7;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              DiagnosticsHelper.iwmNXXEBsYkVpjORDZBU(controllerType, false, (object) stringBuilder);
              num2 = 4;
              continue;
            case 2:
              goto label_8;
            case 3:
              goto label_12;
            case 4:
              goto label_6;
            case 5:
              DiagnosticsHelper.nQnJedEBjqkuEQX2jyZO((object) stringBuilder, (object) action);
              num2 = 2;
              continue;
            case 6:
              if (action == null)
              {
                num2 = 3;
                continue;
              }
              stringBuilder = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
              continue;
            case 7:
              if (!DiagnosticsHelper.K7ATBvEBc9ddC6QOatxa(controllerType, (Type) null))
              {
                num2 = 6;
                continue;
              }
              goto label_9;
            default:
              goto label_9;
          }
        }
label_6:
        stringBuilder.Append((string) DiagnosticsHelper.yEuWNrEBgpNCAcDlu5Ud(874012245 ^ 874005649));
        num1 = 5;
      }
label_8:
      return stringBuilder.ToString();
label_9:
      throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082130570));
label_12:
      throw new ArgumentException((string) DiagnosticsHelper.yEuWNrEBgpNCAcDlu5Ud(-244066886 - -48452443 ^ -195677983));
    }

    public static string GetTypeName(Type type, bool useFullName)
    {
      int num = 2;
      StringBuilder stringBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            DiagnosticsHelper.iwmNXXEBsYkVpjORDZBU(type, useFullName, (object) stringBuilder);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            stringBuilder = new StringBuilder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return stringBuilder.ToString();
    }

    public static void AppendTypeName(Type type, bool useFullName, StringBuilder builder)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int length;
          Type[] genericArguments;
          string str1;
          Type genericTypeDefinition;
          int index;
          string str2;
          switch (num2)
          {
            case 1:
              goto label_19;
            case 2:
              builder.Append(useFullName ? type.FullName : (string) DiagnosticsHelper.fYqmSXEBYmsDEJbaDtm5((object) type));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
              continue;
            case 3:
              if (!type.IsGenericType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 2 : 1;
                continue;
              }
              genericTypeDefinition = type.GetGenericTypeDefinition();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 19 : 2;
              continue;
            case 4:
              if (length <= 0)
                goto case 11;
              else
                goto label_4;
            case 5:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 10 : 3;
              continue;
            case 6:
              DiagnosticsHelper.AppendTypeName(genericArguments[index], useFullName, builder);
              num2 = 13;
              continue;
            case 7:
              genericArguments = type.GetGenericArguments();
              num2 = 5;
              continue;
            case 8:
              if (index > 0)
              {
                num2 = 20;
                continue;
              }
              goto case 6;
            case 9:
              str1 = str1.Substring(0, length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 11 : 6;
              continue;
            case 11:
              builder.Append(str1);
              num2 = 12;
              continue;
            case 12:
              goto label_16;
            case 13:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            case 14:
              DiagnosticsHelper.nQnJedEBjqkuEQX2jyZO((object) builder, DiagnosticsHelper.yEuWNrEBgpNCAcDlu5Ud(277947046 - -1479185048 ^ 1757149950));
              num2 = 17;
              continue;
            case 15:
              length = DiagnosticsHelper.ByBgBsEBzlIDI2Jrx70M((object) str1, '`');
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 4;
              continue;
            case 16:
              str2 = genericTypeDefinition.Name;
              break;
            case 17:
              goto label_14;
            case 18:
              str2 = genericTypeDefinition.FullName;
              break;
            case 19:
              if (useFullName)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 7 : 18;
                continue;
              }
              goto case 16;
            case 20:
              DiagnosticsHelper.nQnJedEBjqkuEQX2jyZO((object) builder, DiagnosticsHelper.yEuWNrEBgpNCAcDlu5Ud(-606654180 ^ -606651106));
              num2 = 6;
              continue;
            default:
              if (index >= genericArguments.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 13 : 14;
                continue;
              }
              goto case 8;
          }
          str1 = str2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 15 : 11;
        }
label_4:
        num1 = 9;
        continue;
label_16:
        builder.Append((string) DiagnosticsHelper.yEuWNrEBgpNCAcDlu5Ud(222162814 ^ 222142648));
        num1 = 7;
      }
label_19:
      return;
label_14:;
    }

    internal static object yEuWNrEBgpNCAcDlu5Ud(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool bdlc6ZEB52OxxAyooorY([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static object nQnJedEBjqkuEQX2jyZO([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object fYqmSXEBYmsDEJbaDtm5([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object peDnd4EBLNQ1AG3iO7rt([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static Type Bs14fREBUIZddkvmyp9t([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

    internal static void iwmNXXEBsYkVpjORDZBU(Type type, bool useFullName, [In] object obj2) => DiagnosticsHelper.AppendTypeName(type, useFullName, (StringBuilder) obj2);

    internal static bool W76ulbEBlgqiaAQSNv0X() => DiagnosticsHelper.QAZoAiEBdMCEWyKCQMHc == null;

    internal static DiagnosticsHelper GM3gLgEBrccpndDbmOiF() => DiagnosticsHelper.QAZoAiEBdMCEWyKCQMHc;

    internal static bool K7ATBvEBc9ddC6QOatxa([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static int ByBgBsEBzlIDI2Jrx70M([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);
  }
}
