// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ExtensionZoneViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>ExtensionZone</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_ExtensionZoneViewItem), "DisplayName")]
  [Serializable]
  public class ExtensionZoneViewItem : ViewItem
  {
    internal static ExtensionZoneViewItem jXsX7eo2XpUGnRbVYuGS;

    public ExtensionZoneViewItem()
    {
      ExtensionZoneViewItem.Q74BrJo2nMqjkxhGVH1G();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.UseOriginalModel = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Идентификатор зоны</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public string ZoneId
    {
      get => this.\u003CZoneId\u003Ek__BackingField;
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
              this.\u003CZoneId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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

    /// <summary>
    /// Использовать в качестве модели оригинальную начальную модель
    /// </summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(true)]
    public virtual bool UseOriginalModel
    {
      get => this.\u003CUseOriginalModel\u003Ek__BackingField;
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
              this.\u003CUseOriginalModel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
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

    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(false)]
    public bool SupportInColumnRender
    {
      get => this.\u003CSupportInColumnRender\u003Ek__BackingField;
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
              this.\u003CSupportInColumnRender\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return ExtensionZoneViewItem.w4JG98o2OewgObeLs3fh((object) parentViewItem, (object) this);
label_3:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => false;

    internal static void Q74BrJo2nMqjkxhGVH1G() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QDmoKpo2Tihc4aCCbKpv() => ExtensionZoneViewItem.jXsX7eo2XpUGnRbVYuGS == null;

    internal static ExtensionZoneViewItem z3RUEAo2km73HElV45dm() => ExtensionZoneViewItem.jXsX7eo2XpUGnRbVYuGS;

    internal static bool w4JG98o2OewgObeLs3fh([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    private class ToolboxItem : AdditionalViewItemToolboxItem<ExtensionZoneViewItem>
    {
      internal static object vd8UKpCQSR1ime07Q9dG;

      /// <inheritdoc />
      public override bool IsAvailable(IMetadata metadata)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_8;
            case 2:
              if (!base.IsAvailable(metadata))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                continue;
              }
              break;
            case 3:
              goto label_6;
          }
          if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
            num = 3;
          else
            goto label_7;
        }
label_6:
        return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
label_7:
        return true;
label_8:
        return false;
      }

      public ToolboxItem()
      {
        ExtensionZoneViewItem.ToolboxItem.cIePwxCQqpjtyQJjcWVb();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool BR66ebCQicTt7EG0d6Or() => ExtensionZoneViewItem.ToolboxItem.vd8UKpCQSR1ime07Q9dG == null;

      internal static ExtensionZoneViewItem.ToolboxItem CK4ZGHCQRkrswg04B9dO() => (ExtensionZoneViewItem.ToolboxItem) ExtensionZoneViewItem.ToolboxItem.vd8UKpCQSR1ime07Q9dG;

      internal static void cIePwxCQqpjtyQJjcWVb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
