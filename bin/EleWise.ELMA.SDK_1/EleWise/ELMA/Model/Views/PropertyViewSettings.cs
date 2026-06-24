// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PropertyViewSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Настройки отображения свойства</summary>
  [Component]
  [Serializable]
  public class PropertyViewSettings : IXsiRoot, IEquatable<PropertyViewSettings>
  {
    internal static PropertyViewSettings cHNB3RoNK3mQ9CQcQVNa;

    /// <summary>Ctor</summary>
    public PropertyViewSettings()
    {
      PropertyViewSettings.r8GawUoNkdcboWfRU5aX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Attributes = new List<ViewAttribute>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Список атрибутов отображения в представлениях</summary>
    public List<ViewAttribute> Attributes { get; set; }

    /// <summary>Получить атрибуты отображения в преставлении</summary>
    /// <param name="viewType">Тип представления</param>
    /// <returns></returns>
    public ViewAttribute GetForView(ViewType viewType) => this.GetForView(viewType, ItemType.Default);

    /// <summary>Получить атрибуты отображения в преставлении</summary>
    /// <param name="viewType">Тип представления</param>
    /// <param name="itemType">Тип элемента</param>
    /// <returns></returns>
    public ViewAttribute GetForView(ViewType viewType, ItemType itemType)
    {
      int num1 = 9;
      ViewAttribute forView1;
      ViewType viewType1;
      ItemType itemType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            itemType1 = itemType;
            num1 = 4;
            continue;
          case 2:
            goto label_11;
          case 3:
            if (forView1 != null)
            {
              num1 = 2;
              continue;
            }
            if (viewType1 == ViewType.Filter)
            {
              num1 = 7;
              continue;
            }
            goto label_18;
          case 4:
            forView1 = this.Attributes.FirstOrDefault<ViewAttribute>((Func<ViewAttribute, bool>) (a =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (PropertyViewSettings.\u003C\u003Ec__DisplayClass6_0.IZgdsLCCgIsFKFWWmR3B((object) a) != ItemType.Default)
                    {
                      num2 = 4;
                      continue;
                    }
                    goto label_5;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    if (PropertyViewSettings.\u003C\u003Ec__DisplayClass6_0.PG4Y6uCCrpL6wXX7qdX6((object) a) == viewType1)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
                      continue;
                    }
                    goto label_6;
                  case 3:
                    goto label_5;
                  case 4:
                    if (itemType1 == ItemType.Default)
                    {
                      num2 = 3;
                      continue;
                    }
                    goto label_4;
                  default:
                    goto label_4;
                }
              }
label_4:
              return (a.ItemType & itemType1) == itemType1;
label_5:
              return true;
label_6:
              return false;
            }));
            num1 = 5;
            continue;
          case 5:
            if (forView1 != null)
            {
              num1 = 10;
              continue;
            }
            forView1 = this.Attributes.FirstOrDefault<ViewAttribute>((Func<ViewAttribute, bool>) (a =>
            {
              int num3 = 2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (PropertyViewSettings.\u003C\u003Ec__DisplayClass6_0.IZgdsLCCgIsFKFWWmR3B((object) a) != ItemType.Default)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 4 : 0;
                      continue;
                    }
                    goto label_3;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    if ((PropertyViewSettings.\u003C\u003Ec__DisplayClass6_0.PG4Y6uCCrpL6wXX7qdX6((object) a) & viewType1) == viewType1)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
                      continue;
                    }
                    goto label_4;
                  case 3:
                    goto label_2;
                  case 4:
                    if (itemType1 == ItemType.Default)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_2;
                  default:
                    goto label_3;
                }
              }
label_2:
              return (a.ItemType & itemType1) == itemType1;
label_3:
              return true;
label_4:
              return false;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 3 : 3;
            continue;
          case 6:
            goto label_17;
          case 7:
            forView1 = this.GetForView(ViewType.Edit, itemType1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 8:
            viewType1 = viewType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
            continue;
          case 9:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 7 : 8;
            continue;
          case 10:
            goto label_7;
          default:
            PropertyViewSettings.vxLGVfoNnhHvEAPHVrgr((object) forView1, false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 6 : 4;
            continue;
        }
      }
