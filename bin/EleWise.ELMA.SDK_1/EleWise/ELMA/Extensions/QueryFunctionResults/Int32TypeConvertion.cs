// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.Int32TypeConvertion
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
  public class Int32TypeConvertion : IQueryTypeConvertion
  {
    internal static Int32TypeConvertion TwoD7FGyRo766Ty7Z0PH;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num = 4;
      Type c;
      while (true)
      {
        PropertyInfo reflectionProperty;
        Type type;
        switch (num)
        {
          case 1:
            type = Int32TypeConvertion.dU1pMlGyOgEV0hAPkZg2(Int32TypeConvertion.S6j6PXGynouQpACoJ453((object) reflectionProperty));
            break;
          case 2:
            goto label_2;
          case 3:
            reflectionProperty = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(Int32TypeConvertion.JU0mlmGyTNSap8iiXmpM((object) metadata)).GetReflectionProperty(propName);
            num = 7;
            continue;
          case 4:
            // ISSUE: type reference
            if (Int32TypeConvertion.DdVorKGyXHB06FPilO53(__typeref (long)).IsAssignableFrom(valueType))
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 5:
            goto label_8;
          case 6:
            if (Int32TypeConvertion.sys01OGy2QqnHf8dovGA(c, (Type) null))
            {
              num = 5;
              continue;
            }
            goto label_9;
          case 7:
            if (!Int32TypeConvertion.R5aP82GykAwG7WgXxLIa((object) reflectionProperty, (object) null))
            {
              num = 8;
              continue;
            }
            type = (Type) null;
            break;
          case 8:
            if (reflectionProperty.PropertyType.IsNullableType())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
              continue;
            }
            goto default;
          default:
            type = Int32TypeConvertion.S6j6PXGynouQpACoJ453((object) reflectionProperty);
            break;
        }
        c = type;
        num = 6;
      }
label_2:
      return false;
label_8:
      // ISSUE: type reference
      return Int32TypeConvertion.DdVorKGyXHB06FPilO53(__typeref (int)).IsAssignableFrom(c);
label_9:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => (object) Convert.ToInt32(value);

    public Int32TypeConvertion()
    {
      Int32TypeConvertion.lAmnhjGyeqDsHyufdCvd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type DdVorKGyXHB06FPilO53([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid JU0mlmGyTNSap8iiXmpM([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool R5aP82GykAwG7WgXxLIa([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static Type S6j6PXGynouQpACoJ453([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Type dU1pMlGyOgEV0hAPkZg2(Type type) => type.GetNonNullableType();

    internal static bool sys01OGy2QqnHf8dovGA([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool WwRfkDGyqPUOYluBEEbK() => Int32TypeConvertion.TwoD7FGyRo766Ty7Z0PH == null;

    internal static Int32TypeConvertion uJ2PLXGyKpdJfAFAbpXe() => Int32TypeConvertion.TwoD7FGyRo766Ty7Z0PH;

    internal static void lAmnhjGyeqDsHyufdCvd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
