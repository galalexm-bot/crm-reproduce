// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExpressionUtil.Tools
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ExpressionUtil
{
  internal static class Tools
  {
    internal static MethodInfo DelegateTargetGetterMethod;
    internal static Tools brv0bJGrbENj8dJdyka2;

    internal static bool IsValueType(this Type type) => IntrospectionExtensions.GetTypeInfo(type).IsValueType;

    internal static bool IsPrimitive(this Type type) => IntrospectionExtensions.GetTypeInfo(type).IsPrimitive;

    internal static bool IsClass(this Type type) => IntrospectionExtensions.GetTypeInfo(type).IsClass;

    internal static bool IsUnsigned(this Type type)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              goto label_6;
            case 2:
              goto label_5;
            case 4:
              // ISSUE: type reference
              if (!Tools.cCsqYHGrf12VIfbSV7t8(type, Tools.aItOFvGrEWH6f3abWgvu(__typeref (byte))))
                break;
              goto label_8;
            case 5:
              // ISSUE: type reference
              if (Tools.cCsqYHGrf12VIfbSV7t8(type, Tools.aItOFvGrEWH6f3abWgvu(__typeref (uint))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
                continue;
              }
              goto label_5;
          }
          // ISSUE: type reference
          if (!Tools.cCsqYHGrf12VIfbSV7t8(type, Tools.aItOFvGrEWH6f3abWgvu(__typeref (ushort))))
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 5 : 5;
          else
            goto label_6;
        }
label_8:
        num1 = 3;
      }
label_5:
      // ISSUE: type reference
      return Tools.cCsqYHGrf12VIfbSV7t8(type, Tools.aItOFvGrEWH6f3abWgvu(__typeref (ulong)));
label_6:
      return true;
    }

    internal static bool IsNullable(this Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!((Type) Tools.XHYPfQGrQDHsoGIrhDrJ(type)).IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: type reference
      return Tools.cCsqYHGrf12VIfbSV7t8(((Type) Tools.XHYPfQGrQDHsoGIrhDrJ(type)).GetGenericTypeDefinition(), Tools.aItOFvGrEWH6f3abWgvu(__typeref (Nullable<>)));
label_3:
      return false;
    }

    internal static MethodInfo FindMethod(this Type type, string methodName)
    {
      int num1 = 3;
      int index;
      MethodInfo[] methodInfoArray;
      Type baseType;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          TypeInfo typeInfo;
          switch (num2)
          {
            case 1:
            case 5:
              if (index >= methodInfoArray.Length)
              {
                num2 = 7;
                continue;
              }
              break;
            case 2:
              methodInfoArray = typeInfo.DeclaredMethods.AsArray<MethodInfo>();
              num2 = 4;
              continue;
            case 3:
              typeInfo = (TypeInfo) Tools.XHYPfQGrQDHsoGIrhDrJ(type);
              num2 = 2;
              continue;
            case 4:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
              continue;
            case 6:
              goto label_11;
            case 7:
              baseType = typeInfo.BaseType;
              if ((object) baseType == null)
              {
                num2 = 8;
                continue;
              }
              goto label_15;
            case 8:
              goto label_14;
            case 9:
              goto label_12;
          }
          if (!(methodInfoArray[index].Name == methodName))
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 9 : 9;
          else
            goto label_11;
        }
label_12:
        ++index;
        num1 = 5;
      }
label_11:
      return methodInfoArray[index];
label_14:
      return (MethodInfo) null;
