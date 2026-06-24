// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.EnumTypeConvertion
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component]
  public class EnumTypeConvertion : IQueryTypeConvertion
  {
    internal static EnumTypeConvertion SY1p6uGJFiQfI7hvBeHu;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num = 7;
      Type c;
      while (true)
      {
        PropertyInfo propertyInfo;
        Type type;
        switch (num)
        {
          case 1:
            if (!EnumTypeConvertion.kcG7uYGJG9lC9iBl6yVl(propertyInfo.PropertyType))
            {
              num = 4;
              continue;
            }
            type = EnumTypeConvertion.HDydoCGJfsVGCgDIIqyc(EnumTypeConvertion.OCaP0PGJEXgohYldv6A9((object) propertyInfo));
            break;
          case 2:
            if (!EnumTypeConvertion.CkDir2GJhBg9koiiZ8MR((object) propertyInfo, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 0;
              continue;
            }
            type = (Type) null;
            break;
          case 3:
            goto label_17;
          case 4:
            type = EnumTypeConvertion.OCaP0PGJEXgohYldv6A9((object) propertyInfo);
            break;
          case 5:
            // ISSUE: type reference
            if (!EnumTypeConvertion.rKN5bZGJougHDWwDIa9A(__typeref (Enum)).IsAssignableFrom(c))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 6:
            propertyInfo = (PropertyInfo) EnumTypeConvertion.DrCg9KGJbikmB16M6emy(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata.Uid), (object) propName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 2;
            continue;
          case 7:
            // ISSUE: type reference
            if (EnumTypeConvertion.rKN5bZGJougHDWwDIa9A(__typeref (string)).IsAssignableFrom(valueType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 5 : 6;
              continue;
            }
            goto label_17;
          case 8:
            if (EnumTypeConvertion.KIklu8GJQTvpNVKHfV81(c, (Type) null))
            {
              num = 5;
              continue;
            }
            goto label_9;
          default:
            goto label_7;
        }
        c = type;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 8 : 0;
      }
label_7:
      return typeof (EnumBase).IsAssignableFrom(c);
label_8:
      return true;
label_9:
      return false;
label_17:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => Locator.GetServiceNotNull<EnumQueryResult>().GetValue(metadata, propName, new object[1]
    {
      value
    });

    public EnumTypeConvertion()
    {
      EnumTypeConvertion.Ff8gCcGJCbDGeXWihKW2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type rKN5bZGJougHDWwDIa9A([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object DrCg9KGJbikmB16M6emy(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool CkDir2GJhBg9koiiZ8MR([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool kcG7uYGJG9lC9iBl6yVl(Type type) => type.IsNullableType();

    internal static Type OCaP0PGJEXgohYldv6A9([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Type HDydoCGJfsVGCgDIIqyc(Type type) => type.GetNonNullableType();

    internal static bool KIklu8GJQTvpNVKHfV81([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool re8d7aGJB9lWddDesN8m() => EnumTypeConvertion.SY1p6uGJFiQfI7hvBeHu == null;

    internal static EnumTypeConvertion I7PYAlGJWSpLocv9HSTh() => EnumTypeConvertion.SY1p6uGJFiQfI7hvBeHu;

    internal static void Ff8gCcGJCbDGeXWihKW2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
