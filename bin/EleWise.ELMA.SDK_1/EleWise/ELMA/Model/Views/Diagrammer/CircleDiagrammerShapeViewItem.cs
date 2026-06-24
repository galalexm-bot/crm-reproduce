// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Diagrammer.CircleDiagrammerShapeViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Diagrammer
{
  /// <summary>Элемент диаграммера в форме круга.</summary>
  [Serializable]
  public class CircleDiagrammerShapeViewItem : BaseDiagrammerVertexShapeViewItem
  {
    internal static CircleDiagrammerShapeViewItem LIQHlMo4CRap35Ue4sjD;

    /// <summary>
    /// Диаметр
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private int Diameter
    {
      get => this.\u003CDiameter\u003Ek__BackingField;
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
              this.\u003CDiameter\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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
    /// Идентификатор родительского элемента
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private Guid ParentElement
    {
      get => this.\u003CParentElement\u003Ek__BackingField;
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
              this.\u003CParentElement\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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

    /// <summary>Изображение внутри элемента</summary>
    private string MainImage
    {
      get => this.\u003CMainImage\u003Ek__BackingField;
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
              this.\u003CMainImage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
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

    /// <summary>Цвет изображения внутри элемента</summary>
    public string MainImageColor
    {
      get => this.\u003CMainImageColor\u003Ek__BackingField;
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
              this.\u003CMainImageColor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
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
    /// У элемента есть быстрая палитра
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private bool HasPopoverContent
    {
      get => this.\u003CHasPopoverContent\u003Ek__BackingField;
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
              this.\u003CHasPopoverContent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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

    public CircleDiagrammerShapeViewItem()
    {
      CircleDiagrammerShapeViewItem.cWy4XSo4Z8E85IA9jrNC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Wmjlreo4vrPMOS1SssZ7() => CircleDiagrammerShapeViewItem.LIQHlMo4CRap35Ue4sjD == null;

    internal static CircleDiagrammerShapeViewItem zccMUQo48islAbx4cg2b() => CircleDiagrammerShapeViewItem.LIQHlMo4CRap35Ue4sjD;

    internal static void cWy4XSo4Z8E85IA9jrNC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