label_15:
      return (MethodInfo) Tools.mvJNeOGrCbIOM4kvQdVY(baseType, (object) methodName);
    }

    internal static MethodInfo FindDelegateInvokeMethod(this Type type) => IntrospectionExtensions.GetTypeInfo(type).GetDeclaredMethod((string) Tools.SdpooBGrvReQNfVRg4LM(694673736 ^ -23604109 ^ -672127133));

    internal static MethodInfo FindNullableGetValueOrDefaultMethod(this Type type)
    {
      int num = 2;
      MethodInfo valueOrDefaultMethod;
      int index;
      MethodInfo[] methodInfoArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 4;
            continue;
          case 2:
            methodInfoArray = ((TypeInfo) Tools.XHYPfQGrQDHsoGIrhDrJ(type)).DeclaredMethods.AsArray<MethodInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
            continue;
          case 3:
            if (!((string) Tools.IE62N6GrZlJqyRybPcFT((object) valueOrDefaultMethod) == (string) Tools.SdpooBGrvReQNfVRg4LM(993438473 ^ 993180163)))
            {
              num = 10;
              continue;
            }
            goto label_2;
          case 4:
          case 7:
            if (index < methodInfoArray.Length)
            {
              num = 11;
              continue;
            }
            goto label_6;
          case 5:
            if (Tools.Mnw0OvGr8qogxQXi6xUR((object) valueOrDefaultMethod).Length != 0)
            {
              num = 8;
              continue;
            }
            goto case 3;
          case 6:
            goto label_6;
          case 8:
          case 10:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 7 : 6;
            continue;
          case 9:
            goto label_2;
          default:
            valueOrDefaultMethod = methodInfoArray[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 5;
            continue;
        }
      }
label_2:
      return valueOrDefaultMethod;
label_6:
      return (MethodInfo) null;
    }

    internal static MethodInfo FindValueGetterMethod(this Type type) => (MethodInfo) Tools.baXoZPGruGlrdXDJFHTO(type, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917297886));

    internal static MethodInfo FindNullableHasValueGetterMethod(this Type type) => (MethodInfo) Tools.baXoZPGruGlrdXDJFHTO(type, Tools.SdpooBGrvReQNfVRg4LM(1051802738 - -1831968059 ^ -1410938723));

    internal static MethodInfo FindPropertyGetMethod(this Type propHolderType, string propName)
    {
      int num1 = 16;
      MethodInfo propertyGetMethod;
      Type baseType;
      while (true)
      {
        int num2 = num1;
        int num3;
        string str;
        int index;
        MethodInfo[] methodInfoArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (num3 == -1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 10 : 4;
                continue;
              }
              goto case 4;
            case 2:
              if (!Tools.i1ew18GrItxWr4HQPSsP((object) propertyGetMethod))
              {
                num2 = 4;
                continue;
              }
              goto case 19;
            case 3:
              if (Tools.VZ5Tj8GrVSW9ZUCNCU3W((object) str) == Tools.VZ5Tj8GrVSW9ZUCNCU3W((object) propName) + 4)
              {
                num2 = 8;
                continue;
              }
              goto case 4;
            case 4:
              ++index;
              num2 = 18;
              continue;
            case 5:
              if ((int) Tools.JwP2VVGrSAsMjqWxyAgL((object) propName, num3) != (int) Tools.JwP2VVGrSAsMjqWxyAgL((object) str, num3 + 4))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
                continue;
              }
              goto label_19;
            case 6:
              if (str[3] == '_')
              {
                num2 = 11;
                continue;
              }
              goto case 4;
            case 7:
            case 13:
              if (num3 != -1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 5;
                continue;
              }
              goto case 1;
            case 8:
              if (str[0] == 'g')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 6 : 5;
                continue;
              }
              goto case 4;
            case 9:
              baseType = ((Type) Tools.XHYPfQGrQDHsoGIrhDrJ(propHolderType)).BaseType;
              if ((object) baseType == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                continue;
              }
              goto label_30;
            case 10:
              goto label_24;
            case 11:
              num3 = Tools.VZ5Tj8GrVSW9ZUCNCU3W((object) propName) - 1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 9 : 13;
              continue;
            case 12:
              propertyGetMethod = methodInfoArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 2;
              continue;
            case 14:
              goto label_19;
            case 15:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 17 : 17;
              continue;
            case 16:
              methodInfoArray = ((TypeInfo) Tools.XHYPfQGrQDHsoGIrhDrJ(propHolderType)).DeclaredMethods.AsArray<MethodInfo>();
              num2 = 15;
              continue;
            case 17:
            case 18:
              if (index >= methodInfoArray.Length)
              {
                num2 = 9;
                continue;
              }
              goto case 12;
            case 19:
              str = (string) Tools.IE62N6GrZlJqyRybPcFT((object) propertyGetMethod);
              num2 = 3;
              continue;
            default:
              goto label_29;
          }
        }
