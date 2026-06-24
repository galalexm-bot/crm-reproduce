// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.DropDownItemTypeConvertion
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
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
  public class DropDownItemTypeConvertion : IQueryTypeConvertion
  {
    private static DropDownItemTypeConvertion WTnkuQGmleWOQ6XgkT5W;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num = 2;
      PropertyInfo propertyInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            // ISSUE: type reference
            if (!DropDownItemTypeConvertion.RecCyUGm5BOHXcpeMMil(__typeref (string)).IsAssignableFrom(valueType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
              continue;
            }
            propertyInfo = (PropertyInfo) DropDownItemTypeConvertion.pfjIpIGmYa9Ncx3hncRl(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(DropDownItemTypeConvertion.aU5PM0GmjWW9ggqjbtmp((object) metadata)), (object) propName);
            num = 3;
            continue;
          case 3:
            if (DropDownItemTypeConvertion.An8lWWGmLmsoByoUajtc((object) propertyInfo, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          default:
            goto label_6;
        }
      }
label_6:
      // ISSUE: type reference
      return DropDownItemTypeConvertion.RecCyUGm5BOHXcpeMMil(__typeref (DropDownItem)).IsAssignableFrom(DropDownItemTypeConvertion.DjjJ2VGmUJ0m3sqLxCUh((object) propertyInfo));
label_7:
      return false;
label_8:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => DropDownItemTypeConvertion.DkQasZGmsjUPnGlVU610((object) Locator.GetServiceNotNull<DropDownItemQueryResult>(), (object) metadata, (object) propName, (object) new object[1]
    {
      value
    });

    public DropDownItemTypeConvertion()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type RecCyUGm5BOHXcpeMMil([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid aU5PM0GmjWW9ggqjbtmp([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object pfjIpIGmYa9Ncx3hncRl(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool An8lWWGmLmsoByoUajtc([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static Type DjjJ2VGmUJ0m3sqLxCUh([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static bool uQZZnZGmr8ywKLHDnn1t() => DropDownItemTypeConvertion.WTnkuQGmleWOQ6XgkT5W == null;

    internal static DropDownItemTypeConvertion EQUTBgGmgyOePdUMStEL() => DropDownItemTypeConvertion.WTnkuQGmleWOQ6XgkT5W;

    internal static object DkQasZGmsjUPnGlVU610(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((DropDownItemQueryResult) obj0).GetValue((EntityMetadata) obj1, (string) obj2, (object[]) obj3);
    }
  }
}
