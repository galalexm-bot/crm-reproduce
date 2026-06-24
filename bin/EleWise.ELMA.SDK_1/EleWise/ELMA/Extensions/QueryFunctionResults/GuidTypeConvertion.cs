// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.GuidTypeConvertion
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
  [Component(Order = 100)]
  public class GuidTypeConvertion : IQueryTypeConvertion
  {
    private static GuidTypeConvertion JJBjGIGJiBnXWvdAd2jN;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num = 1;
      Type c;
      while (true)
      {
        PropertyInfo reflectionProperty;
        Type type;
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            if (GuidTypeConvertion.WVbrkQGJK5lbh3vqo0If(__typeref (string)).IsAssignableFrom(valueType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            }
            goto label_13;
          case 2:
            if (!GuidTypeConvertion.OpKUSJGJXoWilwjYGaWD((object) reflectionProperty, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 6;
              continue;
            }
            type = (Type) null;
            break;
          case 3:
            goto label_9;
          case 4:
            type = GuidTypeConvertion.TXUlqVGJkoDoqlcRv7ye((object) reflectionProperty);
            break;
          case 5:
            goto label_13;
          case 6:
            if (!GuidTypeConvertion.t1VKejGJTlQCJaGGeIle(reflectionProperty.PropertyType))
            {
              num = 4;
              continue;
            }
            type = GuidTypeConvertion.xAdFMqGJn5lxjTPS1Sie(GuidTypeConvertion.TXUlqVGJkoDoqlcRv7ye((object) reflectionProperty));
            break;
          case 7:
            if (GuidTypeConvertion.sTev6MGJOy14sWQoRvxk(c, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 3;
              continue;
            }
            goto label_10;
          default:
            reflectionProperty = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata.Uid).GetReflectionProperty(propName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 2;
            continue;
        }
        c = type;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 7 : 5;
      }
label_9:
      // ISSUE: type reference
      return GuidTypeConvertion.WVbrkQGJK5lbh3vqo0If(__typeref (Guid)).IsAssignableFrom(c);
label_10:
      return false;
label_13:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => Locator.GetServiceNotNull<GuidQueryResult>().GetValue(metadata, propName, new object[1]
    {
      value
    });

    public GuidTypeConvertion()
    {
      GuidTypeConvertion.aeQlYHGJ2E4yqyIkTEU3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type WVbrkQGJK5lbh3vqo0If([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool OpKUSJGJXoWilwjYGaWD([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool t1VKejGJTlQCJaGGeIle(Type type) => type.IsNullableType();

    internal static Type TXUlqVGJkoDoqlcRv7ye([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Type xAdFMqGJn5lxjTPS1Sie(Type type) => type.GetNonNullableType();

    internal static bool sTev6MGJOy14sWQoRvxk([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool zmYqtXGJRmySLGGt5jO6() => GuidTypeConvertion.JJBjGIGJiBnXWvdAd2jN == null;

    internal static GuidTypeConvertion yHrid0GJqBRgIu1Bw0TT() => GuidTypeConvertion.JJBjGIGJiBnXWvdAd2jN;

    internal static void aeQlYHGJ2E4yqyIkTEU3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
