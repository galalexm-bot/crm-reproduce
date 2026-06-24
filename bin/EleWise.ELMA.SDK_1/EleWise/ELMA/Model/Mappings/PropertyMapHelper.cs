// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.PropertyMapHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Mappings
{
  /// <summary>Помощник работы с маппингом</summary>
  [Obsolete("Рекомендуется использовать IPropertyMapService")]
  public class PropertyMapHelper
  {
    private static IPropertyMapService propertyMapService;
    private static IPropertyMapService PropertyMapService;
    internal static PropertyMapHelper HNDuY7hbSKYrSELXFJwU;

    /// <summary>
    /// Скопировать значения из <paramref name="objLeft" /> в <paramref name="objRight" /> в соответствии с картой <paramref name="map" />
    /// </summary>
    /// <param name="objLeft"></param>
    /// <param name="objRight"></param>
    /// <param name="map"></param>
    [Obsolete("Вместо этого метода рекомендуется использовать IPropertyMapService.Map")]
    public static void Map(object objLeft, object objRight, PropertyMap map)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PropertyMapHelper.l6YBgghbqgnfoBUAFIQd((object) PropertyMapHelper.PropertyMapService, objLeft, objRight, (object) map);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public PropertyMapHelper()
    {
      PropertyMapHelper.UmuiLrhbKHPe35xTIhfD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PropertyMapHelper()
    {
      int num = 1;
      while (true)
      {
        IPropertyMapService propertyMapService;
        switch (num)
        {
          case 1:
            PropertyMapHelper.UmuiLrhbKHPe35xTIhfD();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 2:
            propertyMapService = PropertyMapHelper.propertyMapService = Locator.GetServiceNotNull<IPropertyMapService>();
            break;
          case 3:
            goto label_4;
          default:
            propertyMapService = PropertyMapHelper.propertyMapService;
            if (propertyMapService == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 2;
              continue;
            }
            break;
        }
        PropertyMapHelper.PropertyMapService = propertyMapService;
        num = 3;
      }
label_4:;
    }

    internal static void l6YBgghbqgnfoBUAFIQd([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IPropertyMapService) obj0).Map(obj1, obj2, (PropertyMap) obj3);

    internal static bool zVfPsMhbityiMRiSAMfW() => PropertyMapHelper.HNDuY7hbSKYrSELXFJwU == null;

    internal static PropertyMapHelper sgEOrNhbRXuLdRNIxS9a() => PropertyMapHelper.HNDuY7hbSKYrSELXFJwU;

    internal static void UmuiLrhbKHPe35xTIhfD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
