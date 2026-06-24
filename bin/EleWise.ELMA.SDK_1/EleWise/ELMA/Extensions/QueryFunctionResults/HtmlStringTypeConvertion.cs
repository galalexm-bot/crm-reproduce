// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.HtmlStringTypeConvertion
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
using System.Web;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component]
  public class HtmlStringTypeConvertion : IQueryTypeConvertion
  {
    internal static HtmlStringTypeConvertion jFNrgLGmc2vgLwdA4OyH;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num = 2;
      Type c;
      while (true)
      {
        PropertyInfo propertyInfo;
        Type type;
        switch (num)
        {
          case 1:
            propertyInfo = (PropertyInfo) HtmlStringTypeConvertion.sNVNEwGyofwhhpWq7dkh(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(HtmlStringTypeConvertion.AhycvCGyWiyvQYidhtOx((object) metadata)), (object) propName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 8 : 7;
            continue;
          case 2:
            // ISSUE: type reference
            if (HtmlStringTypeConvertion.O6tUQGGyBeSsTlWvNapG(__typeref (string)).IsAssignableFrom(valueType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
            }
            goto label_14;
          case 3:
            type = propertyInfo.PropertyType;
            break;
          case 4:
            if (HtmlStringTypeConvertion.rDL00AGyhsbVpdCtvibp(propertyInfo.PropertyType))
            {
              type = HtmlStringTypeConvertion.faWwkIGyE5e27NQk4PVv(HtmlStringTypeConvertion.bcNLEHGyGk9lFxHR0bne((object) propertyInfo));
              break;
            }
            num = 3;
            continue;
          case 5:
            if (!(c != (Type) null))
            {
              num = 6;
              continue;
            }
            goto label_9;
          case 6:
            goto label_10;
          case 7:
            goto label_14;
          case 8:
            if (!HtmlStringTypeConvertion.WigQToGybGUV71o0ZCo9((object) propertyInfo, (object) null))
            {
              num = 4;
              continue;
            }
            type = (Type) null;
            break;
          default:
            goto label_9;
        }
        c = type;
        num = 5;
      }
label_9:
      // ISSUE: type reference
      return HtmlStringTypeConvertion.O6tUQGGyBeSsTlWvNapG(__typeref (HtmlString)).IsAssignableFrom(c);
label_10:
      return false;
label_14:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => (object) new HtmlString((string) value);

    public HtmlStringTypeConvertion()
    {
      HtmlStringTypeConvertion.NRoutIGyfslZeiDWicZ9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type O6tUQGGyBeSsTlWvNapG([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid AhycvCGyWiyvQYidhtOx([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object sNVNEwGyofwhhpWq7dkh(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool WigQToGybGUV71o0ZCo9([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool rDL00AGyhsbVpdCtvibp(Type type) => type.IsNullableType();

    internal static Type bcNLEHGyGk9lFxHR0bne([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Type faWwkIGyE5e27NQk4PVv(Type type) => type.GetNonNullableType();

    internal static bool aUSeCWGmzeeR6GnlDVSH() => HtmlStringTypeConvertion.jFNrgLGmc2vgLwdA4OyH == null;

    internal static HtmlStringTypeConvertion QGM8yLGyF63lCSp0plOp() => HtmlStringTypeConvertion.jFNrgLGmc2vgLwdA4OyH;

    internal static void NRoutIGyfslZeiDWicZ9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