label_7:
      return forView1;
label_11:
      return forView1;
label_17:
      return forView1;
label_18:
      ViewAttribute forView2 = new ViewAttribute();
      PropertyViewSettings.YH7w8ooNOEe4jgiCaLhK((object) forView2, viewType1);
      PropertyViewSettings.jgXvehoN2v7yVf0ASbAH((object) forView2, viewType1 == ViewType.List ? Visibility.Hidden : Visibility.Visible);
      return forView2;
    }

    public override bool Equals(object obj) => PropertyViewSettings.KX8to0oNeuX4aly5Z2Cg((object) this, (object) (obj as PropertyViewSettings));

    public virtual bool Equals(PropertyViewSettings s)
    {
      int num1 = 3;
      List<ViewAttribute>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_9;
          case 2:
            goto label_6;
          case 3:
            if (s == null)
            {
              num1 = 2;
              continue;
            }
            if (PropertyViewSettings.xkJFDooNPmKtIQq2omoD((object) this.Attributes) == PropertyViewSettings.xkJFDooNPmKtIQq2omoD((object) s.Attributes))
            {
              enumerator = this.Attributes.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            }
            num1 = 4;
            continue;
          case 4:
            goto label_4;
          default:
            goto label_11;
        }
      }
label_4:
      return false;
label_6:
      return false;
label_9:
      return true;
label_11:
      bool flag;
      try
      {
label_19:
        if (enumerator.MoveNext())
          goto label_16;
        else
          goto label_20;
label_13:
        int num2;
        ViewAttribute attr;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_19;
            case 2:
              attr = enumerator.Current;
              num2 = 5;
              continue;
            case 3:
              flag = false;
              num2 = 4;
              continue;
            case 4:
              goto label_10;
            case 5:
              if (!s.Attributes.Any<ViewAttribute>((Func<ViewAttribute, bool>) (a =>
              {
                int num3 = 2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (a.Visibility == PropertyViewSettings.\u003C\u003Ec__DisplayClass8_0.hakv7cCCsM6PDwSD3rt9((object) attr))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (PropertyViewSettings.\u003C\u003Ec__DisplayClass8_0.DH9C6UCCUjkvWeD0iXTs((object) a) == attr.ViewType)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_5;
                    default:
                      goto label_4;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return PropertyViewSettings.\u003C\u003Ec__DisplayClass8_0.M4FNEdCCcDj2YieGsDqf((object) a) == PropertyViewSettings.\u003C\u003Ec__DisplayClass8_0.M4FNEdCCcDj2YieGsDqf((object) attr);
label_5:
                return false;
              })))
              {
                num2 = 3;
                continue;
              }
              goto label_19;
            case 6:
              goto label_9;
            default:
              goto label_16;
          }
        }
label_16:
        num2 = 2;
        goto label_13;
label_20:
        num2 = 6;
        goto label_13;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_10:
      return flag;
    }

    internal static void r8GawUoNkdcboWfRU5aX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xKKX6AoNXl9SABDPPt5K() => PropertyViewSettings.cHNB3RoNK3mQ9CQcQVNa == null;

    internal static PropertyViewSettings o3lCkdoNTcI47obZ4Mef() => PropertyViewSettings.cHNB3RoNK3mQ9CQcQVNa;

    internal static void vxLGVfoNnhHvEAPHVrgr([In] object obj0, bool value) => ((ViewAttribute) obj0).ReadOnly = value;

    internal static void YH7w8ooNOEe4jgiCaLhK([In] object obj0, ViewType value) => ((ViewAttribute) obj0).ViewType = value;

    internal static void jgXvehoN2v7yVf0ASbAH([In] object obj0, Visibility value) => ((ViewAttribute) obj0).Visibility = value;

    internal static bool KX8to0oNeuX4aly5Z2Cg([In] object obj0, [In] object obj1) => ((PropertyViewSettings) obj0).Equals((PropertyViewSettings) obj1);

    internal static int xkJFDooNPmKtIQq2omoD([In] object obj0) => ((List<ViewAttribute>) obj0).Count;
  }
}
