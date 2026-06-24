// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.BooleanTypeConvertion
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
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
  public class BooleanTypeConvertion : IQueryTypeConvertion
  {
    internal static BooleanTypeConvertion WCuGLVGm2jiAIbiF2H4v;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num = 7;
      Type c;
      while (true)
      {
        PropertyInfo reflectionProperty;
        Type type;
        switch (num)
        {
          case 1:
            if (!BooleanTypeConvertion.vmP1UwGma0xrE5VQy0lE(BooleanTypeConvertion.OC14CIGmpMk7FZJOTbPP((object) reflectionProperty)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 4;
              continue;
            }
            type = BooleanTypeConvertion.UBglkHGmDb4v6gk9yVqQ(BooleanTypeConvertion.OC14CIGmpMk7FZJOTbPP((object) reflectionProperty));
            break;
          case 2:
            if (!BooleanTypeConvertion.YCFkKvGm3XeFcYJXioRF((object) reflectionProperty, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
              continue;
            }
            type = (Type) null;
            break;
          case 3:
            goto label_8;
          case 4:
            type = BooleanTypeConvertion.OC14CIGmpMk7FZJOTbPP((object) reflectionProperty);
            break;
          case 5:
            if (!(c != (Type) null))
            {
              num = 3;
              continue;
            }
            goto label_7;
          case 6:
            reflectionProperty = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(BooleanTypeConvertion.Jxy30WGmN5ZsbgjAxyiy((object) metadata)).GetReflectionProperty(propName);
            num = 2;
            continue;
          case 7:
            // ISSUE: type reference
            if (BooleanTypeConvertion.CAJ9NbGm1AC8o0VsGt4j(__typeref (long)).IsAssignableFrom(valueType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 6 : 1;
              continue;
            }
            goto label_9;
          case 8:
            goto label_9;
          default:
            goto label_7;
        }
        c = type;
        num = 5;
      }
label_7:
      return typeof (bool).IsAssignableFrom(c);
label_8:
      return false;
label_9:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => (object) ((long) value != 0L);

    public BooleanTypeConvertion()
    {
      BooleanTypeConvertion.R0s64fGmtXs71Ap2diVZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type CAJ9NbGm1AC8o0VsGt4j([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid Jxy30WGmN5ZsbgjAxyiy([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool YCFkKvGm3XeFcYJXioRF([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static Type OC14CIGmpMk7FZJOTbPP([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static bool vmP1UwGma0xrE5VQy0lE(Type type) => type.IsNullableType();

    internal static Type UBglkHGmDb4v6gk9yVqQ(Type type) => type.GetNonNullableType();

    internal static bool joUHxmGmexRRwxMp3abt() => BooleanTypeConvertion.WCuGLVGm2jiAIbiF2H4v == null;

    internal static BooleanTypeConvertion WaSJe2GmPrtGyrpt3xtK() => BooleanTypeConvertion.WCuGLVGm2jiAIbiF2H4v;

    internal static void R0s64fGmtXs71Ap2diVZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
