// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.ReferenceOnEntityTypeConvertion
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component(Order = 50)]
  public class ReferenceOnEntityTypeConvertion : IQueryTypeConvertion
  {
    private static ReferenceOnEntityTypeConvertion tTeeFCGyrHnl8eZeQ3xD;

    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
    {
      int num1 = 3;
      PropertyInfo propertyInfo;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_6;
            case 3:
              // ISSUE: type reference
              if (ReferenceOnEntityTypeConvertion.H6hpU7GyjwHC8itONqae(__typeref (string)).IsAssignableFrom(valueType))
              {
                if (!ReferenceOnEntityTypeConvertion.z2NT5vGyY8mgJUh1d4Uc((object) propName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283401401)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 4 : 1;
                  continue;
                }
                goto label_4;
              }
              else
                goto label_10;
            case 4:
              propertyInfo = (PropertyInfo) ReferenceOnEntityTypeConvertion.G4GSOhGyUn3v8V47JaEp(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(ReferenceOnEntityTypeConvertion.lAyYeHGyLgRvLl1q9KL2((object) metadata)), (object) propName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_10:
        num1 = 2;
      }
label_3:
      // ISSUE: type reference
      return ReferenceOnEntityTypeConvertion.H6hpU7GyjwHC8itONqae(__typeref (ReferenceOnEntityType)).IsAssignableFrom(ReferenceOnEntityTypeConvertion.bE0XWDGysHdk7EfxFZi8((object) propertyInfo));
label_4:
      return true;
label_6:
      return false;
    }

    public object ConvertValue(EntityMetadata metadata, string propName, object value) => ReferenceOnEntityTypeConvertion.hDJGbcGycu752cynKQk5((object) Locator.GetServiceNotNull<ReferenceOnEntityTypeQueryResult>(), (object) metadata, (object) propName, (object) new object[1]
    {
      value
    });

    public ReferenceOnEntityTypeConvertion()
    {
      ReferenceOnEntityTypeConvertion.ME1lmOGyz4xwiYx9A5Iq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type H6hpU7GyjwHC8itONqae([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool z2NT5vGyY8mgJUh1d4Uc([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static Guid lAyYeHGyLgRvLl1q9KL2([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object G4GSOhGyUn3v8V47JaEp(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static Type bE0XWDGysHdk7EfxFZi8([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static bool s6HmG9Gyg6rJv3JVwrL3() => ReferenceOnEntityTypeConvertion.tTeeFCGyrHnl8eZeQ3xD == null;

    internal static ReferenceOnEntityTypeConvertion FHMbrMGy549POnyDEoU9() => ReferenceOnEntityTypeConvertion.tTeeFCGyrHnl8eZeQ3xD;

    internal static object hDJGbcGycu752cynKQk5(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((ReferenceOnEntityTypeQueryResult) obj0).GetValue((EntityMetadata) obj1, (string) obj2, (object[]) obj3);
    }

    internal static void ME1lmOGyz4xwiYx9A5Iq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
