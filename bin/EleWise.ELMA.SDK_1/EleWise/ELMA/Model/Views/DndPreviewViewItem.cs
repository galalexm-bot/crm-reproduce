// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.DndPreviewViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>
  /// Компонент предпросмотра перетаскиваемого элемента из DndViewItem
  /// </summary>
  [Serializable]
  public class DndPreviewViewItem : RootViewItem
  {
    internal static DndPreviewViewItem GJouPVoSSHo45L1r1dtY;

    /// <summary>
    /// Тип элемента
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private int Type
    {
      get => this.\u003CType\u003Ek__BackingField;
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
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
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
    /// Ширина
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private int Width
    {
      get => this.\u003CWidth\u003Ek__BackingField;
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
              this.\u003CWidth\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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
    /// Высота
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private int Height
    {
      get => this.\u003CHeight\u003Ek__BackingField;
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
              this.\u003CHeight\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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
    /// Цвет фона
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private string BackgroundColor
    {
      get => this.\u003CBackgroundColor\u003Ek__BackingField;
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
              this.\u003CBackgroundColor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
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
    /// Цвет рамки
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private string StrokeColor
    {
      get => this.\u003CStrokeColor\u003Ek__BackingField;
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
              this.\u003CStrokeColor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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
    public override bool IsChildValid(ViewItem childViewItem) => false;

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              if (DndPreviewViewItem.paLwPloSqwqvx8N7WimZ((object) parentViewItem) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                continue;
              }
              goto label_7;
            case 3:
              goto label_5;
            default:
              goto label_7;
          }
        }
label_5:
        if (parentViewItem is SlotViewItem)
          num1 = 2;
        else
          goto label_8;
      }
label_7:
      return parentViewItem.Parent is DndViewItem;
label_8:
      return false;
    }

    public DndPreviewViewItem()
    {
      DndPreviewViewItem.fdQGuVoSKnnq1qPyIkfI();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool NKOdd4oSiWxrFCE05Kme() => DndPreviewViewItem.GJouPVoSSHo45L1r1dtY == null;

    internal static DndPreviewViewItem HPpAHPoSRlrUXrXkBh29() => DndPreviewViewItem.GJouPVoSSHo45L1r1dtY;

    internal static object paLwPloSqwqvx8N7WimZ([In] object obj0) => (object) ((ViewItem) obj0).Parent;

    internal static void fdQGuVoSKnnq1qPyIkfI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
