// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.GridPropertyColumnViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Колонка, отображающая свойство объекта</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_GridPropertyColumnViewItem), "DisplayName")]
  [Serializable]
  public class GridPropertyColumnViewItem : PropertyViewItem, IGridColumnViewItem
  {
    /// <summary>Uid слота для значения свойства</summary>
    internal static Guid ContentSlotUid;
    internal static GridPropertyColumnViewItem IbEJgqoXB4cHwXoc1G5F;

    /// <summary>Ctor</summary>
    public GridPropertyColumnViewItem()
    {
      GridPropertyColumnViewItem.burBRyoXblpZFCcW3nZs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.WidthType = WidthType.Pixel;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    [DefaultValue(WidthType.Pixel)]
    public WidthType WidthType
    {
      get => this.\u003CWidthType\u003Ek__BackingField;
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
              this.\u003CWidthType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    /// <inheritdoc />
    [DefaultValue(null)]
    public int? Width { get; set; }

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_4;
          case 3:
            if (!(parentViewItem is GridViewItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 2;
              continue;
            }
            goto label_5;
          default:
            goto label_5;
        }
      }
label_4:
      return parentViewItem is TableViewItem;
label_5:
      return true;
    }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (childViewItem is PropertyCaptionViewItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return childViewItem is DynamicSlotViewItem;
label_5:
      return true;
    }

    static GridPropertyColumnViewItem()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            GridPropertyColumnViewItem.burBRyoXblpZFCcW3nZs();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            GridPropertyColumnViewItem.ContentSlotUid = new Guid((string) GridPropertyColumnViewItem.j68MmDoXh1QLYDL45I60(-643786247 ^ -643644709));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void burBRyoXblpZFCcW3nZs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool pfJoVSoXWALvyo8GEpIF() => GridPropertyColumnViewItem.IbEJgqoXB4cHwXoc1G5F == null;

    internal static GridPropertyColumnViewItem iYgmRpoXoSUtmbx69Jef() => GridPropertyColumnViewItem.IbEJgqoXB4cHwXoc1G5F;

    internal static object j68MmDoXh1QLYDL45I60(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
