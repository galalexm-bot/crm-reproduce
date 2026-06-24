// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ShowInTypeTreeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, указывающий нужно ли отображать элемент в дереве типов
  /// </summary>
  public class ShowInTypeTreeAttribute : Attribute
  {
    private bool visible;
    private static ShowInTypeTreeAttribute Th1smUoZY00bm09Q9QFQ;

    /// <summary>Ctor</summary>
    /// <param name="visible">Нужно ли отображать элемент в дереве типов</param>
    public ShowInTypeTreeAttribute(bool visible)
    {
      ShowInTypeTreeAttribute.ciJmjmoZsDIYEbyUVoQ6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.visible = visible;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Нужно ли отображать элемент в дереве типов</summary>
    public bool Visible
    {
      get => this.visible;
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
              this.visible = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    internal static void ciJmjmoZsDIYEbyUVoQ6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Eh8EPMoZL6FLnS7K6q0t() => ShowInTypeTreeAttribute.Th1smUoZY00bm09Q9QFQ == null;

    internal static ShowInTypeTreeAttribute AVJ5ftoZU5vI91KMcTyV() => ShowInTypeTreeAttribute.Th1smUoZY00bm09Q9QFQ;
  }
}