label_19:
        --num3;
        num1 = 7;
      }
label_24:
      return propertyGetMethod;
label_29:
      return (MethodInfo) null;
label_30:
      return (MethodInfo) Tools.baXoZPGruGlrdXDJFHTO(baseType, (object) propName);
    }

    internal static MethodInfo FindPropertySetMethod(this Type propHolderType, string propName)
    {
      int num1 = 19;
      MethodInfo propertySetMethod;
      Type baseType;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          MethodInfo[] methodInfoArray;
          int index1;
          string str;
          int index2;
          switch (num2)
          {
            case 1:
            case 2:
              if (index1 != -1)
              {
                num2 = 13;
                continue;
              }
              goto case 17;
            case 3:
              --index1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
              continue;
            case 4:
              str = (string) Tools.IE62N6GrZlJqyRybPcFT((object) propertySetMethod);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 7 : 12;
              continue;
            case 5:
              if (Tools.JwP2VVGrSAsMjqWxyAgL((object) str, 0) == 's')
              {
                num2 = 6;
                continue;
              }
              break;
            case 6:
              if (Tools.JwP2VVGrSAsMjqWxyAgL((object) str, 3) == '_')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                continue;
              }
              break;
            case 7:
            case 10:
              propertySetMethod = methodInfoArray[index2];
              num2 = 16;
              continue;
            case 8:
              goto label_12;
            case 9:
            case 15:
              if (index2 < methodInfoArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 10 : 10;
                continue;
              }
              goto case 14;
            case 11:
              goto label_29;
            case 12:
              if (Tools.VZ5Tj8GrVSW9ZUCNCU3W((object) str) == Tools.VZ5Tj8GrVSW9ZUCNCU3W((object) propName) + 4)
              {
                num2 = 5;
                continue;
              }
              break;
            case 13:
              if ((int) propName[index1] == (int) Tools.JwP2VVGrSAsMjqWxyAgL((object) str, index1 + 4))
                goto case 3;
              else
                goto label_22;
            case 14:
              baseType = ((Type) Tools.XHYPfQGrQDHsoGIrhDrJ(propHolderType)).BaseType;
              if ((object) baseType == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 7 : 11;
                continue;
              }
              goto label_30;
            case 16:
              if (Tools.i1ew18GrItxWr4HQPSsP((object) propertySetMethod))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 4 : 3;
                continue;
              }
              break;
            case 17:
              if (index1 == -1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 8 : 0;
                continue;
              }
              break;
            case 18:
              index2 = 0;
              num2 = 9;
              continue;
            case 19:
              methodInfoArray = ((TypeInfo) Tools.XHYPfQGrQDHsoGIrhDrJ(propHolderType)).DeclaredMethods.AsArray<MethodInfo>();
              num2 = 18;
              continue;
            default:
              index1 = Tools.VZ5Tj8GrVSW9ZUCNCU3W((object) propName) - 1;
              num2 = 2;
              continue;
          }
          ++index2;
          num2 = 15;
        }
label_22:
        num1 = 17;
      }
label_12:
      return propertySetMethod;
label_29:
      return (MethodInfo) null;
