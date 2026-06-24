// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.DoubleTypeConvertion
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
  public class DoubleTypeConvertion : IQueryTypeConvertion
  {
    internal static DoubleTypeConvertion vMDIRZGmw4hLg92C3iN5;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num1 = 1;
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
              // ISSUE: type reference
              if (DoubleTypeConvertion.wOO1TmGmHLeYUrEumubf(__typeref (long)).IsAssignableFrom(valueType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            case 2:
              goto label_10;
            case 3:
              if (propertyInfo == (PropertyInfo) null)
              {
                num2 = 7;
                continue;
              }
              goto case 6;
            case 4:
              if (!DoubleTypeConvertion.di6OYjGmmioPGNF6QpSj(c, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 2;
                continue;
              }
              goto label_9;
            case 5:
              goto label_11;
            case 6:
              if (DoubleTypeConvertion.B9yZIBGmxVYQnGZcQZbO((object) propertyInfo).IsNullableType())
              {
                type = DoubleTypeConvertion.DLLnkvGm0M8U9fqdZ29j(propertyInfo.PropertyType);
                break;
              }
              goto label_14;
            case 7:
              type = (Type) null;
              break;
            case 8:
              goto label_9;
            case 9:
              type = DoubleTypeConvertion.B9yZIBGmxVYQnGZcQZbO((object) propertyInfo);
              break;
            default:
              propertyInfo = (PropertyInfo) DoubleTypeConvertion.DYNn60Gm72XpN0gYlnjD(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(DoubleTypeConvertion.PBFEOwGmA0hntjtgaPnl((object) metadata)), (object) propName);
              num2 = 3;
              continue;
          }
          c = type;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 4 : 2;
        }
label_14:
        num1 = 9;
      }
label_9:
      return typeof (double).IsAssignableFrom(c);
label_10:
      return false;
label_11:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => (object) DoubleTypeConvertion.BwkV4UGmy7UI7aJUcdGi(value);

    public DoubleTypeConvertion()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type wOO1TmGmHLeYUrEumubf([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid PBFEOwGmA0hntjtgaPnl([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object DYNn60Gm72XpN0gYlnjD(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static Type B9yZIBGmxVYQnGZcQZbO([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Type DLLnkvGm0M8U9fqdZ29j(Type type) => type.GetNonNullableType();

    internal static bool di6OYjGmmioPGNF6QpSj([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool jl5mErGm49MdUZJeMw7L() => DoubleTypeConvertion.vMDIRZGmw4hLg92C3iN5 == null;

    internal static DoubleTypeConvertion saWdu9Gm6p4dnrLCvUcq() => DoubleTypeConvertion.vMDIRZGmw4hLg92C3iN5;

    internal static double BwkV4UGmy7UI7aJUcdGi([In] object obj0) => Convert.ToDouble(obj0);
  }
}
