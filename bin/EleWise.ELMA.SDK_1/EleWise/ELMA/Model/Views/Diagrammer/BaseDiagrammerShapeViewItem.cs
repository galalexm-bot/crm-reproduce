// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Diagrammer.BaseDiagrammerShapeViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views.Diagrammer
{
  /// <summary>Базовый класс для элемента диаграммера.</summary>
  [Serializable]
  public class BaseDiagrammerShapeViewItem : RootViewItem
  {
    internal static BaseDiagrammerShapeViewItem E05CKDowUq0t4cCCiNws;

    /// <summary>
    /// Идентификатор
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private Guid Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор свойства контекста.</summary>
    public Guid PropertyUid
    {
      get => this.\u003CPropertyUid\u003Ek__BackingField;
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
              this.\u003CPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    /// <summary>Элемент диаграммы выделен</summary>
    public bool IsSelected
    {
      get => this.\u003CIsSelected\u003Ek__BackingField;
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
              this.\u003CIsSelected\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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

    /// <summary>Отобразить элементы управления</summary>
    private bool DisplayControls
    {
      get => this.\u003CDisplayControls\u003Ek__BackingField;
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
              this.\u003CDisplayControls\u003Ek__BackingField = value;
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

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is SlotViewItem;

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
          case 6:
            goto label_9;
          case 2:
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
              continue;
            }
            goto default;
          case 4:
            if (BaseDiagrammerShapeViewItem.WKFe22owz1jLC8v4CPCD((object) parentViewItem) == null)
            {
              num = 6;
              continue;
            }
            goto label_8;
          case 5:
            goto label_8;
          default:
            if (!(parentViewItem is DynamicListViewItem))
            {
              num = 3;
              continue;
            }
            goto case 4;
        }
      }
label_8:
      return parentViewItem.Parent is DiagrammerViewItem;
label_9:
      return false;
    }

    public BaseDiagrammerShapeViewItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool SObgqbows93qikjRcu52() => BaseDiagrammerShapeViewItem.E05CKDowUq0t4cCCiNws == null;

    internal static BaseDiagrammerShapeViewItem cMeg9Howc5JfcoKKotIW() => BaseDiagrammerShapeViewItem.E05CKDowUq0t4cCCiNws;

    internal static object WKFe22owz1jLC8v4CPCD([In] object obj0) => (object) ((ViewItem) obj0).Parent;
  }
}