label_30:
      return (MethodInfo) Tools.nWEOlxGriVDGQqFF4Qyl(baseType, (object) propName);
    }

    internal static MethodInfo FindConvertOperator(
      this Type type,
      Type sourceType,
      Type targetType)
    {
      int num = 16;
      string str;
      int index;
      MethodInfo convertOperator;
      MethodInfo[] methodInfoArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (Tools.i1ew18GrItxWr4HQPSsP((object) convertOperator))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            }
            goto case 13;
          case 2:
            goto label_31;
          case 3:
            if (str[8] == 'c')
            {
              num = 4;
              continue;
            }
            goto case 13;
          case 4:
            if (Tools.JwP2VVGrSAsMjqWxyAgL((object) str, 9) == 'i')
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 3 : 10;
              continue;
            }
            goto case 13;
          case 5:
          case 6:
            if (index < methodInfoArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 8 : 2;
              continue;
            }
            goto label_2;
          case 7:
            if (str[2] == '_')
            {
              num = 14;
              continue;
            }
            goto case 13;
          case 8:
          case 21:
            convertOperator = methodInfoArray[index];
            num = 9;
            continue;
          case 9:
            if (!convertOperator.IsStatic)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 10 : 13;
              continue;
            }
            goto case 1;
          case 10:
            if (Tools.JwP2VVGrSAsMjqWxyAgL((object) str, 10) == 't')
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 18 : 2;
              continue;
            }
            goto case 13;
          case 11:
            str = (string) Tools.IE62N6GrZlJqyRybPcFT((object) convertOperator);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 4 : 22;
            continue;
          case 12:
            if (str[6] == 'l')
            {
              num = 17;
              continue;
            }
            goto case 13;
          case 13:
          case 20:
            ++index;
            num = 5;
            continue;
          case 14:
            if (Tools.JwP2VVGrSAsMjqWxyAgL((object) str, 5) == 'p')
            {
              num = 12;
              continue;
            }
            goto case 13;
          case 15:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 6 : 4;
            continue;
          case 16:
            methodInfoArray = ((TypeInfo) Tools.XHYPfQGrQDHsoGIrhDrJ(type)).DeclaredMethods.AsArray<MethodInfo>();
            num = 15;
            continue;
          case 17:
            if (Tools.JwP2VVGrSAsMjqWxyAgL((object) str, 7) == 'i')
            {
              num = 3;
              continue;
            }
            goto case 13;
          case 18:
            if (!Tools.cCsqYHGrf12VIfbSV7t8(Tools.HAHDouGrqBR75jySb0gy(Tools.Mnw0OvGr8qogxQXi6xUR((object) convertOperator)[0]), sourceType))
            {
              num = 20;
              continue;
            }
            goto label_31;
          case 19:
            goto label_2;
          case 22:
            if (Tools.VZ5Tj8GrVSW9ZUCNCU3W((object) str) == 11)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 7 : 3;
              continue;
            }
            goto case 13;
          default:
            if (Tools.cCsqYHGrf12VIfbSV7t8(Tools.P5TqOBGrR0tGEqqvCZTd((object) convertOperator), targetType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 11 : 2;
              continue;
            }
            goto case 13;
        }
      }
label_2:
      return (MethodInfo) null;
label_31:
      return convertOperator;
    }

    internal static ConstructorInfo FindSingleParamConstructor(this Type type, Type paramType)
    {
      int num1 = 7;
      ConstructorInfo paramConstructor;
      while (true)
      {
        int num2 = num1;
        int index;
        ConstructorInfo[] constructorInfoArray;
        ParameterInfo[] parameters;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 4;
              continue;
            case 3:
            case 5:
              paramConstructor = constructorInfoArray[index];
              num2 = 8;
              continue;
            case 4:
            case 10:
              goto label_5;
            case 6:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 9 : 10;
              continue;
            case 7:
              constructorInfoArray = IntrospectionExtensions.GetTypeInfo(type).DeclaredConstructors.AsArray<ConstructorInfo>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 6;
              continue;
            case 8:
              parameters = paramConstructor.GetParameters();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 9:
              if (!Tools.cCsqYHGrf12VIfbSV7t8(Tools.HAHDouGrqBR75jySb0gy((object) parameters[0]), paramType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 2;
                continue;
              }
              goto label_3;
            case 11:
              goto label_9;
            default:
              if (parameters.Length != 1)
                goto case 2;
              else
                goto label_12;
          }
        }
label_5:
        if (index < constructorInfoArray.Length)
        {
          num1 = 5;
          continue;
        }
        goto label_9;
label_12:
        num1 = 9;
      }
label_3:
      return paramConstructor;
