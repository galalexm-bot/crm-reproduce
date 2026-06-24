// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.PropertyMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper
{
  /// <summary>Маппер свойства</summary>
  internal sealed class PropertyMap
  {
    private static PropertyMap S6bnmahxBEy5dsQDyU9K;

    /// <summary>Ctor</summary>
    /// <param name="propertyInfo"></param>
    internal PropertyMap(PropertyInfo propertyInfo)
    {
      PropertyMap.iUvkPRhxbYLCmZ3JPDW7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Property = propertyInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 2 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            PropertyMap.QG9IHahxhPGXbA20GN6W((object) propertyInfo, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333643800));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Свойство игнорируется при маппинге</summary>
    internal bool Ignored
    {
      get => this.\u003CIgnored\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CIgnored\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Информация о свойстве</summary>
    internal PropertyInfo Property { get; }

    /// <inheritdoc />
    public override string ToString() => (string) PropertyMap.CDoRvDhxGNNemUb7kyFR((object) this.Property);

    internal static void iUvkPRhxbYLCmZ3JPDW7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void QG9IHahxhPGXbA20GN6W([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool eM75OjhxWs2SLKVmOq1C() => PropertyMap.S6bnmahxBEy5dsQDyU9K == null;

    internal static PropertyMap Aattl8hxocDc3KPhMSq9() => PropertyMap.S6bnmahxBEy5dsQDyU9K;

    internal static object CDoRvDhxGNNemUb7kyFR([In] object obj0) => (object) ((MemberInfo) obj0).Name;
  }
}
