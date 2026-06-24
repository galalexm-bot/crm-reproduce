// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.UriTypeConvertion
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
  public class UriTypeConvertion : IQueryTypeConvertion
  {
    internal static UriTypeConvertion pBvXuPGMFMILBUgHSt7y;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num = 4;
      Type c;
      while (true)
      {
        PropertyInfo propertyInfo;
        Type type;
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (UriTypeConvertion.ysNrZWGMEgxD42RQO6VS(propertyInfo.PropertyType))
            {
              num = 7;
              continue;
            }
            goto case 6;
          case 3:
            goto label_8;
          case 4:
            // ISSUE: type reference
            if (UriTypeConvertion.aoqTOhGMoPOf7Ck3H547(__typeref (string)).IsAssignableFrom(valueType))
            {
              propertyInfo = (PropertyInfo) UriTypeConvertion.kuJoVCGMhc2Kb9RfRBpq(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(UriTypeConvertion.GaxWBMGMbXI4Ttuvw9PE((object) metadata)), (object) propName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            }
            num = 3;
            continue;
          case 5:
            goto label_3;
          case 6:
            type = UriTypeConvertion.aPG4mUGMfQirPWGht0qH((object) propertyInfo);
            break;
          case 7:
            type = UriTypeConvertion.pIIqwcGMQQV61PlwEJaX(UriTypeConvertion.aPG4mUGMfQirPWGht0qH((object) propertyInfo));
            break;
          case 8:
            if (!UriTypeConvertion.H3H7DkGMCNYHyl1Y126Q(c, (Type) null))
            {
              num = 5;
              continue;
            }
            goto label_2;
          default:
            if (!UriTypeConvertion.Hcw6DBGMGaUSDvSiL4oJ((object) propertyInfo, (object) null))
            {
              num = 2;
              continue;
            }
            type = (Type) null;
            break;
        }
        c = type;
        num = 8;
      }
label_2:
      return typeof (Uri).IsAssignableFrom(c);
label_3:
      return false;
label_8:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => (object) new Uri((string) value);

    public UriTypeConvertion()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type aoqTOhGMoPOf7Ck3H547([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid GaxWBMGMbXI4Ttuvw9PE([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object kuJoVCGMhc2Kb9RfRBpq(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool Hcw6DBGMGaUSDvSiL4oJ([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool ysNrZWGMEgxD42RQO6VS(Type type) => type.IsNullableType();

    internal static Type aPG4mUGMfQirPWGht0qH([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Type pIIqwcGMQQV61PlwEJaX(Type type) => type.GetNonNullableType();

    internal static bool H3H7DkGMCNYHyl1Y126Q([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool c8giwWGMB7VlsrsL96mt() => UriTypeConvertion.pBvXuPGMFMILBUgHSt7y == null;

    internal static UriTypeConvertion tq5ZmmGMWYZ2PVWO9fvs() => UriTypeConvertion.pBvXuPGMFMILBUgHSt7y;
  }
}