label_9:
      return (ConstructorInfo) null;
    }

    public static T[] AsArray<T>(this IEnumerable<T> xs)
    {
      if (xs is T[] objArray)
        return objArray;
      return xs != null ? xs.ToArray<T>() : (T[]) null;
    }

    public static T[] Empty<T>() => Tools.EmptyArray<T>.Value;

    public static T[] WithLast<T>(this T[] source, T value)
    {
      if (source == null || source.Length == 0)
        return new T[1]{ value };
      if (source.Length == 1)
        return new T[2]{ source[0], value };
      if (source.Length == 2)
        return new T[3]{ source[0], source[1], value };
      int length = source.Length;
      T[] destinationArray = new T[length + 1];
      Array.Copy((Array) source, 0, (Array) destinationArray, 0, length);
      destinationArray[length] = value;
      return destinationArray;
    }

    public static Type[] GetParamTypes(IReadOnlyList<ParameterExpression> paramExprs)
    {
      if (paramExprs == null || paramExprs.Count == 0)
        return Tools.Empty<Type>();
      if (paramExprs.Count == 1)
        return new Type[1]
        {
          paramExprs[0].IsByRef ? paramExprs[0].Type.MakeByRefType() : paramExprs[0].Type
        };
      Type[] paramTypes = new Type[paramExprs.Count];
      for (int index = 0; index < paramTypes.Length; ++index)
      {
        ParameterExpression paramExpr = paramExprs[index];
        paramTypes[index] = paramExpr.IsByRef ? paramExpr.Type.MakeByRefType() : paramExpr.Type;
      }
      return paramTypes;
    }

    public static Type GetFuncOrActionType(Type[] paramTypes, Type returnType)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        int length;
        while (true)
        {
          switch (num2)
          {
            case 1:
              switch (length)
              {
                case 0:
                  goto label_5;
                case 1:
                  goto label_6;
                case 2:
                  goto label_7;
                case 3:
                  goto label_8;
                case 4:
                  goto label_9;
                case 5:
                  goto label_10;
                case 6:
                  goto label_11;
                case 7:
                  goto label_12;
                default:
                  num2 = 7;
                  continue;
              }
            case 2:
              goto label_22;
            case 3:
              goto label_28;
            case 4:
              // ISSUE: type reference
              if (!Tools.cCsqYHGrf12VIfbSV7t8(returnType, Tools.aItOFvGrEWH6f3abWgvu(__typeref (void))))
              {
                length = paramTypes.Length;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
                continue;
              }
              num2 = 3;
              continue;
            case 5:
              goto label_3;
            case 6:
              goto label_5;
            case 7:
              goto label_13;
            default:
              goto label_14;
          }
        }
label_3:
        switch (length)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_15;
          case 2:
            goto label_16;
          case 3:
            goto label_17;
          case 4:
            goto label_18;
          case 5:
            goto label_19;
          case 6:
            goto label_20;
          case 7:
            goto label_21;
          default:
            num1 = 2;
            continue;
        }
label_28:
        length = paramTypes.Length;
        num1 = 5;
      }
label_5:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Func<>)).MakeGenericType(returnType);
label_6:
      return typeof (Func<,>).MakeGenericType(paramTypes[0], returnType);
label_7:
      return typeof (Func<,,>).MakeGenericType(paramTypes[0], paramTypes[1], returnType);
label_8:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Func<,,,>)).MakeGenericType(paramTypes[0], paramTypes[1], paramTypes[2], returnType);
label_9:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Func<,,,,>)).MakeGenericType(paramTypes[0], paramTypes[1], paramTypes[2], paramTypes[3], returnType);
label_10:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Func<,,,,,>)).MakeGenericType(paramTypes[0], paramTypes[1], paramTypes[2], paramTypes[3], paramTypes[4], returnType);
label_11:
      return typeof (Func<,,,,,,>).MakeGenericType(paramTypes[0], paramTypes[1], paramTypes[2], paramTypes[3], paramTypes[4], paramTypes[5], returnType);
label_12:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Func<,,,,,,,>)).MakeGenericType(paramTypes[0], paramTypes[1], paramTypes[2], paramTypes[3], paramTypes[4], paramTypes[5], paramTypes[6], returnType);
label_13:
      throw new NotSupportedException((string) Tools.b6utReGrKVQ4nVLu1QjY(Tools.SdpooBGrvReQNfVRg4LM(1819636893 << 3 ^ 1672459612), (object) paramTypes.Length));
