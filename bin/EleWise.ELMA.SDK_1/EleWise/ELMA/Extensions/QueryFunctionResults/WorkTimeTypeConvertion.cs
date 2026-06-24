// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.WorkTimeTypeConvertion
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
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
  public class WorkTimeTypeConvertion : IQueryTypeConvertion
  {
    private static WorkTimeTypeConvertion Toxn75GMVfK6WbaICCdA;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num1 = 6;
      Type c;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          PropertyInfo propertyInfo;
          Type type;
          switch (num2)
          {
            case 1:
              if (WorkTimeTypeConvertion.wvk5p9GMkO2pR38t7yU6(WorkTimeTypeConvertion.IV3hBiGMToWCLN0IeDnZ((object) propertyInfo)))
              {
                type = WorkTimeTypeConvertion.SeyiqDGMnwq8x2nWum1M(WorkTimeTypeConvertion.IV3hBiGMToWCLN0IeDnZ((object) propertyInfo));
                break;
              }
              goto label_9;
            case 2:
              goto label_10;
            case 3:
              if (WorkTimeTypeConvertion.xmetEXGMXABceL3eMMSF((object) propertyInfo, (object) null))
              {
                num2 = 8;
                continue;
              }
              goto case 1;
            case 4:
              type = WorkTimeTypeConvertion.IV3hBiGMToWCLN0IeDnZ((object) propertyInfo);
              break;
            case 5:
              propertyInfo = (PropertyInfo) WorkTimeTypeConvertion.YThkXUGMKHOmNhmihLx1(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(WorkTimeTypeConvertion.NCAfN5GMqXSjq2cIHd3x((object) metadata)), (object) propName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 3;
              continue;
            case 6:
              // ISSUE: type reference
              if (WorkTimeTypeConvertion.Rddb8PGMRjSEKCLdyhUD(__typeref (long)).IsAssignableFrom(valueType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 5 : 5;
                continue;
              }
              goto label_4;
            case 7:
              goto label_4;
            case 8:
              type = (Type) null;
              break;
            default:
              if (WorkTimeTypeConvertion.LL0vXYGMOJmnPRT6Mvrm(c, (Type) null))
              {
                num2 = 2;
                continue;
              }
              goto label_11;
          }
          c = type;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
        }
label_9:
        num1 = 4;
      }
label_4:
      return false;
label_10:
      // ISSUE: type reference
      return WorkTimeTypeConvertion.Rddb8PGMRjSEKCLdyhUD(__typeref (WorkTime)).IsAssignableFrom(c);
label_11:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => (object) new WorkTime((long) value);

    public WorkTimeTypeConvertion()
    {
      WorkTimeTypeConvertion.PoBV8AGM22HKtVPVs3ZU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type Rddb8PGMRjSEKCLdyhUD([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid NCAfN5GMqXSjq2cIHd3x([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object YThkXUGMKHOmNhmihLx1(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool xmetEXGMXABceL3eMMSF([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static Type IV3hBiGMToWCLN0IeDnZ([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static bool wvk5p9GMkO2pR38t7yU6(Type type) => type.IsNullableType();

    internal static Type SeyiqDGMnwq8x2nWum1M(Type type) => type.GetNonNullableType();

    internal static bool LL0vXYGMOJmnPRT6Mvrm([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool vuFUmrGMSlhNBX0ShHGH() => WorkTimeTypeConvertion.Toxn75GMVfK6WbaICCdA == null;

    internal static WorkTimeTypeConvertion BMduTLGMiiiTpbE8v5Dr() => WorkTimeTypeConvertion.Toxn75GMVfK6WbaICCdA;

    internal static void PoBV8AGM22HKtVPVs3ZU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