label_14:
      return typeof (System.Action);
label_15:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Action<>)).MakeGenericType(paramTypes);
label_16:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Action<,>)).MakeGenericType(paramTypes);
label_17:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Action<,,>)).MakeGenericType(paramTypes);
label_18:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Action<,,,>)).MakeGenericType(paramTypes);
label_19:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Action<,,,,>)).MakeGenericType(paramTypes);
label_20:
      return typeof (Action<,,,,,>).MakeGenericType(paramTypes);
label_21:
      // ISSUE: type reference
      return Tools.aItOFvGrEWH6f3abWgvu(__typeref (Action<,,,,,,>)).MakeGenericType(paramTypes);
label_22:
      throw new NotSupportedException((string) Tools.b6utReGrKVQ4nVLu1QjY(Tools.SdpooBGrvReQNfVRg4LM(1514961705 ^ 1514695277), (object) paramTypes.Length));
    }

    public static T GetFirst<T>(this IEnumerable<T> source)
    {
      if (source is IList<T> objList)
        return objList.Count != 0 ? objList[0] : default (T);
      using (IEnumerator<T> enumerator = source.GetEnumerator())
        return enumerator.MoveNext() ? enumerator.Current : default (T);
    }

    public static T GetFirst<T>(this IList<T> source) => source.Count != 0 ? source[0] : default (T);

    public static T GetFirst<T>(this T[] source) => source.Length != 0 ? source[0] : default (T);

    static Tools()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            Tools.DelegateTargetGetterMethod = (MethodInfo) Tools.baXoZPGruGlrdXDJFHTO(Tools.aItOFvGrEWH6f3abWgvu(__typeref (Delegate)), Tools.SdpooBGrvReQNfVRg4LM(-70007027 ^ -69741267));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          case 2:
            Tools.lA97rVGrXDgEgYD6NJE7();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool TuhTVIGrheo40gF4FA1k() => Tools.brv0bJGrbENj8dJdyka2 == null;

    internal static Tools lICJq6GrGX42KPFwmXh8() => Tools.brv0bJGrbENj8dJdyka2;

    internal static Type aItOFvGrEWH6f3abWgvu([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool cCsqYHGrf12VIfbSV7t8([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object XHYPfQGrQDHsoGIrhDrJ([In] Type obj0) => (object) IntrospectionExtensions.GetTypeInfo(obj0);

    internal static object mvJNeOGrCbIOM4kvQdVY(Type type, [In] object obj1) => (object) type.FindMethod((string) obj1);

    internal static object SdpooBGrvReQNfVRg4LM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Mnw0OvGr8qogxQXi6xUR([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static object IE62N6GrZlJqyRybPcFT([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object baXoZPGruGlrdXDJFHTO(Type propHolderType, [In] object obj1) => (object) propHolderType.FindPropertyGetMethod((string) obj1);

    internal static bool i1ew18GrItxWr4HQPSsP([In] object obj0) => ((MethodBase) obj0).IsSpecialName;

    internal static int VZ5Tj8GrVSW9ZUCNCU3W([In] object obj0) => ((string) obj0).Length;

    internal static char JwP2VVGrSAsMjqWxyAgL([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static object nWEOlxGriVDGQqFF4Qyl(Type propHolderType, [In] object obj1) => (object) propHolderType.FindPropertySetMethod((string) obj1);

    internal static Type P5TqOBGrR0tGEqqvCZTd([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static Type HAHDouGrqBR75jySb0gy([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

    internal static object b6utReGrKVQ4nVLu1QjY([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void lA97rVGrXDgEgYD6NJE7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private static class EmptyArray<T>
    {
      public static readonly T[] Value;
      private static object BnBg6888JR2qgeWkGGB3;

      static EmptyArray()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              Tools.EmptyArray<T>.Value = new T[0];
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            case 2:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static bool cFUCLM889ggo4ACWUtHl() => Tools.EmptyArray<T>.BnBg6888JR2qgeWkGGB3 == null;

      internal static object LI2FiD88dFGLfplq0Ox2() => Tools.EmptyArray<T>.BnBg6888JR2qgeWkGGB3;
    }
  }
}
